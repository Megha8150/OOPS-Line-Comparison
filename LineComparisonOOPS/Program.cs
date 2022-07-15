// See https://aka.ms/new-console-template for more information
using LineComparisonOOPS;
//LineComparison.lineComparison();

LineComparison line1 = new LineComparison();
LineComparison line2 = new LineComparison();
Double length1 = line1.length();
Console.WriteLine("Enter Values for line2");
Double length2 = line2.length();
Console.WriteLine("Length of line 1 is " +length1);
Console.WriteLine("Length of line 2 is " +length2);

if(length1.Equals(length2))
{
    Console.WriteLine("lines are equal");
}
else if (length1.CompareTo(length2) < 0)
{
    Console.WriteLine("Line 2 is greater");
}
else 
{
    Console.WriteLine("Line 1 is greater");
}