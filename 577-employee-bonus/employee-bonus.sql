/* Write your T-SQL query statement below */
select e.name, b.bonus
from Employee e 
left join Bonus b
on b.empId = e.empId
where  b.bonus < 1000 OR b.bonus IS NULL