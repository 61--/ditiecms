USE [DTCMS]
GO
/****** 对象:  Table [dbo].[DT_Pre_ModuleControl]    脚本日期: 01/06/2010 17:38:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_Pre_ModuleControl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ControlName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ModulesID] [int] NOT NULL,
	[ControlValue] [int] NOT NULL,
	[OrderID] [int] NULL CONSTRAINT [DF_DT_Pre_ModuleControl_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_DT_Pre_ModuleControl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作名字' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Pre_ModuleControl', @level2type=N'COLUMN', @level2name=N'ControlName'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Pre_ModuleControl', @level2type=N'COLUMN', @level2name=N'ModulesID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作值' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Pre_ModuleControl', @level2type=N'COLUMN', @level2name=N'ControlValue'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'DT_Pre_ModuleControl', @level2type=N'COLUMN', @level2name=N'OrderID'
