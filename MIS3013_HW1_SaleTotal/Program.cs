// MIS 3013 HW1
// sales total

string outMesStr = "What is the name of the product you are purchasing? ";
Console.Write(outMesStr);
string productNameStr = Console.ReadLine();

outMesStr = string.Format($"How many {productNameStr}'s do you want to buy? ");
Console.Write(outMesStr);
string quanStr = Console.ReadLine();
double quanDbl = Convert.ToDouble(quanStr);

outMesStr = string.Format($"What is the price of {productNameStr}? ");
Console.Write(outMesStr);
string priceStr = Console.ReadLine();
double priceDbl = Convert.ToDouble(priceStr);

double subtotalDbl = quanDbl * priceDbl;

double taxRateDbl = 8.5 / 100;

double salesTaxDbl = subtotalDbl * taxRateDbl;

double totalDbl = subtotalDbl + salesTaxDbl;

outMesStr = string.Format($"\tYour subtotal for the bill is {subtotalDbl:C2}");
Console.WriteLine(outMesStr);

outMesStr = string.Format($"Your sales tax is {salesTaxDbl:C2}");
Console.WriteLine(outMesStr);

outMesStr = string.Format($"\tYour total for your bill is {totalDbl:C2}");
Console.WriteLine(outMesStr);

