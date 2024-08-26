using DragonsAPI.Dtos;
namespace DragonsAPI.Interfaces
{
	public interface IHouseService
	{
		Task<IEnumerable<HouseDto>> GetAllAsync();
		Task<HouseDto> GetByIdAsync(int id);
		Task AddAsync(HouseDto houseDto);
		Task UpdateAsync(HouseDto houseDto);
		Task DeleteAsync(int id);
	}

}
