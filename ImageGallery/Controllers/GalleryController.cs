using Microsoft.AspNetCore.Mvc;
using ImageGallery.Models;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel()
            {

            };

            return View(model);
        }
    }
}