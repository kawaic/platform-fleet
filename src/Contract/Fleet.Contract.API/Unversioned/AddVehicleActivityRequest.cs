using System;
using System.ComponentModel.DataAnnotations;

namespace Fleet.Contract.API.Unversioned
{
    public class AddVehicleActivityRequest
    {
        [Required]
        public int PartnerId { get; set; }
        [Required]
        public string PrimaryMemberId { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public double Odometer { get; set; }
        public int VehicleId { get; set; }
        [Required]
        public int VehiclePeriodId { get; set; }
        [Required]
        public string Vin { get; set; }
    }
}
