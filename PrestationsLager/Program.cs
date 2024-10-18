using InMemoryDatabase;

namespace PrestationsLager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database db = new Database();
            db.InitieraAnvändare();

            LogicLayer logicLayer = new LogicLayer(db);

            Application.Run(new LogIn(logicLayer));  // Passera LogicLayer till formulären
        }
    }
}