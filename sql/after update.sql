CREATE TRIGGER trg_SalaryUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeLog (EmpId, Action)
    SELECT Id, 'Salary Updated'
    FROM INSERTED;
END;