-- # DDL (Create - Alter - Drop ) [✔]
-- Stop Video (2:42 h)
-- More Example (ALTER TABLE ... ALTER ,ALTER TABLE ... DROP) 
/*
ALTER TABLE ... ADD: Adds a new column to an existing table.
ALTER TABLE ... ALTER: Modifies an existing column in a table.
ALTER TABLE ... DROP: Removes a column from an existing table.
*/

/*
Primary Key: Ensures unique identification of rows.
Foreign Key: Establishes relationships between tables.
Default Values: Provides default values for columns.
Check Constraint: Ensures data integrity.
Composite Primary Key: Uses multiple columns for the primary key.
Identity Column: Automatically generates unique values.
Various Data Types: Uses different data types as needed.
Multiple Constraints: Combines various constraints in one table.
Computed Column: Creates columns calculated from other columns.
*/

-- CREATE 

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







-- Add Constrain 

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
	


-- # DML (inseart - Update - Delete) []
-- # DQL (Select) []

