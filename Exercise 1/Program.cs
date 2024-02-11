// centimeters to inches conversion
Console.WriteLine("Please enter the amount of centimeters to convert: ");
string str  = Console.ReadLine();
 
if (str.Length == 0)
{
	Console.WriteLine("Nothing was entered ");
}
else
{
	int centimeters = Convert.ToInt32(str);
	double  multiplication = centimeters * 2.54;
	Console.WriteLine("the result in inches is  " + multiplication);
}

