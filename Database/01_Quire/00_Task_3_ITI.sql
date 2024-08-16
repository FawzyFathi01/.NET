--#Part_1
--DQL
--1.[✔]	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pnumber,p.Pname , SUM(w.Hours) as toutal_hour
from Project p , Works_for w
where p.Pnumber = w.Pno
group by p.Pname,p.Pnumber
order by 1; 

--2.[✔]Display the data of the department which has the smallest employee ID over all employees' ID.
select e.SSN, d.*
from Departments d , Employee e 
where d.Dnum = e.Dno and e.SSN = ( select Min(SSN)from Employee);

--3.[✔]For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname , min(e.Salary) , max (e.Salary) , AVG (e.Salary)
from Departments d , Employee e 
group by d.Dname;



--#Part_2
--4.[✔]Try to get the max 2 salaries using subquery
SELECT TOP 2 E.Salary ,CONCAT(E.Fname , ' ',E.Lname )AS NAME 
FROM Employee E
ORDER BY Salary DESC;
--5.[✔]Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 1000 
UPDATE Employee 
SET Salary += 1000
WHERE SSN IN (
SELECT ESSn
FROM Works_for W , Project P
WHERE W.Pno = P.Pnumber AND P.Pname = 'Al Rabwah');
--6.[✔]Display the employee number and name if at least one of them have dependents
-- (use exists keyword) self-study.
-- USING SUBQUIRE
SELECT E.SSN , CONCAT( E.Fname,' ',E.Lname) AS NAME 
FROM Employee E
WHERE E.SSN IN (SELECT DISTINCT D.ESSN 
FROM Dependent D);


--#Part_3 still 10 Quire 
--7.	Display (Using Union Function)
--a.[]The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--b.[]And the male dependence that depends on Male Employee.


--8.[✔]List the last name of all managers(SuperVisor) who have no dependents.(WRONG IN THIS QUIRY)
/*
manager [emp have name ]---> department As No Dependent 
*/

select distinct x.Fname + ' ' + x.Lname as SuperName 
from Employee x
inner join Employee y on y.Superssn = x.SSN
where y.Superssn not in (select d.ESSN from dependent d );


--9.[X]For each department-- if its average salary is less than the average salary of all employees
-- display its number, name and number of its employees.
-- Important 
/*
-- Display ==> (number , name) Department & CountEmployee 
-- avg salary department < avg salary for all emp 
*/


--10.[]Retrieve a list of employees and the projects they are working on ordered by department
-- and within each department, ordered alphabetically by last name, first name.


--11.[]Get the full name of employees that is similar to any dependent name


--DML
--1.	In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
--2.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--a.	First try to update her record in the department table
--b.	Update your record to be department 20 manager.
--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
--3.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

