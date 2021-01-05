using DetailingStudio_v2.Models.InstagramSampleModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IConfiguration _configuration;

        public GalleryController(IConfiguration config)
        {
            _configuration = config;
        }
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            var token = _configuration["InstagramToken"];
            InstagramUser user = null;
            HttpResponseMessage response = await client.GetAsync($"https://graph.instagram.com/me?fields=id,username&access_token={token}");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<InstagramUser>();
            }

            InstagramUserData userData = null;
            response = await client.GetAsync($"https://graph.instagram.com/me/media?fields=id,caption&access_token={token}");
            if (response.IsSuccessStatusCode)
            {
                userData = await response.Content.ReadAsAsync<InstagramUserData>();
            }

            List<InstagramPicture> instagramPictures = new List<InstagramPicture>();
            foreach (var data in userData.data)
            {
                response = await client.GetAsync($"https://graph.instagram.com/{data.id}?fields=id,media_type,media_url,username,timestamp&access_token={token}");
                if (response.IsSuccessStatusCode)
                {
                    InstagramPicture instagramPicture = null;
                    instagramPicture = await response.Content.ReadAsAsync<InstagramPicture>();
                    if (instagramPicture != null || instagramPicture.media_type != "IMAGE")
                    {
                        instagramPictures.Add(instagramPicture);
                    }
                }
            }

            return View(instagramPictures);
        }
    }
}
