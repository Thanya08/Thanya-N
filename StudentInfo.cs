﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    //User Defined Data Type
    class StudentInfo
    {
        //State - private
        private string id;
        private string name;
        private int marks;
        
        //behaviors
        public string GetId()
        {
            return this.id;
        }
        public string GetName() { return this.name; }
        public int GetMarks() { return this.marks; }

        public void SetId(string value) { this.id = value; }
        public void SetName(string value) { this.name = value; }
        public void SetMarks(int value) { this.marks = value; }


    }
}
