--variable
/*Declare @id int;
set @id=2;
select * from employee where employee_id=@id;*/
--store qwery in variable
/*Declare @result int;
set @result= (select count(*) from employee);
select @result;*/
-- selecting record into variable
declare @id int ,
@name varchar(50);
select @id=employee_id,@name=first_name from employee where job_title='HR';
select @id,@name ;