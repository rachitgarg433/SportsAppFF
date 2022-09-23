using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SportsApp.Models
{
    [Table(name: "BookingDetails")]
    public class BookingDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }


        [Required]
        [Display(Name = "Select Product")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(BookingDetail.ProductId))] //mapping foreign key
        public Product Product { get; set; }

        [Required]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "Select Quantity")]

        public int Quantity { get; set; }

       
        [Display(Name = "Enter Your Mobile Number")]
        [Required(ErrorMessage = "{0} cannot be empty!!!")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter only 10 digits!!!")]
        public string MoibileNumber { get; set; }



        [Required]
        [Display(Name = "Enter Delivery Address")]
        public string UserAddress { get; set; }
    }
}
