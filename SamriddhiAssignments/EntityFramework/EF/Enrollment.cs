//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public string StudentEnrollmentId { get; set; }
        public int StudentId1 { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}