CREATE TABLE Courses (
    CourseId INT IDENTITY(1,1) PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    CourseDuration VARCHAR(50),
    CourseFee DECIMAL(10,2) CHECK (CourseFee > 0),
    FacultyName VARCHAR(100)
);