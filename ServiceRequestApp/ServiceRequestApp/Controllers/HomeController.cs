using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeServiceApp.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using HomeServiceApp.Common;
using System.Globalization;
using System.Net.Http.Headers;

namespace HomeServiceApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult UserInfo()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult UserUpload()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public class FileInputModel
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public IFormFile image1 { get; set; }
        }
        public class FileInputModelresult
        {
            
            public byte[] PdfData { get; set; }
            public string  FileName { get; set; }
            public int Id { get; set; }
            public string Email { get; set; }

        }


        public async Task<FileInputModelresult> GetbytedataData(FileInputModel files)
        {
            FileInputModelresult newretun = new FileInputModelresult();
            byte[] PdfData = null;

            using (var memoryStream = new MemoryStream())
            {
                await files.image1.CopyToAsync(memoryStream);
                PdfData = memoryStream.ToArray();

            }
            newretun.PdfData = PdfData;
            newretun.FileName = files.image1.FileName;

            return newretun;
        }
        [HttpPost]
        public JsonResult GetSecuredData(FileInputModel files)
        {
            FileInputModelresult newretun = new FileInputModelresult();
           dynamic data = GetbytedataData(files);
         
            newretun.PdfData = data.Result.PdfData;
            newretun.FileName = files.image1.FileName;
            newretun.Id = files.Id;
            newretun.Email = files.Email;

            return Json(newretun);
        }

      
    }
}
