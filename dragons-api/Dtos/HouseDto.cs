using Swashbuckle.AspNetCore.Annotations;

namespace DragonsAPI.Dtos
{
	public class HouseDto
	{
		public int Id { get; set; }
		public string Name { get; set; }

	}

	public class CreateHouseDto
	{
		[SwaggerSchema(ReadOnly = true)]
		public int Id { get; set; }
		public string Name { get; set; }

	}

}
