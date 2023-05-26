CREATE TABLE products1(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) CHECK(unit_price > 0));

	INSERT INTO products1(product_name, unit_price)
VALUES ('Awesome Free Bike', 10);

---------------------------------------------
INSERT INTO products1(product_name, unit_price)
VALUES ('Another Awesome Bike', NULL);
---------------------------------------------
insert into products1 values('mouse',120)
insert into products1 values('mouse',0)//error



create table result122(rno int primary key,
marks int check(marks > 0))
insert into result122 values(1,0)
insert into result122 values(1,99)

-----------------------------------------------------------------
CREATE TABLE products11(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) CONSTRAINT positive_price CHECK(unit_price > 0));
--------------------------------------------------------------------------



CREATE TABLE products2(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) CHECK(unit_price > 0),
    discounted_price DEC(10,2) CHECK(discounted_price > 0),
    CHECK(discounted_price < unit_price));

insert into products2 values('mouse',120,20)
insert into products2 values('mouse',NULL,NULL)
insert into products2 values('mouse',120,220)   //error



CREATE TABLE products3(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) ,
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0),
    CHECK(discounted_price > unit_price));


	CREATE TABLE products4(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0 AND discounted_price > unit_price))




	
CREATE TABLE products5(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0),
    CONSTRAINT valid_prices CHECK(discounted_price > unit_price))


	CREATE TABLE products119(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) NOT NULL)


ALTER TABLE products331
ADD discounted_price DEC(10,2)
CHECK(discounted_price > 0);

alter table products331
add discounted_price1 dec(20,2)

select * from products3311

------------------------------
sp_help products3311
---------------------------------




ALTER TABLE products331
ADD CONSTRAINT valid_price 
CHECK(unit_price > discounted_price);


select * from products119
-----------------------------------
ALTER TABLE products119
DROP Column product_name;
----------------------------------


