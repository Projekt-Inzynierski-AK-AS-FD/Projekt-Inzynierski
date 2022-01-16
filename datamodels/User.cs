using Abituria.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abituria.datamodels
{
    public class User : DomainObject
    {
        //public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatedJoined { get; set; }
    }
}