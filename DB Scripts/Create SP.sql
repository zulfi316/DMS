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
	order by created_on desc, id desc

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

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[get_dockets_for_user]
@user_id int
AS
BEGIN
SELECT * from [dbo].docket
where deactivated is null or deactivated = 0
for xml raw('Docket'), root('Dockets'), elements;

END


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[set_docket_deactivation_status]
@docket_id int,
@deactivated bit,
@reason char(15)
AS
BEGIN

UPDATE [dbo].[docket]
set deactivated = @deactivated,
	deactivation_reason = @reason
where id = @docket_id


END


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_user]
	@login_name  varchar(50),
	@password    varbinary(MAX),
	@employee_id varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO [INOLYST].[dbo].[User]
           ([login_name]
           ,[password]
           ,[employee_id])
     VALUES
           (@login_name
           ,@password
           ,@employee_id)

END



USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[get_password]    Script Date: 11/08/2012 20:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_password]
	@id varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

select top 1 password from dbo.[user]
where employee_id = @id or login_name = @id;

END

USE [INOLYST]
GO
/****** Object:  StoredProcedure [dbo].[get_user_details]    Script Date: 11/08/2012 20:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_user_details]
	@id  varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  SELECT top 1 [id]
      ,[login_name]
      ,[employee_id]
  FROM [INOLYST].[dbo].[User]
where login_name = @id OR employee_id = @id

END
