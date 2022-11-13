using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ToDoLijst
{
    public partial class TodoView : Form
    {
        private TodoList<TodoItem> _todoList;
        delegate void ClearItemsCallback();
        delegate void AddItemCallback(TodoItem phone);

        public TodoView()
        {
            InitializeComponent();
            _todoList = new TodoList<TodoItem>();
        }

        private void btnTodoAanmaken_Click(object sender, EventArgs e)
        {
            TodoCreateView todoCreate = new TodoCreateView();
            todoCreate.TodoCreateEvent += TodoCreate_TodoCreateEvent;

            todoCreate.Show();
        }

        private void TodoCreate_TodoCreateEvent(string type, string name, string uitvoerder, DateTime dueDate, string description, string location)
        {
            try
            {
                if (dueDate < DateTime.Now)
                {
                    throw new Exception("Uitvoer datum moet in de toekomst zijn");
                }
                else
                {
                    if (type.Equals("HomeWork"))
                    {
                        HomeWork todo = new HomeWork();
                        todo.Name = name;
                        todo.ExecuterName = uitvoerder;
                        todo.DueDate = dueDate;
                        todo.Description = description;
                        todo.Location = location;

                        _todoList.AddTodo(todo);
                    }
                    else if (type.Equals("OutsideWork"))
                    {
                        OutsideWork todo = new OutsideWork();
                        todo.Name = name;
                        todo.ExecuterName = uitvoerder;
                        todo.DueDate = dueDate;
                        todo.Description = description;
                        todo.Location = location;
                    }
                    FillLboxTodo();
                }
            }
            catch (Exception ex)
            {
                //handle error
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FillLboxTodo()
        {
            ClearItems();
            
            var result = _todoList.Todos;
            foreach (var item in result)
            {
                AddItem(item);
            }
        }

        private void AddItem(TodoItem item)
        {
            if (lboxTodo.InvokeRequired)
            {
                var d = new AddItemCallback(AddItem);
                this.Invoke(d, item);
            }
            else
            {
                lboxTodo.Items.Add(item);
            }
        }

        private void ClearItems()
        {
            if (lboxTodo.InvokeRequired)
            {
                var d = new ClearItemsCallback(ClearItems);
                this.Invoke(d);
            }
            else
            {
                lboxTodo.Items.Clear();
            }
        }

        private void lblGeselcteerdeTodoAfwerken_Click(object sender, EventArgs e)
        {
            var item = (TodoItem)lboxTodo.SelectedItem;
            item.DateExecuted = DateTime.Now;
            FillLboxTodo();
        }

        private async void btnTodosImporteren_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var lines = File.ReadAllLines("./TodoImport.txt");
                foreach (var line in lines)
                {
                    var splitResult = line.Split(';');
                    if (splitResult[0].Equals("HomeWork"))
                    {
                        HomeWork todo = new HomeWork();
                        todo.Name = splitResult[1];
                        todo.ExecuterName = splitResult[2];
                        var splitResultDateTime = splitResult[3].Split(',');
                        todo.DueDate = new DateTime(int.Parse(splitResultDateTime[0]), int.Parse(splitResultDateTime[1]), int.Parse(splitResultDateTime[2]), 
                            int.Parse(splitResultDateTime[3]), int.Parse(splitResultDateTime[4]), int.Parse(splitResultDateTime[5]));
                        todo.Description = splitResult[4];
                        todo.Location = splitResult[5];

                        _todoList.AddTodo(todo);
                    }
                    else if (splitResult[0].Equals("OutsideWork"))
                    {
                        OutsideWork todo = new OutsideWork();
                        todo.Name = splitResult[1];
                        todo.ExecuterName = splitResult[2];
                        var splitResultDateTime = splitResult[3].Split(',');
                        todo.DueDate = new DateTime(int.Parse(splitResultDateTime[0]), int.Parse(splitResultDateTime[1]), int.Parse(splitResultDateTime[2]),
                            int.Parse(splitResultDateTime[3]), int.Parse(splitResultDateTime[4]), int.Parse(splitResultDateTime[5]));
                        todo.Description = splitResult[4];
                        todo.Location = splitResult[5];

                        _todoList.AddTodo(todo);
                    }  
                    
                }
                FillLboxTodo();
            });
        }

        private void btnGroepeerPerWeek_Click(object sender, EventArgs e)
        {
            //ClearItems();
            //var result = from todo in _todoList.Todos
            //             group todo by todo.DueDate.



            //var result = _todoList.Todos;
            //foreach (var item in result)
            //{
            //    AddItem(item);
            //}
        }

        private void btnGroepeerPerUitvoerder_Click(object sender, EventArgs e)
        {
            ClearItems();
            var result = from todo in _todoList.Todos
                         group todo by todo.ExecuterName into todoExecuter
                         select todoExecuter.Key;

            foreach (var item in result)
            {
                AddItem(_todoList.Todos.FirstOrDefault(x=>x.ExecuterName.Equals(item)));
            }
        }

        private void btnUitgevoerdeTodos_Click(object sender, EventArgs e)
        {
            ClearItems();
            var result = from todo in _todoList.Todos
                         where todo.DateExecuted != default
                         select todo;

            foreach (var item in result)
            {
                AddItem(item);
            }
        }

        private void btnUitTeVoeren_Click(object sender, EventArgs e)
        {
            ClearItems();
            var result = from todo in _todoList.Todos
                         where todo.DateExecuted == default
                         select todo;

            foreach (var item in result)
            {
                AddItem(item);
            }
        }
    }
}
