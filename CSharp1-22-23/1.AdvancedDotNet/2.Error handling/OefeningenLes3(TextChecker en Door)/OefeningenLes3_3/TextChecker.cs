using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3
{
    public class TextChecker
    {
        public void ReadText()
        {
            if (text.Any(char.IsDigit))
            {
                throw new ContainsNumberException("sting contains number");
            }
            if (text.ToLower().Contains('f'))
            {
                throw new ContainsLetterFException("sting contains letter f");
            }
            if (text.Count() >50)
            {
                throw new ContainsAlotException("string has more than 50 characters");
            }
        }

        public string text = "ghmkjqngmkjenmeajnrvmkjeanvmakejnvmkaejnvmeakjnvkkgd";

    }
}
