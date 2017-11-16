SET IDENTITY_INSERT [dbo].[StateTaxRate] ON
DELETE [dbo].[StateTaxRate]
INSERT INTO [dbo].[StateTaxRate] ([ID], [StateCode], [TaxRate]) VALUES (1, N'WI', CAST(0.0540 AS Decimal(5, 4)))
INSERT INTO [dbo].[StateTaxRate] ([ID], [StateCode], [TaxRate]) VALUES (2, N'NY', CAST(0.0760 AS Decimal(5, 4)))
INSERT INTO [dbo].[StateTaxRate] ([ID], [StateCode], [TaxRate]) VALUES (3, N'IL', CAST(0.0750 AS Decimal(5, 4)))
SET IDENTITY_INSERT [dbo].[StateTaxRate] OFF
