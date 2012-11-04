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

