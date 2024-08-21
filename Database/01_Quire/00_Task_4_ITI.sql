-- # PART_1
--[✔]1.Retrieve number of students who have a value in their age. 
SELECT COUNT (S.St_Id) 
FROM Student S
WHERE S.St_Age IS NOT NULL ;

--[✔]2.Get all instructors Names without repetition
SELECT DISTINCT I.Ins_Name 
FROM Instructor I;

--[✔]3.Display student with the following Format (use isNull function)
--Student ID	Student Full Name	Department name	

SELECT S.St_Id AS [STUDENT ID] ,CONCAT (S.St_Fname,' ',S.St_Lname) AS [FULL NAME] ,ISNULL(S.Dept_Id,0) AS [DEPARTMANT NAME] 
FROM Student S;

--[✔]4.Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not

SELECT I.Ins_Name , D.Dept_Name
FROM Instructor I , Department D
WHERE I.Dept_Id = D.Dept_Id;

--[✔]5.Display student full name and the name of the course he is taking
--For only courses which have a grade  
SELECT S.St_Id,CONCAT( S.St_Fname,' ',S.St_Lname) AS FULL_NAME,C.Crs_Name,SC.Grade
FROM Student S,Course C,Stud_Course SC
WHERE SC.St_Id = S.St_Id AND C.Crs_Id = SC.Crs_Id
ORDER BY 1;

--[✔]6.Display number of courses for each topic name

SELECT T.Top_Id, T.Top_Name , COUNT (C.Crs_Id)
FROM Topic T , Course C
WHERE T.Top_Id = C.Top_Id
GROUP BY T.Top_Id,T.Top_Name;

--[✔]7.Display max and min salary for instructors
SELECT MIN (I.Salary),MAX(I.Salary)
FROM Instructor I;


-- # PART_2
--[]8.Display instructors who have salaries less than the average salary of all instructors.
--[]9.Display the Department name that contains the instructor who receives the minimum salary.
--[]10. Select max two salaries in instructor table. 
--[]11. Select instructor name and his salary but if there is no salary display instructor bonus. “use one of coalesce Function”
--[]12.Select Average Salary for instructors 
--[]13.Select Student first name and the data of his supervisor 
--[]14.Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
--[]15. Write a query to select a random  student from each department.  “using one of Ranking Functions”