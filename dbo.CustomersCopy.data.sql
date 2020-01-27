SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [Birthdate]) VALUES (0, N'John Doe', 1, 0, N'1989-06-04 00:00:00')
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [Birthdate]) VALUES (1, N'Mary Williams', 1, 1, N'1992-06-04 00:00:00')
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [Birthdate]) VALUES (2, N'Olatunji Odelade', 1, 2, N'1984-06-04 00:00:00')
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [Birthdate]) VALUES (3, N'Precious Nduka', 1, 2, N'1985-10-04 00:00:00')
INSERT INTO [dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsLetter], [MembershipTypeId], [Birthdate]) VALUES (4, N'Chika Iduma', 1, 3, N'1981-11-04 00:00:00')


SET IDENTITY_INSERT [dbo].[Customers] OFF
