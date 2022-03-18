using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlNhanLuc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Nhanvien());
            //Application.Run(new frmRpPBViewer());
            //Application.Run(new frmRpNVViewer());
            //Application.Run(new Phongban());
        }
        
        public static Form findOpenForm(string name)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    return f;
            return null;
        }
        
    }
}
