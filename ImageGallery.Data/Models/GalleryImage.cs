using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Data.Models
{
    public class GalleryImage
    {
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
