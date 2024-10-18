using AutoMapper;
using dash.DAL.Data;
using dash.DAL.Models;
using dash.PL.Areas.Dashboard.ViewModels;
using dash.PL.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System;
using System.Text.RegularExpressions;

namespace dash.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public BlogController(ApplicationDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IActionResult Index()
        {
            return View(mapper.Map<IEnumerable<BlogIndex>>(context.Blog.ToList()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blogvm vm)
        {
            

       
            vm.Img = Files.UploadFile(vm.ImgName, "images");
        var service = mapper.Map<Blog>(vm);
            service.StartContract = DateTime.Now;
            context.Blog.Add(service);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    
        
      




      
        public IActionResult Edit(int id)
        {
            var info = context.Blog.Find(id);
            if (info is null)
            {
                return NotFound();
            }

            return View(mapper.Map<Blogvm>(info));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Blogvm vm)
        {
             var info = context.Blog.Find(vm.Id);
            if (info is null)
            {
                return NotFound();
            }
            if (vm.ImgName is null)
            {
                ModelState.Remove("ImgName");
            }
            else
            {
                Files.DeleteFile(info.Img, "images");
                vm.Img = Files.UploadFile(vm.ImgName, "images");
            }


            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            vm.StartContract = DateTime.Now;

            mapper.Map(vm, info);


           
            context.SaveChanges();
 


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var info = context.Blog.Find(id);
            if (info is null)
            {

                return RedirectToAction(nameof(Index));
            }
        //var bin = mapper.Map<ServiceBin>(info);
        //    bin.DeletedAt = DateTime.Now;
           
        //    context.ServiceBin.Add(bin);
        //    context.SaveChanges();

            Files.DeleteFile(info.Img, "images");

            context.Blog.Remove(info);
            context.SaveChanges();
            return Ok(new {message="service deleted"});
        }
    }
}
