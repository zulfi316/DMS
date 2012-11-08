USE [INOLYST]
GO
/****** Object:  Table [dbo].[Docket]    Script Date: 11/07/2012 21:46:03 ******/
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
	[created_on] [datetime] NOT NULL,
	[deactivated] [bit] NULL,
	[deactivation_reason] [char](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Docket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Docket]  WITH CHECK ADD  CONSTRAINT [CK_Docket] CHECK  (([deactivation_reason]='DELETED'))
GO
ALTER TABLE [dbo].[Docket] CHECK CONSTRAINT [CK_Docket]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Only allow a certain number of values for deactivation
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Docket', @level2type=N'CONSTRAINT',@level2name=N'CK_Docket'



USE [INOLYST]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/08/2012 20:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login_name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[password] [varbinary](20) NOT NULL,
	[employee_id] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[created_on] [timestamp] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF