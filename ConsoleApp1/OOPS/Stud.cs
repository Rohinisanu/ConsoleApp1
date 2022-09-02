using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Stud
    {
        string studname;
        int passoutyear;
        Batch b;
        public Stud()
        {

        }
    
    public Stud(string studname, int passoutyear, Batch b)
    {
        this.studname = studname;
        this.passoutyear = passoutyear;
        this.B = b;
    }
    public string Studname
    {
        set { studname = value; }
        get { return studname; }
    }
    public int Passoutyear
    {
        set { passoutyear = value; }
        get { return passoutyear; }
    }
    public Batch B
    {
        set { b = value; }
        get { return b; }
    }
}
class Batch
{
    string batchname;
    string technology;
    Trainer t;
    public Batch()
    {

    }
    public Batch(string batchname, string technology, Trainer t)
    {
        this.batchname = batchname;
        this.technology = technology;
        this.t = t;
    }
    public string Batchname
    {
        set { batchname = value; }
        get { return batchname; }
    }
    public string Technology
    {
        set { technology = value; }
        get { return technology; }
    }
    public Trainer T
    {
        set { t = value; }
        get { return t; }
    }
}
class Trainer
{
    string tname;
    int experience;
    string qualification;
    public Trainer()
    {

    }
    public Trainer(string tname,int experience,string qualification)
    {
        this.tname = tname;
        this.experience = experience;
        this.qualification = qualification;
    }
    public string Tname
    {
        set { tname = value; }
        get { return tname; }
    }
    public int Experience
    {
        set { experience = value; }
        get { return experience; }
    }
    public string Qualification
    {
        set { qualification = value; }
        get { return qualification ; }
    }
    static void Main(string[] args)
    {
        Trainer t1 = new Trainer();
        t1.Tname = "Deepa mam";
        t1.Experience = 15;
        t1.Qualification = "BE";
        Batch B1 = new Batch();
        B1.Batchname = "Wipro";
        B1.Technology = "C#";
        B1.T = t1;
        Stud s1 = new Stud();
        s1.Studname = "Rohini";
        s1.Passoutyear = 2017;
        s1.B =  new Batch();


 

        
    }
   
}
}


