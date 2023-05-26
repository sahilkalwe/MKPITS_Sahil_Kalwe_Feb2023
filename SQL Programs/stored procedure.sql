create table product(product_id int,product_name varchar(20),product_rate int,product_quantity int)
insert into product values (11,'dabur',120,5)
insert into product values (12,'amira',130,15)
insert into product values (13,'reynolds',140,50)
insert into product values (14,'kitkat',150,25)
insert into product values (15,'perk',160,35)
insert into product values (16,'munch',170,45)
insert into product values (17,'5star',180,55)
insert into product values (18,'silk',190,65)



create procedure prod
as
begin
select* from product
end;

exec prod

-----------------------------------------

create procedure prod2
as begin select product_name,product_rate
from product order by product_name
end;

exec prod2


----------------------------------------
create proc prod3
as  begin select product_id,product_name
from product order by product_name
end;


exec prod3
execute prod3
--------------------------------------------
alter proc prod3
as 
begin
select product_name ,product_rate,product_id
from product
order by product_id desc
end;


exec prod3
---------------------------------------------

drop proc prod2
------------------------------------------

create procedure prod4(@minprice as int)
as
begin
select * from product
where product_rate>@minprice
order by product_rate
end;

exec prod4 150
exec prod4 180

---------------------------------

create proc pp3(@pn as varchar(20))
as
begin
select * from product
where product_name=@pn
order by product_name
end
exec pp3 'kitkat'
exec pp3 'dairy milk'
exec pp3 'dabur'

------------------------------------------
create proc prod6(@Pname as varchar(20),@prate as float)
as
begin
select* from product
where product_name=@pname
and product_rate>=@prate
order by
product_id
end;


exec prod6'kitkat',150 
exec prod6 'dabur' ,110

------------------------------------------------------

alter procedure prod3(@min_price as dec)
as 
begin
select
product_name,
product_id,
product_rate
from
product
where
product_rate>=@min_price
order by 
product_rate;
end;


exec prod3 150.9

---------------------------------------------------------

create proc prod7(@a as dec ,@b as int)
as
begin
select * from product
where product_rate > @a and product_rate < @b
order by product_name
end;
exec prod7 150,190

--------------------------------------------


