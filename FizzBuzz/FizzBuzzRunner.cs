namespace FizzBuzz
{
    public abstract class FizzBuzzRunner
    {
        public static void Run(int end, IOutputFizzBuzz outputFizzBuzz)
        {
            var logic = new Logic();
            for(int i = 0; i <= end; ++i)
            {
                var output = logic.Run(i);
                outputFizzBuzz.Output($"{i}: {output}");
            }
        }
    }
}
