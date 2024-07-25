--1.	Display the Department id, name and id and the name of its manager.
select d.Dnum , d.Dname ,concat (e.Fname,' ' , e.Lname) as FullName , e.SSN 
from Employee e , Departments d
where e.SSN = d.MGRSSN;

select * from Employee;
select * from Departments;


--2.	Display the name of the departments and the name of the projects under its control.
select d.Dname , p.Pname
from Departments d , Project p 
where d.Dnum = p.Dnum
order by 1;

--3 Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select  concat (e.Fname,' ' , e.Lname) as FullName,d.*
from Employee e, Dependent d
where e.SSN = d.ESSN;

--4.Display the Id, name and location of the projects in Cairo or Alex city.
select p.Pnumber , p.Pname , p.Plocation
from Project p
where p.City in ('Cairo' , 'Alex')

select * from Project;


--5.Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project p 
where p.Pname like 'a%';

select * from Project


--6.Display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select  concat (e.Fname,' ' , e.Lname) as FullName
from Employee e 
where e.Dno = 30 and (e.Salary >= 1000 and e.Salary <=2000);

select * from Employee;

--7.Retrieve the names of all employees in department 10 who works more than or equal 10 hours per week on "AL Rabwah" project.

select  concat (e.Fname,' ' , e.Lname) as FullName , w.Hours , p.Pname
from Employee e , Works_for w , Project p 
where e.SSN = w.ESSn and w.Pno = p.Pnumber and ( e.Dno = 10 and p.Pname = 'AL Rabwah' and w.Hours >= 10);

--8.Find the names of the employees who directly supervised with Kamel Mohamed.
select	concat (y.Fname,' ' , y.Lname) as SuperName , concat (x.Fname,' ' , x.Lname) as EmpName 
from Employee x , Employee y  
where y.SSN = x.Superssn and y.Fname ='Kamel' and y.Lname = 'Mohamed'
order by 1;

--9.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select concat (e.Fname,' ' , e.Lname) as EmpName , p.Pname
from Employee e , Project p , Works_for w 
where e.SSN = w.ESSn and w.Pno = p.Pnumber
order by 2;


--10.For each project located in Cairo City , find the project number, the controlling department name
--,the department manager last name ,address and birthdate.

-- Solve this ==> ???????????????????


--11.Display All Data of the mangers
select * 
from Employee e
where e.SSN in (select d.MGRSSN from Departments d )


--12.Display All Employees data and the data of their dependents even if they have no dependents
select e.* , d.*
from Employee e left outer join Dependent d 
on e.SSN = d.ESSN;


-- Solve this ==> ???????????????????
--Data Manipulating Language:
--1.Insert your personal data to the employee table as a new employee in department number 30,
--SSN = 102672, Superssn = 112233, salary=3000.
--2.Insert another employee with personal data your friend as new employee in department number30,
--SSN = 102660, but don’t enter any value for salary or manager number to him.
--3.Upgrade your salary by 20 % of its last value.
