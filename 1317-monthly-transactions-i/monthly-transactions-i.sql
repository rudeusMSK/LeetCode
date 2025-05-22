SELECT LEFT(trans_date ,7) as month,country ,count(id) trans_count ,
  COUNT(case when state ='approved' then 1 else null end) as approved_count,
        SUM(amount) as trans_total_amount,
        SUM(case when state='approved' then amount else 0 end) as approved_total_amount
FROM Transactions 
GROUP BY LEFT(trans_date ,7),country 