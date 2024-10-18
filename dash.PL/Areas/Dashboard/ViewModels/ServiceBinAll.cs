namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class ServiceBinAll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImgName { get; set; }
        public string? Img { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
