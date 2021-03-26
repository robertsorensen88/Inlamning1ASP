# Inlamning1ASP

I Startup.cs så går man igenom trappan för att skicka användaren vidare på sidan(200). 
Man kan styra själv över hur många steg trappan ska bestå och kan ha olika funktioner på sidan. 

I wwwroot ligger alla dina statiska filer som CSS och bilder.

Razorspråket är unikt då man kan skriva C# i sin HTML-kod. 
Därav fördelar med att kunna använda forloopar eller annat
genom @.



RazorPages består av 2 delar. En ContentPage som har HTML kod och är det visuella.
PageModel som har C# kod och kan bestämma vad som står på ContentPage.
Genom OnGet eller OnPost så kan man förändra sidans text.

MVC

Model som har hand om din hantering av Db.

View är det synliga som användaren ser.

När man är på en view sida kan användaren skicka en request.
Detta tar Controller hand om.
