/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [prodid]
      ,[prodname]
      ,[proddescription]
      ,[catid]
      ,[prodprice]
      ,[qty]
      ,[prodimage]
  FROM [Meesho].[dbo].[Product]
  select * from product