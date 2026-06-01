--if_else block
create procedure ifelse
@id int
AS
Begin
if @id=2
Begin
 select * from employee where employee_id=@id;
end
else
begin
select * from employee;
end
end;