select * 
from (
select *,ROW_NUMBER() over (order by salary) as RN
from Employee
where Salary is not null
) as NewTable 
where RN = 2;


select e.SSN , e.Fname , e.Salary,
	case 
	when e.Salary >= 2500 then 'high salary' 
	when e.Salary < 2500  then 'low'
	else 'invalid'
	end 
from Employee e
where e.Salary is not null
order by 3desc,4;

update Employee
set Salary = iif (salary >= 2500,salary*1.20,salary*1.10);




