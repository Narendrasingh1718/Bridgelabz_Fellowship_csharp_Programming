CREATE TABLE Enrollments (
    EnrollmentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT,
    CourseId INT,
    EnrollmentDate DATE DEFAULT GETDATE(),
    Status VARCHAR(20),

    CONSTRAINT FK_Student
        FOREIGN KEY (StudentId) REFERENCES Students(StudentId),

    CONSTRAINT FK_Course
        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);