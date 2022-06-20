using LibrairieConvertionNote;

LibrairieDeNote Librairie = new LibrairieDeNote();

do
{
        var noteMusicale = ""; 
        Console.WriteLine("Entrez une note musicale entre A et G a convertir en note syllabique");
        noteMusicale = Console.ReadLine();
        string reponse = Librairie.Transformer(noteMusicale);
        Console.WriteLine(reponse);

}

while (true);   