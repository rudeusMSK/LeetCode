/* Write your T-SQL query statement below */
select r.contest_id, round(count(r.user_id)*100.0/(select count(distinct u.user_id) from users u),2) as percentage
from register r
left join users u on u.user_id=r.user_id
group by contest_id
order by percentage desc, contest_id;


-- KEY TAKEAWAYS
--  1. SELECT CAN BE USED IN AN OPERATION AS A NESTED CLAUSE
-- 2. 100.0 MULTIPLICATION IS ALSO IMPORTANT AT THE RIGHT PLACE
-- 3. WHEN YOU FACE ANY TYPE OF DIFFICULTY IN FORMING AN OPERATION THEN A SELECT STATEMENT ON ITS OWN CAN BE USEFUL.
-- 4. HERE AS WELL WE CAN USE COUNT DISTINCT WITHOUT ANY SELECT NESTED STATEMENT BUT AGAIN WE HAVE JOINED THE TABLES IN THAT CASE
-- REMEMBER WHEN 2 TABLES ARE GIVEN ITS NOT NECESSARY TO JOIN THEM 