using EFCoreSession1.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01 What is EF Core
            // EF Core is ORM Tool in Dotnet
            // ORM: Object Relational Mapper -> Link between App and Database


            // 1. Mapping
            //   1.1. Code First: Generate Table Per each Class
            //   1.2. DB First: Generate Class Per each Table
            // 2. L2E (LINQ To Entity): CRUD 


            #endregion


            #region 02 Ways Of Generation (TPC, TPH, TPCC)

            // To Generate the Schema

            // 1. TPC: Table Per Class

            // 2. TPH: Table Per Hierarchy

            // 3. TPCC: Table Per Concert Class


            #endregion


            #region 03 EF Core Vs Dapper Vs ADO.NET

            // ADO.NET is a database access technology that is part of the .NET Framework. It provides a set of classes and interfaces that allow .NET applications to interact with databases. ADO.NET has been around for a long time and is widely used in .NET applications. ADO.NET is a low-level tool, which means that it provides fine-grained control over database operations.

            // Entity Framework Core (EF Core) is a high-level ORM (Object-Relational Mapping) tool that allows .NET applications to interact with databases. It provides a set of classes and APIs that abstract the database operations, making it easier for developers to work with databases. EF Core is built on top of ADO.NET, which means it uses ADO.NET internally to interact with databases.

            // EF Core supports several database providers, including SQL Server, MySQL, SQLite, and PostgreSQL. It provides several features, such as automatic schema migration, query translation, and change tracking. EF Core also supports LINQ, which allows developers to write queries in C# instead of SQL.

            // Dapper is a micro ORM that was developed by the StackOverflow team. It provides a lightweight and fast way to work with databases. Dapper is built on top of ADO.NET and provides a simple API for database operations. Dapper is designed to be fast and efficient, which means that it doesn't have some of the features provided by EF Core.

            // Dapper is ideal for scenarios where performance is critical and developers want fine - grained control over the database operations.Dapper is also easy to learn and use, providing a small set of APIs covering most of the database operations.

            #endregion


            #region 04 Ways Of Mapping (By Convension)

            // in class Employee

            #endregion


            #region 05 Ways Of Mapping (By Data Annotation)

            // in class Employee

            #endregion


            #region 06 DbContext & Installing Required Packages

            AppDbContext context = new AppDbContext(); // DbContext -> Link between App and Database

            #endregion


            #region 07 Our First Migration & Installing Required Packages

            // Migration : To Effected in DB

            // Ways to create Migration:
            //  A. Package Manager Console
            // 06 -> 3:30 -->
            //   1. Download Package -> From (Manage NuGet Packages)
            //   2. View -> Package Manager Console
            //   3. PM> Add-Migration "InitialCreate". -> To undo this action, use Remove-Migration.
            // 4. PM> Update-Database -> To undo this action, use Drop-Database.
            // If Any Change in Model -> Repeat Step 3,4

            // To Delete Migration:
            // PM> Update-Database "LastDatabase"
            // PM> Remove-Migration

            // if not found last database
            // PM> Update-Database 0
            // PM> Remove-Migration


            //context.Employees.Where(E => E.EmpId == 0);


            ////context.Database.Migrate(); // To Apply Migration [Alternative of Update-Database Command]



            #endregion


            #region 08 Ways Of Mapping (By FluentApi - By Configuration Class)



            #endregion


            #region 09 EF Core Summary



            #endregion


        }
    }
}
