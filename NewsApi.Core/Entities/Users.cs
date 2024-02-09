using NewsApi.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NewsApi.Core.Entities
{
    public class Users : IEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int RolesId { get; set; }

    }
}
