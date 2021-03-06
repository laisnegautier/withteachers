﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WithTeachers.Data
{
    public class CourseDocument
    {
        public int CourseDocumentId { get; set; }

        public int Index { get; set; }

        [Required(ErrorMessage = "The document title should not be left empty.")]
        public string Title { get; set; }

        [DataType(DataType.Url)]
        public string FileUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}