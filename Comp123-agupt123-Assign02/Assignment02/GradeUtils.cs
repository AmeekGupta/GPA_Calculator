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
    public static class GradeUtils
    {
        // METHODS
        public static string GpaToLetter(double gpaToLetter)
        {
            //convert gpa to letter
            string letterGrade = "";
            
            if (gpaToLetter == 4.5)
            {
                letterGrade = "A+";
            }
            else if (gpaToLetter >= 4.0 && gpaToLetter <= 4.4)
            {
                letterGrade = "A";
            }
            else if (gpaToLetter >= 3.5 && gpaToLetter <= 3.9)
            {
                letterGrade = "B+";
            }
            else if (gpaToLetter >= 3.0 && gpaToLetter <= 3.4)
            {
                letterGrade = "B";
            }
            else if (gpaToLetter >= 2.5 && gpaToLetter <= 2.9)
            {
                letterGrade = "C+";
            }
            else if (gpaToLetter >= 2.0 && gpaToLetter <= 2.4)
            {
                letterGrade = "C";
            }
            else if (gpaToLetter >= 1.5 && gpaToLetter <= 1.9)
            {
                letterGrade = "D+";
            }
            else if (gpaToLetter >= 1.0 && gpaToLetter <= 1.4)
            {
                letterGrade = "D";
            }
            else if (gpaToLetter >= 0.0 && gpaToLetter <= 0.9)
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
        public static double LetterToGpa(string letterToGpa)
        {
            //convert letter grade to gpa

            double gpa = 0.0;

            if (letterToGpa.ToUpper() == "A+")
            {
                gpa = 4.5;
            }
            else if (letterToGpa.ToUpper() == "A")
            {
                gpa = 4.0;
            }
            else if (letterToGpa.ToUpper() == "B+")
            {
                gpa = 3.5;
            }
            else if (letterToGpa.ToUpper() == "B")
            {
                gpa = 3.0;
            }
            else if (letterToGpa.ToUpper() == "C+")
            {
                gpa = 2.5;
            }
            else if (letterToGpa.ToUpper() == "C")
            {
                gpa = 2.0;
            }
            else if (letterToGpa.ToUpper() == "D+")
            {
                gpa = 1.5;
            }
            else if (letterToGpa.ToUpper() == "D")
            {
                gpa = 1.0;
            }
            else if (letterToGpa.ToUpper() == "F")
            {
                gpa = 0.0;
            }

            return gpa;
        }
        public static string ToLetterGrade(double toLetterGrade)
        {
            // take the number grade and convert to letter grade
           
            string letterGrade = "";

            if (toLetterGrade >= 90 && toLetterGrade <= 100)
            {
                 letterGrade = "A+";
            }
            else if (toLetterGrade >= 80 && toLetterGrade <= 89)
            {
                letterGrade = "A";
            }
            else if (toLetterGrade >= 75 && toLetterGrade <= 79)
            {
                letterGrade = "B+";
            }
            else if (toLetterGrade >= 70 && toLetterGrade <= 74) 
            {
                letterGrade = "B";
            }
            else if (toLetterGrade >= 65 && toLetterGrade <= 69) 
            {
                letterGrade = "C+";
            }
            else if (toLetterGrade >= 60 && toLetterGrade <= 64) 
            {
                letterGrade = "C";
            }
            else if (toLetterGrade >= 55 && toLetterGrade <= 59) 
            {
                letterGrade = "D+";
            }
            else if (toLetterGrade >= 50 && toLetterGrade <= 54) 
            {
                letterGrade = "D";
            }
            else if (toLetterGrade >= 0 && toLetterGrade <= 49) 
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}
