
using AddDate_NoLibrary.Business;
using System.Globalization;

Console.WriteLine("Enter a date(dd/MM/yyyy)");
string? date = Console.ReadLine();
if (!string.IsNullOrEmpty(date))
{
    DateTime inputDate;
    if (DateTime.TryParse(date, out inputDate))
    {
        inputDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        int year = inputDate.Year;
        int month = inputDate.Month;
        int day = inputDate.Day;

        Console.WriteLine("Enter a days to Add:");
        string? numOfDays = Console.ReadLine();
        if (!string.IsNullOrEmpty(date))
        {
            int days = int.Parse(numOfDays);
            DateOnly result = DateManipulation.AddDays(day, month, year, days);
            Console.WriteLine($"New Date :  {result}");
        }
        else
        {
            Console.WriteLine("Please Enter the Number of Days!");
        }
    }
    else
    {
        Console.WriteLine("Please Enter a valid date!");
    }
}
else
{
    Console.WriteLine("Please Enter a valid date!");
}
