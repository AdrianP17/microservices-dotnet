using promociones.Dtos.Promocion;
using promociones.Models;

namespace promociones.Interfaces
{
    public interface IPromocionRepository
    {
        Task<List<Promocion>> GetAllAsync();
        Task<Promocion?> GetByIdAsync(int id);
        Task<Promocion> CreateAsync(Promocion promocion);
        Task<Promocion?> UpdateAsync(int id, UpdatePromocionRequestDto promocion);
        Task<Promocion?> DeleteAsync(int id);
    }
}