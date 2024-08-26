using DragonsAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace DragonsAPI.Models
{
	public class Rider
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public DateTime? DateOfDeath { get; set; }
		public Status Status { get; set; }

		public int HouseId { get; set; }
		public House House { get; set; }

		public ICollection<DragonRider> DragonRiders { get; set; }
	}

}
