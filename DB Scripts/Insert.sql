USE [INOLYST]
GO
/****** Object:  Table [dbo].[Docket]    Script Date: 11/02/2012 18:24:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invention_name] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[inventor_name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[type_of_app] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[number] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Docket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF