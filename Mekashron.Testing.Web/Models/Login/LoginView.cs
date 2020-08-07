using System.ComponentModel.DataAnnotations;

namespace Mekashron.Testing.Web.Models.Login
{
    public partial class LoginView
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}