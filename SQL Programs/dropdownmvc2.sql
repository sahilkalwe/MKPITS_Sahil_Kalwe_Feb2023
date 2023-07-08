
create table CategoryTable(Categoryid int primary key not null,Categoryname varchar(30))
insert into CategoryTable values(1,'Electronics')
insert into CategoryTable values(2,'Kitchen')
insert into CategoryTable values(3,'Houshold')


create table ProductTable(Productid int primary key not null,Productname varchar(30),Categoryid int, constraint p1 foreign key(Categoryid) references CategoryTable(Categoryid))

insert into ProductTable values(11,'TV',1)
insert into ProductTable values(12,'AC',1)

insert into ProductTable values(15,'GAS',2)
insert into ProductTable values(16,'CYLINDER',2)

insert into ProductTable values(17,'FLOOR MOP',3)
insert into ProductTable values(18,'DISHWASHER',3)




select * from ProductTable
select * from CategoryTable