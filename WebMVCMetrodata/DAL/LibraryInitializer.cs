using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebMVCMetrodata.Models;

namespace WebMVCMetrodata.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var students = new List<Student>
            {
                new Student{StudentID=101,FullName="Paijo",StudentGender="Male", ClassLevel="Intermediate",BirthDate=DateTime.Parse("2000-09-01")},
                new Student{StudentID=202,FullName="Laras",StudentGender="Female", ClassLevel="Basic",BirthDate=DateTime.Parse("1997-19-01")},
                new Student{StudentID=303,FullName="Janita",StudentGender="Female", ClassLevel="Upper",BirthDate=DateTime.Parse("2001-12-01")},
                new Student{StudentID=404,FullName="Rani",StudentGender="Female", ClassLevel="Novice",BirthDate=DateTime.Parse("1998-01-01")},
                new Student{StudentID=505,FullName="Paimin",StudentGender="Male", ClassLevel="Intermediate",BirthDate=DateTime.Parse("2001-01-01")},
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book{BookID=100,Title="Blue Mountain",Author="Dewangga",Published=DateTime.Parse("1995-12-01")},
                new Book{BookID=200,Title="Sanctuary",Author="Rojashok",Published=DateTime.Parse("2001-01-01")},
                new Book{BookID=300,Title="Northic Chemistry",Author="Parmichinkov",Published=DateTime.Parse("2007-11-01")},
                new Book{BookID=400,Title="Fall of Babylon",Author="Doruvanya",Published=DateTime.Parse("2014-12-01")},
                new Book{BookID=500,Title="Star Kitchen",Author="Hannivah",Published=DateTime.Parse("2018-12-01")},
                new Book{BookID=600,Title="How to Basic",Author="Rumenza",Published=DateTime.Parse("2002-12-01")},
                new Book{BookID=700,Title="The Crusaders",Author="Giovanna",Published=DateTime.Parse("2015-05-25")},
                new Book{BookID=800,Title="Coding as A Playing",Author="Shubam",Published=DateTime.Parse("2016-07-21")},
                new Book{BookID=900,Title="Cinta Datuk",Author="Noer Noel",Published=DateTime.Parse("1994-12-01")},
                new Book{BookID=1000,Title="Deep Insight",Author="Mireskha",Published=DateTime.Parse("2015-01-01")},
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var inventories = new List<Inventory>
            {
                new Inventory{LendingID=110,BookID=100, StudentID=101, LendDate=DateTime.Parse("2015-12-18"), ReturnDate=DateTime.Parse("2015-12-20")},
                new Inventory{LendingID=120,BookID=200, StudentID=202, LendDate=DateTime.Parse("2015-11-28"), ReturnDate=DateTime.Parse("2015-11-30")},
                new Inventory{LendingID=130,BookID=300, StudentID=101, LendDate=DateTime.Parse("2015-09-29"), ReturnDate=DateTime.Parse("2015-10-01")},
                new Inventory{LendingID=140,BookID=400, StudentID=404, LendDate=DateTime.Parse("2015-10-29"), ReturnDate=DateTime.Parse("2015-11-01")},
                new Inventory{LendingID=150,BookID=500, StudentID=505, LendDate=DateTime.Parse("2015-08-29"), ReturnDate=DateTime.Parse("2015-09-01")},
            };
            inventories.ForEach(s => context.Inventories.Add(s));
            context.SaveChanges();
        }
    }
}