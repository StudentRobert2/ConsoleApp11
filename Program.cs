namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);
            int numResult = num;
            int sum = 1;
            int k = 0;
            int j = 0;
            int result = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                for(int o = numStr.Length; o > 0; o--) {
                     k = num % 10 * o;
                }
                num = num / 10;
                for (int d = numStr.Length; d >= 0; d--)
                {

                    sum = k * k * k;
      
                }
                result += sum;
            }
            if(result== numResult) {
                Console.WriteLine(true);
            }

        }
    }
}