using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs {
    public class UserForRegisterDto : IDto {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }
}
