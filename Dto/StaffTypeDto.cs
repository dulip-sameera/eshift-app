namespace eshift.Dto
{
    internal class StaffTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public StaffTypeDto() { }
        public StaffTypeDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}