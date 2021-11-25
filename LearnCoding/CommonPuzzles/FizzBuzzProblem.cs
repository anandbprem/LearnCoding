namespace LearnCoding.CommonPuzzles
{
    internal class FizzBuzzProblem
    {
        public void Solution1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write(" FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                else
                {
                    Console.Write($" {i} ");
                }
            }
        }

        public void Solution1Optimized(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var div3 = i % 3 == 0;
                var div5 = i % 5 == 0;

                if (div3 && div5)
                {
                    Console.Write(" FizzBuzz ");
                }
                else if (div3)
                {
                    Console.Write(" Fizz ");
                }
                else if (div5)
                {
                    Console.Write(" Buzz ");
                }
                else
                {
                    Console.Write($" {i} ");
                }
            }
        }

        public void Solution2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //if ((i % 3 == 0) && (i % 5 == 0))
                if (i % 15 == 0)
                {
                    Console.Write(" FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                else
                {
                    Console.Write($" {i} ");
                }
            }
        }
    }
}
