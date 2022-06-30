using Backend_Template.DAL;
using Backend_Template.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Template.Areas.SenkaAdmin.Controllers
{
    [Area("SenkaAdmin")]
    public class DesignController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public DesignController(AppDbContext context, IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Design> designs = await context.Designs.ToListAsync();
            return View(designs);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> Create(Design design)
        {
            if (!ModelState.IsValid) return NotFound();
            if (design.Image != null)
            {
                context.Add(design);
                await context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Detail")]
        public async Task<IActionResult> Detail(int id)
        {
            Design design = await context.Designs.FirstOrDefaultAsync(s=>s.Id==id);
            return View(design);
        }


        public IActionResult Edit(int id)
        {
            return View();
        }


        public async Task<IActionResult> Delete(int id)
        {
            Design design = await context.Designs.FirstOrDefaultAsync(s=>s.Id==id);
            if (design.Image == null) return NoContent();
            return View(design);
        }
         
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Dlete")]
        public async Task<IActionResult> DeleteSize(int id)
        {
            Design design = await context.Designs.FirstOrDefaultAsync(s => s.Id == id);
            context.Designs.Remove(design);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
