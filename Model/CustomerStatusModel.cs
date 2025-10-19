namespace eshift.Model
{
    internal class CustomerStatusModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public CustomerStatusModel() { }

        public CustomerStatusModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}