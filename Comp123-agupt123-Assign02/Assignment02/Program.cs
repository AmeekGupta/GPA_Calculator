using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
 * -----ASSIGNMENT 02-----
 * NAME: AMEEK GUPTA
 * STUDENT#: 301170579
 * ----COMP123(SEC.011)---
 */

namespace Assignment02
{
    class Program
    {
        public static StudentRepository _studentRepository;

        static void Main(string[] args)
        {
            _studentRepository = new StudentRepository();

            DisplayMenu(); //Displaying list of students

            string input = "";
            while(input.ToUpper() != "X")
            {
                Console.WriteLine("\nSelect a student number to view their grades and GPA, G to view all students' GPAs, or X to exit. ");
                input = Console.ReadLine().ToUpper();
                if (input.ToUpper() == "X")
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    return;
                }

                else if (IsValidInput(input.ToUpper()))
                {
                    HandleInput(input);
                    Console.WriteLine("\nPress any key to continue, or X to exit.");

                    if (Console.ReadLine().ToUpper() == "X")
                    {
                        Console.WriteLine("Goodbye");
                        Console.ReadKey();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid input! Please try again!");
                }
            }

            Console.ReadKey();
        }
        //METHODS
        public static void HandleInput(string input)
        {
            // student cases go in this method
            List<Student> students = _studentRepository.GetStudents();
            Student student = new Student();
            List<Grade>grades = new List<Grade>();

            if (int.TryParse(input, out int temp))
            {
                student = _studentRepository.GetStudent(input);
                grades = student.Grades;
            }

            switch (input.ToUpper())
            {
                case "1":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "2":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "3":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "4":
                    
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;


                case "5":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "6":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "7":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "8":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "9":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("===========");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); 
                    break;

                case "10":

                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}"); break;
               
                case "G":
                    
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine($"{students[i].FirstName} {students[i].LastName} has a {students[i].GPA:f1} GPA");
                    }
                    break;
            }

        }
        public static bool IsValidInput(string input) // Checks if input is valid
        {
            int numInput;
            if (int.TryParse(input, out numInput))
            {
                if (numInput >= 1 && numInput <= 10)
                {
                    return true;
                }
            }
            else if (input.ToUpper() == "G")
            {
                return true;
            }
            
            return false;
        }
        
        public static void DisplayMenu()
        {
            // To display the list of students in the console
            List<Student> students = _studentRepository.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].FirstName} {students[i].LastName}");
            }
        }
    }
}
