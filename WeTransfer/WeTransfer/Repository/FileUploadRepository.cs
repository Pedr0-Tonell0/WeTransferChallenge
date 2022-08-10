using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using TinyCsvParser;
using WeTransfer.ViewModel;

namespace WeTransfer.Repository
{
    public class FileUploadRepository:IFileUploadRepository
    {
        private IWebHostEnvironment _environment;
        public FileUploadRepository(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public string CreateFile(VMFileUpload File)
        {
            string FileSave = "";
            string path = Path.Combine(_environment.WebRootPath, "uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = Path.GetFileName(File.File.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                File.File.CopyTo(stream);
                FileSave = Path.Combine(path, fileName);
            }
            return FileSave;
        }

        public IEnumerable<Models.Socios> ReadFile(string PathFile)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(false, ';');
            var csvParser = new CsvParser<Models.Socios>(csvParserOptions, new DTO.SocioMapper());
            var records = csvParser.ReadFromFile(PathFile, Encoding.UTF8);
            return records.Select(x => x.Result).ToList();
        }
    }
}
