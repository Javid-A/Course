int[] arr = { 1, 2, 3, 4, 5 };//0xyha203

int num = 5;

int num2 = num;

num = 10;

int[] arr2 = arr;//0xyha203

arr2[0] = 10;

// foreach (var item in arr)
// {
//     Console.WriteLine(item);
// }


object arr3 = arr.Clone();

int[] arr4 = arr3 as int[];


arr[0] = 100;


((int[])arr3)[0] = 333;

foreach (var item in arr4)
{
    Console.WriteLine(item);
}


System.Console.WriteLine("Hello World!, {0}, {1}", num, num2);
System.Console.WriteLine($"Hello World!, {num}, {num2}");


string price = string.Format("{0:C}", 12312312.45);

string date = string.Format("{0:Y}", DateTime.Now);

System.Console.WriteLine(date);


if (string.IsNullOrWhiteSpace(""))
{
    System.Console.WriteLine("Empty");
}
else
{
    System.Console.WriteLine("Not Empty");
}

string hello = "Hello World! How are you?";

string[] arr5 = hello.Split('!');
foreach (var item in arr5)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine(string.Join(",", arr));