//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendanceManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int Id { get; set; }
        public string Student_USN { get; set; }
        public string Teacher_TID { get; set; }
        public string Subject_SubCode { get; set; }
        public string Slot { get; set; }
        public int IsPresent { get; set; }
        public string Date { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
    }
}
