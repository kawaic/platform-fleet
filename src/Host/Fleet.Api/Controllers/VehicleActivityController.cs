using System.Threading.Tasks;
using AutoMapper;
using Fleet.Access.Vehicle.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Fleet.Api.Controllers
{
    [Route("submissions/api/vehicle-activity")]
    public class VehicleActivityController : ControllerBase
    {
        private readonly IVehicleAccess vehicleAccess;
        private static readonly IMapper Mapper;

        static VehicleActivityController()
        {
            Mapper = new MapperConfiguration(
                c =>
                {
                    c.AddProfile<VehicleActivityControllerMappingProfile>();
                }
            ).CreateMapper();
        }

        public VehicleActivityController(IVehicleAccess vehicleAccess)
        {
            this.vehicleAccess = vehicleAccess;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddVehicleActivityAsync(Contract.API.Unversioned.AddVehicleActivityRequest apiRequest)
        {
            var request = Mapper.Map<AddVehicleActivityRequest>(apiRequest);
            await this.vehicleAccess.AddVehicleActivityAsync(request).ConfigureAwait(false);
            return this.Ok();
        }
    }
}
