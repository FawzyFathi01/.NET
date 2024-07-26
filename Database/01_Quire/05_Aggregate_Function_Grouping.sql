-- #Aggregate Function_ Grouping_ Union_ Subqueries
-- (select ... where ... group by ... having) 
-- Aggregate Function ==> Not Alow Null 
-- if use Aggr_Fun ==> groub by on other column 
-- (where with Aggr_Fun) affect on Rows 
-- (having with Aggr_Fun) affect on Groups 
-- use group by with daplucte value Not use with (*,PK)

-- SubQuire with DML 

-- Union all, union => (order and remove dabluction), intersection => Share and ( order and remove dabluction), 
-- Continue:-  except (find it first and not found in secend and ( order and remove dabluction))

select MAX (e.Salary) , e.Dno
from Employee e
where e.Salary >1800
group by e.Dno;

select SUM (e.Salary), e.Dno , d.Dname
from Employee e , Departments d
where e.Dno = d.Dnum
group by e.Dno , d.Dname


















