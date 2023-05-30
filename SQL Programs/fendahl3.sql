create table TableProductGSTDetails(ProductGstID int primary key,GstDetailName varchar(500),CGST decimal,SGST decimal)
insert into TableProductGSTDetails values (601,'Laptop',14,9)
insert into TableProductGSTDetails values (602,'Mobiles',9,6)

select * from TableProductGSTDetails

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableProductCategory(ProductCategoryID int primary key,ProductCategory varchar(500),
ProductGstID int constraint p1 Foreign Key (ProductGstID) references TableProductGSTDetails(ProductGstID))
insert into TableProductCategory values(1001,'Laptop',601)
insert into TableProductCategory values(1002,'Mobiles',602)

select * from TableProductCategory
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableProduct(ProductID int constraint p2 Foreign Key (ProductID) 
references TableProductCategory(ProductCategoryID),ProductName varchar(500), ProductPrice int)

insert into TableProduct values (1001,'HP',40000)
insert into TableProduct values (1001,'Dell',25000)
insert into TableProduct values (1001,'Samsung',30000)
insert into TableProduct values (1001,'Apple',41000) 
insert into TableProduct values (1001,'Infinix',34000)
insert into TableProduct values (1001,'Lenovo',60000)
insert into TableProduct values (1002,'Lava',4000)
insert into TableProduct values (1002,'MI',12000)
insert into TableProduct values (1002,'POCO',17000)
insert into TableProduct values (1002,'Realme',14000) 


select * from TableProduct;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableInvoiceDetails(InvoiceDetailID int primary key identity,CustomerName varchar(500),Contact varchar(15),
ProductCategoryID int constraint p1 Foreign Key (ProductCategoryID) references TableProductCategory(ProductCategoryID), 
ProductID int constraint p2 Foreign Key (ProductID) references TableProduct(ProductID), 
ResedentialTypeID int,InvoiceDate DateTime,Quantity Decimal,Price Decimal,CGST Decimal,SGST Decimal,IGST Decimal, CGSTValue Decimal,SGSTValue Decimal,IGSTValue Decimal,
TotalAmount Decimal)
insert into TableInvoiceDetails values ('Rahul',98521322110 ,1002,210,3001,2023-04-04,1,50000,6,6,12,3000,3000,6000,56000)
insert into TableInvoiceDetails values ('Nikita',7861232210,1001,211,3002,2023-04-08,1,65000,9,9,18,11700,5850,5850,76700)
insert into TableInvoiceDetails values ('gopal',1234567890,1001,215,3003,2023-04-12,1,60000,9,9,18,5400,5400,10800,70800)
insert into TableInvoiceDetails values ('anand',1234567890,1002,210,3004,2023-04-12,1,40000,6,6,6,2400,2400,2400,42400)


select * from TableInvoiceDetails