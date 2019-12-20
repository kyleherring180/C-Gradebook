using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Kyle's grade book");
            book.AddGrade(89.1);
            book.AddGrade(92.4);
            book.AddGrade(63.5);
            book.AddGrade(52.1);
            book.ShowStatistics();
            
        }
    }

}
