using dash.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace dash.PL.Areas.Dashboard.ViewModels
{
    public class DashboardViewModel
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<EmployeeFromVM> EmployeeFromVM { get; set; }
        public IEnumerable<Links> Links { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}


