using LibrairieConvertionNote;

   while (true)
    {
         string noteMusicale = "";
         Console.WriteLine ("Entrez une note musicale entre A et G");
         noteMusicale = Console.ReadLine();
         
        if (noteMusicale == 'A') 
            {
                Console.WriteLine("LA");
  
            }

         if (noteMusicale == 'B') 
            {
                Console.WriteLine("SI");
            }

         if (noteMusicale == 'C') 
            {
                Console.WriteLine("DO");
            }

         if (noteMusicale == 'D') 
            {
                Console.WriteLine("RE");
            }

         if (noteMusicale == 'E') 
            {
                Console.WriteLine("MI");
            }

         if (noteMusicale == 'F') 
            {
                Console.WriteLine("FA");
            }

         if (noteMusicale == 'G') 
            {
                Console.WriteLine("SOL");
            }

         else 
            {
                Console.WriteLine("Entree invalide");
            }
             
      }