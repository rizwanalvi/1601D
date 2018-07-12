using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGridViewEx01.Models
{
    public class Student
    {
        public int StdID { get; set; }
        public String StdName { get; set; }
        public int BatchNo { get; set; }
        public String TimeSlot { get; set; }
        public bool IsAttended { get; set; }

       
        public List<Student> getStudents() {
            List<Student> _lst  = new List<Student>();

            _lst.Add(new Student() { StdID = 1001,StdName= "Ahmed Khan",BatchNo = 1601,TimeSlot="F",IsAttended=true});
            _lst.Add(new Student() { StdID = 1002, StdName = "Kamran Khan", BatchNo = 1601, TimeSlot = "F",IsAttended=true });
            _lst.Add(new Student() { StdID = 1003, StdName = "Rehan Khan", BatchNo = 1601, TimeSlot = "F" ,IsAttended = true });
            _lst.Add(new Student() { StdID = 1004, StdName = "Zaman Khan", BatchNo = 1601, TimeSlot = "F",IsAttended=false });
            _lst.Add(new Student() { StdID = 1005, StdName = "Suffyan Khan", BatchNo = 1601, TimeSlot = "F",IsAttended=false });
            return _lst;
        }
    }
}