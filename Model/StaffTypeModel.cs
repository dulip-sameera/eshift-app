namespace eshift.Model
{
    internal class StaffTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public StaffTypeModel() { }
        public StaffTypeModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}