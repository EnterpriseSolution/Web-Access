SELECT * FROM AuditLog
SELECT * FROM dbo.GBCOLR  WHERE RECNUM IN (71 , 86, 73)


CREATE TABLE [dbo].[AuditLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId]  NVARCHAR(50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Action] [nvarchar](50) NOT NULL,
	[ChangedOn] [datetime] NOT NULL CONSTRAINT [DF_AuditLog_ChangedOn]  DEFAULT (getdate()),
	[TableName] [nvarchar](50) NOT NULL,
	[RowId] [int] NOT NULL,
	[Module] [nvarchar](500) NULL,
	[Page] [nvarchar](500) NULL,
	[Changes] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


CREATE PROCEDURE [dbo].[Common_AuditLog]
	 @UserId                  NVARCHAR(50)
    ,@UserName				  nVARCHAR(50)
	,@Action				  nVARCHAR(50)
    ,@TableName				  nVARCHAR(50)
	,@RowId					  INT
    ,@Module				  nVARCHAR(50) = NULL
    ,@Page					  nVARCHAR(50) = NULL
    ,@Changes				  nVARCHAR(MAX) = NULL
AS
BEGIN
INSERT INTO [dbo].[AuditLog]
           ([UserId]
           ,[UserName]
		   ,[Action]
           ,[ChangedOn]
           ,[TableName]
           ,[RowId]
           ,[Module]
           ,[Page]
           ,[Changes])
     VALUES
           (
		    @UserId    
		   ,@UserName
		   ,@Action
		   ,GetDate()	
		   ,@TableName	
		   ,@RowId		
		   ,@Module	
		   ,@Page		
		   ,@Changes	
		   )
END
GO
		