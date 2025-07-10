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
            Application.Run(new LoginForm());
          //  Application.Run(new NoteApp(1));
          // aqui eu uso para quando quero testar apenas a parte do form NoteApp, pra iniciar direto com ele em vez do LoginForm
        }
    }
}