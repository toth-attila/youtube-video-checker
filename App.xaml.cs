using FirstFloor.ModernUI.Presentation;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace YoutubeVideoChecker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            logger.Info("Start program");
            AppearanceManager.Current.AccentColor = Color.FromRgb(0xdd, 0x28, 0x26);
            if (!CanSelectedCountryReadFromSetting())
            {

            }
        }

        private bool CanSelectedCountryReadFromSetting()
        {
            //TODO: Implement it!
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            logger.Info("End program");
        }
    }
}
