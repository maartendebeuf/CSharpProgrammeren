// See https://aka.ms/new-console-template for more information

//Uitleg / Omschrijving:
//Het is de bedoeling dat we een virtueel telefoonnetwerk gaan maken, aan dit netwerk is het bedoeling dat we verschillende telefoons kunnen toevoegen.

//Opbouw
//Klasse "PhoneNetwork"
//  •	Properties
//      o	Lijst van telefonen (Phone)
//  •	Methods
//      o	CallPhone(int number)
//          	Zoek de telefoon in de lijst
//          	Bij het vinden van de telefoon trigger je het Call event van phone
//      o	SendMessageToPhone(int number, string message)
//          	Zoek de telefoon in de lijst
//          	Bij het vinden van de telefoon trigger je het MessagedEvent van phone 

//Klasse "Phone"
//  •	Properties
//      o	telefoonnummer (string)
//  • Events
//      o	Called (gebruik de default EventHandler)
//      o Messaged 
//          	MessageEventHandler = custom EventHandler (met MessageEventArgs ipv EventArgs)
//          	MessageEventsArgs = custom EventArgs deze heeft de property Message

//Test nu beide klasses:
// •	Maak een PhoneNetwork aan
// •	Voeg enkele Phones toe
// •	Gebruik de method CallPhone() (met bestaande en niet bestaande nummers)
// •	Gebruik de method SendMessageToPhone() (met bestaande en niet bestaande nummers)
// •	Vang beide events op van alle phones (en toon in de console welk nummer er gebeld wordt / of welk bericht een nummer heeft ontvangen)


