using System.ComponentModel.DataAnnotations;

namespace logicaPokedex.Models
{
    public class User
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
