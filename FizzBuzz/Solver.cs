namespace FizzBuzz
{
    public class Solver
    {
        public Solver()
        {
        }

        public string Translate(int number)
        {
            bool fizz = number % 3 == 0;
            bool buzz = number % 5 == 0;

            if (fizz && buzz)
                return "FizzBuzz";
            if (fizz)
                return "Fizz";
            if (buzz)
                return "Buzz";
            return number.ToString();
        }
    }
}