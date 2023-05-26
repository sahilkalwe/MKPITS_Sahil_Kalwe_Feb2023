/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [stud_id]
      ,[roll_no]
      ,[name]
      ,[course]
      ,[designation]
  FROM [student].[dbo].[stud]
  create table users (id int primary key identity,username varchar(20),password varchar(20))
  insert into users values('sahil','abc')
  insert into users values('sanjay','def')
  insert into users values('samir','ghi')
  select* from users