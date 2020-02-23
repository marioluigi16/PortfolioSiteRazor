using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorTest.Data;
using RazorTest.Models;

namespace RazorTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ArtworkContext _context;

        public List<Artwork> LstDigiArt { get; set; }
        public List<Artwork> LstTradArt { get; set; }

        public IndexModel(ArtworkContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            LstDigiArt = _context.Artwork.Where(x => x.Type == "Digital").ToList();
            LstTradArt = _context.Artwork.Where(x => x.Type == "Traditional").ToList();
            System.Diagnostics.Debug.Print("Blah");
        }


    }
}
