using System.ComponentModel.DataAnnotations;

namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class EmployeeFromVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImgName { get; set; } 
        public string? Img { get; set; }
        public DateTime StartContract { get; set; }
        public DateTime? EndContract { get; set; }









        public string? Facebook { get; set; }

      
        public int Mobile { get; set; }


        public string? Linkedin { get; set; }








    }
}

