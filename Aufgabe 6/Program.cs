using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Aufgabe_6
{
    public class Userdata
    {        
        public string name { get; set; }
        public string lastname { get; set;}
        public DateTime bday { get; set; }
        public string city { get; set; }
        public string mail { get; set; }
        public string userid { get; set; }
        public string pb { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
