namespace UniLoggerMain
{
    using UniLogger.Appenders;
    using UniLogger.Contracts;
    using UniLogger.Layouts;
    using UniLogger.Logger;

    internal class UniLoggerMain
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout) { File = "log.txt" };

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");
        }
    }
}