using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Emails
    {

        public int Id {  get; set; }
        public string? Email { get; set; }

        public Emails () { }
        public Emails(string? email)
        {
            Email = email;
        }


    }
}
