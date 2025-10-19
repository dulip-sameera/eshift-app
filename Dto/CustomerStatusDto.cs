namespace eshift.Dto
{
    internal class CustomerStatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public CustomerStatusDto() { }

        public CustomerStatusDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}