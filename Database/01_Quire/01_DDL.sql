-- # DDL (CREATE - ALTER - DROP - TRUNCATE) [✔]
-- DDL :- DDL stands for Data Definition Language.
-- It is a subset of SQL used to define and manage database objects such as tables, indexes, and constraints.
-- DDL statements are used to create, modify, and delete these objects within a database.

-- [A.CREATE] 
-- CREATE DATABASE {CREATE DATABASE <DATABASE_NAME>} 
-- CREATE TABLE  WHIT (PRIMARY KEY , NOT NULL)

CREATE TABLE TEST_EMP (
TID INT PRIMARY KEY,
TNAME VARCHAR (20) NOT NULL,
TAGE TINYINT,
TADDRESS VARCHAR (40)
);

CREATE TABLE TEST_DEPARTMENT (
DNUM INT PRIMARY KEY,
DNAME VARCHAR(10) NOT NULL,
TESTID INT,
);

CREATE TABLE TEST_DEPART_LOCATION(
DID INT NOT NULL, 
LOCATION VARCHAR (10) NOT NULL,
)




-- [B.ALTER]
-- MODIFY DATA TYPE AND SIZE OF COLUMN , MODIFY (NULL , NOT NULL )
-- ADD, DROP COLUMN
-- ADD, DROP CONSTRIANT (CHAECK, DEFAULT, UNIQUE) , (PRIMARY, FOREIGN, COMPOSITE) KEYS
-- TO CHANGE NAME TABLE OR COLUMN 


--CHANGE DATA TYPE , NOT NULL
ALTER TABLE TEST
ALTER COLUMN TNAME VARCHAR (50) NOT NULL;

ALTER TABLE TEST
ALTER COLUMN TAGE TINYINT;

-- ADD , DROP COLUMN
ALTER TABLE TEST
ADD GENDER VARCHAR (10);

ALTER TABLE TEST 
ADD COUNTRY VARCHAR (20);

ALTER TABLE TEST
ADD EMAIL VARCHAR(30);


ALTER TABLE TEST 
DROP COLUMN TADDRESS;



-- CONSTRAINT DEFUALT , CHECK , UNIQUE 


ALTER TABLE TEST 
ADD CONSTRAINT CH_SALARY CHECK (SALARY >= 1000);

ALTER TABLE TEST 
ADD CONSTRAINT DEF_COUNTRY DEFAULT 'EGY' FOR COUNTRY;

ALTER TABLE TEST
ADD CONSTRAINT UNIQUE_EMAIL UNIQUE (EMAIL)

ALTER TABLE TEST 
DROP CONSTRAINT CH_SALARY;


-- CONSTRAINT FOREIGN , PRIMARY , COMPOSITE KEY 

ALTER TABLE TEST 
ADD CONSTRAINT PK_TEST PRIMARY KEY (TID);

ALTER TABLE TEST_DEPART_LOCATION
ADD CONSTRAINT COM_PK PRIMARY KEY (DID,LOCATION);


ALTER TABLE TEST_DEPARTMENT
ADD CONSTRAINT FK_TEST_DEPARTMENT FOREIGN KEY (TESTID) REFERENCES TEST (TID);


ALTER TABLE TEST_DEPART_LOCATION
ADD CONSTRAINT FK_DEPART FOREIGN KEY (DID) REFERENCES TEST_DEPARTMENT (DNUM);





-- [C.DROP] 
-- TO DROP TABLE, DATABASE  [DROP TABLE <TN>] , [DROP DATABASE <TD>]

-- [D.TRUNCATE]
-- TO remove all records from a table [TRUNCATE TABLE <TN>]

-- [E.RENAME]
--  to rename database objects [EXEC sp_rename 'old_name', 'new_name']



-- //////////////////////////////////// FINISH EXPALIN DDL ///////////////////////////////////////////////////////////////// 

-- CREATE 
Use Company

CREATE TABLE Emp (
SSN int Primary key,
Gender varchar(10),
FName varchar(20) NOT NULL,
LName varchar(20) NOT NULL,
Birth_Date date Default getdate(),
DNum int, 
SuperId int,
);


CREATE TABLE Departmant (
DNum int Primary key ,
DName varchar (10) NOT NULL,
Hiring_date date ,
SSN int NOT NULL,
);


CREATE TABLE Depart_Location(
DNum int NOT NULL,
Location varchar (10) NOT NULL
);



CREATE TABLE Project (
PNum int Primary key,
PName varchar (10) NOT NULL,
PCity varchar (10) NOT NULL,
PLocation varchar (10),
DNum int
);



CREATE TABLE Emp_Project (
SSN int NOT NULL, 
PNum int NOT NULL,
WorkingHours int
);


CREATE TABLE Dependent (
SSN int NOT NULL, 
Name varchar (20) NOT NULL,
Gender varchar (10),
Birth_date date,
);



--#2 Add Constrain 

-- Add Constrain Foreign key (DNum ==> Work , Superid ==> supervisor) for Emp 
Alter Table Emp 
Add Constraint FK_Emp_Department foreign key (DNum) REFERENCES Departmant (DNum);

Alter Table Emp 
Add Constraint FK_Emp_Supervisor foreign key (SuperId) REFERENCES Emp (SSN);


-- Add Constrain Foreign key (SSN ==> Manage)
Alter Table Departmant 
Add Constraint FK_Manage_Emp_Departmant foreign key (SSN) REFERENCES Emp (SSN);

-- Add Constrain Composite key (DNum ==> MultiValued location)
ALTER TABLE Depart_Location
ADD CONSTRAINT pk_Depart_Location PRIMARY KEY (DNum, Location);


-- -- Add Constrain Foreign key (DNum ==> Work on Project)
Alter Table Project 
Add Constraint FK_PRoject_Department Foreign key (DNum) REFERENCES Departmant (DNum);


-- -- Add Constrain Foreign key (SSN ==> Work on Project) And ADD 2 Foreign key SSN , PNum
Alter Table Emp_Project 
Add Constraint PK_Emp_Project Primary Key (SSN,PNum);


Alter Table Emp_Project
Add Constraint FK_Emp Foreign key (SSN) REFERENCES Emp (SSN),
	Constraint FK_Project Foreign key (PNum) REFERENCES project (PNum);


-- -- Add Constrain Composite Key (SSN,Name ==> Weak Entity) And Add 2 Foreign key SSN , Name 
Alter Table Dependent
Add Constraint PK_Emp_Dependent Primary Key (SSN , Name);

Alter Table Dependent
Add Constraint FK_Emp_Dependent Foreign key (SSN) REFERENCES Emp (SSN);
	
-- Add Column to Emp (Age , Salary)
Alter Table Emp 
Add Age int,
	Salary int;

ALTER TABLE Emp
ALTER COLUMN Age int NOT NULL;

Alter Table Emp 
Alter Column Salary int NOT NULL;


ALTER TABLE EMP 
ADD CONSTRAINT CHECK_SALARY CHECK (SALARY > 0);


-- Drop the default constraint
ALTER TABLE Emp
DROP CONSTRAINT DF__Emp__Birth_Date__398D8EEE;

ALTER TABLE Emp
DROP COLUMN Birth_Date;



INSERT INTO Emp (SSN, FName , LName , Age , Salary,Gender)
VALUES 
		(1,'Fawzy','Fathi',25,8000,'Male'),
		(2,'Ali','AboElfutouh',40,20000,'Male'),
		(3,'Mohamed','Fathi',31,40000,'Male'),
		(4,'Mona','Mostafa',20,5000,'FeMale'),
		(5,'Eman','Fathi',26,3000,'FeMale'),
		(6,'Shrouk','Ali',19,1500,'FeMale'),
		(7,'Mostafa','Abdo',21,8000,'Male');


SELECT * FROM Emp;









