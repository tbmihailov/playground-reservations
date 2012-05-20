using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies SportComplexMetadata as the class
	// that carries additional metadata for the SportComplex class.
	[MetadataTypeAttribute(typeof(SportComplex.SportComplexMetadata))]
	public partial class SportComplex
	{

		// This class allows you to attach custom attributes to properties
		// of the SportComplex class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class SportComplexMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private SportComplexMetadata()
			{
			}
	
			[Display(Name = "Id")]
			//[Required()]
			public System.Int32 SportComplexId{ get; set; }

			[Display(Name = "Име")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "Адрес")]
			//[Required()]
			public System.String Address{ get; set; }

			[Display(Name = "Град")]
			//[Required()]
			public System.String City{ get; set; }

			[Display(Name = "Квартал")]
			//[Required()]
			public System.String Section{ get; set; }

			[Display(Name = "Описание")]
			//[Required()]
			public System.String Description{ get; set; }

			[Display(Name = "Телефон")]
			//[Required()]
			public System.String Phone{ get; set; }

			[Display(Name = "Имейл")]
			//[Required()]
			public System.String Email{ get; set; }

			[Display(Name = "Гео.Ширина")]
			//[Required()]
			public System.Decimal Latitude{ get; set; }

			[Display(Name = "Гео.Дължина")]
			//[Required()]
			public System.Decimal Longitude{ get; set; }

			[Display(Name = "Id")]
			//[Required()]
			public System.Int32 OwnerId{ get; set; }

			[Display(Name = "Собственик")]
			//[Required()]
			public PlaygroundReservations.Models.OwnerProfile Owner{ get; set; }

			[Display(Name = "Игрища")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.Playground> Playgrounds{ get; set; }

        }
    }
}

