CREATE TABLE [dbo].[Sale]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EntryDate] DATETIME NOT NULL DEFAULT GetUtcDate(), 
    [StateCode] NVARCHAR(2) NOT NULL, 
    [SaleAmount] MONEY NOT NULL, 
    [TaxRate] DECIMAL(5, 4) NOT NULL, 
    [TaxAmount] As SaleAmount * TaxRate PERSISTED
	  
)
