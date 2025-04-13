/* Write your T-SQL query statement below */
Select c.name
from Customer c
where c.referee_id IS NULL OR c.referee_id <> 2;