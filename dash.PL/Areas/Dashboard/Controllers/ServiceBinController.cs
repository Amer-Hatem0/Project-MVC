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
    public class ServiceBinController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ServiceBinController(ApplicationDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IActionResult Index()
        {
            return View(mapper.Map<IEnumerable<ServiceBinAll>>(context.ServiceBin.ToList()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceFromVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            vm.Description = Regex.Replace(vm.Description, "<.*?>", string.Empty);
            vm.Img = Files.UploadFile(vm.ImgName, "images");
        var service = mapper.Map<Service>(vm);
            context.Add(service);
            context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Detials(int id)
        {
            var info = context.Services.Find(id);
            if (info is null)
            {
              return NotFound();
            }



            return View(mapper.Map<SerAll>(info));
        }




      
        public IActionResult Edit(int id)
        {
            var info = context.Services.Find(id);
            if (info is null)
            {
                return NotFound();
            }

            return View(mapper.Map<SerAll>(info));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SerAll vm)
        {
             var info = context.Services.Find(vm.Id);
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
            var info = context.Services.Find(id);
            if (info is null)
            {

                return RedirectToAction(nameof(Index));
            }

            Files.DeleteFile(info.Img, "images");
           context.Services.Remove(info);
            context.SaveChanges();
            return Ok(new {message="service deleted"});
        }
    }
}
