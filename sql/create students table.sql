CREATE TABLE Students (
    StudentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(15),
    Department VARCHAR(50),
    AdmissionDate DATE DEFAULT GETDATE(),
    Status VARCHAR(10) CHECK (Status IN ('Active', 'Inactive'))
);