using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models.InstagramSampleModels
{
    public class InstagramPicture
    {
        public string id { get; set; }
        public string media_type { get; set; }
        public string media_url { get; set; }
        public string username { get; set; }
        public DateTime timestamp { get; set; }
    }
}
