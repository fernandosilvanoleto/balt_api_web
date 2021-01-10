using System.ComponentModel.DataAnnotations;

namespace balt_api_web.Models
{
    public class User
    {
        [Key]
        public int Id { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter 3 e 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter 3 e 20 caracteres")]
        public string Username { get; set; }     

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter 3 e 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter 3 e 20 caracteres")]
        public string Password { get; set; }    

        public string Role { get; set; }
    }
}