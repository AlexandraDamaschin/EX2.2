using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2._2.Models
{
    public class Metadata
    {
        public int Id;

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName;

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(25, MinimumLength = 2)]
        public string LastName;

        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        public string Email;
    }

    [MetadataType(typeof(Metadata))]
    public partial class Customer { }
}