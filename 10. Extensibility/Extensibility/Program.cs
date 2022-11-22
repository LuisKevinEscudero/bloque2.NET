namespace Extensibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\luiskevin.escudero\Desktop\log.txt"));
            dbMigrator.Migrate();
        }
    }
}