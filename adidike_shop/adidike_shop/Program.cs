using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using thanhtoan;

namespace adidike_shop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            Application.Run(new customer());
=======
            Application.Run(new pay());
>>>>>>> Stashed changes
=======
            Application.Run(new product());
>>>>>>> Stashed changes
/*            Application.Run(new pay());  */
        }
    }
}
