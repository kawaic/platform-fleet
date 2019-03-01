using System.Threading.Tasks;

namespace Fleet.Access.Vehicle.Interface
{
    public interface IVehicleAccess
    {
        Task AddVehicleActivityAsync(AddVehicleActivityRequest request);
    }
}