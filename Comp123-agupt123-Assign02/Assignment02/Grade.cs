using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

/*
 * -----ASSIGNMENT 02-----
 * NAME: AMEEK GUPTA
 * STUDENT#: 301170579
 * ----COMP123(SEC.011)---
 */

namespace Assignment02
{
    public class Grade
    {
        //PROPERTIES
        public string CourseTitle { get; set; }
        public string LetterGrade { get; set; }
        public double NumberGrade { get; set; }
    }
}
