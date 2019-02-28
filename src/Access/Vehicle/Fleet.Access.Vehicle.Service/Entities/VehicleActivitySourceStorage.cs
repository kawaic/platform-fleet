using System;
using System.Collections.Generic;
using System.Text;

namespace Fleet.Access.Vehicle.Service.Entities
{
    public class VehicleActivitySourceStorage
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
        public string FleetId { get; set; }
        public string TransactionId { get; set; }
        public int PartnerId { get; set; }
    }
}
