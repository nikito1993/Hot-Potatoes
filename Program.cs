 namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Kids = new Queue<string>(Console.ReadLine().Split(" ").ToList());

            int tosses=int.Parse(Console.ReadLine());
            int toss = 1;
            while (Kids.Count>1)
            {
                string currKid=Kids.Dequeue();
                if (toss==tosses)
                {
                    Console.WriteLine($"Removed {currKid}");
                    toss=1;
                    continue;
                }
                toss++;  
                Kids.Enqueue(currKid);
            }
            Console.WriteLine($"Last is {Kids.Dequeue()}");
        }
    }
}