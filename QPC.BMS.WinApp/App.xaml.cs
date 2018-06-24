using log4net;
using QPC.BMS.Helpers;
using QPC.BMS.Helpers.Enum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QPC.BMS.WinApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ILoggingHelper logger;

        public App()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ///Connfiguration Log4Net
            log4net.Config.XmlConfigurator.Configure();

            #region Log4Net
            logger.Info("        =============  Started Logging  =============        ");
            logger.Warn("        =============  Started Logging  =============        ");
            logger.Error("        =============  Started Logging  =============        ");
            logger.Fatal("        =============  Started Logging  =============        ");
            #endregion

            base.OnStartup(e);
        }
    }
}
