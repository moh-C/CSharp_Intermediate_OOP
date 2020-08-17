using System;

namespace InterfacesExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrator = new DBMigrator(new ConsoleLogger());
            migrator.Migrate();
        }
    }
}
