using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PickUpDate { get; set; }
        public bool IsSuspended { get; set; }
        public string? SusStartDate { get; set; }
        public string? SusEndDate { get; set; }
        public string? OneTimePickUpDay { get; set; }
        public int NumOfPickups { get; set; }
        public double AmountSpentOnTrash { get; set; }
        public bool PickedUp { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
