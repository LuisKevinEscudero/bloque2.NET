namespace Extensibility
{

    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.logInfo("Migration started at {0}" + DateTime.Now);
            //Console.WriteLine("Migration started at {0}", DateTime.Now);

            logger.logInfo("Migration finished at {0}" + DateTime.Now);
            //Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}