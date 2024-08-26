using System.ComponentModel.DataAnnotations;

namespace DragonsAPI.Models
{
	public class House
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

	}

}
