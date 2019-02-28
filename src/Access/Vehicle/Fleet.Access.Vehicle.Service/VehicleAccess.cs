using System.Threading.Tasks;
using AutoMapper;
using Fleet.Access.Vehicle.Interface;
using Fleet.Access.Vehicle.Service.Entities;

namespace Fleet.Access.Vehicle.Service
{
    public class VehicleAccess
    {
        private readonly VehicleContext context;
        private static readonly IMapper Mapper;

        static VehicleAccess()
        {
            Mapper = new MapperConfiguration(
                c =>
                {
                    c.AddProfile<VehicleAccessMappingProfile>();
                }
                ).CreateMapper();
        }

        public VehicleAccess(VehicleContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(AddVehicleActivityRequest request)
        {
            var mapped = Mapper.Map<VehicleActivityStorage>(request.Activity);
            await context.VehicleActivities.AddAsync(mapped);
            await context.SaveChangesAsync();
        }
    }
}
