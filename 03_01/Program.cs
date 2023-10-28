namespace _03_00
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            byte myByte = 30;

            int myInt = 511;

            myByte = (byte) myInt;

            Console.WriteLine($"{myByte}");

            
            {
                byte health = 200;
                byte damage = 10;

                health -= damage;
                health += 100;
            }
        }
    }
}