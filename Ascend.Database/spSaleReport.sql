 

-- =============================================
-- Author:		Doug Reuter
-- Create date: 2/16/2017
-- Description:	Sales Report
-- Ordered by descending entry date time
-- Output format – Entry Date, State Code, Sale Amount, Tax Amount, Sale Total
-- Use currency formatting and date format (dd/mm/yyyy hh:mm), no need to focus on lining up output columns at this point
-- =============================================
CREATE PROCEDURE spSaleReport
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        
		EntryDate as [Entry Date], 
		StateCode as [State Code], 
		SaleAmount [Sale Amount], 
		TaxAmount  as [Tax Amount], 
		SaleAmount + TaxAmount  as [Sale Total]
	FROM  Sale
	ORDER BY EntryDate DESC


END
GO
