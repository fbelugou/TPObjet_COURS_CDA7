// See https://aka.ms/new-console-template for more information
using Tp_Article;

Article  A1 = new Article("DD2", "RR2", 10);
Article  A2 = new Article("DD2", "RR2", 10);
Article  A3 = new Article(A1);

Console.WriteLine(A1 == A3);
Console.WriteLine(A1.Equals(A3));