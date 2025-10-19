namespace eshift.Dto
{
    internal class JobTransportUnitDto
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int TransportUnitId { get; set; }

        public JobTransportUnitDto() { }

        public JobTransportUnitDto(int id, int jobId, int transportUnitId)
        {
            Id = id;
            JobId = jobId;
            TransportUnitId = transportUnitId;
        }
    }
}