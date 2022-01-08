using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;
using System.Threading.Tasks;

namespace Proiect.Pages.Couriers
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public Courier Courier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Courier = await _context.Courier.FirstOrDefaultAsync(m => m.ID == id);

            if (Courier == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
