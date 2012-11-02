USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[get_dockets_for_user]    Script Date: 11/02/2012 18:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_dockets_for_user]
@user_id int
AS
BEGIN
SELECT * from [dbo].docket
for xml raw('Docket'), root('Dockets'), elements;

END


USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[save_docket]    Script Date: 11/02/2012 18:25:53 ******/
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
           (@inventor_name
           ,@invention_name
           ,@type_of_app
           ,@number)

SELECT SCOPE_IDENTITY();

END
