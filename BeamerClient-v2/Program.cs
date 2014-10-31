using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;

namespace BeamerClient_v2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Set libvlc.dll and libvlccore.dll directory path
            VlcContext.LibVlcDllsPath = CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64;
            //Set the vlc plugins directory path
            VlcContext.LibVlcPluginsPath = CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64;

            //Set the startup options
            VlcContext.StartupOptions.IgnoreConfig = true;
            VlcContext.StartupOptions.LogOptions.LogInFile = false;
            VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = false;
            VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogVerbosities.None;

            try
            {
                //Initialize the VlcContext
                VlcContext.Initialize();
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("VLC Required!");
                //return;
            }
            Application.Run(new BeamerClient());

            //Close the VlcContext
            VlcContext.CloseAll();
        }
    }
}
