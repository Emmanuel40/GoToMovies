SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId]) VALUES (1, 'John Smith','True', 1)
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId]) VALUES (2, 'Mary Williams','False', 2)

SET IDENTITY_INSERT [dbo].[Customers] OFF
