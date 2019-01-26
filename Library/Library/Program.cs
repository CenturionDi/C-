using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("Library");
            DataTable readersTable = new DataTable("readers");
            DataColumn readerIdColumn = new DataColumn("id");
            readerIdColumn.DataType = typeof(int);
            readerIdColumn.Unique = true;
            readerIdColumn.AllowDBNull = false;
            readerIdColumn.AutoIncrement = true;
            readerIdColumn.AutoIncrementSeed = 1;
            readerIdColumn.AutoIncrementStep = 1;
            readersTable.Columns.Add(readerIdColumn);

            DataColumn readerFullNameColumn = new DataColumn("fullName");
            readerFullNameColumn.DataType = typeof(string);
            readersTable.Columns.Add(readerFullNameColumn);

            DataColumn readerBirthDateColumn = new DataColumn("Birthdate");
            readerBirthDateColumn.DataType = typeof(DateTime);
            readersTable.Columns.Add(readerBirthDateColumn);

            DataColumn readerPhoneColumn = new DataColumn("phone");
            readerPhoneColumn.DataType = typeof(string);
            readersTable.Columns.Add(readerPhoneColumn);

            dataSet.Tables.Add(readersTable);


            
            DataTable bookTable = new DataTable("books");

            DataColumn bookIdColumn = new DataColumn("id");
            bookIdColumn.DataType = typeof(int);
            bookIdColumn.Unique = true;
            bookIdColumn.AllowDBNull = false;
            bookIdColumn.AutoIncrement = true;
            bookIdColumn.AutoIncrementSeed = 1;
            bookIdColumn.AutoIncrementStep = 1;
            
            DataColumn bookTitleColumn = new DataColumn("name");
            bookTitleColumn.DataType = typeof(string);
            bookTable.Columns.Add(bookTitleColumn);


            DataColumn bookDescriptionColumn = new DataColumn("description");
            bookDescriptionColumn.DataType = typeof(string);
            bookTable.Columns.Add(bookDescriptionColumn);

            DataColumn bookAuthorColumn = new DataColumn("author");
            bookAuthorColumn.DataType = typeof(string);
            bookTable.Columns.Add(bookAuthorColumn);

            dataSet.Tables.Add(bookTable);



            DataTable loanTable = new DataTable("loans");

            DataColumn loanIdColumn = new DataColumn("id");
            loanIdColumn.DataType = typeof(int);
            loanIdColumn.Unique = true;
            loanIdColumn.AllowDBNull = false;
            loanIdColumn.AutoIncrement = true;
            loanIdColumn.AutoIncrementSeed = 1;
            loanIdColumn.AutoIncrementStep = 1;
            loanTable.Columns.Add(loanIdColumn);




            DataColumn loanBookIdColumn = new DataColumn("bookId");
            loanBookIdColumn.DataType = typeof(int);
            loanTable.Columns.Add(loanBookIdColumn);

            DataColumn loanReaderIdColumn = new DataColumn("readerId");
            loanReaderIdColumn.DataType = typeof(int);
            loanTable.Columns.Add(loanReaderIdColumn);

            DataColumn loanDatestampColumn = new DataColumn("takenDate");
            loanDatestampColumn.DataType = typeof(DateTime);
            loanTable.Columns.Add(loanDatestampColumn);
            
            dataSet.Tables.Add(loanTable);




            DataRelation firstDataRelation = new DataRelation("users_people_fk", "readers", "loans", new string[] { "id" }, new string[] { "readerId" }, false);
            DataRelation secondDataRelation = new DataRelation("users_people_fk", "books", "loans", new string[] { "id" }, new string[] { "bookId" }, false);

            dataSet.Relations.Add(firstDataRelation);
            dataSet.Relations.Add(secondDataRelation);


        }
    }
}
