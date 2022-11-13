namespace CSharpOverView._3.AdvancedDotNet.Error_handling
{
    internal class TextChecker
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
            if (text.Count() > 50)
            {
                throw new ContainsAlotException("string has more than 50 characters");
            }
        }

        public string text = "ghmkjqngmkjenmeajnrvmkjeanvmakejnvmkaejnvmeakjnvkkgd";
    }
}