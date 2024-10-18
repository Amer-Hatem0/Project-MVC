using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dash.DAL.Models
{
    public class Links
    {


        public int Id { get; set; }
        [Url(ErrorMessage = "Invalid Facebook URL format.")]
        public string? Facebook { get; set; }

        [Required(ErrorMessage = "Mobile is required.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Mobile number must be a 10-digit number.")]
        public int Mobile { get; set; }

        [Url(ErrorMessage = "Invalid LinkedIn URL format.")]
        public string? Linkedin { get; set; } 
        [Url(ErrorMessage = "Invalid XApp URL format.")]
        public string? XApp { get; set; }
        [Url(ErrorMessage = "Invalid Instagram URL format.")]
        public string? Instagram { get; set; }

        [Url(ErrorMessage = "Invalid Youtube URL format.")]
        public string? Youtube { get; set; } 
       
        public string? Location { get; set; } 
   
        public string? Email { get; set; }
 

    }
}
