namespace eshift.Model
{
    internal class JobStatusModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public JobStatusModel() { }

        public JobStatusModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}