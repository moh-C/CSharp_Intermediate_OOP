using System;

namespace InterfacesExtensibility
{
    public class DBMigrator
    {
        private readonly ILogger _logger;
        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.InfoLogger("Migration started at " + DateTime.Now);
            System.Threading.Thread.Sleep(2000);
            _logger.ErrorLogger("Migration finished at " + DateTime.Now);
        }
    }
}