using System.ComponentModel.DataAnnotations.Schema;

namespace Fleet.Access.Vehicle.Service.Entities
{
    public class VehicleActivitySourceStorage
    {
        public int Id { get; set; }
        public string Status { get; set; }

        [Column(TypeName = "jsonb")]
        public string Data { get; set; }
        public string FleetId { get; set; }
        public string TransactionId { get; set; }
        public int PartnerId { get; set; }
    }
}
