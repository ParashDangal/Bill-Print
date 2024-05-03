using Bill_Print.Data;
using Microsoft.AspNetCore.Mvc;
using Bill_Print.Models;
using Bill_Print.Data;
using Bill_Print.Models.Dynamic;

namespace Bill_Print.Controllers
{
    public class ItemNameController : Controller
    {
        private readonly BillPrintDbContext _context;
        public ItemNameController(BillPrintDbContext context)
        {
            _context = context;
        }

       

        public IActionResult Index()
        {
            var ItemNames =_context.ItemNames.ToList();
            return View(ItemNames);
        }
        public IActionResult Create()
        {
            var model= new ItemNameViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ItemNameViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var itemName = new ItemName
                    {
                        Name = model.Name,
                        CreatedDate = model.CreatedDate,
                    };
                     _context.ItemNames.Add(itemName);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred while loading categories: {ex.Message}");
                return StatusCode(500); // Internal Server Error
            }

        }

    }
}
