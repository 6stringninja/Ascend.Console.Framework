 
 
-- =============================================
-- Author:		Doug Reuter
-- Create date: 2/16/2017
-- Description:	General Insert
-- =============================================
CREATE PROCEDURE spSaleInsert
 
 @StateCode nvarchar(2),
 @SaleAmount money,
 @TaxRate decimal(5,4)  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	INSERT INTO [Sale] 
		(StateCode,	SaleAmount,	TaxRate)
	VALUES     
		(@StateCode, @SaleAmount, @TaxRate)
 
	 



END
GO
