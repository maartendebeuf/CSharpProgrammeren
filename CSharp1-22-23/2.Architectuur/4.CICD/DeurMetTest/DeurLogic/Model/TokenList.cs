using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeurLogic.Model
{
    sealed class TokenList
    {
        private static List<Token> tokenList;
        public static List<Token> GetTokens
        {
            get
            {
                if (tokenList == null)
                {
                    tokenList = new List<Token>();
                    Token token1 = new Token(Convert.ToInt32("B59D", 16), new List<int>() { 54 },DeurStatus.Actief); 
                    tokenList.Add(token1);

                    Token token2 = new Token(Convert.ToInt32("5789", 16), new List<int>() { 24, 54 }, DeurStatus.Actief);
                    tokenList.Add(token2);

                    Token token3 = new Token(Convert.ToInt32("ABCD", 16), new List<int>() { 1, 24 }, DeurStatus.Geblokkeerd);
                    tokenList.Add(token3);
                }
                return tokenList;
            }
        }

    }
}
