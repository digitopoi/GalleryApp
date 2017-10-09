using Microsoft.AspNetCore.Mvc;
using ImageGallery.Models;
using System.Collections.Generic;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://static.pexels.com/photos/596126/pexels-photo-596126.jpeg",
                    Created = System.DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://static.pexels.com/photos/269809/pexels-photo-269809.jpeg",
                    Created = System.DateTime.Now,
                    Tags = hikingImageTags
                },
                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://static.pexels.com/photos/374710/pexels-photo-374710.jpeg",
                    Created = System.DateTime.Now,
                    Tags = cityImageTags
                }
            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };

            return View(model);
        }
    }
}