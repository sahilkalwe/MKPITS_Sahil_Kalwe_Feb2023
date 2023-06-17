  Database: 'tms'
  ------------------------------
  
  
  CREATE TABLE `tms`.`new_user` (
  `Id` INT NOT NULL,
  `First_Name` VARCHAR(45) NOT NULL,
  `Last_Name` VARCHAR(45) NOT NULL,
  `Email_Id` VARCHAR(45) NOT NULL,
  `User_Role` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `Confirm_Password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`));


SELECT * FROM tms.new_user;


INSERT INTO new_user (Id, First_Name, Last_Name, Email_Id, User_Role, Password, Confirm_Password)
VALUES ('1' , 'John' , 'Smith' , 'js@gmail.com' , 'Accountant' , 'abcd' , 'abcd');


INSERT INTO new_user
VALUES ('2', 'Sarita', 'Marie', 'sm@gmail.com', 'Intern', 'sam#221','sam#221');


INSERT INTO new_user
VALUES ('3', 'Vicki', 'Aavya', 'va@gmail.com', 'Data Analyst', 'viki#341','viki#341');


INSERT INTO new_user
VALUES ('4', 'Mahr', 'Maqsood', 'mahr@gmail.com', 'Developer', 'sood#355','viki#355');


UPDATE new_user
SET First_Name = 'Alfred ', Last_Name = 'Schmidt'
WHERE Id = 2;


SELECT * FROM new_user WHERE Last_Name='Aavya';

SELECT * FROM new_user WHERE user_role='Developer';

DELETE FROM new_user WHERE User_Role= 'Intern' ;

------------------------------------------------

 CREATE TABLE `tms`.`new_project` (
    `Id` INT NOT NULL,
    `Name` VARCHAR(45) NOT NULL,
    `Status` VARCHAR(45) NOT NULL,
    `Start_Date` DATE NOT NULL,
    `End_Date` DATE NOT NULL,
    `Project_Manager` VARCHAR(45)
    `Project_TeamMembers` VARCHAR(45)
    `Add_Comments` VARCHAR(75)
     )


SELECT * FROM tms.new_project;
     

INSERT INTO new_project (Id, Name , Status , Start_Date , End_Date, Project_Manager, 
Project_Team_Members, Add_Comments)
VALUES ('2', 'John Smith', '75%', '01-03-2022', '30-06-2022', 'Ria Sharma' , 'Ravi,Nia' , '');


INSERT INTO new_project 
VALUES ('3' , 'Fatima Muhammad','30%', '30-03-2020' , '15-08-2020' , 'Yash Ramya' , 'Ram,Niya', '');


INSERT INTO new_project 
VALUES ('4','Ram Chandak', '30%' , '30-03-2020' , '15-08-2020' , 'Yash Ramya' , 'Nia,Fatima' , ''); 


UPDATE new_project SET Status= '65%'
WHERE ID = 1;


SELECT * FROM new_project WHERE Project_Manager='Ria Sharma';


DELETE FROM new_project WHERE Name='John Smith';

-----------------------------------------------------------------


   CREATE TABLE `tms`.`new_task` (
  `ID` INT NOT NULL,
  `First_Name` VARCHAR(45) NOT NULL,
  `Last_Name` VARCHAR(45) NOT NULL,
  `Project_Name` VARCHAR(45) NOT NULL,
  `Task_Assigned` VARCHAR(45) NOT NULL,
  `Start_Date` DATE NOT NULL,
  `End_Date` DATE NOT NULL,
  `Add_Details` VARCHAR(75) NULL,
  PRIMARY KEY (`ID`));
 
    SELECT * FROM tms.new_task;
    
    
    INSERT INTO new_task (Id, First_Name, Last_Name , Project_Name,
    Task_Assigned, Start_Date, End_Date, Add_Details) 
    VALUES('1','John','Smith','abcd','Front End', '01-01-2020', '30-02-2020','');


Insert Into new_task Values ('2','Niya','Singh','Website','Backend','01-01-2020', '30-02-2020','');


Insert Into new_task Values ('3','Fatima','Muhammad','Institue Website','Backend','11-01-2020', '15-04-2020','');

Insert Into new_task Values ('4','Nia','Khan','Institue Website','Frontend','11-01-2020', '15-04-2020','');


UPDATE new_task
SET Project_Name = 'Website ' WHERE Id = 1;


SELECT * FROM new_task WHERE Start_Date= '01-01-2020';


DELETE FROM new_task WHERE First_Name='Nia';




