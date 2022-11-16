using DeurLogic.Repo;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DeurLogic
{
    public class DeurHandeling
    {
        //10:   OK      -> heeft toegang                    TokenID ok / DeurId ok / Status ok
        //20:   Niet OK -> geen toegang                     
        //21:   Niet OK -> geen toegang, token gewijgerd    TokenID nok / deurId ok
        //22:   Niet OK -> geen toegang, onbekend token     
        //0:    Geen respons(time-out/fout)

        public static int ToegangAanvraag(string tokenId, int deurId)
        {
            int hexTokenId;
            try
            {
                hexTokenId = Convert.ToInt32(tokenId, 16);

                var tokenrepo = TokenRepo.GetTokens();
                foreach (var token in tokenrepo)
                {
                    if (token.TokenId == hexTokenId)
                    {       
                        foreach (var deur in token.ToegangDeur)
                        {
                            if (deur.DeurId == deurId)
                            {
                                if (token.Status == DeurStatus.Actief)
                                {
                                    return 10;
                                }
                                else
                                {
                                    return 21;
                                }
                            }
                        }
                                              
                    }
                }
                //var geldigeTokenId = tokenrepo.Select(x => x.TokenId.Equals(hexTokenId));
            }
            catch
            {
                throw new ArgumentException();
            }
            return 22;
            

            ////mogelijke Tokens voor deurID
            //var geldigeTokenIdList = TokenRepo.GetTokens().Where(x =>x.TokenId == tokenId)

            //foreach (var token in TokenRepo.GetTokens())
            //{
                
            //}
            //var geldigeDeurIdTokens = TokenRepo.GetTokens().Where(x => x.ToegangDeur.FirstOrDefault(x=>x.DeurId == deurId) != null);
            ////als er meerdere deuren zijn...
            //if (geldigeDeurIdTokens.Count() >0)
            //{
            //    var geldigeTokenId = geldigeDeurIdTokens.FirstOrDefault(x => x.TokenId.Equals(tokenId));
            //    if (geldigeTokenId == null)
            //    {
            //        return 22;
            //    }
            //    else
            //    {
            //        if (geldigeTokenId.Status == DeurStatus.Actief)
            //        {
            //            return 10;
            //        }
            //        else
            //        {
            //            return 21;
            //        }
            //    }
            //}
            //else
            //{
            //    return 22;
            //}
        }
        public void Afsluiten()
        {

        }
    }
}