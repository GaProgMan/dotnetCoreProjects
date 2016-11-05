using HiFive.Models;
using HiFive.Repositories;
using System;
using Microsoft.AspNetCore.Mvc;

namespace HiFive.Controllers
{
    [RouteAttribute("/")]
    public class HiFiveController : Controller
    {
        private IHiFiveRepository _hiFiveContext { get; set; }

        public HiFiveController(IHiFiveRepository repository)
        {
            _hiFiveContext = repository;
        }

        [HttpGet]
        public string Get()
        {
            return "Hey buddy! Hi 5?!";
        }

        [HttpPost]
        public string Post()
        {
            _hiFiveContext.AddOrUpdate(new HiFiveRecord{
                HiFiver = "Anonymous",
                Created = DateTime.Now,
                Modified = DateTime.Now
            });
            return "YEAAAAH WOOOOOH!!!";
        }
    }
}
