using System.ComponentModel.DataAnnotations;

namespace BuilderCompany.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть назву проекту")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Вкажіть локацію")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Додайте опис виконаних робіт")]
        public string Description { get; set; } = string.Empty;

        public int YearCompleted { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}