namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class Serbin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImgName { get; set; }
        public string? Img { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
