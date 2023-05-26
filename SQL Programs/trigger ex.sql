create table employee (empid int, empname varchar(20))


create table emplog1 ( logid int identity (1,1) not  null,empid int not null,
operation nvarchar(10) not null, updateddate  datetime not null)

-----------------------------------------------------
create trigger empt1
on employee
for insert 
as
insert into
emplog1(empid,operation,updateddate)
select empid,'insert',GETDATE() from inserted; 

truncate table emplog

insert into employee values(11,'amit')
select * from employee
select * from emplog1


insert into employee values(12,'amita')
select * from employee
select * from emplog1

drop trigger empt
-------------------------------------------------------------
-----------------insertion----------------------
CREATE TRIGGER trgEmployeeInsert
ON Employee
FOR INSERT	
AS
    INSERT INTO emplog1(EmpID, Operation, UpdatedDate)
    SELECT EmpID ,'INSERT',GETDATE() FROM INSERTED; --virtual table INSERTED

	select * from employee
select * from emplog1

---------------------------------------------



create trigger empu
on employee
after update
as
insert into EmpLog1(EmpID,Operation,UpdatedDate)
select empid,'update',GETDATE() from deleted
update employee set empname='amitabh' where empid=11

select * from employee
select * from emplog1


-----------------------------------------------



