Select query_name, 
round(AVG(rating*1.0/position),2) AS quality,
Round(sum(case when rating <3 then 1 else 0 end)*100.0/count(query_name) ,2) as poor_query_percentage 
from Queries 
Group by query_name
Order BY quality desc
