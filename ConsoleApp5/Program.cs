namespace CHaaar

{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string text;
            //Console.Write("Input text: ");
            //text = Console.ReadLine();
  
            Console.Write("Enter a string :");
            string str = Console.ReadLine();

            int totalCharacter = 0, totalLetterChar = 0;

            char[] strArray = str.ToCharArray();
            foreach (var item in strArray)
            {
                if (char.IsLetter(item))
                    totalLetterChar++;
              
            }

            
            //Console.WriteLine("Entered String : " + str);
           
            Console.WriteLine("Total Letter Character String : " + totalLetterChar);
            

            Console.ReadKey();
        }
    }
}