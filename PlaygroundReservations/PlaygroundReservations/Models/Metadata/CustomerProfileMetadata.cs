using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies CustomerProfileMetadata as the class
	// that carries additional metadata for the CustomerProfile class.
	[MetadataTypeAttribute(typeof(CustomerProfile.CustomerProfileMetadata))]
	public partial class CustomerProfile
	{

		// This class allows you to attach custom attributes to properties
		// of the CustomerProfile class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class CustomerProfileMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private CustomerProfileMetadata()
			{
			}
	
			[Display(Name = "CustomerProfileId")]
			//[Required()]
			public System.Int32 CustomerProfileId{ get; set; }

			[Display(Name = "Email")]
			//[Required()]
			public System.String Email{ get; set; }

			[Display(Name = "Name")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "Notes")]
			//[Required()]
			public System.String Notes{ get; set; }

			[Display(Name = "Phone")]
			//[Required()]
			public System.String Phone{ get; set; }

			[Display(Name = "Reservations")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.Reservation> Reservations{ get; set; }

        }
    }
}

