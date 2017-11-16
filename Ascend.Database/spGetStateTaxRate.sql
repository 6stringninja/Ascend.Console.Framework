CREATE PROCEDURE [dbo].[spGetStateTaxRate]
 
	@statecode nvarchar(2),
	@defaultTaxRate decimal(5,4)
	 
AS
 Declare @isdefault  bit = 1;
	SELECT @defaultTaxRate = TaxRate , @isdefault = 0
	from [dbo].[StateTaxRate] where [dbo].[StateTaxRate].StateCode = @statecode
	select @defaultTaxRate TaxRate, @isdefault IsDefault
RETURN 0
