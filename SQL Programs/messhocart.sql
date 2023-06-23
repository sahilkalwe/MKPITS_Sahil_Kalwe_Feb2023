
/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [cartid]
      ,[prodid]
      ,[prodname]
      ,[prodprice]
      ,[qty]
      ,[sessionid]
  FROM [Meesho].[dbo].[Cart]