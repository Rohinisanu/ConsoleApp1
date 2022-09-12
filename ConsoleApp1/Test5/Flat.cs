using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class Flat
    {
        int flatno;
        string wingname;
        Member member;
        public Flat()
        {

        }
        public Flat(int flatno, string wingname, Member member1)
        {
            this.flatno = flatno;
            this.wingname = wingname;
            this.member1 = member1;

        }
        public int Flatno
        {
            set { flatno = value; }
            get { return flatno; }
        }
        public string Wingname
        {
            set { wingname = value; }
            get { return wingname; }
        }
        public Member member1
        {
            set { member = value; }
            get { return member; }
        }
    }
    class Member
    {
        int memberid;
        string membername;
        string profession;
        int age;
       public Member()
        {
            

        }
        public Member(int memberid,string membername,string profession,int age)
        {
            this.memberid = memberid;
            this.membername = membername;
            this.profession = profession;
            this.age = age;
        }
        public int Memberid
        {
            set { memberid = value; }
            get { return memberid; }
        }
        public string Membername
        {
            set { membername = value; }
            get { return membername; }
        }
        public string Profession
        {
            set { profession = value; }
            get { return profession; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        static void Main(string[] args)
        {
            Flat f = new Flat(1001,"A Wing",new Member(02,"Gite","Service",31));
            Flat f1 = new Flat(1004, "A Wing", new Member(05, "Darade", "Army", 29));
            Console.WriteLine(f.Flatno);
            Console.WriteLine(f.Wingname);
            Console.WriteLine(f.member1.Memberid);
            Console.WriteLine(f.member1.Membername);
            Console.WriteLine(f.member1.Profession);
            Console.WriteLine(f.member1.Age);
            Console.WriteLine(f1.Flatno);
            Console.WriteLine(f.Wingname);
            Console.WriteLine(f.member1.Memberid);
            Console.WriteLine(f.member1.Membername);
            Console.WriteLine(f.member1.Profession);
            Console.WriteLine(f.member1.Age);
            


        }
    }
    
            

}

