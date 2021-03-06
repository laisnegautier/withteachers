﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "The course title should not be left empty.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The course description should not be left empty.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Slug { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<CourseDocument> Documents { get; set; } = new List<CourseDocument>() { };
    }
}