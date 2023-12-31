﻿// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using THTDotNetCore.ConsoleApp.AdoDotNetExamples;
using THTDotNetCore.ConsoleApp.DapperExamples;
using THTDotNetCore.ConsoleApp.EFCoreExamples;
using THTDotNetCore.ConsoleApp.HttpClientExamples;
using THTDotNetCore.ConsoleApp.RefitExamples;
using THTDotNetCore.ConsoleApp.RestClientExamples;

Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = "."; //server name
//sqlConnectionStringBuilder.InitialCatalog = "THARGYI"; //dbname
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "thargyi";

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
//{
//    DataSource = ".",
//    InitialCatalog = "THARGYI",
//    UserID = "sa",
//    Password = "thargyi"
//};

//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

//connection.Open();

//string query = @"
//    SELECT [BlogId]
//          ,[BlogTitle]
//          ,[BlogAuthor]
//          ,[BlogContent]
//      FROM [dbo].[Tbl_Blog]
//    ";

//SqlCommand command = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();

////DataSet can access multiple tables)
////DataTable
////DataRow
////DataColumn

////DataSet->DataTable->DataRow->DataColumn

//foreach(DataRow dr in dt.Rows)
//{
//    Console.WriteLine($"Id => {dr["BlogId"]}");
//    Console.WriteLine($"Title => {dr["BlogTitle"]}");
//    Console.WriteLine($"Author => {dr["BlogAuthor"]}");
//    Console.WriteLine($"Content => {dr["BlogContent"]}");

//    Console.WriteLine("------------------");
//}

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();

//DapperExample dapperDotNetExample = new DapperExample();
//dapperDotNetExample.Run();

//EFCoreExample efCoreExample = new EFCoreExample();
//efCoreExample.Run();

//HttpClientExample httpClientExample = new HttpClientExample();
//await httpClientExample.Run();

//RestClientExample example = new RestClientExample();
//await example.Run();

Console.WriteLine("Please wait for api...");
Console.ReadKey();

RefitExample example = new RefitExample();
await example.Run();

Console.ReadKey();

