using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MemberAppISP.Abstracts
{
    public interface IDiamond:IPremium
    {
        public void DeletMember(IMember member);
    }
}
