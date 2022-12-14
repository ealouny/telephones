/****** Object:  Database [Telephone]    Script Date: 8/30/2022 10:23:04 AM ******/
CREATE DATABASE [Telephone]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Telephone', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Telephone.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Telephone_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Telephone_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Telephone] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Telephone].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Telephone] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Telephone] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Telephone] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Telephone] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Telephone] SET ARITHABORT OFF 
GO
ALTER DATABASE [Telephone] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Telephone] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Telephone] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Telephone] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Telephone] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Telephone] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Telephone] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Telephone] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Telephone] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Telephone] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Telephone] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Telephone] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Telephone] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Telephone] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Telephone] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Telephone] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Telephone] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Telephone] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Telephone] SET  MULTI_USER 
GO
ALTER DATABASE [Telephone] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Telephone] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Telephone] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Telephone] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Telephone] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Telephone] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Telephone] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[tblTelephones]    Script Date: 8/30/2022 10:23:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTelephones](
	[UID] [uniqueidentifier] NOT NULL,
	[FName] [nvarchar](50) NULL,
	[LName] [nvarchar](50) NULL,
	[Dept] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone1] [nvarchar](15) NULL,
	[Phone2] [nvarchar](15) NULL,
	[Ext] [nchar](10) NULL,
	[Comments] [nvarchar](50) NULL,
	[Dept_OrderId] [int] NULL,
	[IsActive] [bit] NULL,
	[Empl_OrderId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 8/30/2022 10:23:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[UID] [uniqueidentifier] NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[UserRight] [char](5) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ad6c5450-6d87-42eb-a6fa-7b8d8ef44247', N'David', N'Gilbert', N'IT', N'Supervisor', N'davidg@pechanga.com', N'951-234-3727', N'951-234-1505', N'143       ', N'None', 5, 1, 6)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'd3631dac-733e-4281-93fd-88b87aeccb7e', N'James', N'Taylor', N'IT', N'Director', N'jamest@pechanga.com', N'951-234-1506', N'951-234-4953', N'144       ', N'None', 5, 1, 2)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'f5248ad4-4736-42ac-a2bd-271a55bda976', N'Emily', N'Harris', N'IT', N'Assistant Director', N'emilyh@pechanga.com', N'951-234-4958', N'951-234-2717', N'145       ', N'None', 5, 1, 3)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'c6c1817c-f1fc-4735-b6c5-f429d84936e7', N'Bill', N'Baker', N'IT', N'Assistant Manager', N'billb@pechanga.com', N'951-234-3942', N'951-234-1505', N'146       ', N'None', 5, 1, 5)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'a040f36b-0df9-49be-8864-839ee7bb02c7', N'Nancy', N'Robinson', N'IT', N'Manager', N'nancyr@pechanga.com', N'951-234-5949', N'951-234-5950', N'147       ', N'Temp', 5, 1, 4)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'fc8b71a5-93d5-422a-9894-473ff182ed92', N'Jim', N'Miller', N'Finance', N'Director', N'jimm@pechanga.com', N'951-234-9283', N'951-234-9898', N'113       ', N'None', 2, 1, 2)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'80f57e01-c6dc-4cc3-8395-71721c8600ed', N'Peter', N'Hernandez', N'Engineer', N'Director', N'peterh@pechanga.com', N'951-234-6407', N'951-234-6895', N'102       ', N'None', 4, 1, 2)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'9e103d8a-1726-4197-992b-f93004c24dad', N'Grace', N'Thompson', N'Engineer', N'Assistant Director', N'gracet@pechanga.com', N'951-234-5516', N'951-234-5617', N'103       ', N'None', 4, 1, 3)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'cd80b5f6-6242-4d10-b494-32de4f939260', N'Andrew', N'Wayne', N'HR', N'Director', N'andreww@pechanga.com', N'951-234-2906', N'951-234-3173', N'123       ', N'None', 3, 1, 2)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'1aecd87c-b349-4522-8403-4dcea88c4012', N'Brad', N'Amstrong', N'IT', N'Employee', N'brada@pechanga.com', N'951-234-6666', N'951-234-2222', N'141       ', N'Temp', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'01c1d84c-b367-4633-a7e9-1388ac56b8ce', N'Jason', N'McDuffy', N'IT', N'VP', N'jasonm@pechanga.com', N'951-234-3413', N'951-234-9999', N'142       ', N'None', 5, 1, 1)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'a94f98a5-a4de-4079-a83c-41ca4bfc8c94', N'Jason', N'Riley', N'Engineer', N'Supervisor', N'jasonr@pechanga.com', N'951-234-4778', N'951-234-0214', N'104       ', N'None', 4, 1, 6)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'2e131fd7-e03b-452d-a531-15abfa22cfac', N'Charlie', N'Jones', N'Engineer', N'Manager', N'charliej@pechanga.com', N'951-234-5550', N'951-234-2141', N'105       ', N'Temp', 4, 1, 4)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'e1e4571d-7f75-4193-a186-fe7d1aea10f7', N'Chris', N'Nichols', N'Engineer', N'Assistant Manager', N'chrisn@pechanga.com', N'951-234-1001', N'951-234-9924', N'100       ', N'None', 4, 1, 5)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'9d6a513c-c2ed-493a-8d24-587ede9a376c', N'Joshua', N'McKinley', N'HR', N'Assistant Manager', N'joshuam@pechanga.com', N'951-234-8373', N'951-234-7235', N'122       ', N'None', 3, 1, 5)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ba64ef7a-199f-47b9-a320-e7df3ea0afcc', N'Tommy', N'Martinez', N'Finance', N'Assistant Director', N'tommym@pechanga.com', N'951-234-6756', N'951-234-1241', N'117       ', N'Temp', 2, 1, 3)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ce9954d0-46fc-4b9e-9c32-3c60a0855bbd', N'Bill', N'Schnieder', N'HR', N'Manager', N'bills@pechanaga.com', N'951-234-5202', N'951-234-1293', N'121       ', N'None', 3, 1, 4)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'7c7e541b-2236-4107-b506-4298df2351ce', N'Jackson', N'Miller', N'Finance', N'Supervisor', N'jacksond@pechanga.com', N'951-234-0881', N'951-234-7989', N'118       ', N'None', 2, 1, 6)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'63ad98c9-81fd-4966-bd69-26072351b2fb', N'Jonathan', N'Richards', N'Finance', N'Assistant Manager', N'jonathanr@pechanga.com', N'951-234-5420', N'951-234-1022', N'119       ', N'None', 2, 1, 5)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'2f4031b4-c5fc-4fd5-ab87-0f21e979ba01', N'Carl', N'Cox', N'Finance', N'Manager', N'carlcox@pechanga.com', N'951-234-1119', N'951-234-4300', N'125       ', N'None', 2, 1, 4)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ecfa9430-fcf7-4014-9706-57fa05225821', N'Joseph', N'Conrad', N'Engineer', N'Employee', N'josephc@pechanga.com', N'951-234-9984', N'951-234-0813', N'106       ', N'Temp', 4, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'4d7f7bf1-0732-4a9e-a787-f049972dd6c3', N'Marco', N'Vargas', N'Engineer', N'Employee', N'marcov@pechanaga.com', N'951-234-4440', N'951-234-0755', N'107       ', N'None', 4, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'7f2c6d8b-6bcb-490c-ba65-c06a08d26feb', N'Zack', N'Wright', N'Finance', N'Employee', N'zackw@pechanga.com', N'951-234-8949', N'951-234-2184', N'114       ', N'None', 2, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'8ed56ebc-33fd-4616-8477-2771299ba217', N'Dave', N'Green', N'Finance', N'Employee', N'daveg@pechanga.com', N'951-234-6175', N'951-234-8349', N'115       ', N'Temp', 2, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'eee31f05-8b72-482f-8f2d-736b5ed70696', N'Jeffery', N'Clark', N'HR', N'Employee', N'jefferya@pechanga.com', N'951-234-6370', N'951-234-4921', N'124       ', N'None', 3, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'70167e61-c546-489d-a3fe-9f222b734be7', N'Christopher', N'Mason', N'Finance', N'Employee', N'christopherm@pechanga.com', N'951-234-1202', N'951-234-4389', N'116       ', N'None', 2, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'213e87df-530f-4fc6-ba72-808bf3cda53b', N'Brian', N'Williams', N'IT', N'Employee', N'brianw@pechanga.com', N'951-234-2316', N'951-234-2345', N'131       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'26792ec0-a0a0-4c01-8397-616a0bb1e1e7', N'Jake', N'Garcia', N'IT', N'Employee', N'jakeg@pechanga.com', N'951-234-8321', N'951-234-7213', N'132       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'25a505cc-e064-4425-9ae4-e0218dcd51af', N'Jesse', N'McDonald', N'IT', N'Employee', N'jessem@pechanga.com', N'951-234-2478', N'951-234-9372', N'133       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'7014ed67-b769-4bfb-9ce3-4c8d7e864c54', N'Jerry', N'Domingo', N'IT', N'Employee', N'jerryd@pechanga.com', N'951-234-8888', N'951-234-2222', N'135       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'f9f4c482-7453-47fb-803c-7f4a3ef19c34', N'Tom', N'Phillips', N'IT', N'Employee', N'tomp@pechanga.com', N'951-234-4087', N'951-234-3127', N'136       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'2d6e69fc-88c8-4eb6-8619-9dd05b9ac32a', N'Sandy', N'Cruz', N'IT', N'Employee', N'sandyc@pechanga.com', N'951-234-6670', N'951-234-3333', N'137       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'f0dee1f4-99cd-4c7d-ba7f-21dccaef9b72', N'Allison', N'Delgado', N'IT', N'Employee', N'allisond@pechanga.com', N'951-234-0231', N'951-234-7644', N'138       ', N'Temp', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'72e2b477-bc82-48a7-b2bc-2b51169593b7', N'Tracy', N'Johnson', N'IT', N'Employee', N'tracyj@pechanga.com', N'951-234-4343', N'951-234-0802', N'139       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'b557918d-0974-4bde-a2f7-3b1dd192a879', N'Kevin', N'Smith', N'IT', N'Employee', N'kevins@pechanga.com', N'951-234-9737', N'951-234-6420', N'140       ', N'None', 5, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'cbb072b3-5909-4045-a94e-edcd2d5d4886', N'Lewis', N'Adams', N'HR', N'Assistant Director', N'lewisa@pechanga.com', N'951-234-9475', N'951-234-1283', N'125       ', N'None', 3, 1, 3)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'df52aae8-f177-4f07-8ace-002cf518a4ba', N'Monica', N'Scott', N'HR', N'Employee', N'monicas@pechanga.com', N'951-234-5340', N'951-234-0555', N'126       ', N'None', 3, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'b9113788-eb43-4596-9a40-6685d6eb6482', N'Robert', N'West', N'HR', N'Supervisor', N'robertw@pechanga.com', N'951-234-9232', N'951-234-8730', N'127       ', N'None', 3, 1, 6)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ce12b64a-45fc-40e6-9497-4289a2a0f869', N'Michael', N'Reynolds', N'HR', N'Employee', N'michaelr@pechanga.com', N'951-234-4323', N'951-234-1590', N'128       ', N'None', 3, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'a13b7bde-07ed-4e5c-b5c8-d3d623b4385d', N'Travis', N'Brown ', N'HR', N'Employee', N'travisb@pechanga.com', N'951-234-7624', N'951-020-8133', N'129       ', N'None', 3, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'7bb45615-8dae-48e1-9055-758ac90d5b3f', N'Sally', N'Jenkins', N'HR', N'Employee', N'sallyj@pechanga.com', N'951-234-0030', N'951-234-4938', N'130       ', N'None', 3, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'5d905b0a-053c-4d8f-996e-9194d059b9ef', N'David', N'Thomas', N'Finance', N'Employee', N'davidt@pechanga.com', N'951-234-2882', N'951-234-5509', N'111       ', N'None', 2, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'ba247162-21bc-4b8b-8722-ebdba7fee2b1', N'Charles', N'Lopez', N'Finance', N'Employee', N'charlesl@pechanga.com', N'951-234-7474', N'951-234-8235', N'112       ', N'Temp', 2, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'5dfd62d6-d660-4789-a8e4-740db8b33d76', N'Richard', N'Wilson', N'Engineer', N'Employee', N'richardw@pechanga.com', N'951-234-8120', N'951-234-2040', N'108       ', N'None', 4, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'75fed025-ac08-4d2e-8d2d-3da3039d9c9d', N'Mark', N'Davis', N'Engineer', N'Employee', N'markd@pechanga.com', N'951-234-0551', N'951-234-3227', N'109       ', N'None', 4, 1, 9)
INSERT [dbo].[tblTelephones] ([UID], [FName], [LName], [Dept], [Title], [Email], [Phone1], [Phone2], [Ext], [Comments], [Dept_OrderId], [IsActive], [Empl_OrderId]) VALUES (N'f25f10f2-7c60-4ace-8896-8a78f9daf98a', N'Anthony', N'Moore', N'Engineer', N'Employee', N'anthonym@pechanga.com', N'951-234-4701', N'951-234-3072', N'110       ', N'None', 4, 1, 9)
GO
INSERT [dbo].[tblUsers] ([UID], [Username], [Password], [IsActive], [UserRight]) VALUES (N'97444a07-9fd3-453c-b155-5037f1f583a0', N'Dean', N'111', 1, N'2    ')
INSERT [dbo].[tblUsers] ([UID], [Username], [Password], [IsActive], [UserRight]) VALUES (N'fa71ed75-a536-4f57-9d3a-6c03d463c640', N'Admin', N'111', 1, N'0    ')
INSERT [dbo].[tblUsers] ([UID], [Username], [Password], [IsActive], [UserRight]) VALUES (N'1e77a72f-0fe0-4951-a9c0-57f9ae953c27', N'Employee', N'222', 1, N'2    ')
GO
ALTER DATABASE [Telephone] SET  READ_WRITE 
GO
