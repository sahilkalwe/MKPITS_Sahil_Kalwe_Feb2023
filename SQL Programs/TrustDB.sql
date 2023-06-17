create table Item_Master(Item_ID int primary key,Item_Name varchar(500) not null,
Category varchar(500) not null,rate int,Balance_Quantity int not null)

drop Table Item_Master

select * from Item_Master



create table Department_Master(Department_ID int primary key identity,Department_Name varchar(500) not null)

select * from Department_Master



create table Vendor_Master(Vendor_ID int primary Key identity,Vendor_Name varchar(500) not null)

select * from Vendor_Master;


 create table Transaction_Table(Transaction_ID int primary Key identity,
Item_ID int, constraint c1 foreign key (Item_ID) references Item_Master(Item_ID),
Transaction_Date DateTime not null,
Department_ID int, constraint c2 foreign key(Department_ID) references Department_Master(Department_ID),
Vendor_ID int, constraint c3 foreign key(Vendor_ID) references Vendor_Master(Vendor_ID),
Quantity int not null)

select * from Transaction_Table

