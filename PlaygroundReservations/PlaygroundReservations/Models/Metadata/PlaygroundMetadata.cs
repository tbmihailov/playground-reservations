using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies PlaygroundMetadata as the class
	// that carries additional metadata for the Playground class.
	[MetadataTypeAttribute(typeof(Playground.PlaygroundMetadata))]
	public partial class Playground
	{

		// This class allows you to attach custom attributes to properties
		// of the Playground class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class PlaygroundMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private PlaygroundMetadata()
			{
			}

            [Display(Name = "Номер")]
			//[Required()]
			public System.Int32 PlaygroundId{ get; set; }

            [Display(Name = "Име")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "Описание")]
			//[Required()]
			public System.String Description{ get; set; }

			[Display(Name = "Ширина")]
			//[Required()]
			public System.Double Width{ get; set; }

			[Display(Name = "Дължина")]
			//[Required()]
			public System.Double Length{ get; set; }

			[Display(Name = "Номер")]
			//[Required()]
			public System.Int32 SurfaceId{ get; set; }

			[Display(Name = "Настилка")]
			//[Required()]
			public PlaygroundReservations.Models.Surface Surface{ get; set; }

            [Display(Name = "Id")]
			//[Required()]
			public System.Int32 SportComplexId{ get; set; }

			[Display(Name = "Спортен комплкес")]
			//[Required()]
			public PlaygroundReservations.Models.SportComplex SportComplex{ get; set; }

			[Display(Name = "Снимки")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.PlaygroundImage> PlaygroundImages{ get; set; }

			[Display(Name = "Резервации")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.Reservation> Reservations{ get; set; }

			[Display(Name = "Такса")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.ReservationFee> ReservationFees{ get; set; }

        }
    }
}

