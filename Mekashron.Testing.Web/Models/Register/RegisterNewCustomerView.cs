using System.ComponentModel.DataAnnotations;

namespace Mekashron.Testing.Web.Models.Register
{
    public class RegisterNewCustomerView
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Mobile { get; set; }
    }
}