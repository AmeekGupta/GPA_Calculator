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
    public class Student
    {
        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public double GPA 
        { 
            get
            {
                return AverageGPA();
            }
        }
        public List<Grade> Grades { get; set; } // This list contains just number grades, so we need letter grades as well with our program
        //METHOD
        private double AverageGPA()
        {

            foreach (Grade grade in Grades) // Converting number grade to letter grade
            {
                grade.LetterGrade = GradeUtils.ToLetterGrade(grade.NumberGrade); 
            }

            double gpa = 0.0;
            foreach (Grade grade2 in Grades) // Converting letter grade to gpa
            {
                gpa += GradeUtils.LetterToGpa(grade2.LetterGrade);
            }

            double avg = gpa / 3; // GPA average

            return avg;
        }
    }
}
