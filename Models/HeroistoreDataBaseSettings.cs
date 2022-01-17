namespace projectC.Models
{
    public class HeroistoreDatabaseSettings : IHeroistoreDatabaseSettings
    {
        public string HeroisCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IHeroistoreDatabaseSettings
    {
        string HeroisCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}