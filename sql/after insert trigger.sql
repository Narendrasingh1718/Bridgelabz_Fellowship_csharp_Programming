CREATE TRIGGER trg_LogInsert
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeLog (EmpId, Action)
    SELECT Id, 'Inserted'
    FROM INSERTED;
END;