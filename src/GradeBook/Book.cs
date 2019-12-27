using System;
using System.Collections.Generic;

namespace GradeBook{
    public class Book {
        //declaring and initializing grades as a field
        List<double> grades;
        public string Name;

        //explicit constructor (initializes field)
        //must have same name as class
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
            
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
                
            }
            result.Average /= grades.Count;
            
            return result;
        }

        
    }
}