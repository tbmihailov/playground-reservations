using System.ComponentModel.DataAnnotations;

namespace PlaygroundReservations.Models
{
	// The MetadataTypeAttribute identifies ReservationMetadata as the class
	// that carries additional metadata for the Reservation class.
	[MetadataTypeAttribute(typeof(Reservation.ReservationMetadata))]
	public partial class Reservation
	{

		// This class allows you to attach custom attributes to properties
		// of the Reservation class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class ReservationMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private ReservationMetadata()
			{
			}
	
			[Display(Name = "ReservationId")]
			//[Required()]
			public System.Int32 ReservationId{ get; set; }

			[Display(Name = "PlaygroundId")]
			//[Required()]
			public System.Int32 PlaygroundId{ get; set; }

			[Display(Name = "Playground")]
			//[Required()]
			public PlaygroundReservations.Models.Playground Playground{ get; set; }

			[Display(Name = "ResrvationDate")]
			//[Required()]
			public System.DateTime ResrvationDate{ get; set; }

			[Display(Name = "Hour")]
			//[Required()]
			public System.Int32 Hour{ get; set; }

			[Display(Name = "CustomerEmail")]
			//[Required()]
			public System.String CustomerEmail{ get; set; }

			[Display(Name = "CustomerName")]
			//[Required()]
			public System.String CustomerName{ get; set; }

			[Display(Name = "CustomerPhone")]
			//[Required()]
			public System.String CustomerPhone{ get; set; }

			[Display(Name = "Created")]
			//[Required()]
			public System.DateTime Created{ get; set; }

			[Display(Name = "IsApprovedByOwner")]
			//[Required()]
			public System.Boolean IsApprovedByOwner{ get; set; }

			[Display(Name = "ReservationTypeId")]
			//[Required()]
			public System.Int32 ReservationTypeId{ get; set; }

			[Display(Name = "ReservationType")]
			//[Required()]
			public PlaygroundReservations.Models.ReservationType ReservationType{ get; set; }

			[Display(Name = "RequestStatusId")]
			//[Required()]
			public System.Int32 RequestStatusId{ get; set; }

			[Display(Name = "RequestStatus")]
			//[Required()]
			public PlaygroundReservations.Models.RequestStatus RequestStatus{ get; set; }

			[Display(Name = "ApprovalStatusId")]
			//[Required()]
			public System.Int32 ApprovalStatusId{ get; set; }

			[Display(Name = "ApprovalStatus")]
			//[Required()]
			public PlaygroundReservations.Models.ApprovalStatus ApprovalStatus{ get; set; }

			[Display(Name = "ReservedById")]
			//[Required()]
			public System.Int32? ReservedById{ get; set; }

			[Display(Name = "ReservedBy")]
			//[Required()]
			public PlaygroundReservations.Models.CustomerProfile ReservedBy{ get; set; }

        }
    }
}

