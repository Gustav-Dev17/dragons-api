using DragonsAPI.Dtos;
using DragonsAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DragonsAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HousesController : ControllerBase
	{
		private readonly IHouseService _houseService;

		public HousesController(IHouseService houseService)
		{
			_houseService = houseService;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateHouseDto createHouseDto)
		{
			var houseDto = new HouseDto { Name = createHouseDto.Name };
			await _houseService.AddAsync(houseDto);

			return CreatedAtAction(nameof(GetById), new { id = houseDto.Id }, houseDto);
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var houses = await _houseService.GetAllAsync();
			return Ok(houses);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var house = await _houseService.GetByIdAsync(id);
			if (house == null) return NotFound();
			return Ok(house);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(int id, [FromBody] HouseDto houseDto)
		{
			if (id != houseDto.Id) return BadRequest();
			await _houseService.UpdateAsync(houseDto);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _houseService.DeleteAsync(id);
			return NoContent();
		}
	}

}
