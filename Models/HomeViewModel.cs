using System.Collections.Generic;

namespace BuilderCompany.Models
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; } = new List<Service>();
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}