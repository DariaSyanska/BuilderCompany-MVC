using System.ComponentModel.DataAnnotations;

namespace BuilderCompany.Models
{
    public class Service
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Назва послуги обов'язкова")]
        public string Title { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
        
        public string IconClass { get; set; } = string.Empty;
    }
}