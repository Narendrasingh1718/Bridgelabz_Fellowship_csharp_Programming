--try-catch
create procedure excep
@a int ,
@b int,
@result int output
AS
Begin
 Begin try
 set @result =@a /@b;
 end try
 begin catch
 SELECT  
            ERROR_NUMBER() AS ErrorNumber  
            ,ERROR_SEVERITY() AS ErrorSeverity  
            ,ERROR_STATE() AS ErrorState  
            ,ERROR_PROCEDURE() AS ErrorProcedure  
            ,ERROR_LINE() AS ErrorLine  
            ,ERROR_MESSAGE() AS ErrorMessage;  
 end catch
End