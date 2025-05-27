Select convert(varchar(7),trans_date, 120) AS month,
        country,
        count(state) as trans_count,
        sum(case when state = 'approved' then 1 else 0 end) approved_count,
        sum(amount) as trans_total_amount,
        sum(case when state = 'approved' then amount else 0 end) approved_total_amount

from transactions
group by convert(varchar(7),trans_date, 120), country
order by convert(varchar(7),trans_date, 120) asc, country desc

/*ans*/
-- select left(convert(varchar, trans_date), 7) as month, 
--     country, 
--     count(id) as trans_count, 
--     count(case when state = 'approved' then id else Null end) as approved_count,
--     sum(amount) as trans_total_amount,
--     sum(case when state = 'approved' then amount else 0 end) as approved_total_amount
-- from Transactions
-- group by left(convert(varchar, trans_date), 7) , country;