using System;

namespace Fleet.Contract.API.Unversioned
{
    public class AddVehicleActivityRequest
    {
        public string PrimaryMemberId { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Odometer { get; set; }
        public int PartnerId { get; set; }
        public int VehicleId { get; set; }
        public int VehiclePeriodId { get; set; }
        public int SourceId { get; set; }
        public string OdometerUnits { get; set; }
    }
}
