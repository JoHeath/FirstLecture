﻿//create a variable called x and give it a value of 5
int age = 5;string name = "Justin";string name2 = "Ethan";






 * validate the number variable * do something if validated */
if (age == 1){}

//declaring variables
int money;
//intialize variable
money = 5;
//combined
bool hungry = true;

//constant
const double taxRate = 0.06;
// taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate);
//mini code problem
Console.WriteLine("Please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value =  double.Parse(Console.ReadLine());
double area = Math.PI * value * value;
Console.WriteLine(area);

//increment
age++;
age--;
//odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if (oddCheck == 0)
{
    Console.WriteLine("even");
}
else if(oddCheck == 1)
    {
        Console.WriteLine("odd");
    }
//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);
//null
string catName = null;
Console.WriteLine(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;
if (y == null)
{
    y = "ghfh";
}
//nonnullable
//int z = null;

//exercises

//1
Console.WriteLine("What is your favorite color?");
string favoriteColor = Console.ReadLine();
Console.WriteLine(favoriteColor);

//2
Console.WriteLine("Please enter an number");
int userInput = int.Parse(Console.ReadLine());
userInput++;
Console.WriteLine(userInput);

//3
Console.WriteLine("Enter a number");
double userNum = double.Parse(Console.ReadLine());
userNum += .5;
Console.WriteLine(userNum);

//4
Console.WriteLine("Enter a number");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(x + y);

//5
Console.WriteLine("Enter a number");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(a * b);



