/*QUERY JOIN TABLE:
SELECT a1.machine_id, a1.timestamp, a2.timestamp
FROM Activity a1
JOIN Activity a2
ON a1.process_id = a2.process_id
AND a1.machine_id = a2.machine_id
AND a1.timestamp < a2.timestamp;
 */

 /*ADD CONDITION: */
 SELECT a1.machine_id, 
 ROUND(AVG(a2.timestamp - a1.timestamp),3) as processing_time
FROM Activity a1
JOIN Activity a2
ON a1.process_id = a2.process_id
AND a1.machine_id = a2.machine_id
AND a1.timestamp < a2.timestamp
GROUP BY a1.machine_id;

/*Ans:
select machine_id,Convert(decimal(10,3),avg(m)) as processing_time 
from (
select machine_id, Sum(iif(activity_type='end',[timestamp],-[timestamp])) as m from Activity group by machine_id,process_id  ) as tbl group by machine_id 
 */