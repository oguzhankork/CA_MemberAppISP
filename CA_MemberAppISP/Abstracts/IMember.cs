using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MemberAppISP.Abstracts
{
    public interface IMember
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }     
    }
}
