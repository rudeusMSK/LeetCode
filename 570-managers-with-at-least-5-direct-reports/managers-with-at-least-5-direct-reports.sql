/* Write your T-SQL query statement below */
SELECT      e1.name 
FROM        Employee e1
JOIN        Employee e2
ON          e1.id = e2.managerId
GROUP BY    e1.id, e1.name
HAVING      COUNT(e1.id) >= 5;

/*Ans
select 
    e1.name
from
    employee e1
    inner join
    (select 
        managerId,
        count(managerId) as report
    from 
        employee
    group by 
        managerId
    ) as e2
    on
    e1.id = e2.managerid

where e2.report >= 5
*/