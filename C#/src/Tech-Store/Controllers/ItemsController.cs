using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tech_Store.Data;
using Tech_Store.Models;

namespace Tech_Store.Controllers;

public class ItemsController(TechStoreContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var item = await _context.Items.ToListAsync();
        return View(item);
    }
}

