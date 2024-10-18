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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EmployeeController(ApplicationDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IActionResult Index()
        {
            return View(mapper.Map<IEnumerable<EmployeeIndex>>(context.Employees.ToList()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeFromVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            vm.Description = Regex.Replace(vm.Description, "<.*?>", string.Empty);
            vm.Img = Files.UploadFile(vm.ImgName, "images");
        var service = mapper.Map<Employee>(vm);
            service.StartContract = DateTime.Now;
            context.Add(service);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    
        
        [HttpGet]
        public IActionResult Detials(int id)
        {
            var info = context.Employees.Find(id);
            if (info is null)
            {
              return NotFound();
            }



            return View(mapper.Map<EmployeeFromVM>(info));
        }




      
        public IActionResult Edit(int id)
        {
            var info = context.Employees.Find(id);
            if (info is null)
            {
                return NotFound();
            }

            return View(mapper.Map<EmployeeFromVM>(info));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeFromVM vm)
        {
             var info = context.Employees.Find(vm.Id);
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
           
           

            mapper.Map(vm, info);


           
            context.SaveChanges();
 


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var info = context.Employees.Find(id);
            if (info is null)
            {

                return RedirectToAction(nameof(Index));
            }
        //var bin = mapper.Map<ServiceBin>(info);
        //    bin.DeletedAt = DateTime.Now;
           
        //    context.ServiceBin.Add(bin);
        //    context.SaveChanges();

            Files.DeleteFile(info.Img, "images");

            context.Employees.Remove(info);
            context.SaveChanges();
            return Ok(new {message="service deleted"});
        }
    }
}
