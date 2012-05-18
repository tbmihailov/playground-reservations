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
	
			[Display(Name = "SportComplexId")]
			//[Required()]
			public System.Int32 SportComplexId{ get; set; }

			[Display(Name = "Name")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "Address")]
			//[Required()]
			public System.String Address{ get; set; }

			[Display(Name = "City")]
			//[Required()]
			public System.String City{ get; set; }

			[Display(Name = "Section")]
			//[Required()]
			public System.String Section{ get; set; }

			[Display(Name = "Description")]
			//[Required()]
			public System.String Description{ get; set; }

			[Display(Name = "Phone")]
			//[Required()]
			public System.String Phone{ get; set; }

			[Display(Name = "Email")]
			//[Required()]
			public System.String Email{ get; set; }

			[Display(Name = "Latitude")]
			//[Required()]
			public System.Decimal Latitude{ get; set; }

			[Display(Name = "Longitude")]
			//[Required()]
			public System.Decimal Longitude{ get; set; }

			[Display(Name = "OwnerId")]
			//[Required()]
			public System.Int32 OwnerId{ get; set; }

			[Display(Name = "Owner")]
			//[Required()]
			public PlaygroundReservations.Models.OwnerProfile Owner{ get; set; }

			[Display(Name = "Playgrounds")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.Playground> Playgrounds{ get; set; }

        }
    }
}

