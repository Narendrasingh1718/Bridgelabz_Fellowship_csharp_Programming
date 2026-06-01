-- procedure
CREATE PROCEDURE AddStudent
    @StudentName VARCHAR(100),
    @Email VARCHAR(100),
    @Phone VARCHAR(15),
    @Department VARCHAR(50)
AS
BEGIN
    INSERT INTO Students (StudentName, Email, Phone, Department, Status)
    VALUES (@StudentName, @Email, @Phone, @Department, 'Active');
END;


CREATE PROCEDURE EnrollStudent
    @StudentId INT,
    @CourseId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentId = @StudentId)
    BEGIN
        PRINT 'Student does not exist';
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM Courses WHERE CourseId = @CourseId)
    BEGIN
        PRINT 'Course does not exist';
        RETURN;
    END
    IF EXISTS (
        SELECT 1 FROM Enrollments 
        WHERE StudentId = @StudentId AND CourseId = @CourseId
    )
    BEGIN
        PRINT 'Student already enrolled in this course';
        RETURN;
    END
    INSERT INTO Enrollments (StudentId, CourseId, Status)
    VALUES (@StudentId, @CourseId, 'Active');

    PRINT 'Enrollment successful';
END;