namespace api.dogovor.alif.tj.LogSettings
{
    public class LogProvider : ILogProvider
    {
        private static Logger logger/* = LogManager.GetLogger("MyLoggerRules")*/;
        private static LogProvider Instance;

        private LogProvider() { }

        public static LogProvider GetInstance()
        {
            if (Instance == null)
                Instance = new LogProvider();
            return Instance;
        }
        private Logger GetLogger(string theLogger)
        {
            if (LogProvider.logger == null)
                LogProvider.logger = LogManager.GetLogger(theLogger);
            return LogProvider.logger;
        }
        public void Debug(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("MyAppLoggerRule").Debug(message);
            else
                GetLogger("MyAppLoggerRule").Debug(message, arg);
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("MyAppLoggerRule").Error(message);
            else
                GetLogger("MyAppLoggerRule").Error(message, arg);
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("MyAppLoggerRule").Info(message);
            else
                GetLogger("MyAppLoggerRule").Info(message, arg);
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
                GetLogger("MyAppLoggerRule").Warn(message);
            else
                GetLogger("MyAppLoggerRule").Warn(message, arg);
        }
    }
}
