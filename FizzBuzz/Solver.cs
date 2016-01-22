namespace FizzBuzz
{
    internal class Solver
    {
        public Solver()
        {
        }

        public string Translate(int number)
        {
            if (number%3 == 0)
                return "Fizz";
            return number.ToString();
        }
    }
}