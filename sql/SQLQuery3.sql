--parameter store procedure
/*create procedure GetEmpById(
@id int
)
As
begin
 select * from employee where employee_id =@id;
end*/
--by passing two parameter
/*create procedure GetEmp(
@id int= 2 ,
@job varchar(50)
)
AS
Begin
select * from employee where employee_id=@id and job_title=@job;
end;*/
--while example

DECLARE @counter int =1;
while @counter <=3
Begin
select * from employee ;
 set @counter=@counter+1
end

