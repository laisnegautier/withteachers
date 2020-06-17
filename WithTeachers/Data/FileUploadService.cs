﻿using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }

    public class FileUploadService : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment env)
        {
            _environment = env;
        }

        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_environment.ContentRootPath, "wwwroot/uploads", fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
    }
}