using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebProjectHackathon.Models
{
    public class Users
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string fullName { get; set; } = string.Empty;
        public string login { get; set; } = string.Empty;
        public string gmail { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

    }
}
