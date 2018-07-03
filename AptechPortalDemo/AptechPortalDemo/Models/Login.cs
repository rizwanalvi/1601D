using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechPortalDemo.Models
{
    public class Login
    {
        public int ID { get; set; }
        public String UNAME { get; set; }
        public String UPASS { get; set; }
        public int ROLEID { get; set; }
    }
}