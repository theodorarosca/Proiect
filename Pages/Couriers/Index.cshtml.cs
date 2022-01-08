using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proiect.Pages.Couriers
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Courier> Courier { get; set; }

        public async Task OnGetAsync()
        {
            Courier = await _context.Courier.ToListAsync();
        }
    }
}
