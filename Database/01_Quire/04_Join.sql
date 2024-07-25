-- Type Join 
-- 1- Cross Not use  
-- 2- Inner 
select e.Fname , d.Dname
from Employee e , Departments d
where e.Dno = d.Dnum;

-- 3- Outer (left , right , full)
select e.Fname , d.Dname
from Employee e left outer join  Departments d
on e.Dno = d.Dnum;

-- 4- self
select x.Fname as EmpName , y.Fname as SuperName 
from Employee x , Employee y 
where y.SSN = x.Superssn;

-- Multiple join - Join with DML(insert - updata - delete ) 

select concat (e.Fname,' ' , e.Lname) as FullName , p.Pname , w.Hours
from Employee e , Project p , Works_for w 
where p.Pnumber = w.Pno and w.ESSn = e.SSN;

-- IsNull (age , 'No data') , Coalesce (age , addres , 'No data') , Concat (FName," " ,LName,) , Convert ()
-- Like , _ one char / % one or more char  / [ahm] a or h or m 
-- continue ===> [^ahm] Not a,h,m / [a-h] range a--> h
-- order by 1 

