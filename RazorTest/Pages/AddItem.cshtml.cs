using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTest.Data;
using RazorTest.Models;
using RazorTest.Utilities;
using System;
using System.IO;
using System.Net;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace RazorTest.Pages
{
    public class AddItemModel : PageModel
    {
        private readonly ArtworkContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly string[] _permittedExtensions = { ".jpg", ".jpeg", ".bmp", ".png" };

        public IFormFile Upload { get; set; }

        public AddItemModel(IWebHostEnvironment environment, ArtworkContext context)
        {
            _environment = environment;
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            //Image
            //var img = FileHelpers.ProcessFormFile<Artwork>(Upload, ModelState, _permittedExtensions);

            //Do other stuff
            Artwork art = new Artwork
            {
                Type = Request.Form["Type"],
                Title = Request.Form["Title"],
                CreateDate = DateTime.Parse(Request.Form["CreateDate"]),
                Description = Request.Form["Description"],
                SrcFile = await GetImage()
            };

            //Save to db
            _context.Artwork.Add(art);
            _context.SaveChanges();
        }

        private async Task<string> GetImage()
        {
            string ret = WebUtility.HtmlEncode(Upload.FileName).Replace(' ', '_');
            var fileName = Path.Combine(_environment.WebRootPath, "art" + Path.DirectorySeparatorChar, ret);
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }

            return ret;
        }
    }
}
