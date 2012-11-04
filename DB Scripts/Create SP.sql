USE [inolyst]
GO
/****** Object:  StoredProcedure [dbo].[save_docket]    Script Date: 11/04/2012 11:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[save_docket]

@invention_name varchar(max),
@inventor_name	varchar(50),
@type_of_app	varchar(50),
@number			varchar(20)
	
AS
BEGIN
	
  INSERT INTO [dbo].[docket]
           ([invention_name]
           ,[inventor_name]
           ,[type_of_app]
           ,[number])
     VALUES
           (@invention_name
		   ,@inventor_name
           ,@type_of_app
           ,@number)
           

SELECT SCOPE_IDENTITY();

END

USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[get_last_docket_number]    Script Date: 11/04/2012 17:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_last_docket_number]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- incase the time stamp is same for 2 or more columns id will resolve the clash
select top 1 number from dbo.docket
	order by created_on, id desc

END


USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[save_docket]    Script Date: 11/04/2012 17:28:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[save_docket]

@invention_name varchar(max),
@inventor_name	varchar(50),
@type_of_app	varchar(50),
@number			varchar(20),
@created_on		datetime
	
AS
BEGIN
	
  INSERT INTO [dbo].[docket]
           ([invention_name]
           ,[inventor_name]
           ,[type_of_app]
           ,[number]
		   ,[created_on])
     VALUES
           (@inventor_name
           ,@invention_name
           ,@type_of_app
           ,@number
		   ,@created_on)

SELECT SCOPE_IDENTITY();

END

