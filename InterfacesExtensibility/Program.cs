using System;

namespace InterfacesExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // var migrator = new DBMigrator(new FileLogger("C:\\Users\\moham\\Desktop\\GitHub\\CSharp_OOP\\InterfacesExtensibility\\Log.txt"));
            var migrator = new DBMigrator(new ConsoleLogger());
            migrator.Migrate();
        }
    }
}
