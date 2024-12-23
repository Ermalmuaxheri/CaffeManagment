using edomndtest2.Forms;

namespace edomndtest2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (PinForm pinForm = new PinForm())
            {
                if (pinForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1(pinForm.UserId, pinForm.UserName, pinForm.UserSurname));
                }
            }
        }
    }
}