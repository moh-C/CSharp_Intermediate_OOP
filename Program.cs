using System;

namespace CSharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DbMigrator(new Logger());
            var install = new Install(new Logger());
            db.Migrate();
            install._Install();
        }
    }
}
