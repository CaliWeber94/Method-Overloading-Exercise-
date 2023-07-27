namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
                           

            Add(2,2);
            Add(3m, 3m);
            Add(4, 5, true);
            Console.WriteLine(Add(2,2));
            Console.WriteLine(Add(3m,3m));
            Console.WriteLine(Add(4,5, true));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        } 

        public static string Add(int x, int y, bool ischecked)
        {
            int sum = x + y;
            if (ischecked == true && sum >1)
            {
                return $"{sum} dollars";
            }
            else if (ischecked == true && sum >=5)
            {
                return $"{sum} dollars";
            }
            else if (ischecked == true && sum <16)
            {
                return $"{sum} dollars";
            }
            else
            {
                return "not dollar amount";
            }
        }     
        
         
        

        
           
        
    }
}
