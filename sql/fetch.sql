--select * from students
--select * from courses
--select * from students where Status='Active';
-- SELECT s.StudentId, s.StudentName, c.CourseName FROM Students s INNER JOIN Enrollments e ON s.StudentId = e.StudentId INNER JOIN Courses c ON e.CourseId = c.CourseId;
--SELECT s.StudentId, s.StudentName FROM Students s LEFT JOIN Enrollments e ON s.StudentId = e.StudentId WHERE e.StudentId IS NULL;
/*SELECT s.StudentName, STRING_AGG(c.CourseName, ', ') AS Courses
FROM Students s
JOIN Enrollments e ON s.StudentId = e.StudentId
JOIN Courses c ON e.CourseId = c.CourseId
GROUP BY s.StudentName;*/

SELECT TOP 2 CourseId, CourseName, CourseDuration, CourseFee, FacultyName
FROM Courses
ORDER BY CourseFee ASC;
SELECT *
FROM (
    SELECT *, RANK() OVER (ORDER BY CourseFee DESC) AS rnk
    FROM Courses
) t
WHERE rnk <= 2;