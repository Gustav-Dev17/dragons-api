using DragonsAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace DragonsAPI.Models
{
	public class Dragon
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public string Size { get; set; }
		public decimal Weight { get; set; }
		public decimal Height { get; set; }
		public string Temperament { get; set; }
		public Status Status { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public DateTime? DateOfDeath { get; set; }

		public ICollection<DragonRider> DragonRiders { get; set; }
	}

}
