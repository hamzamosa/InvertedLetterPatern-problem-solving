namespace problem14
{
    internal class Program
    {
        public static void InvertedLetterPatern(int number) 
        {
          for(int i = 65 + number - 1; i >= 65; i--) 
            {
            
            for(int j = 1; j <= number; j++) 
                {

                    Console.Write((char)i);
                
                
                }
                number--;
                Console.WriteLine();


            }
        
        
        }

        static void Main(string[] args)
        {
            InvertedLetterPatern(5);
          
        }
    }
}