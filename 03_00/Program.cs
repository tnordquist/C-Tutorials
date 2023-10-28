
namespace _03_00
{

    enum WEEKDAY { MONDAY = 1, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY }
    class Program
    {
        private static void Main(string[] args)
        {

            

            Console.WriteLine("Enter the day you want - 1 to 7");

            int input = int.Parse(Console.ReadLine());
            WEEKDAY day = (WEEKDAY)input;

            Console.WriteLine($"Today is {day}");

            switch (day)
            {
                case WEEKDAY.MONDAY:
                    Console.WriteLine("Monday Blues");
                    break;
                case WEEKDAY.TUESDAY:
                    Console.WriteLine("Tuesdays are the neutral day.");
                    break;
                case WEEKDAY.WEDNESDAY:
                    Console.WriteLine("Wednesday humpday");
                    break;
                case WEEKDAY.THURSDAY:
                    Console.WriteLine("Thursday almost there.");
                    break;
                case WEEKDAY.FRIDAY:
                    Console.WriteLine("Friday celebrate");
                    break;
                case WEEKDAY.SATURDAY:
                    Console.WriteLine("Saturday recuperate, church.");
                    break;
                case WEEKDAY.SUNDAY:
                    Console.WriteLine("Sunday hike; relax.");
                    break;
            }
        }
    }
}