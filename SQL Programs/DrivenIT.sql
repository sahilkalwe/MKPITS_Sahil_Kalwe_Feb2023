 create table ItemMaster(ItemID int primary key identity not null,ItemDescr  nvarchar(100)null,BalQty int null,CreatedOn DateTime)
 insert into ItemMaster values('mona',20,20/02/2003)
  insert into ItemMaster values('shona',20,20/02/2003)
   insert into ItemMaster values('rona1',10,09/05/2001)
    insert into ItemMaster values('mona1',50,10/03/2009)
 
 select * from ItemMaster



 create table transactions (TransID int identity primary key not null,ItemID int not null, constraint c1 foreign key (ItemID) references ItemMaster(ItemID),TransType char(1) not null,TransQty int,TransDate datetime)

select * from transactions

insert into transactions values(3,'R',3,'06/02/2023')
insert into transactions values(5,'I',4,'10/01/2021')