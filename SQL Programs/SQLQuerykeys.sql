create table keys1(col1 int ,col2 nvarchar(28),col3 nvarchar(30),col4 int
primary key (col1,col2))

insert into keys1 values(1,'11','11',1);
insert into keys1 values(11,'11','12',1);
insert into keys1 values(11,'12','11',1);
insert into keys1 values(1,'11','11',1);



CREATE TABLE students(   
S_Id int NOT NULL,  
LastName varchar (255) NOT NULL,  
FirstName varchar (255),  
City varchar (255),  
CONSTRAINT uc_studentId UNIQUE (S_Id, LastName)  
)  




create table sample21(id int primary key,name varchar(20))
insert into sample21(name) values('ravi')
select * from sample21


create table employee(empid int primary key,empname varchar(20),
passportno int,drivinglicenceno int,
constraint e1 unique(passportno,drivinglicenceno))

insert into employee values(1,'jayesh',12345,98989)
insert into employee values(3,'jayesh',22345,98989)
insert into employee values(4,'jayesh',223145,98989)

select * from employee

create table emp(empid int primary key,empname varchar(20),
pno int unique,dlno int unique)

insert into emp values(1,'anand',111,222)
insert into emp values(2,'anand',112,223)
---------------------------------------------

create table customer1(custid int primary key identity,
custname varchar(50))

insert into customer1 values('raj')
select * from customer1
insert into customer1 values('rajesh')
select * from customer1


