CREATE TABLE [dbo].[Users] (
    [UserID]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserFirstName]  VARCHAR (50)   NULL,
    [UserSecondName] VARCHAR (50)   NULL,
    [UserBDate]      DATE           NULL,
    [UserName]       VARCHAR (10)   NOT NULL,
    [UserPass]       VARBINARY (50) NULL,
    [UserMail]       VARCHAR (50)   NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


GO
-- =============================================
-- Author:		Eugenio Hidalgo
-- Create date: 08/11/2013
-- Description:	Borra los datos relacionados con el usuario borrado en Trainings y Material.
-- El resto se borra por cascada.
-- =============================================
CREATE TRIGGER deleteUser 
   ON  Users 
   AFTER DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
    
    
    delete from Trainings where Trainings.UserID=(Select UserID from deleted);
    delete from Materials where Materials.userID=(Select UserID from deleted);
    
END
