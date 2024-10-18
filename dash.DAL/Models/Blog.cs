using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dash.DAL.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must not exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Start contract date is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime StartContract { get; set; }

        [Required(ErrorMessage = "Image is required")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Invalid image URL format")]
         public string Img { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Read count must be a non-negative number")]
        public int ReadCount { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Comment count must be a non-negative number")]
        public int CommentCount { get; set; }
    }
}
