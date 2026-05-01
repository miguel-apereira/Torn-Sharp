using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TornSharp.Settings {
    internal class AppSettings {
        internal static void SaveSettings() {
            UserSettings.Default.Save();
        }
    }
}
