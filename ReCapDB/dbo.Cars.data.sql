SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (1, 5, 1, N'Honda Civic', 2017, 2500, N'Double Motors Honda Civic')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (2, 4, 2, N'Ford Focus', 2020, 2000, N'Ford Focus Transportoer')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (3, 2, 2, N'Mini Cooper', 2015, 4000, N'Mini Family Car')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [CarName], [ModelYear], [DailyPrice], [Description]) VALUES (4, 2003, 2, N'Model S', 2021, 5000, N'Tesla Model S - 5 Kişilik Elektirikli Araba')
SET IDENTITY_INSERT [dbo].[Cars] OFF
