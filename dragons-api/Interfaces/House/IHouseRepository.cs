using DragonsAPI.Models;

namespace DragonsAPI.Interfaces
{
	public interface IHouseRepository
	{
		Task<IEnumerable<House>> GetAllAsync();
		Task<House> GetByIdAsync(int id);
		Task AddAsync(House house);
		Task UpdateAsync(House house);
		Task DeleteAsync(House house);
	}

}
