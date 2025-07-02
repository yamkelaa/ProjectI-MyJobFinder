--Table for authorising users
CREATE TABLE [dbo].[Users](
[UserId] INT PRIMARY KEY IDENTITY(1,1),
[EntraUserId] NVARCHAR(100) NOT NULL,
[Role] VARCHAR(20) NOT NULL
)
--Table for storing the email addresses linked to an authorised user 
CREATE TABLE [dbo].[TargetEmails](
[TargetEmailId] INT PRIMARY KEY IDENTITY(1,1),
[UserId] INT NOT NULL CONSTRAINT FK_TargetEmails_UserId FOREIGN KEY(UserId)
REFERENCES [dbo].[Users] (UserId)
ON DELETE CASCADE
ON UPDATE CASCADE,
[TargetEmail] VARCHAR(250) NOT NULL
)

--Table for storing the websited linked to an authorised user including the website domain the users password for that website as well as their username
CREATE TABLE [dbo].[TargetWebsites](
[TargetWebsiteId] INT PRIMARY KEY IDENTITY(1,1),
[UserId] INT NOT NULL CONSTRAINT FK_TargetWebsites_UserId FOREIGN KEY(UserId)
REFERENCES [dbo].[Users] (UserId)
ON DELETE CASCADE
ON UPDATE CASCADE,
[Link] VARCHAR(500) NOT NULL,
[Username] NVARCHAR(250) NOT NULL,
[Password] NVARCHAR(250) NOT NULL
)



