using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rental_Application.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }
        public bool IsSubscribed { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}