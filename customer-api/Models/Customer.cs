using System;
using Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{

    [Table("customer")]
    public class Customer : BaseEntity
    {
        [Required(ErrorMessage = "Date created is required")]
        public Guid AccountId { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "FirstName  is required")]
        public String FirstName { get; set; }

         [Required(ErrorMessage = "LastName is required")]
        public String LastName { get; set; }
    }
}