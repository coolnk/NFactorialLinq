using Xunit;

namespace NFactorialLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For a number get all the values uptill 1;
            List<int> list = new List<int>();
            int i = 3;
            var result = 1;
            while (i!=1)
            {
                list.Add(i);
                result =i==2?result:result*GetMul(i);
                i--;
            }
           var linqResult = list.Aggregate(1, (x, val) => x * val);  
           
            Assert.Equal(result, linqResult);
            Console.WriteLine(linqResult);

                
        }

        static int GetMul(int n) =>n==1?1:n *( n - 1);
    }
}