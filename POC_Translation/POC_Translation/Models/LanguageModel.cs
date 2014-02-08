using System.ComponentModel.DataAnnotations;

namespace POC_Translation.Models
{
    public class LanguageModel
    {
        [Required]
        [Display(Name = "Enter English Word")]
        public string English { get; set; }

        [Display(Name = "Creole Word")]
        public string Creole { get; set; }

    }
}