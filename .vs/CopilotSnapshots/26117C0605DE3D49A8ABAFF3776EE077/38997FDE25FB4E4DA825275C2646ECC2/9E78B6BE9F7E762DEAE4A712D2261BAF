namespace eshift.Dto
{
    public class VehicleDto
    {
        public int? Id { get; set; } // Database ID
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public double ContainerVolume { get; set; }
        public double MaxWeight { get; set; }

        public VehicleDto() { }
        public VehicleDto(int? id, string brand, string model, string registrationNumber,
                          double containerVolume, double maxWeight)
        {
            Id = id;
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
            ContainerVolume = containerVolume;
            MaxWeight = maxWeight;
        }
        public VehicleDto(string brand, string model, string registrationNumber,
                          double containerVolume, double maxWeight)
        {
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
            ContainerVolume = containerVolume;
            MaxWeight = maxWeight;
        }
    }
}
