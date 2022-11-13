// See https://aka.ms/new-console-template for more information
using OefeningenLes3;

TextChecker textChecker = new TextChecker();

try
{
    textChecker.ReadText();
}
catch (ContainsNumberException ex)
{
    CustomFileLog.AddErrorLog(ex.Message);
    //Console.WriteLine(ex);
}
catch (ContainsLetterFException ex)
{

    CustomFileLog.AddErrorLog(ex.Message);
    //Console.WriteLine(ex);
}
catch (ContainsAlotException ex)
{
    CustomFileLog.AddErrorLog(ex.Message);
    //Console.WriteLine(ex);
}

