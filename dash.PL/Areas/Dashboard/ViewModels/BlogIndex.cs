using System.ComponentModel.DataAnnotations;

namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class BlogIndex
    {     
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartContract { get; set; }

        public IFormFile ImgName { get; set; }
        public string Img { get; set; }
   
        public int ReadCount { get; set; }

  
        public int CommentCount { get; set; }




    }
}

