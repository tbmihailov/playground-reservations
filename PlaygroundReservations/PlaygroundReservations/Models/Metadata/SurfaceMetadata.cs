using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies SurfaceMetadata as the class
	// that carries additional metadata for the Surface class.
	[MetadataTypeAttribute(typeof(Surface.SurfaceMetadata))]
	public partial class Surface
	{

		// This class allows you to attach custom attributes to properties
		// of the Surface class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class SurfaceMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private SurfaceMetadata()
			{
			}
	
			[Display(Name = "Id")]
			//[Required()]
			public System.Int32 SurfaceId{ get; set; }

			[Display(Name = "Име")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "Описание")]
			//[Required()]
			public System.String Description{ get; set; }

        }
    }
}

