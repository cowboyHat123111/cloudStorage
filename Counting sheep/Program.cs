namespace Counting_sheep
{
    internal class Program
    {
        /*public static int CountSheeps(bool[] sheeps)
        {
            int counter = 0;

            foreach (bool item in sheeps)
            {
                if (item)
                {
                    ++counter;
                }
            }
            return counter;
        }*/

        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s is true);
        }

        static void Main(string[] args)
        {
            bool[] bools = { true, false, true, true, false, true };

            Console.WriteLine(CountSheeps(bools));
        }
    }
}