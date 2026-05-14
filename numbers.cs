WorkWithInt();
orderPrecedence();
void WorkWithInt()
{
int a=19;
int b=23;
int sum=a+b;
Console.WriteLine(sum); 

// subtraction
int diff=b-a;
Console.WriteLine(diff);

// multiplication
int multi=a*b;
Console.WriteLine(multi);

}
void orderPrecedence()
{
    int x=4;
    int y=6;
    int z=2;
    int total=(x+y)/z;
    Console.WriteLine(total);
}

int min=int.MinValue;
int max=int.MinValue;
Console.WriteLine($"the minimum value is {min} and the maximum value is {max}");

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);


double maxi = double.MaxValue;
double mini = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");


double radius=2.50;
double pi=Math.PI;
double area=  pi*(radius*radius);
Console.WriteLine(area);