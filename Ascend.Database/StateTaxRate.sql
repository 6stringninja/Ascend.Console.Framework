CREATE TABLE [dbo].[StateTaxRate]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[StateCode] NVARCHAR(2) NOT NULL, 
	[TaxRate] DECIMAL(5, 4) NOT NULL, 
	 CONSTRAINT [CK_StateTaxRate_StateCodeIsUpper2CharsOrDefault] CHECK (UPPER([StateCode]) = [StateCode] collate Latin1_General_BIN2 AND  LEN([StateCode]) = 2 ) 
)

GO

CREATE UNIQUE INDEX [IX_StateTaxRate_UniqueStates] ON [dbo].[StateTaxRate] ([StateCode])
