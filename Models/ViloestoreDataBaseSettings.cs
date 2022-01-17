namespace projectC.Models
{
    public class ViloestoreDatabaseSettings : IViloestoreDatabaseSettings
    {
        public string ViloesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IViloestoreDatabaseSettings
    {
        string ViloesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}