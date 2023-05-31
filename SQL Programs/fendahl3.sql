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


------------------------------------------------------------------------------------------------------------------------------------
create table TableProductDetails(AvailableQty int ,TotalQty int,TotalPrice Varchar(500),FirstName Varchar(20),LastName Varchar(20), 
Gender Varchar(20),Contact Varchar(200),ProductName varchar(500), ProductPrice int)


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableInvoiceDetails(InvoiceDetailID int primary key identity, AvailableQty int ,TotalQty int,FirstName varchar(500),
LastName varchar(500),Gender varchar(20), Contact varchar(15),
InvoiceDate DateTime,Price Decimal,CGST Decimal,SGST Decimal, CGSTValue Decimal,SGSTValue Decimal,
TotalPrice Decimal,PaidAmount Decimal,NetAmount Decimal)


insert into TableInvoiceDetails values (6,10,'Rahul','Likhar','Male','98521322110',2023-04-04,50000,6,6,3000,3000,6000,56000,12000)
insert into TableInvoiceDetails values (16,20,'Nikita','Pande','Female','7861232210',2023-04-08,65000,9,9,11700,5850,5850,76700,13000)
insert into TableInvoiceDetails values (8,22,'gopal','Bondre','Male','1234567890',2023-04-12,60000,9,9,5400,5400,10800,70800,14000)
insert into TableInvoiceDetails values (9,10,'anand','Palliwar','Male','1234567890',2023-04-12,40000,6,6,2400,2400,2400,42400,15000)


select * from TableInvoiceDetails