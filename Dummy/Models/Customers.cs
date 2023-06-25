using System.ComponentModel.DataAnnotations;

namespace Dummy.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscriberToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "MemberShip Types")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}
