create database techmart;

use techmart;

create table Customers(
CustID INT PRIMARY KEY,
CustName VARCHAR(100),
Email VARCHAR(200),
City VARCHAR(100)
);

create table Products(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
Price DECIMAL(10,2),
Stock INT CHECK(Stock >= 0)
);

create table Orders(
OrderID INT PRIMARY KEY,
CustID INT FOREIGN KEY REFERENCES Customers(CustID),
OrderDate DATE,
Status VARCHAR(20),
EmployeeID INT
);

create table OrderDetails(
DetailID INT PRIMARY KEY,
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
Qty INT CHECK(Qty > 0)
);

create table Payments(
PaymentID INT PRIMARY KEY,
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
Amount DECIMAL(10,2),
PaymentDate DATE
);


INSERT INTO Customers (CustID, CustName, Email, City) VALUES
(1, 'Amit Sharma', 'amit.sharma@gmail.com', 'Mumbai'),
(2, 'Ravi Kumar', 'ravi.kumar@yahoo.com', 'Delhi'),
(3, 'Priya Singh', 'priya.singh@gmail.com', 'Pune'),
(4, 'John Mathew', 'john.mathew@hotmail.com', 'Bangalore'),
(5, 'Sara Thomas', 'sara.thomas@gmail.com', 'Kochi'),
(6, 'Nidhi Jain', 'nidhi.jain@gmail.com', NULL);
 
 
INSERT INTO Products (ProductID, ProductName, Price, Stock) VALUES
(101, 'Laptop Pro 14', 75000, 15),
(102, 'Laptop Air 13', 55000, 8),
(103, 'Wireless Mouse', 800, 50),
(104, 'Mechanical Keyboard', 3000, 20),
(105, 'USB-C Charger', 1200, 5),
(106, '27-inch Monitor', 18000, 10),
(107, 'Pen Drive 64GB', 600, 80);
 
 
INSERT INTO Orders (OrderID, CustID, OrderDate, Status) VALUES
(5001, 1, '2025-01-05', 'Pending'),
(5002, 2, '2025-01-10', 'Completed'),
(5003, 1, '2025-01-20', 'Completed'),
(5004, 3, '2025-02-01', 'Pending'),
(5005, 4, '2025-02-15', 'Completed'),
(5006, 5, '2025-02-18', 'Pending');
 
 
INSERT INTO OrderDetails (DetailID, OrderID, ProductID, Qty) VALUES
(9001, 5001, 101, 1),
(9002, 5001, 103, 2),
(9003, 5002, 104, 1),
(9004, 5002, 103, 1),
(9005, 5003, 102, 1),
(9006, 5003, 105, 1),
(9007, 5003, 103, 3),
(9008, 5004, 106, 1),
(9009, 5005, 107, 4),
(9010, 5005, 104, 1),
(9011, 5006, 101, 1),
(9012, 5006, 107, 2);
 

INSERT INTO Payments (PaymentID, OrderID, Amount, PaymentDate) VALUES
(7001, 5002, 3300, '2025-01-11'),
(7002, 5003, 62000, '2025-01-22'),
(7003, 5005, 4500, '2025-02-16');


-- Section 1: SQL Queries:
-- Q1: List customers who placed an order in the last 30 days. 
select distinct c.CustID, c.CustName, c.Email, c.City
from Customers c
inner join Orders o on c.CustID = o.CustID
where o.OrderDate >= DATEADD(day, -30, getdate());


--Q2: Display top 3 products that generated the highest total sales amount. 
select top 3
p.ProductID,
p.ProductName,
SUM(od.Qty * p.Price) as Totalsales
from Products p
inner join OrderDetails od on p.ProductID = od.ProductID
group by p.ProductID, p.ProductName
order by Totalsales desc;


--Q3: For each city, show number of customers and total order count
select
c.City,
COUNT(distinct c.CustID) as Customercount,
COUNT(o.OrderID) as Ordercount
from Customers c
left join Orders o on c.CustID = o.CustID
group by c.City;


--Q4:  Retrieve orders that contain more than 2 different products
select o.OrderID, o.OrderDate, o.Status
from Orders o
inner join (
select OrderID, COUNT(distinct ProductID) as Productcount
from OrderDetails
group by OrderID
having COUNT(distinct ProductID) > 2
) od ON o.OrderID = od.OrderID;


--Q5: Show orders where total payable amount is greater than 10,000
select
o.OrderID,
o.OrderDate,
o.Status,
SUM(od.Qty * p.Price) as TotalPayable
from Orders o
inner join OrderDetails od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
group by o.OrderID, o.OrderDate, o.Status
having SUM(od.Qty * p.Price) > 10000;


--Q6: List customers who ordered the same product more than once
select
c.CustID,
c.CustName,
p.ProductID,
p.ProductName,
COUNT(*) as TimesOrdered
from Customers c
inner join Orders o on c.CustID = o.CustID
inner join OrderDetails od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
group by c.CustID, c.CustName, p.ProductID, p.ProductName
having COUNT(*) > 1;


--Q7: Display employee-wise order processing details
 select 
 o.EmployeeID,
 COUNT(o.OrderID) as TotalOrders,
 SUM(case when o.Status = 'Completed' then 1 else 0 end) as CompleteOrders,
 SUM(case when o.Status = 'Pending' then 1 else 0 end) as PendingOrders
 from Orders o
 group by o.EmployeeID
 go


 -- Section 2: Views
 --Q1:  Create a view vw_LowStockProducts (Show only products with stock < 5)
-- (View should be WITH SCHEMABINDING and Encrypted)
create view vw_LowStockProducts
with schemabinding, encryption
as
select ProductID,ProductName, price, Stock
from dbo.Products
where Stock < 5;
go


-- Section 3: Functions
--Q1: Create a table-valued function: fn_GetCustomerOrderHistory(@CustID)
create function fn_GetCustomerOrderHistory(@CustID int)
returns table
as 
return(
select o.OrderID, o.OrderDate, SUM(od.Qty * p.Price) as TotalAmount
from Orders o
inner join OrderDetails od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where o.CustID = @CustID
group by o.OrderID, o.OrderDate
);
go


--Q2: Create a function fn_GetCustomerLevel(@CustID) 
create function fn_GetCustomerLevel(@CustID int)
returns varchar(20)
as 
begin
declare @TotalPurchase decimal(10,2);
declare @Customerlevel varchar(20);

select @TotalPurchase = SUM(od.Qty * p.Price)
from Orders o
inner join OrderDetails od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where o.CustID = @CustID;

if @TotalPurchase > 100000
set @Customerlevel = 'Platinum';
else if @TotalPurchase >= 50000 and @TotalPurchase <= 100000
set @Customerlevel = 'Gold';
else
set @Customerlevel = 'Silver';

return @CustomerLevel
end;
go


-- Section 4: Procedures
-- Q1: Create a stored procedure to update product price

create table PriceHistory(
HistoryID INT IDENTITY(1,1) PRIMARY KEY,
ProductID int,
OldPrice decimal(10,2),
NewPrice decimal(10,2),
ChangeDate datetime default getdate(),
ChangedBy varchar(100)
);
go


create procedure UpdateProductPrice
@ProductID int,
@NewPrice decimal(10,2),
@ChangedBy varchar(100)
as
begin
if @NewPrice <= 0
begin
throw 50001, 'New Price must be greater than 0', 1;
return;
end

declare @OldPrice decimal(10,2);
select @OldPrice = Price from Products where ProductID = @ProductID;
if @OldPrice is null
begin
throw 50002, 'Product not found', 1;
return;
end

begin transaction;
insert into PriceHistory(ProductID, OldPrice, NewPrice, ChangedBy)
values (@ProductID, @OldPrice, @NewPrice, @ChangedBy);
update Products set Price = @NewPrice where ProductID = @ProductID;
commit transaction;
end;
go


--Q2: Create a procedure sp_SearchOrders
create procedure sp_SearchOrders
@CustomerName varchar(100) = null,
@City varchar(100) = null,
@ProductName varchar(100) = null,
@StartDate date = null,
@EndDate date = null
as
begin
select o.OrderID, o.OrderDate, o.Status, c.CustName, c.City, p.ProductName, od.Qty, (od.Qty * p.Price) as ItemTotal
from Orders o
inner join Customers c on o.CustID = c.CustID
inner join OrderDetails od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where (@CustomerName is null or c.CustName like '%' + @CustomerName + '%')
and (@City is null or c.City = @City)
and (@ProductName is null or p.ProductName like '%' + @ProductName + '%')
and (@StartDate is null or o.OrderDate >= @StartDate)
and (@EndDate is null or o.OrderDate <= @EndDate);
end;
go


-- Section 5: Triggers
--Q1: Create a Trigger on Products
create trigger trg_PreventProductDelete
on Products
instead of delete
as
begin
if exists(
select 1 from deleted d
inner join OrderDetails od on d.ProductID = od.ProductID
)
begin
throw 50003, 'Cannot delete the product which is already existing in the order details', 1;
return;
end

delete from Products where ProductID in (select ProductID from deleted);
end;


--Q2: Create an AFTER UPDATE trigger on Payments

create table PaymentAudit(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
PaymentID int,
OldAmount decimal(10,2),
NewAmount decimal(10,2),
AuditDate datetime default getdate(),
ActionBy varchar(100)
);
go


create trigger trg_PaymentAudit
on Payments
after update
as
begin
insert into PaymentAudit (PaymentID, OldAmount, NewAmount, ActionBy)
select i.PaymentID, d.Amount as OldAmount, i.Amount as NewAmount, system_user as ActionBy
from inserted i
inner join deleted d on i.PaymentID = d.PaymentID;
end;
go



--Q3: Create an INSTEAD OF DELETE trigger on Customers
create trigger trg_InsteadOfDeleteCustomer
on Customers
instead of delete
as
begin
update Customers
set CustName = 'Inactive Customer',
Email = null,
City = null
where CustID in (
select d.CustID from deleted d
where exists (select 1 from Orders o where o.CustID = d.CustID)
);

delete from Customers
where CustID in (
select d.CustID from deleted d
where not exists (select 1 from Orders o where o.CustID = d.CustID)
);
end;




