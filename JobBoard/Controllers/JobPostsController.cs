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
      List<JobPost> allPosts = JobPost.GetAll();
      return View(allPosts);
    }

    [HttpPost("/jobposts")]
    public ActionResult Create(string title, string description, string contactInfo)
    {
      JobPost userPost = new JobPost(title, description, contactInfo);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/jobposts/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/jobposts/{id}")]
    public ActionResult Show(int id)
    {
      return View(JobPost.Find(id));
    }

    [HttpPost("/jobposts/delete")]
    public ActionResult DeleteAll()
    {
      JobPost.ClearAll();
      return View();
    }

  }
}