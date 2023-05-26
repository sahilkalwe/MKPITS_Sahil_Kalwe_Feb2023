create table student1(rno int primary key,name varchar(20),email varchar(20),city varchar(20),courseid int);
insert into student1 values(11,'sahil','s@gmail.com','nagpur','311')
insert into student1 values(12,'jay','j@gmail.com','kolhapur','312')
insert into student1 values(13,'mona','m@gmail.com','solapur','313')
insert into student1 values(14,'tanmay','t@gmail.com','samudrapur','314')
insert into student1 values(15,'trupti','t1@gmail.com','rampur','315')



create table fees(feesid int primary key,rno int,feesdate varchar(20),amount int,courseid int );
insert into fees values(111,11,'1/2/2023',1200,'311')
insert into fees values(112,12,'1/3/2022',1300,'312')
insert into fees values(113,13,'1/4/2022',1400,'313')
insert into fees values(114,14,'1/5/2022',1500,'314')
insert into fees values(115,15,'1/6/2023',1600,'315')