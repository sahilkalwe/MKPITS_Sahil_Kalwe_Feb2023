create table teacher1 (teacherid int primary key ,age int )
insert into teacher1 values(1,30)
insert into teacher1 values(2,26)
insert into teacher1 values(3,25)


create table subject1 (teacherid int, subject1 varchar(20),
constraint t1 foreign key (teacherid) references teacher1(teacherid))
insert into subject1 values (1,'chemistry')
insert into subject1 values (1,'biology')
insert into subject1 values (2,'english')
insert into subject1 values (2,'maths')
insert into subject1 values (3,'computer')
select * from subject1
select * from teacher1