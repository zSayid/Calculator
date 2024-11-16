namespace virtualLesson.Calc
{
    public class Calculator
    {
       
        public void Start() 
        {
            while (true)
            {
                Console.WriteLine("Calculator app");

                double firstNumber = parseNumber();
                string operation = ValidateOperation();
                double secondNumber = parseNumber();
                double result =  Calculate(firstNumber, operation, secondNumber);
                Console.WriteLine(result);
            }

        }
        private double parseNumber()
        {
            bool parsingResult = false;
            double result = 0;

            while (!parsingResult)
            {
                Console.WriteLine("Sonni kiriting");
                string firstNumberString = Console.ReadLine();
                parsingResult = double.TryParse(firstNumberString, out result);
            }
            return result;

        }

        private string ValidateOperation()
        {
            string operation = string.Empty;
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "^" && operation != "#")
            {
                Console.WriteLine("Amalni kiriting (+ - * / ^ ) #");
                operation = Console.ReadLine();
            }
            return operation;

        }

        private double Calculate(double firstNumber, string operation, double secondNumber)
        {
            var result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
                "#" => Math.Sqrt(firstNumber),
                _ => 0,
            }; 
            Console.WriteLine($"Natija {firstNumber} {operation} {secondNumber} = {result}");
            return result;
        }
    }
}
