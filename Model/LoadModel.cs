namespace eshift.Model
{
    internal class LoadModel
    {
        public int? Id { get; set; }
        public string LoadId { get; set; }
        public string Description { get; set; }
        public double Volume { get; set; }
        public double Weight { get; set; }
        public int JobId { get; set; }

        public LoadModel() { }

        public LoadModel(int? id, string loadId, string description, double volume, double weight, int jobId)
        {
            Id = id;
            LoadId = loadId;
            Description = description;
            Volume = volume;
            Weight = weight;
            JobId = jobId;
        }
    }
}