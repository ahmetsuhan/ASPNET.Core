using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode2
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool SendMail { get; set; }
        public bool SendBill { get; set; }
        public bool PrintReport { get; set; }
    }
}
