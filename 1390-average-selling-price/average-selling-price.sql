SELECT 
    p.product_id, 
    COALESCE(
        ROUND(
            SUM(CAST(u.units * p.price AS FLOAT)) 
            / SUM(u.units)
        ,2),0) AS average_price
FROM Prices p
LEFT JOIN UnitsSold u
    ON u.product_id = p.product_id 
    AND u.purchase_date BETWEEN p.start_date AND p.end_date
GROUP BY p.product_id;

/*ans:
WITH CTE AS (
    SELECT 
        A.PRODUCT_ID,
        A.PRICE,
        B.UNITS
    FROM PRICES A
    LEFT JOIN UNITSSOLD B 
        ON A.PRODUCT_ID = B.PRODUCT_ID
        AND B.PURCHASE_DATE BETWEEN A.START_DATE AND A.END_DATE
),
Aggregated AS (
    SELECT 
        PRODUCT_ID,
        SUM(ISNULL(PRICE, 0) * ISNULL(UNITS, 0)) AS Total_price,
        SUM(ISNULL(UNITS, 0)) AS Total_units
    FROM CTE
    GROUP BY PRODUCT_ID
)
SELECT 
    PRODUCT_ID,
    CASE 
        WHEN Total_units = 0 THEN 0 
        ELSE ROUND(CAST(Total_price AS FLOAT) / Total_units, 2)
    END AS AVERAGE_PRICE
FROM Aggregated;
*/