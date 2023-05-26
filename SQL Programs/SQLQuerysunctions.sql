create table functions1(id int primary key identity, region varchar(20),product varchar(20), year int, quantity int, price int)
insert into functions1 values('east','mouse',2020,130,50000)
insert into functions1 values('east','computer',2020,120,35000)
insert into functions1 values('south','computer',2020,110,40000)
insert into functions1 values('north','computer',2020,10,5500)
insert into functions1 values('east','Hard Disk',2021,150,45000)
insert into functions1 values('west','computer',2021,15,4400)
insert into functions1 values('south','hard disk',2021,17,7500)
insert into functions1 values('west','hard disk',2021,19,800)
insert into functions1 values('east','pen drive',2019,10,1500)
insert into functions1 values('north','mouse',2019,18,750)
insert into functions1 values('south','pendrive',2019,16,1200)
insert into functions1 values('east','mouse',2019,1,650)

select * from functions1




    SELECT Product, Quantity, Price  
    FROM functions 
    WHERE price = (  
    SELECT MIN(price) AS "Minimum price	"   
    FROM functions);  


	SELECT Product, MIN(quantity) AS "Minimum quantity"   
    FROM functions1  
    GROUP BY Product;  



	SELECT Product, MIN(quantity) AS "Minimum Quantity"   
    FROM functions1  
    GROUP BY Product  
    HAVING MIN(quantity)>100;  


