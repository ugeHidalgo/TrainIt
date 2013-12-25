CREATE PROCEDURE [dbo].FillByUserName
(
	@UserName varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT UserID, UserFirstName, UserSecondName, UserBDate, UserName, UserPass, UserMail FROM dbo.Users WHERE UserName =@UserName