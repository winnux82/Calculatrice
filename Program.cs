using Calculatrice;

namespace Calculatrice
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();
            login.ShowDialog();

            if (login.IsValidLogin == true)
            {
                CalculatricePOO calculate = new CalculatricePOO();
                calculate.ShowDialog();
            }

            //Application.Run(new FormLogin());

            //Application.Run(new FormLogin());
        }
    }
}