namespace HelloNLog
{
    public class Calculus
    {
        public string FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return  $"FizzBuzz - {number}";
            }

            if(number % 3 == 0)
            {
                return $"Fizz - {number}";
            }

            if (number % 5 == 0)
            {
                return $"Buzz - {number}";
            }

            return number.ToString();
        }
    }
}
