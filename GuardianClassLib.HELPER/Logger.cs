using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.HELPER
{
    public class Logger
    {
        private static readonly log4net.ILog Log4Net = log4net.LogManager.GetLogger("log");

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static void WriteInfo(string msg)
        {
            Log4Net.Info(msg);
        }
        public static void WriteDebug(string msg)
        {
            Log4Net.Debug(msg);
        }
        public static void WriteError(string msg)
        {
            Log4Net.Error(msg);
        }
        public static void WriteFatal(string msg)
        {
            Log4Net.Fatal(msg);
        }
        public static void WriteWarn(string msg)
        {
            Log4Net.Warn(msg);
        }
    }
}
