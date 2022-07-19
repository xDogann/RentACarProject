SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (2, 5, 1, N'Honda Civic', 2017, 2500, N'Double Motors Honda Civic')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (7, 4, 2, N'Ford Focus', 2020, 2000, N'Ford Focus Sport')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (8, 2, 2, N'Mini Cooper', 2015, 4000, N'Mini Family Car')
SET IDENTITY_INSERT [dbo].[Cars] OFF
