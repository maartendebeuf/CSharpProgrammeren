using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace MVC_Klas.Controllers
{
    public class CultureController : Controller
    {
        [HttpPost]
        public IActionResult SetCulture(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(30) }
            );

                    Response.Cookies.Append(
                    "cookie",
                    culture,
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(30) }
        );

            return LocalRedirect(returnUrl);
        }
        //use culturer info zorgt ervoor dat de cookie toegevoegd wordt
        //middelware nodig om vertaling goed te laden. als de combobox aangepast wordt moet de cookie ook worden aangepast (current culture info bleef op en staan)
        //we geven 3 dingen mee : een key, een value en welke taal (tijdsduur van hoe lang de cookie bijgehouden mag worden moet ook ergens ingesteld worden
        //kan ook met zelf gedeinieerde waardes maar is beter deze te laten genereren door c# volgens standaarden
        //alles wat te maken heeft met een request geeft een response terug
        //wat zijn headers in mvc. Google dat eens
    }
}
