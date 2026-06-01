INSERT INTO Students (StudentName, Email, Phone, Department, Status)
VALUES
('Rahul', 'rahul01@gmail.com', '9876500001', 'IT', 'Active'),
('Amit', 'amit01@gmail.com', '9876500002', 'CS', 'Active'),
('Neha', 'neha01@gmail.com', '9876500003', 'IT', 'Inactive'),
('Priya', 'priya01@gmail.com', '9876500004', 'ECE', 'Active'),
('Rohit', 'rohit01@gmail.com', '9876500005', 'ME', 'Active'),
('Anjali', 'anjali01@gmail.com', '9876500006', 'CS', 'Inactive'),
('Vikas', 'vikas01@gmail.com', '9876500007', 'IT', 'Active'),
('Sneha', 'sneha01@gmail.com', '9876500008', 'ECE', 'Active'),
('Karan', 'karan01@gmail.com', '9876500009', 'ME', 'Inactive'),
('Pooja', 'pooja01@gmail.com', '9876500010', 'CS', 'Active');
INSERT INTO Courses (CourseName, CourseDuration, CourseFee, FacultyName)
VALUES
('SQL Server', '3 Months', 5000, 'Rakesh'),
('Python', '4 Months', 6000, 'Suman'),
('Java', '5 Months', 7000, 'Deepak'),
('Web Development', '6 Months', 8000, 'Imran'),
('Data Science', '6 Months', 10000, 'Kavita');
INSERT INTO Enrollments (StudentId, CourseId, Status)
VALUES
(1, 1, 'Active'),
(1, 2, 'Active'),
(2, 1, 'Active'),
(2, 3, 'Active'),
(3, 2, 'Inactive'),
(4, 4, 'Active'),
(5, 5, 'Active'),
(6, 3, 'Inactive'),
(7, 1, 'Active'),
(7, 5, 'Active'),
(8, 4, 'Active'),
(9, 2, 'Inactive'),
(10, 3, 'Active'),
(10, 5, 'Active'),
(5, 2, 'Active');