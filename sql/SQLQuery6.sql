--output paramter
create procedure output
@count int output
As
Begin
select count(*) from employee;
end
