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
      JobPost myJobPost = new JobPost();
      Assert.AreEqual(typeof(JobPost), myJobPost.GetType());
    }
  }
}