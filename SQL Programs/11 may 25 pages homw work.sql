
------------------------------------------------------------------------------------
create table salesman (salesman_id int primary key,name varchar (20),city varchar(20),comission varchar(20))
insert into salesman values (5001,'james hoog','new york',0.15)
insert into salesman values (5002,'nail knite','paris',0.13)
insert into salesman values (5005,'pit alex','london',0.11)
insert into salesman values (5006,'mc lyon','paris',0.14)
insert into salesman values (5003,'lauson hen san','san jose',0.12)
insert into salesman values (5007,'paul adam','rome',0.13)
-----------------------------------------------------------------------------------------
create table customer (customer_id int primary key ,cust_name varchar (20),city varchar(20),grade int ,
salesman_id int constraint s1 foreign key (salesman_id) references salesman(salesman_id))
insert into customer values (3002,'nick rimando','new york',100,5001)
insert into customer values (3007,'brad davis','new york',200,5001)
insert into customer values (3005,'graham zusi','california',200,5002)
insert into customer values (3008,'julian green','london',300,5002)
insert into customer values (3004,'fabian johnson','paris',300,5006)
insert into customer values (3009,'geoff cameron','berlin',100,5003)
insert into customer values (3003,'jozy altidor','moscow',200,5007)
insert into customer values (3001,'brad guzan','london',null,5005)


------------------------------------------------------------------------------------

create table orders (ord_id int primary key ,purch_amt dec,ord_date varchar(20),
customer_id int constraint c1 foreign key (customer_id) references customer(customer_id),
salesman_id int constraint s2 foreign key (salesman_id) references salesman(salesman_id))
insert into orders values (70001,150.5,'2012-10-05',3005,5002)
insert into orders values (70009,270.65,'2012-09-10',3001,5005)
insert into orders values (70002,65.26,'2012-10-05',3002,5001)
insert into orders values (70004,110.5,'2012-08-17',3009,5003)
insert into orders values (70007,948.5,'2012-09-10',3005,5002)
insert into orders values (70005,2400.6,'2012-07-27',3007,5001)
insert into orders values (70008,5760,'2012-10-10',3002,5001)
insert into orders values (70010,1983.43,'2012-10-10',3004,5006)
insert into orders values (70003,2480.4,'2012-10-10',3009,5003)
insert into orders values (70012,250.45,'2012-06-27',3008,5002)
insert into orders values (70011,75.29,'2012-08-17',3003,5007)
insert into orders values (70013,3045.6,'2012-04-25',3002,5001)

-----------------------------------1-------------------------------------------------

select ord_id, purch_amt, ord_date, customer_id salesman_id from orders
where salesman_id=(select salesman_id from salesman 
where name= 'paul adam')

---------------------------------------2-------------------------------------------

select ord_id, purch_amt, ord_date, customer_id, salesman_id from orders 
where salesman_id=(select salesman_id from salesman 
where city='london' )

------------------------------------------3------------------------------------------

select ord_id, purch_amt, ord_date, customer_id, salesman_id from  orders
where salesman_id =(select distinct salesman_id from orders
where customer_id=3007)

-----------------------------------------------4--------------------------------------
select ord_id, purch_amt, ord_date, customer_id, salesman_id from orders 
where purch_amt>(select AVG (purch_amt) from orders where ord_date='2012-10-10')


-------------------------------------------5----------------------------------
select ord_id, purch_amt, ord_date, customer_id ,salesman_id from orders
where salesman_id=(select salesman_id from salesman where city='new york')

-----------------------------------------6-------------------------------
select comission from salesman 
where city='paris'


-----------or-----------
select comission from salesman 
where salesman_id=(select salesman_id from customer where city='paris')


----------------------------------7-----------------------------------

select * from customer
where customer_id=(select salesman_id-2001 from salesman where name='mc lyon')


----------------------------------8---------------------------------------
select grade ,COUNT(*) from customer
group by grade
having grade >(select AVG(grade)from customer where city='new york')

-------------------------------------9------------------------------------
select ord_id, purch_amt, ord_date,salesman_id from orders
where salesman_id=(select salesman_id from salesman where comission=(select MAX(comission)from salesman))

------------------------------------------------10-------------------------
10. From the following tables write SQL query to find the customers who placed orders on 17th August
2012. Return ord_no, purch_amt, ord_date, customer_id, salesman_id and cust_name.

SELECT b.*, a.cust_name
FROM orders b, customer a
WHERE a.customer_id=b.customer_id
AND b.ord_date='2012-08-17';



----------------------------------------------------11-----------------------------------
11. From the following tables write a SQL query to find salespeople who had more than one customer.
Return salesman_id and name.


select salesman_id,name from salesman a
where 1<(select count (*) from customer
where salesman_id=a.salesman_id)

----------------------------------------------12------------------------------------------

12. From the following tables write a SQL query to find those orders, which are higher than the average
amount of the orders. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.


select * from orders a 
where purch_amt > (select avg (purch_amt) from orders b 
where b.customer_id =a.customer_id)

---------------------------------------------------13-------------------------------------

13. From the following tables write a SQL query to find those orders that are equal or higher than the
average amount of the orders. Return ord_no, purch_amt, ord_date, customer_id and salesman_id.



SELECT *
FROM orders a
WHERE purch_amt >=
(SELECT AVG(purch_amt) FROM orders b
WHERE b.customer_id = a.customer_id);

------------------------------------------14----------------------------------------


14. Write a query to find the sums of the amounts from the orders table, grouped by date, and eliminate
all dates where the sum was not at least 1000.00 above the maximum order amount for that date.


SELECT ord_date, SUM (purch_amt)
FROM orders a
GROUP BY ord_date
HAVING SUM (purch_amt) >
(SELECT 1000.00 + MAX(purch_amt)
FROM orders b
WHERE a.ord_date = b.ord_date);

------------------------------------------15----------------------------------------------
15) Write a query to extract all data from the customer table if and only if one or more of the customers in
the customer table are located in London.


SELECT customer_id,cust_name, city
FROM customer
WHERE EXISTS
(SELECT *
FROM customer
WHERE city='London')

------------------------------------------------------16--------------------------------------

16. From the following tables write a SQL query to find salespeople who deal with multiple customers.
Return salesman_id, name, city and commission.


SELECT *
FROM salesman
WHERE salesman_id IN (
SELECT DISTINCT salesman_id
FROM customer a
WHERE EXISTS (
SELECT *
FROM customer b
WHERE b.salesman_id=a.salesman_id
AND b.cust_name<>a.cust_name));