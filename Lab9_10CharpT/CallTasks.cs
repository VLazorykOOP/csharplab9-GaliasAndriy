
namespace Lab9_10CharpT
{
    public class TasksUsage
    {
        public static void Program1()
        {
            Task1.ExecuteTask();
        }

        public static void Program2()
        {
            Task2.ExecuteTask();
        }

        public static void Program3() {
            Task3.ExecuteTask();
        }

        public static void Program4() {
            MusicCatalog catalog = new();

            catalog.AddMusicCD("CD1", "Rick Astley");
            catalog.AddMusicCD("CD2", "Different Artists");

            catalog.AddSong("CD1", "Together Forever", "Rick Astley", "Whenever You Need Somebody", new Time(3, 25));
            catalog.AddSong("CD1", "Never Gonna Give You Up", "Rick Astley", "Whenever You Need Somebody", new Time(3, 33));
            catalog.AddSong("CD2", "Stayin' Alive", "Bee Gees", "Staying Alive", new Time(1, 32));
            catalog.AddSong("CD2", "Stumblin' In", "Chris Norman, Suzi Quatro", new Time(3, 59));

            catalog.DisplayCatalog();
            catalog.AddMusicCD("CD5", "Eurythmics");
            catalog.AddSong("CD5", "Sweet Dreams (Are Made of This)", "Eurythmics. Annie Lennox, Dave Stewart", "Sweet Dreams (Are Made of This)", new Time(3, 36));
            catalog.RemoveSong("CD1", "Together Forever");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Show after changes");
            Console.ResetColor();
            Console.WriteLine("");
            catalog.DisplayCatalog();

            catalog.SearchByArtist("Rick Astley");
        }
    }
}
