create table country (country_id int primary key, country_name varchar(20) );
insert into country values(1,'India')
insert into country values(2,'USA')

create table state (state_id int primary key, state_name varchar(20), country_id int constraint c foreign key(country_id) 
references country(country_id) );
insert into state values(1,'Maharashtra',1)
insert into state values(2,'MP',1)
insert into state values(3,'Washington',2)
insert into state values(4,'Las Vegas',2)


create table city (city_id int primary key, city_name varchar(20),state_id int constraint c1 foreign key(state_id) 
references state(state_id) );

insert into city values(1,'Nagpur',1)
insert into city values(2,'Mumbai',1)
insert into city values(3,'Bhopal',2)
insert into city values(4,'Indore',2)
insert into city values(5,'La',3)
insert into city values(6,'Algona',4)





select * from country
select * from state
select * from city


select c1.country_id,c1.country_name,s1.state_name
from country c1 inner join state s1 
on c1.country_id=s1.country_id
where c1.country_name='India';


select s1.state_name
from country c1 inner join state s1 
on c1.country_id=s1.country_id
where c1.country_name='India';


select ct.city_name
from city ct inner join state s1 
on ct.state_id=s1.state_id
where s1.state_name='Maharashtra'


select state_name from state where country_id=1
(select country_id from country where country_name='india')

select city_name from city where state_id=1
(select state_id from state where state_name='maharashtra')



