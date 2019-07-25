﻿using Microsoft.AspNetCore.Mvc;

namespace MeowvBlog.Web.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class TagsController : Controller
    {
        [Route("/tags")]
        public IActionResult Index() => View();

        [Route("/tag/{name}")]
        public IActionResult Tag() => View();
    }
}