using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_struct_class
{
    class Student
    { 
        private string Name { set; get; }
        private string Last_name { set; get; }
        private string Surname { set; get; }
        private int Age { set; get; }
        private int S_marks = 6;
        private int[,] PAD_marks;
        private int[] Midl_mark;
        public Student()
        {
            PAD_marks = new int[3, S_marks];
            Midl_mark = new int[3];
           
        }
        public Student(string Name,string Last,string Sur,int Age)
        {
           
            this. Name = Name;
            Last_name = Last;
            Surname = Sur;
            this.Age = Age;
            PAD_marks = new int[3, S_marks];
            Midl_mark = new int[3];
        }
        public void Set_marks(int x)
        {
            //реализовал рандом, но можно сделать под ручной ввод
            Random RND = new Random();
            for(int i=0;i<S_marks;i++)
            {
                RND = new Random();
                PAD_marks[x,i] = RND.Next(-1, 6)+i;
            }
            //ручной ввод
            //for (int i = 0; i < S_marks; i++)
            //{
            //    PAD_marks[x, i] = int.Parse(Console.ReadLine());
            //}
        }
        public float Get_midl_Mark(int x)
        {
            for(int i=0;i<S_marks;i++)
            {
                Midl_mark[x] += PAD_marks[x, i];
            }
            Midl_mark[x] /= S_marks;
            return Midl_mark[x];
        }
        public override string ToString()
        {
            return $"Full Name: {Name} {Last_name} {Surname}\nAge: {Age}\nMidl Marks:\n Prg: {Midl_mark[0]}\nAdm: {Midl_mark[1]}\nDsg: {Midl_mark[2]}";
        }
    }
}
