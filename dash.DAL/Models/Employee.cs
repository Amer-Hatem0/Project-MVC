using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dash.DAL.Models
{
    public class Employee
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Url(ErrorMessage = "Invalid Facebook URL format.")]
        public string? Facebook { get; set; }

        [Required(ErrorMessage = "Mobile is required.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Mobile number must be a 10-digit number.")]
        public int Mobile { get; set; }

        [Url(ErrorMessage = "Invalid LinkedIn URL format.")]
        public string? Linkedin { get; set; }

        [Required(ErrorMessage = "Start contract date is required.")]
        public DateTime StartContract { get; set; }

        public DateTime? EndContract { get; set; }

        public string Img { get; set; }

    }
}
