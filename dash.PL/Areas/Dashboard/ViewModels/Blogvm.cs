using System.ComponentModel.DataAnnotations;

namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class Blogvm
    {     
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartContract { get; set; }

        public IFormFile ImgName { get; set; }
        public string Img { get; set; }
   
        




    }
}

