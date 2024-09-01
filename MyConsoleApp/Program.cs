 namespace Variables
 {
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);     
            int x = 1000; // 232 is the max for bytes
            byte b = (byte) x; // cast
            string number = "1234";
            // int i = (int) number; //string cannot be cast to int
            int i = Convert.ToInt32(number); // has to use convert
            System.Console.WriteLine(b);
            System.Console.WriteLine(i);

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                System.Console.WriteLine(c);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte;"); // prevents the app to crash
            }

        }
    }
 }
