create table TableNation(NationID int Primary Key,NationName Varchar(500))
insert into TableNation Values(1,'India')  
insert into TableNation Values(2,'United-Nation') 
insert into TableNation Values(3,'Nepal') 
insert into TableNation Values(4,'SriLanka') 

select * from TableNation


create table TableState(StateID int Primary Key,
NationID int constraint c1 foreign key (NationID) references TableNation(NationID),StateName Varchar(500))
insert into TableState Values(101,1,'Andhra Pradesh')
insert into TableState Values(102,1,'Punjab')
insert into TableState Values(103,2,'California')
insert into TableState Values(104,2,'Florida')
insert into TableState Values(105,3,'Koshi')
insert into TableState Values(106,3,'Bagmati')
insert into TableState Values(107,4,'Colombo')
insert into TableState Values(108,4,'Ratnapura')


select * from TableState

create table TableCity(CityID int Primary Key,
StateID int constraint c2 foreign key (StateID) references TableState(StateID),CityName Varchar(500))
insert into TableCity Values(1001,101,'Visakhapatanam')
insert into TableCity Values(1002,101,'Vijaywada')
insert into TableCity Values(1003,101,'Guntur')
insert into TableCity Values(1004,102,'Amritsar')
insert into TableCity Values(1005,102,'Jalandar')
insert into TableCity Values(1006,102,'Chandigarh')
insert into TableCity Values(1007,103,'Los Angels')
insert into TableCity Values(1008,103,'San Jose')
insert into TableCity Values(1009,103,'San Diego')
insert into TableCity Values(1010,104,'Jacksonville')
insert into TableCity Values(1011,104,'Milami')
insert into TableCity Values(1012,104,'Tampa')
insert into TableCity Values(1013,105,'Damak')
insert into TableCity Values(1014,105,'Dharan')
insert into TableCity Values(1015,105,'Biratnagar')
insert into TableCity Values(1016,106,'Banepa')
insert into TableCity Values(1017,106,'Bharatpur')
insert into TableCity Values(1018,106,'Hetauda')
insert into TableCity Values(1019,107,'Grandpass')
insert into TableCity Values(1020,107,'Borella')
insert into TableCity Values(1021,107,'Pettah')
insert into TableCity Values(1022,108,'Balangoda')
insert into TableCity Values(1023,108,'Kolonna')


select * from TableCity



------------------------------------------------------------------------------------------------------------------------------------
create table TableCourseRegDetails(CourseRegID int Primary Key,CategoryID int ,FullName Varchar(1500),GenderID int)
Insert into TableCourseRegDetails values(4,1,'mk',1)
Insert into TableCourseRegDetails values(5,2,'mk2',2)
Insert into TableCourseRegDetails values(6,1,'ravi',1)
Insert into TableCourseRegDetails values(7,1,'anand',1)
Insert into TableCourseRegDetails values(8,1,'gaurav',1)
Insert into TableCourseRegDetails values(9,1,'pranjali',2)
Insert into TableCourseRegDetails values(10,1,'mk3',1)
Insert into TableCourseRegDetails values(11,1,'mk4',1)
Insert into TableCourseRegDetails values(12,1,'mk5',1)
Insert into TableCourseRegDetails values(13,1,'mk6',1)
Insert into TableCourseRegDetails values(14,2,'dhananjay',1)
Insert into TableCourseRegDetails values(15,1,'m khan',1)
Insert into TableCourseRegDetails values(16,2,'anaya',2)



select * from TableCourseRegDetails
------------------------------------------------------------------------------------------------------------------------------------

create table TableRegAddress(RegAddressID int,
CourseRegID int constraint c3 foreign key (CourseRegID) references TableCourseRegDetails(CourseRegID) ,
NationID int constraint c4 foreign key (NationID) references TableNation(NationID),
StateID int constraint c5 foreign key (StateID) references TableState(StateID),
CityID int constraint c6 foreign key (CityID) references TableCity(CityID));
Insert into TableRegAddress values(1,4,4,102,1003)
Insert into TableRegAddress values(2,5,4,104,1009)
Insert into TableRegAddress values(3,6,4,102,1003)
Insert into TableRegAddress values(4,7,4,104,1012)
Insert into TableRegAddress values(5,8,2,104,1009)
Insert into TableRegAddress values(6,9,2,104,1009)
Insert into TableRegAddress values(7,10,2,103,1009)
Insert into TableRegAddress values(8,11,2,103,1007)
Insert into TableRegAddress values(9,12,1,102,1006)
Insert into TableRegAddress values(10,13,1,101,1001)
Insert into TableRegAddress values(11,14,4,107,1021)
Insert into TableRegAddress values(12,15,2,104,1012)
Insert into TableRegAddress values(13,16,1,101,1002)

select * from TableRegAddress
-------------------------------------------------------------------------------------------------------------------------------------
create table TableFeeDetails(FeeID int Primary Key identity,
CourseRegID int constraint c7 foreign key (CourseRegID) references TableCourseRegDetails(CourseRegID),
TotalAmount Decimal,MinPer decimal,PaidAmount Decimal,BalAmount Decimal,PaidDate DateTime)
insert into TableFeeDetails values (4,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (5,3000,0,20,2980,2023-04-04)
insert into TableFeeDetails values (6,1000,0,200,800,2023-04-10)
insert into TableFeeDetails values (7,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (8,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (9,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (10,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (11,1000,0,500,500,2023-04-10)
insert into TableFeeDetails values (12,1000,0,600,400,2023-04-10)
insert into TableFeeDetails values (13,1000,500,600,400,2023-04-10)
insert into TableFeeDetails values (14,3000,2400,2400,600,2023-04-10)
insert into TableFeeDetails values (15,1000,500,500,500,2023-04-10)
insert into TableFeeDetails values (16,3000,2400,2500,500,2023-04-10)



select * from TableFeeDetails
-----------------------------------------------------------------------------------------------------------------------------------------