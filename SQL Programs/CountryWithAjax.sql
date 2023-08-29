
create table Countries(CountryId int primary key identity,CountryName varchar(30))
insert into Countries values('India')
insert into Countries values('USA')
insert into Countries values('Canada')
select * from Countries



create table States(StateName varchar(30),StateId int primary key identity ,CountryId int constraint v1 foreign key(CountryId) references  Countries (CountryId))

insert into States values('Kerala',1)
insert into States values('Gujarat',1)
insert into States values('bihar',1)
insert into States values('ohio',2)
insert into States values('texas',2)
insert into States values('florida',2)
insert into States values('ontario',3)
insert into States values('monitaba',3)
insert into States values('Qubie',2)


select * from Countries
select * from States
select * from Cities

create table Cities(CityId int primary key identity,StateId int,CityName varchar(40),constraint v foreign key (StateId)references States(StateId) )
insert into Cities values(1,'Banglore')
insert into Cities values(1,'Koimbatore')
insert into Cities values(2,'Vadodara')
insert into Cities values(2,'Ahemdabad')
insert into Cities values(3,'patna')
insert into Cities values(3,'gaya')
insert into Cities values(4,'ramo')
insert into Cities values(5,'vokas')
insert into Cities values(6,'argo')
insert into Cities values(7,'amdas')
insert into Cities values(8,'argo')
