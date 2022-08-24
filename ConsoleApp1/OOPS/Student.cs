using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Student
    {
        string Name;
        float Percentage;
        string Qualification;
        int Passoutyr;
        
    public void SetNmae(String nm)
        {
            Name = nm;

        }
        public string GetName( )
        {
            return Name;
        }
        public void SetPercentage(float p)
        {
            Percentage = p;
        }
        public float GetPercentage( )
        {
            return Percentage;
        }
        public void SetQualification(string q)
        {
            Qualification = q;
        }
        public  string GetQualification( )
        {
            return Qualification;
        }
        public void SetPassoutyr(int pyr )
        {
            Passoutyr = pyr;
        }
        public int GetPassoutyr( )
        {
            return Passoutyr;
        }



        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Rohini";
            s1.Percentage = 8.3f;
            s1.Qualification = "M.E";
            s1.Passoutyr = 2017;
            Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.GetPercentage());
            Console.WriteLine(s1.GetQualification());
            Console.WriteLine(s1.GetPassoutyr());
        }
        
    }
}
