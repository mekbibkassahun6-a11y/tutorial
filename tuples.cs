var pt=(x:1,y:2);
var slope=(double)pt.x/(double)pt.y;
Console.WriteLine($"something {pt} is going to be {slope}");
pt.x=pt.x+5;
Console.WriteLine($" the new pt value is {pt.x}");
var pt2=pt with{y=10};
Console.WriteLine(pt2);
var subscript=(a:0,b:0);
subscript=pt;
Console.WriteLine(subscript);
var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
Console.WriteLine($"the day starts with{namedData.Temp} and it is known as {person.FirstName} as well as {order.Product}");

//types
public record Point(int x,int y);
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");