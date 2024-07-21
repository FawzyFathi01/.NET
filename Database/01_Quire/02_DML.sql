-- # DML (INSERT - UPDATE - DELETE ) []
use Company
-- INSERT INTO  
SELECT * FROM Emp;

INSERT INTO Emp (SSN ,FName,LName, Gender,Age,Salary)
VALUES 
	  (8,'GEHAD','MOHAMED','FEMALE',24,7000),
	  (9,'SOHAILA','ELBADAWY','FEMALE',19,8000);

EXEC sp_rename 'Departmant', 'Department';


INSERT INTO Department (DNum,DName,Hiring_date,SSN)
VALUES 
	  (101,'CS',GETDATE(),1),
	  (102,'IT',GETDATE(),7),
	  (103,'IS',GETDATE(),1),
	  (104,'OR',GETDATE(),4);



INSERT INTO Depart_Location (DNum,Location)
VALUES 
      (101,'GAIRO'),
	  (101,'MENOFIA'),
	  (101,'GEZA'),
	  (102,'ALEX'),
	  (102,'CAIRO');

INSERT INTO Dependent(SSN,Name,Gender,Birth_date)
VALUES 
      (1,'MOUSA','MALE','10-10-2000'),
	  (1,'MONA','FEMALE','1-1-1999');
	  

INSERT INTO Project(PNum,PName,PCity,DNum)
VALUES 
	  (701,'WEB APP','CAIRO',101),
	  (702,'MOBILE APP','ALEX',102);


INSERT INTO Emp_Project(SSN,PNum,WorkingHours)
VALUES 
	  (2,701,8),
	  (5,701,8),
	  (3,702,8),
	  (6,702,8),
	  (8,702,8);
/*
Modify existing data in a table.
UPDATE table_name
SET column1 = value1, column2 = value2, ...
WHERE condition;
*/

/*
DELETE ROW
DELETE FROM table_name
WHERE condition;
*/


/*
Delete All Rows:
DELETE FROM Employees; 
*/
