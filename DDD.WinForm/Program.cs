using Ddd.WinForm.Views;
using System;
using System.Windows.Forms;

namespace Ddd.WinForm
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuView());
        }
    }
}
