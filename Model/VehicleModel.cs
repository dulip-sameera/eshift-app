namespace eshift.Model
{
    internal class VehicleModel
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public double ContainerVolume { get; set; }
        public double MaxWeight { get; set; }

        public VehicleModel() { }

        public VehicleModel(int id)
        {
            Id = id;
        }

        public VehicleModel(int id, string brand, string model, string registrationNumber, double containerVolume, double maxWeight)
        {
            Id = id;
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
            ContainerVolume = containerVolume;
            MaxWeight = maxWeight;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({RegistrationNumber}) - Volume: {ContainerVolume} m³, Max Weight: {MaxWeight} kg";
        }

    }
}
