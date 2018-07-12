using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppEx01.Models
{
    public class Student
    {
        private List<Student> _lst = null;
        public Student()
        {
            _lst = new List<Student>();
        }
        [Key]
        public int ID { get; set; }
        public String StdName { get; set; }
        public String TimeSlot { get; set; }
        public int BatchID { get; set; }
        public bool Attended { get; set; }

            public List<Student> getAllStudents() {
            _lst.Add(new Student { ID=1001,StdName="Ahmed Khan",TimeSlot= "D",BatchID =1601,Attended=true});
            _lst.Add(new Student { ID = 1002, StdName = "Kamran Khan", TimeSlot = "D", BatchID = 1602, Attended = true });
            _lst.Add(new Student { ID = 1003, StdName = "Salman Khan", TimeSlot = "D", BatchID = 1602, Attended = true });
            _lst.Add(new Student { ID = 1004, StdName = "Rehan Khan", TimeSlot = "D", BatchID = 1602, Attended = false });
            return _lst;
        }


        public DataTable getAllStudentsTable()
        {
            _lst.Add(new Student { ID = 1001, StdName = "Ahmed Khan", TimeSlot = "D", BatchID = 1601, Attended = true });
            _lst.Add(new Student { ID = 1002, StdName = "Kamran Khan", TimeSlot = "D", BatchID = 1602, Attended = true });
            _lst.Add(new Student { ID = 1003, StdName = "Salman Khan", TimeSlot = "D", BatchID = 1602, Attended = true });
            _lst.Add(new Student { ID = 1004, StdName = "Rehan Khan", TimeSlot = "D", BatchID = 1602, Attended = false });
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID"), new DataColumn("ID"), new DataColumn("ID"), new DataColumn("ID") });
            return dt;
        }

    }
}