using System.ComponentModel.DataAnnotations;

namespace DragonsAPI.Models
{
	public class DragonRider
	{
		[Key]
		public int Id { get; set; }

		public int RiderId { get; set; }
		public Rider Rider { get; set; }

		public int DragonId { get; set; }
		public Dragon Dragon { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }

		public bool IsCurrent { get; set; }
	}

}
