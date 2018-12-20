using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SMP.Models;

namespace SMP.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly SMP.Models.SMPContext _context;

        public IndexModel(SMP.Models.SMPContext context)
        {
            _context = context;
        }

        // Sorting
        public string DateSort { get; set; }
        public string TopicSort { get; set; }

        public IList<Meeting> Meeting { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            TopicSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            

            IQueryable<Meeting> studentIQ = from s in _context.Meeting
                                            select s;

            switch (sortOrder)
            {
                case "name_desc":
                    studentIQ = studentIQ.OrderByDescending(s => s.Topic);
                    break;
                case "Date":
                    studentIQ = studentIQ.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    studentIQ = studentIQ.OrderByDescending(s => s.Date);
                    break;
                default:
                    studentIQ = studentIQ.OrderBy(s => s.Topic);
                    break;
            }

            Meeting = await studentIQ.AsNoTracking().ToListAsync();
        }
    }
}
