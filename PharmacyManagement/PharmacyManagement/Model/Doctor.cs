using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Model
{
    public class Doctor
    {
        [Key]
        [Column(TypeName = "varchar(25)")]
        public string DoctorId { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required(ErrorMessage = "Please enter a valid Name")]
        public string DoctorName { get; set; }


        [Column(TypeName = "varchar(25)")]
        [Required(ErrorMessage = "Please enter a valid number")]
        public string Contact { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Please enter a valid Address")]
        public string Address { get; set; }


        [Required]
        [Column(TypeName = "varchar(35)")]
        [MinLength(7, ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }

        [Required]
        [Column(TypeName = "varchar(225)")]
        public string Password { get; set; }


    }
}
