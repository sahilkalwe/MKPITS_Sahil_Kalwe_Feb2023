create  table employee (id int , name varchar(20), city varchar(20),address varchar(50))
--------------
create procedure [dbo].[AddEmp]    
(   @id int,
   @name varchar (20),    
   @city varchar (20),    
   @address varchar (50)    
)    
as    
begin    
   Insert into employee values(@id,@name,@city,@address)    
End   

select * from employee



create procedure [dbo].[UpdateEmp]    
(    
@id int,
   @name varchar (20),    
   @city varchar (20),    
   @address varchar (50)    
)    
as    
begin    
   update employee set city=@city,address=@address
   where name=@name
End
