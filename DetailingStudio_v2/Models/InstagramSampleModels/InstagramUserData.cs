using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models.InstagramSampleModels
{
    public class Datum
    {
        public string id { get; set; }
    }

    public class Cursors
    {
        public string before { get; set; }
        public string after { get; set; }
    }

    public class Paging
    {
        public Cursors cursors { get; set; }
    }

    public class InstagramUserData
    {
        public List<Datum> data { get; set; }
        public Paging paging { get; set; }
    }
}
