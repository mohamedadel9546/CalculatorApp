namespace calculator
{
    internal class Program
    {
        static int add (int num1,int num2)
        {
              return num1 + num2;
        }
        static int Subtratc (int num1,int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
         return num2 - num1;
            }
        static int Multibly(int num1, int num2)
        {
            return num1 * num2;
        }
       static int Divide(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch
            {
                  Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter First number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operator: (+, -, *, /)");
                string op = Console.ReadLine();


                Console.WriteLine("Enter Second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case "+":
                      Console.WriteLine($"{num1} {op} {num2} = {add(num1, num2)}");
                        break;
                    case "-":
                      Console.WriteLine("Result: " + Subtratc(num1, num2));
                        break;
                    case "*":
                      Console.WriteLine("Result: " + Multibly(num1, num2));
                        break;
                    case "/":
                      Console.WriteLine("Result: " + Divide(num1, num2));
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

            }
        }
    }
}
