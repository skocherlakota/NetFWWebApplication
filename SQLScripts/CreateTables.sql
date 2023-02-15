USE [LibraryDB]
GO

/****** Object:  Table [dbo].[users]    Script Date: 2/15/2023 5:57:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[active] [bit] NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[T_Book](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Author] [varchar](50) NULL,
	[PubDate] [date] NULL,
	[Price] [decimal](18, 0) NULL,
	[Del_IND] [bit] NULL,
 CONSTRAINT [PK_T_Book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



