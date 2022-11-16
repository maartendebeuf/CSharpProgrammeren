using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeurLogic.Repo
{
    internal class TokenRepo
    {
        static public List<Token> GetTokens()
        {
            return Model.TokenList.GetTokens;
        }
    }
}
