using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Models
{
    public class Student
    {
        public int StdID { get; set; }
        public String StdName { get; set; }
        public int BatchNo { get; set; }
        public String TimeSlot { get; set; }
        public bool IsAttended { get; set; }
        private List<Student> _lst = null;

        public List<Student> getAllStudents() {
             _lst = new List<Student>();
            _lst.Add(new Student() {StdID=1001,StdName= "Ahmed Khan",BatchNo= 1609,TimeSlot="D",IsAttended = true });
            _lst.Add(new Student() { StdID = 1002, StdName = "Ahmed Khan", BatchNo = 1609, TimeSlot = "D", IsAttended = false});
            _lst.Add(new Student() { StdID = 1003, StdName = "Hamza Khan", BatchNo = 1609, TimeSlot = "D", IsAttended = true });
            _lst.Add(new Student() { StdID = 1004, StdName = "Salman Khan", BatchNo = 1609, TimeSlot = "D", IsAttended = false });
            _lst.Add(new Student() { StdID = 1005, StdName = "Noman Khan", BatchNo = 1609, TimeSlot = "D", IsAttended = true });

            return _lst;
        }
    }
}