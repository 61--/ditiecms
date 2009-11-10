USE [dtcms]
GO
/****** 对象:  Table [dbo].[DT_Arc_Article]    脚本日期: 11/10/2009 21:02:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DT_Arc_Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NOT NULL,
	[Title] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ShortTitle] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[TitleStyle] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[OrderID] [tinyint] NULL CONSTRAINT [DF_DT_Arc_Article_Sort]  DEFAULT (0),
	[Tags] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[ImgUrl] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Author] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Editor] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[PubLisher] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Souce] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[Templet] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Keywords] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Description] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Content] [ntext] COLLATE Chinese_PRC_CI_AS NULL,
	[Click] [int] NOT NULL CONSTRAINT [DF_DT_Arc_Article_Click]  DEFAULT (0),
	[Good] [int] NOT NULL CONSTRAINT [DF_DT_Arc_Article_Good]  DEFAULT (0),
	[Bad] [int] NOT NULL CONSTRAINT [DF_DT_Arc_Article_Bad]  DEFAULT (0),
	[Readaccess] [smallint] NULL CONSTRAINT [DF_DT_Arc_Article_Readaccess]  DEFAULT (0),
	[Money] [smallint] NULL CONSTRAINT [DF_DT_Arc_Article_Money]  DEFAULT (0),
	[Attribute] [char](1) COLLATE Chinese_PRC_CI_AS NULL CONSTRAINT [DF_DT_Arc_Article_Status]  DEFAULT (0),
	[IsComment] [tinyint] NULL,
	[IsChecked] [tinyint] NOT NULL,
	[IsRecycle] [tinyint] NOT NULL,
	[IsRedirect] [tinyint] NOT NULL CONSTRAINT [DF_DT_Arc_Article_IsRedirect]  DEFAULT (0),
	[IsHtml] [tinyint] NULL CONSTRAINT [DF_DT_Arc_Article_IsHtml]  DEFAULT (0),
	[IsPaging] [tinyint] NULL CONSTRAINT [DF_DT_Arc_Article_IsPaging]  DEFAULT (0),
	[FilePath] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[AddDate] [datetime] NOT NULL,
	[PubDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ClassID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章标题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章缩略标题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ShortTitle'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'标题样式' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'TitleStyle'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章TAG' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Tags'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章缩略图' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ImgUrl'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章作者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'责任编辑' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Editor'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'PubLisher'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章来源' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Souce'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章模版' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Templet'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'关键字' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Keywords'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章正文' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章点击' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Click'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'顶' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Good'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'踩' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Bad'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'阅读权限，会员组' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Readaccess'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'消费点数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Money'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章属性，h头条，c推荐，p图片，f灯幻，s滚动' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Attribute'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否允许评论，1允许，0不允许' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsComment'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否审核，0未审核，1审核' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsChecked'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否放入回收站，0正常，1回收站' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsRecycle'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否跳转地址，1是，0否' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsRedirect'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否生成静态页，1生成静态，0动态访问' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsHtml'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否分页' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsPaging'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'存储路径' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'FilePath'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'PubDate'