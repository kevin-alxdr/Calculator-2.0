namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string again = "y";
            while (again == "y")

            {
                Console.WriteLine("\n--------------------------Calculator--------------------------\n");
                Console.WriteLine("Please enter 2 numbers with a symbol between them: (+ - * /) ");
                Console.WriteLine(" ");
                string line = Console.ReadLine();

                line = line.Replace(" ", string.Empty);


                // ADD
                // --------------------------------------------------------------

                if (line.Contains("+"))
                {

                    string[] subs = line.Split('+');

                    int result = int.Parse(subs[0]);
                    int result2 = int.Parse(subs[1]);

                    int result3 = result + result2;
                    Console.WriteLine("Answer: " + result3);
                }


                // SUBTRACT
                // --------------------------------------------------------------

                if (line.Contains("-"))
                {

                    string[] subs = line.Split('-');

                    int result = int.Parse(subs[0]);
                    int result2 = int.Parse(subs[1]);

                    int result3 = result - result2;
                    Console.WriteLine("Answer: " + result3);
                }


                // MULTIPLY
                // --------------------------------------------------------------

                if (line.Contains("*"))
                {

                    string[] subs = line.Split('*');

                    int result = int.Parse(subs[0]);
                    int result2 = int.Parse(subs[1]);

                    int result3 = result * result2;
                    Console.WriteLine("Answer: " + result3);
                }


                // DIVIDE
                // --------------------------------------------------------------

                if (line.Contains("/"))
                {

                    string[] subs = line.Split('/');

                    int result = int.Parse(subs[0]);
                    int result2 = int.Parse(subs[1]);

                    float result3 = (float)result / (float)result2;
                    Console.WriteLine("Answer: " + result3);
                }


                Console.WriteLine("\nCalculate again? (y/n)\n");
                again = Console.ReadLine();
            }
        }
    }
}