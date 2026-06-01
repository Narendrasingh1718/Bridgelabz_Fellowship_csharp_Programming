create trigger tr_After 
on Employees
After insert
As
Begin 
 print 'data inserted'
End;