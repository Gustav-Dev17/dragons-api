using DragonsAPI.Models;
using DragonsAPI.Interfaces;
using DragonsAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace DragonsAPI.Repositories
{
	public class HouseRepository : IHouseRepository
	{
		private readonly AppDbContext _context;

		public HouseRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<House>> GetAllAsync()
		{
			return await _context.Houses.ToListAsync();
		}

		public async Task<House> GetByIdAsync(int id)
		{
			return await _context.Houses.FindAsync(id);
		}

		public async Task AddAsync(House house)
		{
			await _context.Houses.AddAsync(house);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(House house)
		{
			_context.Houses.Update(house);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(House house)
		{
			_context.Houses.Remove(house);
			await _context.SaveChangesAsync();
		}
	}

}
