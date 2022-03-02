using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobPostTests
  {
    [TestMethod]
    public void JobPostConstructor_CreatesInstanceOfJobPost_JobPost()
    {
      JobPost myJobPost = new JobPost("title");
      Assert.AreEqual(typeof(JobPost), myJobPost.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Junior Developer";
      JobPost newPost = new JobPost(title);
      string result = newPost.Title;
      Assert.AreEqual(title, result);
    }
  }
}