class Program
{
    static void Main()
    {
        int nowDay = 0;

        Day day = () =>
        {
            string[] daysWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string nextDay = daysWeek[nowDay];

            nowDay = (nowDay + 1) % 7;

            return nextDay;
        };

        for (byte i = 0; i < 15; i++)
            Console.WriteLine(day());
    }
}

delegate string Day();