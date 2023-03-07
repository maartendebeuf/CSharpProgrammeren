// See https://aka.ms/new-console-template for more information
using RestApi;
using System.Net;

Console.WriteLine("Geef een artikel in:");
Console.WriteLine("");
Console.WriteLine("1.Zoek IP-adres op");
Console.WriteLine("2.Geef een lijst met publieke API's");
Console.WriteLine("3.Lijst van alle soorten katten");
Console.WriteLine("4.Post anything");
Console.WriteLine("5.Delete anything");
Console.WriteLine("5.Delete");
Console.WriteLine("6.Delete2");
Console.WriteLine("7.Inlezen eigen api");
Console.WriteLine("8.Inlezen eigen api met token");
Console.WriteLine("9.Inlezen eigen api met token2");
Console.WriteLine("10.Post eigen api");
Console.WriteLine("11.Post eigen api2");
Console.WriteLine("12.Post eigen api ActionResult");
Console.WriteLine("13.Post eigen api ActionResult en stringcontent");
Console.WriteLine("14.Put eigen api");


string result = Console.ReadLine();

switch (result)
{
    case "1":
        RestApiCall.GetIp();
        break;
    case "2":
        RestApiCall.GetPublicAPIs();
        break;
    case "3":
        RestApiCall.GetCatList();
        break;
    case "4":
        RestApiCall.postTest();
        break;
    case "5":
        RestApiCall.DeleteAnythingTest();
        break;
    case "6":
        RestApiCall.DeleteTest();
        break;
    case "7":
        RestApiCall.ApiSenderGet();
        break;
    case "8":
        RestApiCall.ApiSenderGetWithToken();
        break;
    case "9":
        Console.WriteLine("Geef id in:");
        string id = Console.ReadLine();
        Console.WriteLine("Geef token in:");
        string token = Console.ReadLine();
        RestApiCall.ApiSenderGetWithToken(id, token);
        break;
    case "10":
        RestApiCall.ApiSenderPost();
        break;
    case "11":
        RestApiCall.ApiSenderPost2("100%");
        break;
    case "12":
        RestApiCall.ApiSenderPostActionResult(new Tekst() { message = "HelloWorld" });
        break;
    case "13":
        RestApiCall.ApiSenderPostActionResultStringContent(new Tekst() { message = "HelloWorld" });
        break;
    case "14":
        RestApiCall.ApiSenderPut();
        break;
    default:
		break;
}