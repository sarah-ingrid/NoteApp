namespace NoteLogin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            Application.Run(new NoteApp(1));
        }
    }
}