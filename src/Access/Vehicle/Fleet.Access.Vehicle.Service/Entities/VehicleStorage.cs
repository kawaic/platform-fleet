namespace Fleet.Access.Vehicle.Service.Entities
{
    public class VehicleStorage
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string VehicleId { get; set; }
        public string PlateNumber { get; set; }
        public int PartnerId { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PartnerVehicleId { get; set; }
    }
}
