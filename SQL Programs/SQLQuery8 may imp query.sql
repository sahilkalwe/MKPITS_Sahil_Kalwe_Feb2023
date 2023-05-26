create table student11(id int identity primary key,name varchar(20),age int,city varchar(10),state varchar(10))
insert into student11	 values('shreya',26,'mankapur','MH')
insert into student11 values('mahima',28,'pardi','MH')
insert into student11 values('rupali',30,'mohgaon','CH')
insert into student11 values('mayuri',26,'koradi','MH')
insert into student11 values('its',29,'ballarshah','CH')
insert into student11 values('tanmay',28,'besa','MH')
insert into student11 values('sahil',27,'nandanvan','Hp')
insert into student11 values('anjali',24,'kalmeshwar','MP')
insert into student11 values('mona',24,'ambazari','MH')
insert into student11 values('tanu',25,'tumsar','MP')
insert into student11 values('karishma',26,'burdi','MH')
insert into student11 values('khan sir',59,'sadar','MH')
insert into student11 values('ashish',28,'ghat road','MH')


select * from students11


update student11  set city = 'mauda' 
where name='its'

update student11 set city='amravati' where name='mona' and state='mh' 


delete from student11 where name='karishma'

delete from student11


truncate table student11


alter table student11
add price int


select * from students11

alter table student11
alter column price varchar(20)



sp_help students11



alter table student11
drop column price


sp_rename 'student11' ,'students11'


exec sp_rename 'students11.name','fullname', 'COLUMN'


select * from students11
 