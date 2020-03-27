using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are Migrating");
        }
    }
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We are installing the application");
        }
    }
    class Composition
    {
        static void Test()
        {
            var dbMigrator = new DBMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
