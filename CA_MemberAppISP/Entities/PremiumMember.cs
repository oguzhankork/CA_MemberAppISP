using CA_MemberAppISP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MemberAppISP.Entities
{
    public class PremiumMember : IPremium
    {
        public int ID { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public void SendMail(IMember member, IMember member2)
        {
            Console.WriteLine($"{member.FirstName} isimli kullanıcıya {member2.FirstName} mail gönderiliyor..");
        }

        public void SendPic(IMember member)
        {
            Console.WriteLine($"{member.FirstName} isimli kullanıcıya resim gönderiliyor..");
        }
    }
}
