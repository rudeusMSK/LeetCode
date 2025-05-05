SELECT
    S.student_id
    ,S.student_name
    ,SU.subject_name
    ,COUNT(E.student_id) attended_exams

FROM Students S
CROSS JOIN Subjects SU
LEFT JOIN Examinations E
    ON S.student_id = E.student_id
    AND SU.subject_name = E.subject_name

GROUP BY S.student_id, S.student_name, SU.subject_name
ORDER BY S.student_id, S.student_name, SU.subject_name;

/*ans: 
WITH CTE AS(
SELECT * FROM STUDENTS
CROSS JOIN
SUBJECTS
)

SELECT A.STUDENT_ID, A.STUDENT_NAME, A.SUBJECT_NAME,  COUNT(B.SUBJECT_NAME) AS ATTENDED_EXAMS
FROM CTE A
LEFT OUTER JOIN EXAMINATIONS B
ON A.STUDENT_ID = B.STUDENT_ID
AND A.SUBJECT_NAME = B.SUBJECT_NAME
GROUP  BY A.STUDENT_ID, A.STUDENT_NAME, A.SUBJECT_NAME;
*/