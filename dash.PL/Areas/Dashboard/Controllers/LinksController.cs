using AutoMapper;
using dash.DAL.Data;
using dash.DAL.Models;
using dash.PL.Areas.Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dash.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class LinksController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public LinksController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var links = context.Links.FirstOrDefault();
            if (links == null)
            {
                links = new Links();
                context.Links.Add(links);
                context.SaveChanges();
            }

            var linksViewModel = mapper.Map<UpdatedLink>(links);
            return View(linksViewModel);
        }



     

     


    
        public IActionResult Edit(int id)
        {
            var link = context.Links.Find(id);
            if (link is null)
            {
                return NotFound();
            }

            var updatedLink = mapper.Map<UpdatedLink>(link);
            return View(updatedLink);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UpdatedLink vm)
        {
            var info = context.Links.Find(vm.Id);
            if (info == null)
            {
                return NotFound();
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
            var info = context.Links.Find(id);
            if (info == null)
            {
                return RedirectToAction(nameof(Index));
            }
 
            context.Links.Remove(info);
            context.SaveChanges();
            return Ok(new { message = "service deleted" });
        }
    }
}
