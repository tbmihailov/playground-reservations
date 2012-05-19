using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int PlaygroundId { get; set; }
        public virtual Playground Playground { get; set; }

        public DateTime ResrvationDate { get; set; }
        public int Hour { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public DateTime Created { get; set; }

        //public string CustomerEditUrl { get; set; }
        //public string CustomerRejectUrl { get; set; }
        //public string CustomerDetailsUrl { get; set; }

        public bool IsApprovedByOwner { get; set; }

        public int ReservationTypeId { get; set; }
        [NotMapped]
        public ReservationType ReservationType
        {
            get
            {
                return (ReservationType)ReservationTypeId;
            }
            set
            {
                ReservationTypeId = (int)value;
            }
        }

        public int PaymentTypeId { get; set; }
        [NotMapped]
        public PaymentType PaymentType
        {
            get
            {
                return (PaymentType)PaymentTypeId;
            }
            set
            {
                PaymentTypeId = (int)value;
            }
        }

        public int RequestStatusId { get; set; }
        [NotMapped]
        public RequestStatus RequestStatus
        {
            get
            {
                return (RequestStatus)RequestStatusId;
            }
            set
            {
                RequestStatusId = (int)value;
            }
        }

        public int ApprovalStatusId { get; set; }
        [NotMapped]
        public ApprovalStatus ApprovalStatus
        {
            get
            {
                return (ApprovalStatus)ApprovalStatusId;
            }
            set
            {
                ApprovalStatusId = (int)value;
            }
        }

        public int? ReservedById { get; set; }
        public virtual CustomerProfile  ReservedBy { get; set; }

    }
}