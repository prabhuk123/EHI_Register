using Microsoft.AspNetCore.Http;
using System;

namespace ServiceRequestModels.api.Models
{
    public class Upload
    {
        public byte[] PdfData { get; set; }
        public string FileName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        //public IFormFile image1 { get; set; }

    }
}
