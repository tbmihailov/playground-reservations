using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies OwnerProfileMetadata as the class
	// that carries additional metadata for the OwnerProfile class.
	[MetadataTypeAttribute(typeof(OwnerProfile.OwnerProfileMetadata))]
	public partial class OwnerProfile
	{

		// This class allows you to attach custom attributes to properties
		// of the OwnerProfile class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class OwnerProfileMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private OwnerProfileMetadata()
			{
			}
	
			[Display(Name = "����� ���������� �� ������")]
			//[Required()]
			public System.Int32 OwnerProfileId{ get; set; }

            [Display(Name = "�����")]
			//[Required()]
			public System.String Email{ get; set; }

            [Display(Name = "���")]
			//[Required()]
			public System.String Name{ get; set; }

			[Display(Name = "�����")]
			//[Required()]
			public System.String Address{ get; set; }

			[Display(Name = "�����")]
			//[Required()]
			public System.String Number{ get; set; }

			[Display(Name = "��� �� �����������")]
			//[Required()]
			public System.String LiablePersonName{ get; set; }

            [Display(Name = "�������")]
			//[Required()]
			public System.String Notes{ get; set; }

            [Display(Name = "��������� �����")]
			//[Required()]
			public System.String Phone{ get; set; }

			[Display(Name = "�������� ��������")]
			//[Required()]
			public System.String WebSite{ get; set; }

			[Display(Name = "������� ���������")]
			//[Required()]
			public System.Collections.Generic.IEnumerable<PlaygroundReservations.Models.SportComplex> SportComplexes{ get; set; }

        }
    }
}

