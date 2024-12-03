using System;
using System.Windows.Forms;

namespace btvn
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Đảm bảo Form1 đã được định nghĩa
        }
    }
}
