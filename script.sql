USE [Telephone]
GO
/****** Object:  Table [dbo].[tblTelephones]    Script Date: 8/30/2022 9:23:24 AM ******/
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
/****** Object:  Table [dbo].[tblUsers]    Script Date: 8/30/2022 9:23:24 AM ******/
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
