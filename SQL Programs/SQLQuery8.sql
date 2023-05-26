create table stud(id int primary key,rollno int, name varchar(20),surname varchar(20),course varchar(20),city varchar(20),state varchar(20))
insert into stud values(1,11,'sahil', 'kalwe','dotnet','nagpur','MH')
insert into stud values(16,26,'sahil', 'kadao','dotnet','nagpur','MH')
insert into stud values(2,12,'tanmay', 'patil','dotnet','nagpur','MH')
insert into stud values(3,13,'jay', 'deshmukh','java','amravati','MH')
insert into stud values(4,14,'anjali', 'pathak','java','amravati','MH')
insert into stud values(19,29,'mona', 'mohadikar','dotnet','nagpur','MH')
insert into stud values(21,30,'mona', 'mahatme','dotnet','amravati','MH')
insert into stud values(5,15,'mona', 'mohatkar','dotnet','nagpur','MH')
insert into stud values(61,16,'tanu', 'meshream','java','amravati','MH')
insert into stud values(22,17,'karishma', 'pachdhare','dotnet','bhandara','MH')
insert into stud values(8,18,'aashish', 'rampal','dotnet','bhandara','MH')
insert into stud values(9,19,'its', 'yasmin','java','ballarshsh','MH')
insert into stud values(10,20,'rupali', 'barde','dotnet','nagpur','MH')
insert into stud values(11,21,'mahima', 'barde','dotnet','nagpur','MH')
insert into stud values(12,22,'shreya', 'dakhale','java','nagpur','MH')
insert into stud values(13,23,'mayuri', 'palewar','dotnet','nagpur','MH')
insert into stud values(17,27,'mayuri', 'palekar','dotnet','nagpur','MH')
insert into stud values(18,28,'mayuri', 'pal','dotnet','nagpur','MH')
insert into stud values(23,24,'muzahid', 'khan','java','bhandara','MH')
insert into stud values(15,25,'rita', 'ingole','dotnet','ballarshah','MH')
select * from stud
delete from stud where id=61
select city, count (*) from stud where state='MH'
group by city
having count (*) >1
order by city;



select city, count(*) from stud
where state ='MH'
group by city

select city, count(*)from stud
where state='MH'
group by city
having count (*)>2


select name,surname from stud order by name desc

select city,name from stud
order by city desc,name desc;



select  city ,name,surname from stud order by course


select name,surname from stud  order by LEN(name)desc; 


select top 2 name,  course from stud order by course desc


select top 20 percent
name,course from stud order by course desc;



select distinct course from stud



select city from stud order by city


select distinct name from stud 


select * from stud where name='mayuri'



select course ,city id,state ,surname
from stud 
where city='nagpur'
order by surname desc



select id,name,city,state,surname,course from stud
where name='mona'
AND course='dotnet'
order by city 



select * from stud where id<6
and name ='mona'



select id,name,city ,state,surname from stud where 
id between 3 and 20
order by surname desc



select * from stud where name between 'a'and 's'



select * from stud where rollno between 15 and 22



select * from stud where id in(1,13,5)


select * from stud where id not in(1,13,5)




select id ,name,city,state from stud 
where 
name LIKE '%a%'
order by  id



select * from stud where name like 'm%a'


select * from stud where name like 's%'


select * from stud where name like '%tan%'


select * from stud where city='nagpur' and id<11
order by id desc;



select * from stud where city ='amravati' and id <23 and state ='mh' 
order by id desc;



select * from stud where (city ='nagpur' or id <15) and state ='mh' 
order by id desc;



select name ,surname from stud where id IN(15,18,20)
order by id desc





select name ,surname from stud where id=5 or id=9 or id=1
order by id desc




select city ,name,surname from stud where id not in (13,17,18)
order by id desc





select id ,surname,course from stud 
where city ='nagpur' and course='dotnet'



select id, name,surname,course
from stud
where id IN(select id from stud where course='dotnet' and city='nagpur')
order by name desc





























