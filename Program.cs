using System;
using System.Threading.Tasks;

namespace English_breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start to cook breakfest!");
            CutMushRoom(5);
            var fryMushroom =  FryMushRoom();
            var fryreadSlices = FryBreadSlices(2); 
            var fryeggs = FryEggs(2); 
            await Task.WhenAll(fryMushroom, fryreadSlices, fryeggs);
            Console.WriteLine("BreakFest ready! Have a nice meal");
        }

        private static async Task FryBreadSlices(int bread)
        {
            Console.WriteLine($"We start to fry {bread} slices of bread in a frying pan");            
            await Task.Delay(bread * 3500);
            Console.WriteLine("The bread is ready");
            Console.WriteLine();
        }

        private static async Task FryEggs(int eggs)
        {
            Console.WriteLine($"We start to cook scrambled eggs from {eggs}  eggs");            
            await Task.Delay(eggs * 2000);
            Console.WriteLine("Scrambled eggs cooked");
            Console.WriteLine();
        }

        private static async Task FryMushRoom()
        {
            Console.WriteLine("We start to fry mushrooms");            
            await Task.Delay(5000);
            Console.WriteLine("Fried mushrooms are ready");
            Console.WriteLine();
        }

        private static void CutMushRoom(int mushroom)
        {
            Console.WriteLine($"Cut {mushroom} mushrooms into pieces");           
            Task.Delay(1000 * mushroom);
            Console.WriteLine("Finished cutting mushrooms");
            Console.WriteLine();
        }
    }
}
