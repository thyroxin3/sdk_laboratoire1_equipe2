namespace LibrairieConvertionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public void Transformer()
        {
        bool error =true;
            do{
                string noteMusicale = '01';
                Console.WriteLine ("entrez une note musicale entre A et G");
                Console.ReadLine(""+noteMusicale);
                if (noteMusicale = 'A') 
                {
                    Console.WriteLine("La");
                    error = false;
                }
                if (noteMusicale = 'B') 
                {
                    Console.WriteLine("Si");
                    error = false;
                }
                if (noteMusicale = 'C') 
                {
                    Console.WriteLine("Do");
                    error = false;
                }
                if (noteMusicale = 'D') 
                {
                    Console.WriteLine("Re");
                    error = false;
                }

                if (noteMusicale = 'E') 
                {
                    Console.WriteLine("Mi");
                    error = false;
                }

                if (noteMusicale = 'F') 
                {
                    Console.WriteLine("Fa");
                    error = false;
                }

                if (noteMusicale = 'G') 
                {
                    Console.WriteLine("Sol");
                    error = false;
                }

                else 
                {
                    Console.WriteLine("entree invalide");
                }
             
            }while (error=true) 
        }

    }
}