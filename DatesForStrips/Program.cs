DateOnly today = DateOnly.FromDateTime(DateTime.Now);
DateOnly plus85 = today.AddDays(85);
DateOnly plus180 = today.AddDays(180);
DateOnly plus365 = today.AddDays(365);
DateOnly plus364 = today.AddDays(364);

string todayString = today.ToString();
string plus85String = plus85.ToString();
string plus180String = plus180.ToString();
string plus364String = plus364.ToString();
string plus365String = plus365.ToString();


Console.WriteLine("Today is " + todayString + ".");
Console.WriteLine();
Console.WriteLine("FREESTYLE LIBRE must expire AFTER: " + plus85String + ".");
Console.WriteLine();
Console.WriteLine("ALL OTHER BOXES:");
Console.WriteLine();
Console.WriteLine("FULL PRICE if expiring AFTER: " + plus365String + "."); 
Console.WriteLine();
Console.WriteLine("HALF PRICE if expiring BETWEEN: " + plus180String + " and " + plus364String + ".");
Console.WriteLine();
Console.WriteLine("This is the date-based pricing.");
Console.WriteLine("This is the MAXIMUM we could pay for MINT CONDITION boxes based on the dates.");
Console.WriteLine("But all boxes must still be graded for condition and adjustments to price should be expected.");

