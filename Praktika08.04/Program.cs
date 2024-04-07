using Praktika08._04.Extension;

namespace Praktika08._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(typeof(Roles))) 
            {
                Console.WriteLine(item.ToString());
            }
            //    int num1 = 34;
            //    int num2 = 34;
            //    string text = "azerbaycan";
            //    Console.WriteLine(text.Capitalize());
            //    Console.WriteLine(34.Add(num2));
            //    isEven(null);

            //}
            //static void isEven(int ? num)
            //{
            //    if(num==null) Console.WriteLine("num must be non nullable value");
            //    else Console.WriteLine(num%2==0);

           
        }

    }
}
