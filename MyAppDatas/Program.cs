// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

// // var data = new DateTime();
// var data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Day);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.Minute);
// Console.WriteLine(data.Second);

// Console.WriteLine((int)data.DayOfWeek);
// Console.WriteLine((int)data.DayOfYear);

var data = DateTime.Now;
var formato = String.Format("{0}", data);
Console.WriteLine(formato);