USE [DTCMS]
GO
/****** 对象:  Table [dbo].[DT_Users]    脚本日期: 01/06/2010 16:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DT_Users](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[NickName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Password] [char](32) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[SecureQuestion] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[SecureAnswer] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Sex] [tinyint] NULL CONSTRAINT [DF_DT_Users_Sex]  DEFAULT ((1)),
	[Email] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[RoleID] [int] NULL CONSTRAINT [DF_DT_Users_RoleID]  DEFAULT ((0)),
	[UsergroupID] [int] NULL CONSTRAINT [DF_DT_Users_UsergroupID]  DEFAULT ((0)),
	[RegisterIP] [char](15) COLLATE Chinese_PRC_CI_AS NULL,
	[RegisterTime] [datetime] NULL CONSTRAINT [DF_DT_Users_RegisterDate]  DEFAULT (getdate()),
	[LastloginIP] [char](15) COLLATE Chinese_PRC_CI_AS NULL,
	[LastloginTime] [datetime] NULL CONSTRAINT [DF_DT_Users_LastloginTime]  DEFAULT (getdate()),
	[LoginCount] [int] NULL CONSTRAINT [DF_DT_Users_LoginCount]  DEFAULT ((0)),
	[PostCount] [int] NULL CONSTRAINT [DF_DT_Users_PostCount]  DEFAULT ((0)),
	[OnlineTime] [int] NULL CONSTRAINT [DF_DT_Users_OnlineTime]  DEFAULT ((0)),
	[Credits] [int] NULL CONSTRAINT [DF_DT_Users_Credits]  DEFAULT ((0)),
	[ExtCredits1] [decimal](18, 0) NULL CONSTRAINT [DF_DT_Users_ExtCredits1]  DEFAULT ((0)),
	[ExtCredits2] [decimal](18, 0) NULL CONSTRAINT [DF_DT_Users_ExtCredits2]  DEFAULT ((0)),
	[ExtCredits3] [decimal](18, 0) NULL CONSTRAINT [DF_DT_Users_ExtCredits3]  DEFAULT ((0)),
	[ExtCredits4] [decimal](18, 0) NULL,
	[ExtCredits5] [decimal](18, 0) NULL,
	[Avatar] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Birthday] [smalldatetime] NULL,
	[PMCount] [int] NULL CONSTRAINT [DF_DT_Users_PmCount]  DEFAULT ((0)),
	[IsVerify] [tinyint] NULL CONSTRAINT [DF_DT_Users_IsVerify]  DEFAULT ((0)),
	[IsLock] [tinyint] NULL CONSTRAINT [DF_DT_Users_IsForbidden]  DEFAULT ((0)),
 CONSTRAINT [PK_DT_Users] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户UID编号' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'UID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'UserName'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户昵称' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'NickName'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'安全提示问题' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'SecureQuestion'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'安全提示答案' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'SecureAnswer'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'Sex'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email地址' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'Email'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户权限ID' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'RoleID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组ID' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'UsergroupID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注册IP' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'RegisterIP'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注册时间' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'RegisterTime'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次登陆IP' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'LastloginIP'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次登陆时间' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'LastloginTime'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆次数' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'LoginCount'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布文章数' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'PostCount'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'在线时间（单位：分钟）' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'OnlineTime'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户积分' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'Credits'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'ExtCredits1'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分2' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'ExtCredits2'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分3' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'ExtCredits3'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分4' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'ExtCredits4'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'ExtCredits5'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户头像' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'Avatar'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生日' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'Birthday'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新短消息数' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'PMCount'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否审核' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'IsVerify'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否锁定' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Users', @level2type=N'COLUMN', @level2name=N'IsLock'
