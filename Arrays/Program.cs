internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********");
        Console.WriteLine("Calculator");
        Console.WriteLine("**********");

        bool again = true;

        while (again)
        {
            float firstNum;
            float secondNum;
            float result;
            string op = "";

            Console.Write("Input first number: ");
            firstNum = float.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            secondNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Choose your Operator: ADD(+), SUB(-), DIV(/), MUL(*) ");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + result);
                    break;
                case "-":
                    result = firstNum + secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + result);
                    break;
                case "/":
                    result = firstNum + secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + result);
                    break;
                case "*":
                    result = firstNum + secondNum;
                    Console.WriteLine(firstNum + " * " + secondNum + " = " + result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.WriteLine("would you like to try again (Y/N)");
            string input = Console.ReadLine();

            if (input.ToUpper() != "Y")
            {
                again = false;
            }
        }
        


        Console.ReadKey();
        
    }
}