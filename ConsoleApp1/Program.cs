namespace CalculatorTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            double operation;
            double answer;

            Console.WriteLine("This is a simple Calculator");
            Console.WriteLine("Enter First Number:");
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation \r\n1. Addition\r\n2. Subtraction\r\n3. Multiplication\r\n4. Division\r\nEnter Number: ");
            operation = Convert.ToDouble(Console.ReadLine());

            if (operation == 1) { answer = firstNum + secondNum; }
            else if (operation == 2) { answer = firstNum - secondNum; }
            else if (operation == 3) { answer = firstNum * secondNum; }
            else { answer = firstNum / secondNum; };



            Console.WriteLine("The answer is " + answer);

        }
    }
}
