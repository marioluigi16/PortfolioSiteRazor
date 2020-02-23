using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTest.Data;
using RazorTest.Models;

namespace RazorTest.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ArtworkContext _context;
        public Artwork ArtItem { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }


        public DetailModel(ArtworkContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            ArtItem = _context.Artwork.Single(x => x.ID == ID);
        }

        public string GetDate()
        {
            string ret = "";

            if (ArtItem.CreateDate.Month > 1)
                ret = ArtItem.CreateDate.Month + "/";

            ret += ArtItem.CreateDate.Year;

            return ret;
        }

        public string GetSrcFilePath()
        {
            return "/art/" + ArtItem.SrcFile;
        }
    }
}
