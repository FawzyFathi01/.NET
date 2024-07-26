--#Part_1
--DQL
--1.	Display (Using Union Function)
--a.[]The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--b.[]And the male dependence that depends on Male Employee.

--2.[✔]	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pnumber,p.Pname , SUM(w.Hours) as toutal_hour
from Project p , Works_for w
where p.Pnumber = w.Pno
group by p.Pname,p.Pnumber
order by 1;

--3.[✔]Display the data of the department which has the smallest employee ID over all employees' ID.
select e.SSN, d.*
from Departments d , Employee e 
where d.Dnum = e.Dno and e.SSN = ( select Min(SSN)from Employee);

--4.[✔]For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname , min(e.Salary) , max (e.Salary) , AVG (e.Salary)
from Departments d , Employee e 
group by d.Dname;

--5.[X]List the last name of all managers who have no dependents.(WRONG IN THIS QUIRY)
select e.Fname + ' ' + e.Lname as ManagerName
from Departments d INNER JOIN  Employee e 
ON e.SSN = d.MGRSSN
INNER JOIN Dependent de
ON e.SSN = de.ESSN
where d.MGRSSN IN ( SELECT SSN from Employee where SSN NOT IN (select distinct ESSN from Dependent));


--#Part_2
--6.[]For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
--7.	Retrieve a list of employees and the projects they are working on ordered by department and within each department, ordered alphabetically by last name, first name.
--8.	Try to get the max 2 salaries using subquery
--9.	Get the full name of employees that is similar to any dependent name
--10.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
--11.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
--DML
--1.	In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
--2.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--a.	First try to update her record in the department table
--b.	Update your record to be department 20 manager.
--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
--3.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

