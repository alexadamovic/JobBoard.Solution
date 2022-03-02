using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobPost
  {
    public string Title { get; }
    public string Description { get; }
    public string ContactInfo { get; }
    private static List<JobPost> _instances = new List<JobPost> {};
    public JobPost(string title, string description, string contactInfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactInfo;
      _instances.Add(this);
    }

    public static List<JobPost> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}