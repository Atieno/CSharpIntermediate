using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Logger
    {
        //create a method Log that takes a message and simply writes it to the console
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    //class DbMigrator
    public class Dbmigrator
    {
        private readonly Logger _logger;
        //create an association to the Logger class
        public Dbmigrator(Logger logger)
        {
            _logger = logger;
    }
        public void Migrate()
        {
            //call the log ,method of the logger class
            _logger.Log("We are migrating yaeeeee.....");
      


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
            // as part of installing the application, we are going to log messages to our log file
            _logger.Log("We are Installing the application. ");

            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new Dbmigrator(new Logger());
            // can pass this obl=ject to the DBMigration installer
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

        }
    }
}
