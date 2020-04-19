using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pittig.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Datum bestelling")]
        public DateTime OrderDate { get; set; }

        [Required]
        public double   OrderTotalOriginal { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:00}")]
        [Display(Name ="Totaal bestelling")]
        public double OrderTotal { get; set; }

        [Required]
        [Display(Name = "Tijdstip ophaling")]
        public DateTime PickUpTime { get; set; }

        [Required]
        [NotMapped]
        [Display(Name = "Datum ophaling")]
        public DateTime PickUpDate { get; set; }

       [Display(Name ="Kortingscode")]
        public string CouponCode { get; set; }
        [Display(Name = "Korting")]
        public double CouponCodeDiscount { get; set; }
        public string Status { get; set; }
        [Display(Name = "Status betaling")]
        public string PaymentStatus { get; set; }
        [Display(Name = "Commentaar")]
        public string Comments { get; set; }


        [Display(Name = "Naam ophaler")]
        public string PickupName { get; set; }

        [Display(Name = "TelNr")]
        public string PhoneNumber { get; set; }

        public string TransactionId { get; set; }




    }
}
