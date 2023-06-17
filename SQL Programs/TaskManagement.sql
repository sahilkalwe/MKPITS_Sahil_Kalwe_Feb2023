create table project (Name varchar(200),StartDate  datetime,ProjectManager varchar(200), Status int, EndDate datetime, ProjectTeamMembers int)


select * from Project


create table Task(FirstName varchar(200),ProjectName varchar(200),StartDate datetime,LastName varchar(200),TaskAssigned varchar(200),Enddate datetime)

select * from Task


create table User1(FirstName varchar(200),Email varchar(200),Password varchar(200),LastName varchar(200),UserRole varchar(200),ConfirmPassword varchar(200))


select * from User1


create table SignIn(Email varchar(200),Password varchar(200))


select * from SignIn