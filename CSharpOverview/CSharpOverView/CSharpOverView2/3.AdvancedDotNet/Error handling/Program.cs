using CSharpOverView._3.AdvancedDotNet.EventsAndDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.Error_handling
{
    internal class Program
    {
        public void Main()
        {
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
        }
    }
}
