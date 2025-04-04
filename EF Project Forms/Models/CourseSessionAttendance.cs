﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Project_Forms.Models;

[Index("CourseSessionId", Name = "IX_CourseSessionAttendances_CourseSessionId")]
[Index("StudentID", Name = "IX_CourseSessionAttendances_StudentID")]
public partial class CourseSessionAttendance
{
    [Key]
    public int Id { get; set; }

    public int? CourseSessionId { get; set; }

    public int? StudentID { get; set; }

    public int? Grade { get; set; }

    public string Notes { get; set; }

    [ForeignKey("CourseSessionId")]
    [InverseProperty("CourseSessionAttendances")]
    public virtual CourseSession CourseSession { get; set; }

    [ForeignKey("StudentID")]
    [InverseProperty("CourseSessionAttendances")]
    public virtual Student Student { get; set; }
}