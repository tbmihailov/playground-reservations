using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies PlaygroundImageMetadata as the class
	// that carries additional metadata for the PlaygroundImage class.
	[MetadataTypeAttribute(typeof(PlaygroundImage.PlaygroundImageMetadata))]
	public partial class PlaygroundImage
	{

		// This class allows you to attach custom attributes to properties
		// of the PlaygroundImage class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class PlaygroundImageMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private PlaygroundImageMetadata()
			{
			}
	
			[Display(Name = "PlaygroundImageId")]
			//[Required()]
			public System.Int32 PlaygroundImageId{ get; set; }

			[Display(Name = "Path")]
			//[Required()]
			public System.String Path{ get; set; }

			[Display(Name = "PlaygroundId")]
			//[Required()]
			public System.Int32 PlaygroundId{ get; set; }

			[Display(Name = "Playground")]
			//[Required()]
			public PlaygroundReservations.Models.Playground Playground{ get; set; }

        }
    }
}

