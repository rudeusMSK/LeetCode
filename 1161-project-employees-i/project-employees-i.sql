-- SELECT p.project_id, ROUND(AVG(CAST(experience_years as DECIMAL(10,2))) ,2) AS average_years
-- FROM Project p
-- INNER JOIN Employee e
-- ON p.employee_id = e.employee_id
-- GROUP BY p.project_id

-- ---------- Ans No.1 ------------- --

SELECT p.project_id, ROUND(SUM(e.experience_years) * 1.0 /COUNT(p.employee_id), 2) average_years 
FROM Employee e
JOIN Project p
    ON e.employee_id = p.employee_id
GROUP BY p.project_id
