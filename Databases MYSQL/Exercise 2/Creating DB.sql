CREATE DATABASE CustomerDataBase;
USE CustomerDataBase;
CREATE TABLE Customers(
		CustomerID INT primary key,
        FirstName VARCHAR(50),
        LastName VARCHAR(50),
        PhoneNumber VARCHAR(15),
        Email VARCHAR(100),
        City VARCHAR(50)
);
CREATE TABLE Products(
	ProductID INT primary key,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    UnitPrice DECIMAL(10,2),
    StockQuantity INT
);
CREATE TABLE Orders(
	OrderID INT primary key,
    OrderDate DATE,
    CustomerID INT,
    CONSTRAINT fk_CustomerID foreign key (CustomerID) REFERENCES Customers(CustomerID),
    TotalAmount DECIMAL(10,2)
);
CREATE TABLE OrderDetails(
	OrderDetailID INT primary key,
    OrderID INT,
    CONSTRAINT fk_OrderID foreign key (OrderID) REFERENCES Orders(OrderID),
    ProductID INT,
    CONSTRAINT fk_ProductID foreign key (ProductID) REFERENCES Products(ProductID),
    Quantity INT,
    SubTotal DECIMAL(10,2)
);


