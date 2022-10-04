namespace OefeningenLes7
{
    public partial class Form1 : Form
    {
        delegate void SetLblResultCallback(string value);
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnstart_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (!string.IsNullOrWhiteSpace(tbNumber1.Text) && !string.IsNullOrWhiteSpace (tbNumber2.Text))
                {
                    List<int> delersNumber1 = new List<int>();
                    List<int> delersNumber2 = new List<int>();


                    string outputMessage = "";
                    for (int i = 2; i <= int.Parse(tbNumber1.Text); i++)
                    {
                        if (int.Parse(tbNumber1.Text)%i == 0 )
                        {
                            delersNumber1.Add(i);
                        }
                    }
                    for (int i = 2; i <= int.Parse(tbNumber2.Text); i++)
                    {
                        if (int.Parse(tbNumber2.Text) % i == 0)
                        {
                            delersNumber2.Add(i);
                        }
                    }
                    var gemeneDelers = delersNumber1.Where(x => delersNumber2.Contains(x));
                    foreach (var item in delersNumber1)
                    {
                        if (delersNumber2.Contains(item))
                        {
                            outputMessage += item.ToString() + ", ";
                        }
                    }
                    outputMessage = outputMessage.Remove(outputMessage.Length - 2);
                    SetLblResult(outputMessage);
                    lblResult.Text = outputMessage;
                }                
            });
        }

        private void SetLblResult(string value)
        {         
            if (this.lblResult.InvokeRequired)
            {
                SetLblResultCallback setProgressCallback = new SetLblResultCallback(SetLblResult);
                this.Invoke(setProgressCallback, value);
            }
            else
            {
                this.lblResult.Text = value;
            }
        }

        private void btnDoeIets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iets gedaan!");
        }
    }
}