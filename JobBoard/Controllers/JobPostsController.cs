using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobPostsController : Controller
  {
    [HttpGet("/jobposts")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/jobposts/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}