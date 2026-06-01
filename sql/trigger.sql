--trigger
Alter trigger enroll
on students
AFTER INSERT
AS
BEGIN
 print 'Enrollment Successful ';
END

CREATE TRIGGER Del 
ON students 
INSTEAD OF DELETE
AS 
BEGIN 
IF EXISTS ( SELECT 1 FROM Enrollments e JOIN deleted d ON e.StudentId=d.StudentId ) 
BEGIN 
PRINT 'Cannot delete student with enrollment'; 
END 
ELSE 
BEGIN DELETE FROM Students WHERE StudentId IN (SELECT StudentId FROM deleted); 
END
END;
