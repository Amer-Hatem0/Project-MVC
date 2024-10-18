using AutoMapper;
using dash.DAL.Data;
using dash.DAL.Models;
using dash.PL.Areas.Dashboard.ViewModels;
using dash.PL.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System;
using System.Text.RegularExpressions;
using System.Transactions;


namespace dash.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ServiceController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ServiceController(ApplicationDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IActionResult Index()
        {
            return View(mapper.Map<IEnumerable<SerVM>>(context.Services.ToList()));
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

        
            vm.Img = Files.UploadFile(vm.ImgName, "images");
        var service = mapper.Map<Service>(vm);
            service.CreateAt = DateTime.Now;
            context.Add(service);


            var servicez = mapper.Map<ServiceBin>(vm);
            context.ServiceBin.Add(servicez);


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
        [ValidateAntiForgeryToken]
        public IActionResult Deletebin(int id)
        {
            var info = context.Services.Find(id);

            if (info == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var binData = mapper.Map<ServiceBin>(info);
            context.ServiceBin.Add(binData);
 
            context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }
            [HttpPost]
        public IActionResult Delete(int id)
        {
            var info = context.Services.Find(id);

            if (info == null)
            {
                return RedirectToAction(nameof(Index));
            }

         

            Files.DeleteFile(info.Img, "images");  

            context.Services.Remove(info);   
            context.SaveChanges();  

            return Ok(new { message = "service deleted" });
        }

 

        [HttpPost]
    public IActionResult Delete1(int id)
    {
        using (var transaction = new TransactionScope())
        {
            try
            {
                // البحث عن السجل في الجدول Service
                var info = context.Services.Find(id);

                // التحقق من وجود السجل
                if (info == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                // نقل البيانات إلى الجدول ServiceBin
                var binData = mapper.Map<ServiceBin>(info);
                context.ServiceBin.Add(binData);  // إضافة السجل إلى ServiceBin

                // حذف الصورة إذا كانت موجودة
                Files.DeleteFile(info.Img, "images");

                // حذف السجل من الجدول Service
                context.Services.Remove(info);

                // حفظ التغييرات في قاعدة البيانات
                context.SaveChanges();

                // إكمال المعاملة
                transaction.Complete();

                return Ok(new { message = "Service moved to bin and deleted from Service." });
            }
            catch (Exception ex)
            {
                // إذا حدث خطأ، يتم إلغاء المعاملة هنا
                return BadRequest(new { message = "Error occurred while deleting the service.", error = ex.Message });
            }
        }
    }




    //  [HttpPost]
    //  public IActionResult DeleteBin(int id)
    //  {
    //      var info = context.Services.Find(id);
    //      if (info is null)
    //      {

    //          return RedirectToAction(nameof(Index));
    //      }




    //context.ServiceBin.Add(new ServiceBin
    //     {
    //         Id = info.Id,
    //         Name = info.Name,
    //         Description = info.Description,
    //         Img = info.Img,
    //         DeletedAt = DateTime.Now   // Mark as deleted or move to bin logic
    //     });





    //      context.SaveChanges();
    //      return Ok(new { message = "service deleted" });


    //  }

    //[HttpPost]

    //public IActionResult DeleteBin(int id)
    //{
    //    var info = context.Services.Find(id);
    //    if (info == null)
    //    {
    //        return NotFound(new { message = "Service not found." });
    //    }

    //    // Move service to the bin (you can customize this part)
    //    context.ServiceBin.Add(new ServiceBin
    //    {
    //        Id = info.Id,
    //        Name = info.Name,
    //        Description = info.Description,
    //        Img = info.Img,
    //        DeletedAt = DateTime.Now   // Mark as deleted or move to bin logic
    //    });

    //    context.Services.Remove(info);
    //    context.SaveChanges();

    //    return Ok(new { message = "Service moved to bin." });
    //}



    //[HttpPost]
    //public IActionResult DeleteBin(int id)
    //{
    //    var info = context.Services.Find(id);
    //    if (info is null)
    //    {

    //        return RedirectToAction(nameof(Index));
    //    }


    //    context.ServiceBin.Add(new ServiceBin
    //    {
    //        Id = info.Id,
    //        Name = info.Name,
    //        Description = info.Description,
    //        Img = info.Img,
    //        DeletedAt = DateTime.Now   // Mark as deleted or move to bin logic
    //    });



    //    Files.DeleteFile(info.Img, "images");

    //    context.Services.Remove(info);
    //    context.SaveChanges();
    //    return Ok(new { message = "service deleted" });


    //}


}
}
