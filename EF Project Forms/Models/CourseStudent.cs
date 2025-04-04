﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Project_Forms.Models;

[PrimaryKey("CourseID", "StudentID")]
[Index("StudentID", Name = "IX_CourseStudents_StudentID")]
public partial class CourseStudent
{
    [Key]
    public int CourseID { get; set; }

    [Key]
    public int StudentID { get; set; }

    [ForeignKey("CourseID")]
    [InverseProperty("CourseStudents")]
    public virtual Course Course { get; set; }

    [ForeignKey("StudentID")]
    [InverseProperty("CourseStudents")]
    public virtual Student Student { get; set; }
}