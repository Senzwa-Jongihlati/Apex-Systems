Use CustomerDataBase;
SELECT * FROM Customers;
INSERT INTO Customers(CustomerID,FirstName,LastName,PhoneNumber,Email,City)
VALUES  (1001,"Alice","Smith","0825551234","alice@gmail.com","City"),
		(1002,"Brian","Jones","0834445678","brian@email.com","Pietermaritzburg"),
        (1003,"Carla","Naidoo","0843337890","carla@email.com","Durban"),
        (1004,"David","Khumalo","0817776543","david@email.com","Richard Bay"),
        (1005,"Emma","Pillay","0821112233","emma@email.com","Ballito");
SELECT * FROM Products;
INSERT INTO Products(ProductID,ProductName,Category,UnitPrice,StockQuantity)
VALUES	(201,"Laptop","Electronics",12500,15),
		(202,"Wireless Mouse","Accessories",250,80),
        (203,"Keyboard","Accessories",450,50),
        (204,"Monitor","Electronics",3200,20);
SELECT * FROM Orders;
INSERT INTO Orders(OrderID,OrderDate,CustomerID,TotalAmount)
VALUES	(301,"2026-03-01",1001,12750),
		(302,"2026-03-02",1002,3200),
        (303,"2026-03-3",1003,700),
        (304,"2026-03-04",1004,12950),
        (305,"2026-03-05",1005,500);
SELECT * FROM OrderDetails;
INSERT INTO OrderDetails(OrderDetailID,OrderID,ProductID,Quantity,SubTotal)
VALUES	(1,301,201,1,12500),
		(2,301,202,1,250),
        (3,302,204,1,3200),
        (4,303,202,1,250),
        (5,303,203,1,450),
        (6,304,201,1,12500),
        (7,304,203,1,450),
        (8,305,202,2,500);
INSERT INTO Orders(OrderID,OrderDate,CustomerID,TotalAmount) VALUES	(306,"2026-03-06",1001,250);
INSERT INTO OrderDetails(OrderDetailID,OrderID,ProductID,Quantity,SubTotal) VALUES (9,306,202,1,250);
        