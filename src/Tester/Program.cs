// See https://aka.ms/new-console-template for more information
using DocAnalyzer.Common;

Console.WriteLine("Hello, World!");
var file = new FileInfo(@"C:\Users\vshevchenko\Desktop\DocAnalyzer\docs\doc1.xlsx");
ExcelWorker worker = new ExcelWorker(file);
worker.ReadCurriculum();
Console.WriteLine("");
Console.ReadKey();