using DragonsAPI.Dtos;
using DragonsAPI.Interfaces;
using DragonsAPI.Models;

namespace DragonsAPI.Services
{
	public class HouseService : IHouseService
	{
		private readonly IHouseRepository _houseRepository;

		public HouseService(IHouseRepository houseRepository)
		{
			_houseRepository = houseRepository;
		}

		public async Task<IEnumerable<HouseDto>> GetAllAsync()
		{
			var houses = await _houseRepository.GetAllAsync();
			return houses.Select(h => new HouseDto { Id = h.Id, Name = h.Name }).ToList();
		}

		public async Task<HouseDto> GetByIdAsync(int id)
		{
			var house = await _houseRepository.GetByIdAsync(id);
			if (house == null) return null;

			return new HouseDto { Id = house.Id, Name = house.Name };
		}

		public async Task AddAsync(HouseDto houseDto)
		{
			var house = new House
			{
				Name = houseDto.Name
			};

			await _houseRepository.AddAsync(house);

			houseDto.Id = house.Id;
		}

		public async Task UpdateAsync(HouseDto houseDto)
		{
			var house = await _houseRepository.GetByIdAsync(houseDto.Id);
			if (house != null)
			{
				house.Name = houseDto.Name;
				await _houseRepository.UpdateAsync(house);
			}
		}

		public async Task DeleteAsync(int id)
		{
			var house = await _houseRepository.GetByIdAsync(id);
			if (house != null)
			{
				await _houseRepository.DeleteAsync(house);
			}
		}
	}


}
