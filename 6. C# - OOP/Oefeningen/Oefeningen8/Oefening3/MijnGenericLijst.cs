using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class MijnGenericLijst<T>
    {
        public List<T> List { get; set; } = new List<T>();
        public void Add(T element)
        {
            List.Add(element);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public bool Contains(T element)
        {
            return List.Contains(element);
        }
        public object Last()
        {
            return List[^1];
        }
        public object First()
        {
            return List[0];
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in List)
            {
                stringBuilder.Append(" " + item.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
