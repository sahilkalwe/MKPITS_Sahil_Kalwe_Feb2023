create table TableProductGSTDetails(Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST decimal,SGST decimal,IGST decimal)
insert into TableProductGSTDetails values (601,'AC and fridge',14,14,14)
insert into TableProductGSTDetails values (602,'Computers',9,9,9)
insert into TableProductGSTDetails values (603,'Printers',9,9,9)
insert into TableProductGSTDetails values (604,'Mobiles',6,6,6)

select * from TableProductGSTDetails

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableProductCategory(Product_Category_ID int primary key,Product_Type_Name varchar(500),
Product_Gst_ID int constraint p4 Foreign Key (Product_Gst_ID) references TableProductGSTDetails(Product_Gst_ID))
insert into TableProductCategory values(1001,'Computers',602)
insert into TableProductCategory values(1002,'Mobiles',604)
insert into TableProductCategory values(1003,'Printers',603)
insert into TableProductCategory values(1004, 'Ac and fridge',601)


select * from TableProductCategory
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableProduct(ProductID int primary key,ProductTypeID int constraint p3 Foreign Key (ProductTypeID) references TableProductCategory(Product_Category_ID),
ProductName varchar(500))
ALTER TABLE TableProduct
ADD ProductPrice decimal;
update TableProduct set ProductPrice=40000 where ProductName='Apple';
update TableProduct set ProductPrice=25000 where ProductName='Lenovo';
update TableProduct set ProductPrice=50000 where ProductName='Samsung';
update TableProduct set ProductPrice=20000 where ProductName='IFB';
update TableProduct set ProductPrice=30000 where ProductName='LG';
update TableProduct set ProductPrice=60000 where ProductName='Sony';

insert into TableProduct values (210,1002,'Apple',40000)
insert into TableProduct values (211,1002,'Lenovo',25000)
insert into TableProduct values (212,1003,'Samsung')
insert into TableProduct values (213,1004,'IFB') 
insert into TableProduct values (214,1004,'LG')
insert into TableProduct values (215,1001,'Sony')


select * from TableProduct;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table TableInvoiceDetails(Invoice_Detail_ID int primary key identity,Customer_Name varchar(500),Customer_Contact varchar(15),
Product_Category_ID int constraint p1 Foreign Key (Product_Category_ID) references TableProductCategory(Product_Category_ID), 
Product_ID int constraint p2 Foreign Key (Product_ID) references TableProduct(ProductID), 
Resedential_Type_ID int,Invoice_Date DateTime,Quantity Decimal,Price Decimal,CGST Decimal,SGST Decimal,IGST Decimal, CGST_Value Decimal,SGST_Value Decimal,IGST_Value Decimal,
Total_Amount Decimal)
insert into TableInvoiceDetails values ('Rahul',98521322110 ,1002,210,3001,2023-04-04,1,50000,6,6,12,3000,3000,6000,56000)
insert into TableInvoiceDetails values ('Nikita',7861232210,1001,211,3002,2023-04-08,1,65000,9,9,18,11700,5850,5850,76700)
insert into TableInvoiceDetails values ('gopal',1234567890,1001,215,3003,2023-04-12,1,60000,9,9,18,5400,5400,10800,70800)
insert into TableInvoiceDetails values ('anand',1234567890,1002,210,3004,2023-04-12,1,40000,6,6,6,2400,2400,2400,42400)


select * from TableInvoiceDetails
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------