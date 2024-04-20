using CA_MemberAppISP.Abstracts;
using CA_MemberAppISP.Entities;

namespace CA_MemberAppISP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ISP
--Console uygulaması oluşturun. Bu uygulama içerisinde üyeler ve üyelere ait roller bulunsun.
	--Üye'nin rolü "Basic" ise o üye sadece mail gönderebilsin.
	-Üye'nin rolü "Premium" ise o üye hem mail hem de gorsel yukleyebilsin.
	-Üye'nin rolü "Diamond" ise o üye hem mail gönderebilsin hem görsel yükleyebilsin hem de "farklı bir üyeyi silsin"
             
             
             */
            Member member = new Member();
            member.ID = 1;
            member.FirstName = "Oğuz";
            member.LastName = "Kork";

           
            BasicMember bm = new BasicMember();
            bm.ID = 2;
            bm.FirstName = "İrem";
            bm.LastName = "Kork";
            bm.SendMail(member,bm);


            PremiumMember pm = new PremiumMember();
            pm.ID = 3;
            pm.FirstName = "Aslan";
            pm.LastName = "Şahin";
            pm.SendMail(member,pm);
            pm.SendPic(member);


            DiamaondMember dm = new DiamaondMember();
            dm.ID = 4;
            dm.FirstName = "Lina";
            dm.LastName = "Şahin";
            dm.SendMail(member,dm);
            dm.SendPic(member);
            dm.DeletMember(member);


            Console.Read();
        }
    }
}
