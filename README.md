###Question 1:

This section of code creates a shrot array and sums up all of the elemets, then prints out the sum. It prints out '18' and a new line charachter when executed

---
###Question 2:

The code outputs "1 1.5" ; demonstrating how division is handled between integers with truncation vs how division is handled between floating point numbers with a closest approximation available. In this case there are no rounding errors in the floating point calculation.

---
###Question 3:

The code outputs 20, summing up the numbers multiples of 2 less than 8 until it reaches something less than 2; in this case 0. The Foo() method is unique in that it uses recursion, calling itself from within the method body. This can be dangerous to use liberally, as it is in this case, because this will cause unnecessary memory usage by the program and slow down execution. Especially so when the function can be made flat, as is very likely here.

---
###Question 4:

See code library

---
###Question 5:

See code library

---
###Question 6:

See code library

---
###Question 7:

The code outputs "true false" . This is because the first check will attempt to cast both i and j into compatable types, and then check for equality. in this case i would get cast into a string, "0", making it equal to j. In the second check, type casting is disabled and the code checks for both the same type and the same data.

---
###Question 8:

See code library

---
###Question 9:

I'm not 100% sure about this one, if I had to give an answer it would be Object-Relational Mapping. 

---
###Question 10:

I would expect x to have a value of the second Widget in theList. The Max function should find the object in the list with the highest value as determined by the value function (w => w.Weight) , returning the object itself rather than the result of the value function.

---
###Question 11:

See code library

---
###Question 12:

Inversion of control

---
###Question 13:


Which users that have placed at least one order have the oldest accounts?
```SQL
SELECT
    DISTINCT Customers.Name, Customers.JoinDate, Customers.Id
FROM 
    Customers INNER JOIN Orders
    ON Customers.Id = Orders.CustomerId
ORDER BY Customers.JoinDate ASC;
```

What is the current price value of the entire inventory of active products?

```SQL
SELECT
    SUM(UnitPrice) AS TotalPrice
FROM Products
WHERE IsActive = 1;
```

How many customers have ordered the product "Granola" at some point?

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

Which orders included products that sold at a different price than they are currently listed at?

```SQL
SELECT Orders.Id, Orders.UnitPrice, Products.UnitPrice, Products.Name
FROM
    Orders INNER JOIN Products
    ON Oders.ProductId = Products.Id
WHERE
    Orders.UnitPrice != Products.UnitPrice
```

---
###Question 14:

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

In order to allow for multiple products to be mapped to in a single Order instance; I would recommend creating a new table, ProductOrders, and moving some columns from Orders into this table. The new ProductOrders and Orders table would look like this:

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

This would allow for a many-to-one relationship between Products and Orders, while maintaining the per-product order information in the ProductOrders cross table.


