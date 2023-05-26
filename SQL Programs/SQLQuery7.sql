create table student(id int,name varchar(20),age int,city varchar(10),state varchar(10))
insert into student values(1,'shreya',26,'mankapur','MH')
insert into student values(2,'mahima',28,'pardi','MH')
insert into student values(3,'rupali',30,'mohgaon','CH')
insert into student values(4,'mayuri',26,'koradi','MH')
insert into student values(5,'its',29,'ballarshah','CH')
insert into student values(6,'tanmay',28,'besa','MH')
insert into student values(7,'sahil',27,'nandanvan','Hp')
insert into student values(8,'anjali',24,'kalmeshwar','MP')
insert into student values(9,'mona',24,'ambazari','MH')
insert into student values(13,'tanu',25,'tumsar','MP')
insert into student values(10,'karishma',26,'burdi','MH')
insert into student values(11,'khan sir',59,'sadar','MH')
insert into student values(12,'ashish',28,'ghat road','MH')
select * from student
select * from student order by id desc
select * from student
delete from student where id=9
select * from student
select * from student where name ='ashish'
select * from student where id>1 and id<11
select * from student where name='ashish'
select * from student where state ='mp'
select * from student where state ='mp' order
by name
select * from student where state ='mp' order
by name desc
select city,COUNT(*) from student
where city='mohgaon'
group by city


select state,COUNT(*) from student
where city <> 'nandanvan'
group by age order by age


select city,COUNT(*) from student
where state = 'MH'

group by city

select city,COUNT(*) from student
where state = 'MH'
group by city
having COUNT(*) < 2