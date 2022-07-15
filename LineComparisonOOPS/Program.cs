// See https://aka.ms/new-console-template for more information
using LineComparisonOOPS;
//LineComparison.lineComparison();

LineComparison line1 = new LineComparison();
LineComparison line2 = new LineComparison();

double length1 = line1.length();
double length2 = line2.length();
Console.WriteLine("Length of line 1 is " +length1);
Console.WriteLine("Length of line 2 is " +length2);