using AutoMapper;
using dash.DAL.Data;
using dash.PL.Areas.Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dash.PL.Controllers
{
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PagesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        
        public IActionResult Index()
        {
            
            DashboardViewModel mymodel = new DashboardViewModel();
            mymodel.Services = context.Services;
            mymodel.Blogs = context.Blog;
            mymodel.Links = context.Links;
            mymodel.EmployeeFromVM = mapper.Map<IEnumerable<EmployeeFromVM>>(context.Employees.ToList());
            return View(mymodel);
        }
 

        public IActionResult About() {
            DashboardViewModel mymodel = new DashboardViewModel();
            mymodel.Services = context.Services;
            mymodel.Blogs = context.Blog;
            mymodel.Links = context.Links;
            mymodel.EmployeeFromVM = mapper.Map<IEnumerable<EmployeeFromVM>>(context.Employees.ToList());
            return View(mymodel);
        }
        public IActionResult Contact() {
            DashboardViewModel mymodel = new DashboardViewModel();
            mymodel.Services = context.Services;
            mymodel.Blogs = context.Blog;
            mymodel.Links = context.Links;
            mymodel.EmployeeFromVM = mapper.Map<IEnumerable<EmployeeFromVM>>(context.Employees.ToList());
            return View(mymodel);
        }
        public IActionResult Blog() {
            DashboardViewModel mymodel = new DashboardViewModel();
            mymodel.Services = context.Services;
            mymodel.Blogs = context.Blog;
            mymodel.Links = context.Links;
            mymodel.EmployeeFromVM = mapper.Map<IEnumerable<EmployeeFromVM>>(context.Employees.ToList());
            return View(mymodel);
        }

        public IActionResult Details(int id)
        {
            var info = context.Services.Find(id);
            if (info is null)
            {
                return NotFound();
            }



            return View(mapper.Map<SerAll>(info));
        }
        public IActionResult Team()
        {
            DashboardViewModel mymodel = new DashboardViewModel();
            mymodel.Services = context.Services;
            mymodel.Blogs = context.Blog;
            mymodel.Links = context.Links;
            mymodel.EmployeeFromVM = mapper.Map<IEnumerable<EmployeeFromVM>>(context.Employees.ToList());
            return View(mymodel);
        } 
        public IActionResult Service() { return View(mapper.Map<IEnumerable<SerVM>>(context.Services.ToList())); }

        [HttpPost]
        public IActionResult IncreaseReadCount(int id)
        {
            var blog = context.Blog.Find(id);  
            if (blog != null)
            {
                blog.ReadCount++;
                context.SaveChanges();
                return Json(new { newReadCount = blog.ReadCount });  
            }

            return NotFound();
        }



    }
}
