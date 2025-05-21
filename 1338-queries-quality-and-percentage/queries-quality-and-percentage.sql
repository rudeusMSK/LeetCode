select
query_name,
convert(numeric(10,2),sum((rating*1.0/position))/count(*)) quality,
convert(numeric(10,2),sum(case when rating < 3 then 1.0 else 0.0 end)/count(query_name)*100.0) poor_query_percentage
from Queries
group by query_name

-- select 
-- query_name,
-- round(avg(rating*1.0/position),2) quality,
-- round(sum(case when rating <3 then 1 else 0 end)*100.0/count(*),2) poor_query_percentage
-- from Queries
-- group by query_name
