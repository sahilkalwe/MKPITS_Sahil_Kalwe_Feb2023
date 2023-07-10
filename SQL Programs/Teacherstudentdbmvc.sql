
create table StaffTable(Staffid int primary key not null,Staffname varchar(30))
insert into StaffTable values(1,'Muzahid Khan')
insert into StaffTable values(2,'Gati krishna Mehar')
insert into StaffTable values(3,'Ashish Gajbhiye')


create table StudentTable(Studentid int primary key not null,Studentname varchar(30),Staffid int,constraint p1 foreign key(Staffid) references StaffTable(Staffid))

insert into StudentTable values(11,'Jayesh',1)
insert into StudentTable values(12,'Sahil',1)
insert into StudentTable values(13,'Mona',1)
insert into StudentTable values(14,'Anjali',1)
insert into StudentTable values(15,'Tanu',1)
insert into StudentTable values(16,'Tanmay',1)

insert into StudentTable values(17,'Tejaswini',2)
insert into StudentTable values(18,'Trupti',2)
insert into StudentTable values(19,'Ankita',2)
insert into StudentTable values(20,'Pranay',2)
insert into StudentTable values(21,'Pawan',2)
insert into StudentTable values(22,'Bharat',2)



insert into StudentTable values(23,'Neha',3)
insert into StudentTable values(24,'Dishita',3)




select * from StaffTable
select * from StudentTable
