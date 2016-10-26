###Question 1:

> What does the following C# code output? Briefly describe what this code is doing.
> ```csharp
int[] myCollection = {3, 6, 9};
int acc = 0;
foreach(int el in myCollection)
{
	acc += el;
}
Console.WriteLine(acc);
```


This section of code creates a shrot array and sums up all of the elemets, then prints out the sum. It prints out '18' and a new line charachter when executed

---
###Question 2:

> What does the following C# code output? What is the main concept being demonstrated here?
> ```csharp
> int i = 3, j = 2;
> double x = 3, y = 2;

> var a = i / j;
> var b = x / y;

> Console.WriteLine("{0} {1}", a, b);
> ```


The code outputs "1 1.5" ; demonstrating how division is handled between integers with truncation vs how division is handled between floating point numbers with a closest approximation available. In this case there are no rounding errors in the floating point calculation.

---
###Question 3:

> What does the following C# code output? What is special about the Foo() method and what are the consequences of that?
> ```csharp
int Foo(int input)
{
	if (input < 2)
		return 0;
	
	return input + Foo(input - 2);
}

void Main()
{
	Console.WriteLine(Foo(8));
}
```


The code outputs 20, summing up the numbers multiples of 2 less than 8 until it reaches something less than 2; in this case 0. The Foo() method is unique in that it uses recursion, calling itself from within the method body. This can be dangerous to use liberally, as it is in this case, because this will cause unnecessary memory usage by the program and slow down execution. Especially so when the function can be made flat, as is very likely here.

---
###Question 4:

> Write a function that sorts an array of integers


```csharp
public int[] SortArray(int[] input)
{
    if (input == null)
        return null;

    /*using coctail sort because the example given was small that a simple sort will be most efficient and avoid a need to instantiate any new data structures
    */
    
    int top = input.Length - 1, bottom = 0;

    while (top > bottom)
    {
        for (int i = bottom; i < top; i++)
        {
            if (input[i+1] < input[i])
            {
                swap(i+1, i, input);
            }
        }
        top -= 1;
        for (int i = top - 1; i >= bottom; i--)
        {
            if (input[i + 1] < input[i])
            {
                swap(i + 1, i, input);
            }
        }
        bottom += 1;
    }

    return input;
}
```

[Code](./CentairSolutions/Question4.cs)
[Tests](./CentairSolutionsTests/Question4Tests.cs)


---
###Question 5:

> Write a function that returns only the digits 0-9 contained in a string

```csharp
public string GetDigits(string input)
{
    if (input == null)
        return null;
    var digits = new StringBuilder();

    foreach (var chr in input)
    {
        if (chr >= '0' && chr <= '9')
        {
            digits.Append(chr);
        }
    }
    return digits.ToString();
}
```
[Code](./CentairSolutions/Question5.cs)
[Tests](./CentairSolutionsTests/Question5Tests.cs)

---
###Question 6:

> Write a function that takes an array of Widget and outputs the number of widgets created on each day of the week (Monday, Tuesday, etc.).

```csharp
//outputting results as a dictionary, because the question did not specify output format
public Dictionary<DayOfWeek, int> CountByDayOfWeek(Widget[] input)
{
    if (input == null)
    {
        return null;
    }

    var result = new Dictionary<DayOfWeek, int>();
    result[DayOfWeek.Monday] = 0;
    result[DayOfWeek.Tuesday] = 0;
    result[DayOfWeek.Wednesday] = 0;
    result[DayOfWeek.Thursday] = 0;
    result[DayOfWeek.Friday] = 0;
    result[DayOfWeek.Saturday] = 0;
    result[DayOfWeek.Sunday] = 0;

    foreach (var widget in input)
    {
        result[widget.CreatedDate.DayOfWeek] += 1;
    }

    return result;
}
```
[Code](./CentairSolutions/Question6.cs)
[Tests](./CentairSolutionsTests/Question6Tests.cs)

---
###Question 7:

> What does the following JavaScript code output? Write a sentence or two explaining why this is.
> ```javascript
var i = 0, j = "0";
console.log(i == j);
console.log(i === j);
```

The code outputs "true false" . This is because the first check will attempt to cast both i and j into compatable types, and then check for equality. in this case i would get cast into a string, "0", making it equal to j. In the second check, type casting is disabled and the code checks for both the same type and the same data.

---
###Question 8:

> Write a function that, given an integer for the width, prints a diamond. The user can select if the diamond is filled or outlined.

```csharp
private void PrintSpaces(int num)
{
    for (int j = 0; j < num; j++)
    {
        output.Write(' ');
    }
}

public void PrintDiamond(int width, bool filled = true)
{
    output.WriteLine();
    for (int line = -width + 1; line < width; line++)
    {
        PrintSpaces(Math.Abs(line));
        output.Write('*');
        for (int j = width - Math.Abs(line); j > 1; j -= 1)
        {
            output.Write(
                (j == 2 || filled) ?
                    " *" : "  ");
        }
        PrintSpaces(Math.Abs(line));
        output.WriteLine();
    }
}
```
[./CentairSolutions/Question8.cs]
[./CentairSolutionsTests/Question8Tests.cs]

---
###Question 9:

> Which of these is a common way to get objects into a SQL database?

> * Lazy Loading
> * Liskov Substitution
> * CORBA
> * Object-Relational Mapping

Object-Relational Mapping. 

---
###Question 10:

> What do you expect the value of x to be at the end of Main()? Briefly explain your choice.

> ```csharp
class Widget
{
	public string Name { get; set; }
	public decimal Weight { get; set; }
}

void Main()
{
	var theList = new[] {
		new Widget { Name = "A", Weight = 10.0 },
		new Widget { Name = "B", Weight = 20.0 },
		new Widget { Name = "C", Weight = 5.5 }
	};
	
	var x = theList.Max(w => w.Weight);
}
```

I would expect x to have a value of the second Widget in theList. The Max function should find the object in the list with the highest value as determined by the value function (w => w.Weight) , returning the object itself rather than the result of the value function.

---
###Question 11:

> Assume that the URL http://example.com/MessageOfTheDay returns just a string; no HTML. Write a function that returns that string. Assume that any external libraries you want are there; just mention them in a comment.


```csharp
using System.Net;
using System.IO;

public string GetMessageOfTheDay() {
    var task = getURL("http://example.com/MessageOfTheDay");
    task.Wait();
    if(task.Status == TaskStatus.RanToCompletion) {
        return task.Result;
    }
    else {
        if (task.IsFaulted)
            throw task.Exception;
        else
            throw new Exception("HTTP Request task could not complete");
    }
}

public async Task<string> getURL(string url)
{
    var response = await WebRequest.Create(url).GetResponseAsync().ConfigureAwait(false);
    var responseStreamReader = new StreamReader(response.GetResponseStream());
    return await responseStreamReader.ReadToEndAsync();
}
```


---
###Question 12:

> In the following code snippet, what pattern is being used to create the OrderProcessor class?

> ```csharp
class OrderProcessor
{
	private readonly IOrderRepository orderRepository;

	public OrderProcessor(IOrderRepository orderRepository)
	{
		this.orderRespository = orderRepository;
	}

	...
}
```


Inversion of control


---
###SQL
---
###Question 13:

> Write SQL queries that can answer each of the following questions:

> Which users that have placed at least one order have the oldest accounts?


```SQL
SELECT
    DISTINCT Customers.Name, Customers.JoinDate, Customers.Id
FROM 
    Customers INNER JOIN Orders
    ON Customers.Id = Orders.CustomerId
ORDER BY
    Customers.JoinDate ASC;
```

> What is the current price value of the entire inventory of active products?

```SQL
SELECT
    SUM(UnitPrice) AS TotalPrice
FROM
    Products
WHERE
    IsActive = 1;
```

> How many customers have ordered the product "Granola" at some point?

```SQL
SELECT
    COUNT(CustomerId) AS GranolaLovers
FROM (
    SELECT
        DISTINCT Orders.CustomerId AS CustomerId
    FROM
        Orders INNER JOIN Products
        ON Orders.ProductId = Products.Id
    WHERE
        Products.Name = 'Granola'
    );
```

> Which orders included products that sold at a different price than they are currently listed at?

```SQL
SELECT
    Orders.Id, Orders.UnitPrice, Products.UnitPrice, Products.Name
FROM
    Orders INNER JOIN Products
    ON Oders.ProductId = Products.Id
WHERE
    Orders.UnitPrice != Products.UnitPrice
```

---
###Question 14:

> If we wanted to change the application to support having multiple products in each order, what changes (if any) would you recommend?

In order to allow for multiple products to be mapped to in a single Order instance; I would recommend creating a new table, ProductOrders, and moving some columns from Orders into this table. The new ProductOrders and Orders table would look like this:

```SQL
CREATE TABLE ProdcutOrders (
    OrderId int NOT NULL CONSTRAINT FK_OrderId FOREIGN KEY REFERENCES Orders(Id),
    ProductId int NOT NULL CONSTRAINT FK_ProductId FOREIGN KEY REFERENCES Products(Id),
    UnitPrice money NOT NULL,
    Quanity int NOT NULL
);

CREATE TABLE Orders (
    Id int IDENTITY PRIMARY KEY,
    CustomerId int NOT NULL CONSTRAINT FK_CustomerId FOREIGN KEY REFERENCES Customers(Id),
    OrderDate datetime NOT NULL,
    ShippedDate datetime
);
```

This would allow for a many-to-one relationship between Products and Orders, while maintaining the per-product order information in the ProductOrders cross table.