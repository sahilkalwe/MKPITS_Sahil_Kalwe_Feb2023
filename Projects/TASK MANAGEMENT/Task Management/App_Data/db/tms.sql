Database - 'tms'
--------------------------------------------------

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

INSERT INTO tms.new_user (Id, First_Name, Last_Name, Email_Id, User_Role, Password, Confirm_Password)
VALUES ('1' , 'John' , 'Smith' , 'js@gmail.com' , 'Accountant' , 'abcd' , 'abcd');

INSERT INTO tms.new_user
VALUES ('2', 'Sarita', 'Marie', 'sm@gmail.com', 'Intern', 'sam#221','sam#221');


INSERT INTO tms.new_user
VALUES ('3', 'Vicki', 'Aavya', 'va@gmail.com', 'Data Analyst', 'viki#341','viki#341');


INSERT INTO tms.new_user
VALUES ('4', 'Mahr', 'Maqsood', 'mahr@gmail.com', 'Developer', 'sood#355','viki#355');

UPDATE tms.new_user
SET First_Name = 'Alfred ', Last_Name = 'Schmidt'
WHERE Id = 2;

SELECT * FROM tms.new_user WHERE Last_Name='Aavya';

SELECT * FROM tms.new_user WHERE user_role='Developer';

DELETE FROM tms.new_user WHERE User_Role= 'Intern' ;
-----------------------------------------------------------

CREATE TABLE `tms`.`new_project` (
    `Id` INT NOT NULL,
    `Name` VARCHAR(45) NOT NULL,
    `Status` VARCHAR(45) NOT NULL,
    `Start_Date` DATE NOT NULL,
    `End_Date` DATE NOT NULL,
    `Project_Manager` VARCHAR(45),
    `Project_Team_Members` VARCHAR(45),
    `Add_Comments` VARCHAR(75)
     )

SELECT * FROM tms.new_project;







