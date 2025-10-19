namespace eshift.Dto
{
    internal class JobStatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public JobStatusDto() { }

        public JobStatusDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}