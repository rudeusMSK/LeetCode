/* Ans */
WITH cte AS (
    SELECT
        customer_id,
        order_date,
        RANK() OVER (PARTITION BY customer_id ORDER BY order_date) AS r,
        customer_pref_delivery_date
    FROM
        Delivery
)
SELECT
    ROUND(
        CAST(100*COUNT(CASE WHEN order_date = customer_pref_delivery_date THEN 1 END) AS decimal) /
        CAST(COUNT(customer_id) AS decimal),
    2) AS immediate_percentage
FROM
    cte
WHERE r = 1;

/*Ans*/
-- WITH FirstOrders AS (
--     SELECT *,
--            ROW_NUMBER() OVER (PARTITION BY customer_id ORDER BY order_date ASC) AS rn
--     FROM delivery
-- )

-- select round((cast(count(*) as decimal) / Cast((select count(customer_id) from FirstOrders WHERE rn = 1) as decimal)) * 100, 2) as immediate_percentage
-- from FirstOrders
-- where order_date = customer_pref_delivery_date and rn = 1