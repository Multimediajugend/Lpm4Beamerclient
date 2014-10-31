using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using System.IO;

namespace BeamerClient
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

            // Set libvlc.dll and libvlccore.dll directory path
            if (Directory.Exists(CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64))
                VlcContext.LibVlcDllsPath = CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64;
            else
                VlcContext.LibVlcDllsPath = @"E:\Program Files (x86)\VideoLAN\VLC\";

            // Set the vlc plugins directory path
            if (Directory.Exists(CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64))
                VlcContext.LibVlcPluginsPath = CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64;
            else
                VlcContext.LibVlcPluginsPath = @"E:\Program Files (x86)\VideoLAN\VLC\plugins\";

            // Ignore the VLC configuration file
            VlcContext.StartupOptions.IgnoreConfig = true;
            
            //stellt die Anzeige des Dateinamens zu Begin ab
            VlcContext.StartupOptions.AddOption("--no-osd");

            // Enable file based logging
            VlcContext.StartupOptions.LogOptions.LogInFile = false;

            // Shows the VLC log console (in addition to the applications window)
            VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = false;

            // Set the log level for the VLC instance
            VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogVerbosities.None;

            // Initialize the VlcContext
            VlcContext.Initialize();

            Application.Run(new Form1());

            // Close the VlcContext
            VlcContext.CloseAll();
        }
    }
}
