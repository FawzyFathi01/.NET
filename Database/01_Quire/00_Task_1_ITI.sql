--[✔] 1.Display all the employees Data.
SELECT * 
FROM Employee;
--[✔] 2.Display the employee First name, last name, Salary and Department number.
select Fname , Lname , Dno ,Salary
from Employee;
--[✔] 3.Display all the projects names, locations and the department which is responsible about it.
SELECT P.Pname , P.Plocation , D.Dname,E.Fname + ' ' + E.Lname AS FULLNAME
FROM Project P , Departments D , Employee E
WHERE E.SSN = D.MGRSSN AND P.Dnum = D.Dnum;
--[✔] 4.Display the employees Id, name who earns more than 1000 LE monthly.
SELECT E.SSN , E.Fname + ' ' + E.Lname AS FULLNAME , E.Salary 
FROM Employee E 
WHERE E.Salary >= 1000;
--[✔] 5.Display the employees Id, name who earns more than 10000 LE annually.
SELECT E.SSN , E.Fname + ' ' + E.Lname AS FULLNAME , E.Salary*12 AS  SalaryAnnually
FROM Employee E 
WHERE (E.Salary*12) >= 10000;
--[✔] 6.Display the names and salaries of the female employees 
SELECT E.Fname
FROM Employee E
WHERE E.Sex = 'F';
--[X] 7.Display each department id, name which managed by a manager with id equals 968574.
-- ERROR FIXED LATER 
SELECT E.SSN , E.Fname + ' ' + E.Lname FULLNAME
FROM Employee E , Departments D 
WHERE D.MGRSSN = E.SSN AND D.Dnum =  (SELECT D.Dnum FROM Departments WHERE D.MGRSSN = 968574);
--[✔] 8.Dispaly the ids, names and locations of  the pojects which controled with department 10.
SELECT P.Pnumber , P.Pname , P.Plocation 
FROM Project P 
WHERE P.Dnum = 10;