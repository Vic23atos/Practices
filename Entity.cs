namespace src.ServiceWithDependencies
{
    public class Entity
    {
        public Entity(int key, string name, string description)
        {
            Id = key;
            Name = name;
            Description = description;
        }

        public Entity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}