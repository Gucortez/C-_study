namespace MyConsoleApp.ConditionalStatements
{
    public class Switch
    {
        public static void switchSeasons (Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("It's perfect to got to the beach.");
                    break;
                case Season.Spring:
                    System.Console.WriteLine("It's beautiful to see the flowers outside.");
                    break;
                case Season.Winter:
                    System.Console.WriteLine("The cold can be cruel.");
                    break;
                default:
                    System.Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}


