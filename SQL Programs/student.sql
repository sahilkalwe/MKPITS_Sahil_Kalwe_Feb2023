/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [rno]
      ,[name]
  FROM [student].[dbo].[s1]

  truncate table stud1