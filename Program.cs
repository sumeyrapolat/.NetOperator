// See https://aka.ms/new-console-template for more information


//atama operatörleri

int x = 10;
int y = 30;
y += 2;
y /= 4;
Console.WriteLine(y);
Console.WriteLine(x);

y *= 4;
Console.WriteLine(y);


//mantıksal operatörler 
// && || !

bool isSuccess = false;
bool isFail = false;
bool isError = true;

if(isError && isFail)
{
    Console.WriteLine("Keep trying");
}else if(isError || isFail)
{
    Console.WriteLine("Not working correctly");

}else if (!isSuccess)
{
    Console.WriteLine("not succeed");
}else if (!isFail)
{
    Console.WriteLine("Working Finally");
}

//İlişkisel operatörler


int s = 100;
int p = 1020;

bool val = s < p;
Console.WriteLine(val);

val = s == p;
Console.WriteLine(val);

p = 1;
val = s != p;
Console.WriteLine(val);


//Aritmatik Operatörler
// + - / * %

// % mod alır 
int value = 50 % 3;
Console.WriteLine(value);