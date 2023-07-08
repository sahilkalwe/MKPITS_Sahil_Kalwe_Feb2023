create database CountryDB
create table Statetable(stateid int primary key not null,statename varchar(30))
insert into Statetable values(1,'maharashtra')
insert into Statetable values(2,'MP')
insert into Statetable values(3,'Up')


create table Citytable(Cityid int primary key not null,cityname varchar(30),stateid int,constraint p1 foreign key(stateid) references Statetable(stateid))

insert into Citytable values(11,'nagpur',1)
insert into Citytable values(12,'pune',1)

insert into Citytable values(15,'Indore',2)
insert into Citytable values(16,'Bhopal',2)

insert into Citytable values(17,'Sikandarabad',3)
insert into Citytable values(18,'Faridabad',3)




select * from Statetable
select * from Citytable
