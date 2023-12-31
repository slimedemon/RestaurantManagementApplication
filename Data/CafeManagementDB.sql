USE [master]
GO
/****** Object:  Database [RestaurantManagementDB]    Script Date: 8/14/2023 11:04:02 AM ******/
CREATE DATABASE [RestaurantManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantManagementDB', FILENAME = N'D:\ProgramFiles\SQLServer\MSSQL16.SQLEXPRESS\MSSQL\DATA\RestaurantManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantManagementDB_log', FILENAME = N'D:\ProgramFiles\SQLServer\MSSQL16.SQLEXPRESS\MSSQL\DATA\RestaurantManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RestaurantManagementDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RestaurantManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RestaurantManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RestaurantManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RestaurantManagementDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [RestaurantManagementDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RestaurantManagementDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](100) NOT NULL,
	[password] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[billId] [varchar](10) NOT NULL,
	[tableId] [varchar](10) NULL,
	[outDate] [date] NULL,
	[inDate] [date] NULL,
	[total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[billId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[billId] [varchar](10) NOT NULL,
	[categoryId] [varchar](10) NOT NULL,
	[foodId] [varchar](10) NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[billId] ASC,
	[categoryId] ASC,
	[foodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[categoryId] [varchar](10) NOT NULL,
	[foodId] [varchar](10) NOT NULL,
	[foodname] [nvarchar](100) NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC,
	[foodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[categoryId] [varchar](10) NOT NULL,
	[categoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RTable]    Script Date: 8/14/2023 11:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RTable](
	[tableId] [varchar](10) NOT NULL,
	[tableNumber] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tableId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [password]) VALUES (N'k', N'1962026656160185351301320480154111117132155')
GO
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F001', N'Tôm hùng sốt phomai', 1000000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F002', N'Cua hoàng đế sốt cajun', 5400000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F003', N'Tôm hùng đất sốt bơ tỏi', 200000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F004', N'Tôm càng xanh sốt tiêu chanh', 240000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F005', N'Hàu tươi 5 loại', 160000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T001', N'F006', N'Bào ngư nướng muối ớt', 300000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F001', N'Đùi gà chay chiên giòn', 100000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F002', N'Carry nấm', 120000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F003', N'Canh chay ngũ quả', 150000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F004', N'Ngũ quả úp lò', 160000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F005', N'Nấm nướng muối ớt', 90000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T002', N'F006', N'Thị bò chay xào súp lơ', 200000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F001', N'Gà tẩm sốt - nướng', 100000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F002', N'Ba rọi sát mỏng tẩm ớt muối - nướng', 120000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F003', N'Bò ba chỉ sốt nướng - nướng', 200000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F004', N'Bạch tuộc tẩm sa tế - nướng', 230000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F005', N'Lòng heo sa tế - nướng', 150000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T003', N'F006', N'Chân gà tẩm sốt - nướng', 100000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F001', N'Cafe sữa đá', 30000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F002', N'Cafe đen', 30000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F003', N'Milo đá dầm', 50000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F004', N'Sinh tố bơ', 35000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F005', N'Nước việt quốc kem tuyết', 60000)
INSERT [dbo].[Food] ([categoryId], [foodId], [foodname], [price]) VALUES (N'T004', N'F006', N'Nước cam chanh sả', 45000)
GO
INSERT [dbo].[FoodCategory] ([categoryId], [categoryName]) VALUES (N'T001', N'Hải sản')
INSERT [dbo].[FoodCategory] ([categoryId], [categoryName]) VALUES (N'T002', N'Đồ ăn chay')
INSERT [dbo].[FoodCategory] ([categoryId], [categoryName]) VALUES (N'T003', N'Đồ ăn nướng')
INSERT [dbo].[FoodCategory] ([categoryId], [categoryName]) VALUES (N'T004', N'Nước uống')
GO
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T001', 1, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T002', 2, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T003', 3, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T004', 4, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T005', 5, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T006', 6, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T007', 7, N'Trống')
INSERT [dbo].[RTable] ([tableId], [tableNumber], [status]) VALUES (N'T008', 8, N'Trống')
GO
/****** Object:  Index [UQ__RTable__680DA9568822CDED]    Script Date: 8/14/2023 11:04:03 AM ******/
ALTER TABLE [dbo].[RTable] ADD UNIQUE NONCLUSTERED 
(
	[tableNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([tableId])
REFERENCES [dbo].[RTable] ([tableId])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([categoryId], [foodId])
REFERENCES [dbo].[Food] ([categoryId], [foodId])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([billId])
REFERENCES [dbo].[Bill] ([billId])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([categoryId])
REFERENCES [dbo].[FoodCategory] ([categoryId])
GO
USE [master]
GO
ALTER DATABASE [RestaurantManagementDB] SET  READ_WRITE 
GO
