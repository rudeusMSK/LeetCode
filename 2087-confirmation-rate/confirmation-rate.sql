SELECT
    s.user_id,
    ROUND(
        AVG(
            CASE 
                WHEN c.action = 'confirmed' THEN 1.00
                ELSE 0
            END
        ),
        2
    ) confirmation_rate
FROM
    Signups s
LEFT JOIN
    Confirmations c
    ON
    s.user_id = c.user_id
GROUP BY
    s.user_id

/*ans:
SELECT
    s.user_id,
    ROUND(
        AVG(
            IF(c.action = 'confirmed', 1.00, 0)
        ), 
        2
    ) confirmation_rate
FROM
    Signups s
LEFT JOIN
    Confirmations c
    ON
    s.user_id = c.user_id
GROUP BY
    s.user_id

    ////////////sample performance/////////////
    SELECT s.user_id, 
       ROUND(
           COALESCE(SUM(CASE WHEN c.action = 'confirmed' THEN 1 ELSE 0 END) * 1.0 / 
           NULLIF(COUNT(c.user_id), 0), 0), 
       2) AS confirmation_rate
FROM Signups s
LEFT JOIN Confirmations c 
ON s.user_id = c.user_id
GROUP BY s.user_id
ORDER BY s.user_id;
*/