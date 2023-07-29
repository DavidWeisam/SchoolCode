using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    class Sturdent
    {
        private string name;
        private int grade1;
        private int grade2;
        private int grade3;
        

        public Sturdent(string name, int grade1, int grade2, int grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;

        }

        public Sturdent(string name)
        {
            this.name = name;
            this.grade1 = 0;
            this.grade2 = 0;
            this.grade3 = 0;

        }

        public string GetName()
        {
            return this.name;
        }

        public int GetGrade1()
        {
            return this.grade1;
        }

        public int GetGrade2()
        {
            return this.grade2;

        }

        public int GetGrade3()
        {
            return this.grade3;
        }

        // פעולות עדכון
        public void SetGrade1(int grade)
        {
            this.grade1 = grade;
        }

        public void SetGrade2(int grade)
        {
            this.grade2 = grade;
        }

        public void SetGrade3(int grade)
        {
            this.grade3 = grade;
        }

        // מחרוזת המתארת את העצם
        public override string ToString()
        {
            string str = this.name + "(";
            str += this.grade1 + ", ";
            str += this.grade2 + ", ";
            str += this.grade3 + ")";
            return str;

        }


    }




}

