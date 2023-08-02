namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
                           

             var intAdd = Add(2,2);
           var decimalAdd = Add(3m, 3m);
           var dollarsAdd = Add(0, 1, true);
            Console.WriteLine(intAdd);
            Console.WriteLine(decimalAdd);
            Console.WriteLine(dollarsAdd);
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
            else if (ischecked == true && sum ==1)
            {
                return $"{sum} dollar";
            }
            else if (ischecked == true && sum <1)
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
