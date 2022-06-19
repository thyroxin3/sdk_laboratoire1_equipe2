namespace LibrairieConvertionNote
{
    public class ConversionAlphabetiqueToNote
    {
        static void TableDeHachage()
        {
            Console.WriteLine("----TableDeHachage()-----\n");
            Hashtable hs = new Hashtable(); // Création d'une table de hachage
            hs.Add("A", "LA"); // La table de hachage est aussi une combinaison de Clef/Valeur, mais non typé
            hs.Add("B", "SI");
            hs.Add("C", "DO");
            hs.Add("D", "RE");
            hs.Add("E", "MI");
            hs.Add("F", "FA");
            hs.Add("G", "SOL");
        }

    }

}