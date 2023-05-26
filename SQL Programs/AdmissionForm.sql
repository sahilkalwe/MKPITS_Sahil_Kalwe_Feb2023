create table Course(CourseID int primary key,CourseName varchar(20),Fees decimal)
insert into Course values(1,'Dotnet',75000)
insert into Course values(2,'Java',80000)


create table Country(CountryID int primary key,CountryName varchar(20))
insert into Country values(1,'India')
insert into Country values(2,'USA')
select * from Country



create table State(StateID int primary key,StateName varchar(20),CountryID int constraint c1 foreign key (CountryID)references Country(CountryID))
insert into State values(1,'Maharashtra',1)
insert into State values(2,'California',2)



create table City(CityID int primary key,CityName varchar(20),StateId int constraint s1 foreign key (StateID) references State(StateID))
insert into City values(1,'Nagpur',1)
insert into City values(2,'Bhandara',1)
insert into City values(3,'Oakland',2)
insert into City values(4,'San Fransisco',2)


create table Admission(AdmissionID int primary key identity,Gender varchar(20),Contact Varchar(20),
CountryID int constraint s2 foreign key (CountryID) references Country(CountryID),
StateId int constraint s3 foreign key (StateID) references State(StateID),
CityID int constraint s4 foreign key (CityID) references City(CityID),
AdmissionDate datetime,CourseID int constraint s5 foreign key (CourseID) references Course(CourseID),
fees decimal,AmountPaid Decimal,
Balance Decimal)
insert into Admission values('male','7678678908',1,1,1,22/02/2023,1,75000,25000,50000)
insert into Admission values('female','7655578908',2,2,2,28/10/2022,2,80000,30000,50000)
select * from Admission 




