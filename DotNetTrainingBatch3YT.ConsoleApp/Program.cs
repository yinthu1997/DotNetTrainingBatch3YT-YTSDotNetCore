﻿// See https://aka.ms/new-console-template for more information
using DotNetTrainingBatch3YT.ConsoleApp.AdoDotNetExamples;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = ".";
//sqlConnectionStringBuilder.InitialCatalog = "TestDb";
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "sa@123";

//Console.WriteLine("ConnectionString => " + sqlConnectionStringBuilder.ConnectionString);

//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

//Console.WriteLine("Connection Opening..");
//connection.Open();
//Console.WriteLine("Connection Opened..");

//string query = @"SELECT [BlogId]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//  FROM [dbo].[Tbl_Blog]";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);

//Console.WriteLine("Connection Closing..");
//connection.Close();
//Console.WriteLine("Connection Closed..");

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Title.." + dr["BlogTitle"]);
//    Console.WriteLine("Author.." + dr["BlogAuthor"]);
//    Console.WriteLine("Content.." + dr["BlogContent"]);
//}

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();

//adoDotNetExample.Edit(1);
//adoDotNetExample.Edit(11);

//adoDotNetExample.Create("test title", "test author", "test content");

adoDotNetExample.Update(11, "test title 2", "test author 2", "test content 2");

adoDotNetExample.Delete(11);

Console.ReadKey();
