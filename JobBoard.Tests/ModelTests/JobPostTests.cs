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
      JobPost myJobPost = new JobPost("title", "description", "contactInfo");
      Assert.AreEqual(typeof(JobPost), myJobPost.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Junior Developer";
      string description = "This is the first job you will have in tech";
      string contactInfo = "(800)-678-5309";
      JobPost newPost = new JobPost(title, description, contactInfo);
      string result = newPost.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Junior Developer";
      string description = "This is the first job you will have in tech";
      string contactInfo = "(800)-678-5309";
      JobPost newPost = new JobPost(title, description, contactInfo);
      string result = newPost.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetContactInfo_ReturnsContactInfo_String()
    {
      string title = "Junior Developer";
      string description = "This is the first job you will have in tech";
      string contactInfo = "(800)-678-5309";
      JobPost newPost = new JobPost(title, description, contactInfo);
      string result = newPost.ContactInfo;
      Assert.AreEqual(contactInfo, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_JobPostList()
    {
      List<JobPost> myList = new List<JobPost> {};
      List<JobPost> result = JobPost.GetAll();
      CollectionAssert.AreEqual(myList, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsAllJobPostings_JobPost()
    // {
    //   JobPost myJobPost1 = new JobPost("title1", "description1", "contactInfo1");
    //   JobPost myJobPost2 = new JobPost("title2", "description2", "contactInfo2");
    //   JobPost myJobPost3 = new JobPost("title3", "description3", "contactInfo3");
    //   List<JobPost> myList = new List<JobPost> {};
    //   Assert.AreEqual();
    // }
    
  }
}