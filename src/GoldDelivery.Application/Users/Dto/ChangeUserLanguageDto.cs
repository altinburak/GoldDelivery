using System.ComponentModel.DataAnnotations;

namespace GoldDelivery.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}