using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArchitectuur
{
    public class Logic
    {
        public Logic()
        {

        }
        public List<string> ReadFolder()
        {
            var files = Directory.GetFiles("./TestFiles");
            
            List<string> fileList = new List<string>(files);

            return fileList;
        }
        public List<string> ReadTxtFile(string filePath)
        {
            List<string> fileText = new List<string>();
            var text = File.ReadAllLines(filePath);
            foreach (var line in text)
            {
                fileText.Add(line);
            }

            return fileText;
        }
    }
}
