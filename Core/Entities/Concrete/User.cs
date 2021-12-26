using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete {
    public class User:IEntity {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
