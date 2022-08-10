using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WeTransfer.Models;

namespace WeTransfer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Repository.IHomeRepository _dbrepository;
        private Repository.IFileUploadRepository _filerepository;
        ViewModel.VMFileUpload _fileupload;

        public HomeController(ILogger<HomeController> logger, Repository.IHomeRepository repository, Repository.IFileUploadRepository filerepository, ViewModel.VMFileUpload fileupload)
        {
            _logger = logger;
            _dbrepository = repository;
            _filerepository = filerepository;
            _fileupload = fileupload;
        }

        [Route("WeTransfer")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(_fileupload);
        }

        [Route("WeTransfer/Results")]
        [HttpPost]
        public IActionResult Results(ViewModel.VMFileUpload _fileupload)
        {
            if (!ModelState.IsValid)
            {
                _fileupload.ErrorDiv = 1;
            }
            else if (Path.GetExtension(_fileupload.File.FileName) != ".csv")
            {
                _fileupload.ErrorDiv = 2;
            }
            else
            {
                string PathFile = _filerepository.CreateFile(_fileupload);
                IEnumerable<Models.Socios> Lista = _filerepository.ReadFile(PathFile);
                if (Lista != null)
                {
                    _dbrepository.AddSocio(Lista);
                    ViewBag.Total = _dbrepository.GetCantidadSocios();
                    ViewBag.Promedio = _dbrepository.GetPromedioSociosRacing();
                    List<Models.Socios> listTop100 = _dbrepository.GetTop100();
                    ViewBag.Punto3 = listTop100;
                    List<Models.Socios> listTop5 = _dbrepository.GetTop5();
                    ViewBag.Punto4 = listTop5;
                    List<ViewModel.VMSocios> listLastPoint = _dbrepository.GetUltimoPunto();
                    ViewBag.Punto5 = listLastPoint;
                    _fileupload.OkDiv = 1;
                }
                else
                {
                    _fileupload.ErrorDiv = 3;
                }
            }
            return View("Index", _fileupload);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ViewModel.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
