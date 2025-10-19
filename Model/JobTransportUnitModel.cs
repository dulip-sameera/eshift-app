namespace eshift.Model
{
    internal class JobTransportUnitModel
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int TransportUnitId { get; set; }

        public JobTransportUnitModel() { }

        public JobTransportUnitModel(int id, int jobId, int transportUnitId)
        {
            Id = id;
            JobId = jobId;
            TransportUnitId = transportUnitId;
        }
    }
}