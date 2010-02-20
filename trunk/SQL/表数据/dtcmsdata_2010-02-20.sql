if exists (select * from sysobjects where id = OBJECT_ID('[DT_Arc_Class]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Arc_Class]

CREATE TABLE [DT_Arc_Class] (
[CID] [int]  IDENTITY (1, 1)  NOT NULL,
[ParentID] [int]  NOT NULL DEFAULT ((0)),
[Attribute] [tinyint]  NOT NULL,
[ClassName] [nvarchar]  (100) NOT NULL,
[ClassEName] [varchar]  (50) NULL,
[ClassType] [tinyint]  NOT NULL,
[ClassDomain] [varchar]  (255) NULL,
[ClassPath] [varchar]  (255) NULL,
[IndexTemplet] [varchar]  (255) NULL,
[ListTemplet] [varchar]  (255) NULL,
[ArchiveTemplet] [varchar]  (255) NULL,
[IndexRule] [varchar]  (255) NULL,
[ListRule] [varchar]  (255) NULL,
[ArchiveRule] [varchar]  (255) NULL,
[ClassPage] [tinyint]  NULL,
[Description] [nvarchar]  (500) NULL,
[IsHidden] [tinyint]  NOT NULL,
[IsHtml] [tinyint]  NOT NULL,
[CheckLevel] [tinyint]  NOT NULL,
[IsContribute] [tinyint]  NOT NULL,
[IsComment] [tinyint]  NOT NULL,
[Readaccess] [smallint]  NULL,
[SiteID] [tinyint]  NULL,
[AddDate] [datetime]  NOT NULL,
[Relation] [varchar]  (100) NULL,
[OrderID] [smallint]  NOT NULL,
[ImgUrl] [varchar]  (255) NULL,
[Keywords] [nvarchar]  (200) NULL,
[CrossID] [varchar]  (200) NULL,
[ClassContent] [ntext]  NULL)

ALTER TABLE [DT_Arc_Class] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Arc_Class] PRIMARY KEY  NONCLUSTERED ( [CID] )
SET IDENTITY_INSERT [DT_Arc_Class] ON

INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 9,0,1,'WEB技术','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',10)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 10,9,1,'HTML基础','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',10)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 11,9,1,'Javascript','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',30)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 12,9,1,'DIV+CSS','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',50)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 13,9,1,'AJAX技术','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',40)

SET IDENTITY_INSERT [DT_Arc_Class] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Arc_Soft]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Arc_Soft]

CREATE TABLE [DT_Arc_Soft] (
[AID] [int]  NOT NULL)

if exists (select * from sysobjects where id = OBJECT_ID('[DT_AttachMent]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_AttachMent]

CREATE TABLE [DT_AttachMent] (
[AID] [int]  IDENTITY (1, 1)  NOT NULL,
[Attribute] [tinyint]  NOT NULL,
[DisplayName] [nvarchar]  (50) NULL,
[AttachMentPath] [varchar]  (255) NULL,
[AttachMentSize] [int]  NULL,
[AbbrPhotoPath] [varchar]  (255) NULL,
[PubLisher] [nvarchar]  (50) NULL,
[AddDate] [datetime]  NULL,
[PhotoDescription] [nvarchar]  (100) NULL)

ALTER TABLE [DT_AttachMent] WITH NOCHECK ADD  CONSTRAINT [PK_DT_AttachMent] PRIMARY KEY  NONCLUSTERED ( [AID] )
SET IDENTITY_INSERT [DT_AttachMent] ON


SET IDENTITY_INSERT [DT_AttachMent] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Help]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Help]

CREATE TABLE [DT_Help] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[HelpID] [char]  (8) NOT NULL,
[PID] [char]  (8) NOT NULL,
[Title] [nvarchar]  (100) NULL,
[Message] [nvarchar]  (1000) NULL,
[OrderID] [int]  NULL DEFAULT ((0)))

ALTER TABLE [DT_Help] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Help] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_Help] ON


SET IDENTITY_INSERT [DT_Help] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_ModuleControl]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_ModuleControl]

CREATE TABLE [DT_ModuleControl] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[ControlName] [nvarchar]  (20) NOT NULL,
[ModuleID] [varchar]  (8) NOT NULL,
[ControlValue] [int]  NOT NULL,
[OrderID] [int]  NULL DEFAULT ((0)))

ALTER TABLE [DT_ModuleControl] WITH NOCHECK ADD  CONSTRAINT [PK_DT_ModuleControl] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_ModuleControl] ON

INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 5,'查看','M02',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 6,'查看','M0201',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 7,'查看','M0202',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 8,'查看','M0203',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 9,'查看','M0204',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 10,'查看','M03',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 11,'查看','M0301',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 12,'查看','M0302',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 13,'查看','M0303',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 14,'查看','M04',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 15,'查看','M0401',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 16,'查看','M0402',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 17,'查看','M05',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 18,'查看','M0501',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 19,'查看','M0502',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 20,'查看','M0503',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 21,'查看','M0504',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 22,'查看','M06',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 23,'查看','M0601',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 24,'查看','M0602',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 25,'查看','M0603',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 26,'查看','M0604',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 27,'查看','M0605',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 28,'查看','M0606',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 29,'查看','M07',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 30,'查看','M0701',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 31,'查看','M0703',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 32,'查看','M0704',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 33,'查看','M08',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 34,'查看','M0801',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 35,'查看','M0802',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 36,'查看','M0803',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 61,'查看','M0201001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 62,'添加','M0201001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 63,'编辑','M0201001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 64,'删除','M0201001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 65,'查看','M0201003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 66,'添加','M0201003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 67,'编辑','M0201003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 68,'删除','M0201003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 69,'查看','M0201002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 70,'添加','M0201002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 71,'编辑','M0201002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 72,'删除','M0201002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 73,'查看','M0202001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 74,'添加','M0202001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 75,'编辑','M0202001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 76,'删除','M0202001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 77,'查看','M0202002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 78,'添加','M0202002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 79,'编辑','M0202002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 80,'删除','M0202002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 81,'查看','M0202003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 82,'添加','M0202003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 83,'编辑','M0202003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 84,'删除','M0202003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 85,'查看','M0202004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 86,'添加','M0202004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 87,'编辑','M0202004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 88,'删除','M0202004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 89,'查看','M0203001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 90,'添加','M0203001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 91,'编辑','M0203001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 92,'删除','M0203001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 93,'查看','M0203002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 94,'添加','M0203002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 95,'编辑','M0203002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 96,'删除','M0203002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 97,'查看','M0204001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 98,'添加','M0204001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 99,'编辑','M0204001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 100,'删除','M0204001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 105,'查看','M0301002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 106,'添加','M0301002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 107,'编辑','M0301002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 108,'删除','M0301002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 109,'查看','M0301008',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 110,'添加','M0301008',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 111,'编辑','M0301008',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 112,'删除','M0301008',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 113,'查看','M0301009',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 114,'添加','M0301009',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 115,'编辑','M0301009',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 116,'删除','M0301009',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 117,'查看','M0301010',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 118,'添加','M0301010',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 119,'编辑','M0301010',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 120,'删除','M0301010',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 121,'查看','M0302001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 122,'添加','M0302001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 123,'编辑','M0302001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 124,'删除','M0302001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 125,'查看','M0302002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 126,'添加','M0302002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 127,'编辑','M0302002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 128,'删除','M0302002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 129,'查看','M0303003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 130,'添加','M0303003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 131,'编辑','M0303003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 132,'删除','M0303003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 133,'查看','M0303004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 134,'添加','M0303004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 135,'编辑','M0303004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 136,'删除','M0303004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 137,'查看','M0303005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 138,'添加','M0303005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 139,'编辑','M0303005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 140,'删除','M0303005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 141,'查看','M0303006',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 142,'添加','M0303006',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 143,'编辑','M0303006',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 144,'删除','M0303006',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 145,'查看','M0303007',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 146,'添加','M0303007',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 147,'编辑','M0303007',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 148,'删除','M0303007',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 149,'查看','M0401001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 150,'添加','M0401001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 151,'编辑','M0401001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 152,'删除','M0401001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 153,'查看','M0401002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 154,'添加','M0401002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 155,'编辑','M0401002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 156,'删除','M0401002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 157,'查看','M0401003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 158,'添加','M0401003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 159,'编辑','M0401003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 160,'删除','M0401003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 161,'查看','M0401004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 162,'添加','M0401004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 163,'编辑','M0401004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 164,'删除','M0401004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 165,'查看','M0401005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 166,'添加','M0401005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 167,'编辑','M0401005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 168,'删除','M0401005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 169,'查看','M0402001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 170,'添加','M0402001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 171,'编辑','M0402001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 172,'删除','M0402001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 173,'查看','M0402002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 174,'添加','M0402002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 175,'编辑','M0402002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 176,'删除','M0402002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 177,'查看','M0402003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 178,'添加','M0402003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 179,'编辑','M0402003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 180,'删除','M0402003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 181,'查看','M0402004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 182,'添加','M0402004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 183,'编辑','M0402004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 184,'删除','M0402004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 185,'查看','M0501001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 186,'添加','M0501001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 187,'编辑','M0501001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 188,'删除','M0501001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 189,'查看','M0501002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 190,'添加','M0501002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 191,'编辑','M0501002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 192,'删除','M0501002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 193,'查看','M0501003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 194,'添加','M0501003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 195,'编辑','M0501003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 196,'删除','M0501003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 197,'查看','M0501004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 198,'添加','M0501004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 199,'编辑','M0501004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 200,'删除','M0501004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 201,'查看','M0502001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 202,'添加','M0502001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 203,'编辑','M0502001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 204,'删除','M0502001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 205,'查看','M0502002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 206,'添加','M0502002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 207,'编辑','M0502002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 208,'删除','M0502002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 209,'查看','M0503001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 210,'添加','M0503001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 211,'编辑','M0503001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 212,'删除','M0503001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 213,'查看','M0503002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 214,'添加','M0503002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 215,'编辑','M0503002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 216,'删除','M0503002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 217,'查看','M0504001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 218,'添加','M0504001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 219,'编辑','M0504001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 220,'删除','M0504001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 221,'查看','M0504002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 222,'添加','M0504002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 223,'编辑','M0504002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 224,'删除','M0504002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 225,'查看','M0601001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 226,'添加','M0601001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 227,'编辑','M0601001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 228,'删除','M0601001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 229,'查看','M0601002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 230,'添加','M0601002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 231,'编辑','M0601002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 232,'删除','M0601002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 233,'查看','M0602001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 234,'添加','M0602001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 235,'编辑','M0602001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 236,'删除','M0602001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 237,'查看','M0602002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 238,'添加','M0602002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 239,'编辑','M0602002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 240,'删除','M0602002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 241,'查看','M0602003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 242,'添加','M0602003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 243,'编辑','M0602003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 244,'删除','M0602003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 245,'查看','M0603001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 246,'添加','M0603001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 247,'编辑','M0603001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 248,'删除','M0603001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 249,'查看','M0603002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 250,'添加','M0603002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 251,'编辑','M0603002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 252,'删除','M0603002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 253,'查看','M0604001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 254,'添加','M0604001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 255,'编辑','M0604001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 256,'删除','M0604001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 257,'查看','M0604002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 258,'添加','M0604002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 259,'编辑','M0604002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 260,'删除','M0604002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 261,'查看','M0604003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 262,'添加','M0604003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 263,'编辑','M0604003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 264,'删除','M0604003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 265,'查看','M0605001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 266,'添加','M0605001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 267,'编辑','M0605001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 268,'删除','M0605001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 269,'查看','M0605002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 270,'添加','M0605002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 271,'编辑','M0605002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 272,'删除','M0605002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 273,'查看','M0606001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 274,'添加','M0606001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 275,'编辑','M0606001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 276,'删除','M0606001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 277,'查看','M0701001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 278,'添加','M0701001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 279,'编辑','M0701001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 280,'删除','M0701001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 281,'查看','M0701002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 282,'添加','M0701002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 283,'编辑','M0701002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 284,'删除','M0701002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 285,'查看','M0701003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 286,'添加','M0701003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 287,'编辑','M0701003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 288,'删除','M0701003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 289,'查看','M0701004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 290,'添加','M0701004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 291,'编辑','M0701004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 292,'删除','M0701004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 293,'查看','M0701005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 294,'添加','M0701005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 295,'编辑','M0701005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 296,'删除','M0701005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 297,'查看','M0701006',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 298,'添加','M0701006',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 299,'编辑','M0701006',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 300,'删除','M0701006',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 301,'查看','M0703001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 302,'添加','M0703001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 303,'编辑','M0703001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 304,'删除','M0703001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 305,'查看','M0703002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 306,'添加','M0703002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 307,'编辑','M0703002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 308,'删除','M0703002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 309,'查看','M0703003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 310,'添加','M0703003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 311,'编辑','M0703003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 312,'删除','M0703003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 313,'查看','M0703004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 314,'添加','M0703004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 315,'编辑','M0703004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 316,'删除','M0703004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 317,'查看','M0704001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 318,'添加','M0704001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 319,'编辑','M0704001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 320,'删除','M0704001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 321,'查看','M0704002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 322,'添加','M0704002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 323,'编辑','M0704002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 324,'删除','M0704002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 325,'查看','M0801001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 326,'添加','M0801001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 327,'编辑','M0801001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 328,'删除','M0801001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 329,'查看','M0801002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 330,'添加','M0801002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 331,'编辑','M0801002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 332,'删除','M0801002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 333,'查看','M0801003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 334,'添加','M0801003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 335,'编辑','M0801003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 336,'删除','M0801003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 337,'查看','M0801004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 338,'添加','M0801004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 339,'编辑','M0801004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 340,'删除','M0801004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 341,'查看','M0802001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 342,'添加','M0802001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 343,'编辑','M0802001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 344,'删除','M0802001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 345,'查看','M0802002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 346,'添加','M0802002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 347,'编辑','M0802002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 348,'删除','M0802002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 349,'查看','M0802003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 350,'添加','M0802003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 351,'编辑','M0802003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 352,'删除','M0802003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 353,'查看','M0802004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 354,'添加','M0802004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 355,'编辑','M0802004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 356,'删除','M0802004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 357,'查看','M0802005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 358,'添加','M0802005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 359,'编辑','M0802005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 360,'删除','M0802005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 361,'查看','M0803001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 362,'添加','M0803001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 363,'编辑','M0803001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 364,'删除','M0803001',8,4)

SET IDENTITY_INSERT [DT_ModuleControl] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Modules]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Modules]

CREATE TABLE [DT_Modules] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[ModuleID] [varchar]  (8) NOT NULL,
[ParentID] [varchar]  (8) NOT NULL,
[ModuleName] [nvarchar]  (50) NOT NULL,
[EName] [varchar]  (50) NULL,
[ModuleDepth] [tinyint]  NULL,
[ModuleURL] [varchar]  (255) NULL,
[Target] [varchar]  (20) NULL,
[Description] [nvarchar]  (200) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[IsQuickMenu] [tinyint]  NULL DEFAULT ((0)),
[IsSystem] [tinyint]  NULL DEFAULT ((0)),
[IsEnable] [tinyint]  NULL DEFAULT ((1)),
[OrderID] [int]  NULL DEFAULT ((0)))

ALTER TABLE [DT_Modules] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Modules] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_Modules] ON

INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 1,'M01','M0','控制面板','ControlPanel',1,'controlpanel.aspx','main_body','附件管理','2010-1-17 17:07:08',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 2,'M0101','M01','快捷导航','QuickMenu',2,'main_body','快捷导航','2010-1-17 17:19:35',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 3,'M0102','M01','个人信息','PersonalInfo',2,'user/','main_body','个人信息','2010-1-17 17:20:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 4,'M0102001','M0102','我的资料','MyInfo',3,'user/myinfo.aspx','main_body','我的资料','2010-1-17 17:21:07',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 5,'M0102002','M0102','短消息','MyPM',3,'user/pm_list.aspx','main_body','短消息','2010-1-29 15:47:25',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 6,'M0102003','M0102','我的权限','MyPermission',3,'user/mypermission.aspx','main_body','我的权限','2010-1-29 15:48:00',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 7,'M0103','M01','系统帮助','SystemHelp',2,'help/','main_body','系统帮助','2010-2-1 14:57:22',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 8,'M0103001','M0103','系统使用帮助','SystemHelp',3,'http://www.91aspx.com/help/','_blank','系统使用帮助','2010-2-1 14:58:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 9,'M0103002','M0103','模版标签帮助','TemplateHelp',3,'http://www.91aspx.com/help/','_blank','模版标签帮助','2010-2-1 15:00:17',0,0,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 10,'M0103003','M0103','官方网站','OfficialSite',3,'http://www.91aspx.com/','_blank','官方网站','2010-2-1 15:04:00',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 11,'M02','M0','站点管理','SiteManage',1,'site/class_list.aspx','main_body','频道管理','2010-1-17 17:01:21',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 12,'M0201','M02','频道管理','ChannelManage',2,'site/','main_body','频道管理','2010-1-29 16:01:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 13,'M0201001','M0201','内容模型管理','ModelList',3,'site/model_list.aspx','main_body','内容模型管理','2010-1-29 16:07:39',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 14,'M0201003','M0201','单页文档管理','SimpleArchiveList',3,'site/simplearchive_list.aspx','main_body','单页文档管理','2010-1-29 16:08:36',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 15,'M0201002','M0201','网站栏目管理','ClassList',3,'site/class_list.aspx','main_body','网站栏目管理','2010-1-29 16:12:44',1,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 16,'M0202','M02','频道设置','ChannelSetting',2,'site/','main_body','频道设置','2010-1-29 16:02:39',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 17,'M0202001','M0202','栏目默认字段','ClassAdd',3,'site/class_add.aspx','main_body','栏目默认字段','2010-1-29 16:12:23',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 18,'M0202002','M0202','栏目防采集设置','ClassImport',3,'site/class_import.aspx','main_body','栏目防采集设置','2010-1-29 16:14:24',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 19,'M0202003','M0202','文档默认字段','ArchivesDefault',3,'site/archivesdefault_setting.aspx','main_body','文档默认字段','2010-2-2 14:32:58',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 20,'M0202004','M0202','软件下载设置','SoftDownload',3,'site/softdownload_setting.aspx','main_body','软件下载设置','2010-2-2 14:34:39',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 21,'M0203','M02','文件管理','FileManage',2,'site/','main_body','文件管理','2010-1-29 16:03:24',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 22,'M0203001','M0203','文件管理器','FileList',3,'site/file_list.aspx','main_body','文件管理器','2010-1-29 16:16:30',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 23,'M0203002','M0203','木马检测','FileTrojanDetect',3,'site/file_detect.aspx','main_body','文件木马检测','2010-1-29 16:18:47',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 24,'M0204','M02','模版管理','TemplateManage',2,'site/','main_body','模版管理','2010-1-29 16:04:36',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 25,'M0204001','M0204','模版管理','TemplateList',3,'site/template_list.aspx','main_body','模版管理','2010-1-29 16:20:36',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 26,'M0204002','M0204','添加模版','TemplateAdd',3,'site/template_add.aspx','main_body','添加模版','2010-1-29 16:21:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 27,'M03','M0','内容管理','ContentManage',1,'content/news/article_list.aspx','main_body','内容管理','2010-1-17 17:03:23',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 28,'M0301','M03','信息管理','NewsManage',2,'content/news/','main_body','信息管理','2010-1-29 16:26:35',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 29,'M0301002','M0301','文档发布','ArchivsAdd',3,'javascript:;" onclick="alert('test');','main_body','文档发布','2010-1-29 16:57:18',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 30,'M0301008','M0301','内容审核','NewsVerify',3,'content/news/new_sverify.aspx','main_body','内容审核','2010-1-29 17:19:14',0,1,1,8)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 31,'M0301009','M0301','重复标题检测','NewsTitleDetect',3,'content/news/news_detect.aspx','main_body','重复标题检测','2010-1-29 17:22:52',0,1,1,9)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 32,'M0301010','M0301','内容回收站','NewsRecycle',3,'content/news/newsrecycle.aspx','main_body','内容回收站','2010-1-29 17:24:17',0,1,1,10)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 33,'M0302','M03','专题管理','SpecialManage',2,'content/news/','main_body','专题管理','2010-1-29 16:28:30',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 34,'M0302001','M0302','添加专题','SpecialAdd',3,'content/special_add.aspx','main_body','添加专题','2010-1-29 17:26:57',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 35,'M0302002','M0302','专题列表','SpecialList',3,'content/special_list.aspx','main_body','专题列表','2010-1-29 17:27:36',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 36,'M0303','M03','文档管理','ContentPublish',2,'content/','main_body','文档管理','2010-2-2 13:57:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 37,'M0303003','M0303','文章管理','ArticleList',3,'content/news/article_list.aspx','main_body','文章管理','2010-1-29 17:12:19',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 38,'M0303004','M0303','软件管理','SoftList',3,'content/news/soft_list.aspx','main_body','软件管理','2010-1-29 17:12:52',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 39,'M0303005','M0303','图片管理','PictureList',3,'content/news/picture_list.aspx','main_body','图片文档管理','2010-1-29 17:15:03',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 40,'M0303006','M0303','视频管理','VedioList',3,'content/news/vedio_list.aspx','main_body','视频文档管理','2010-1-29 17:16:20',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 41,'M0303007','M0303','产品管理','ProductList',3,'content/news/product_list.aspx','main_body','产品管理','2010-1-29 17:17:16',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 42,'M04','M0','生成管理','CreatStatic',1,'createstatic/createhtml.aspx','main_body','生成管理','2010-1-17 17:04:08',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 43,'M0401','M04','网站生成','CreateWeb',2,'createstatic/','main_body','生成管理','2009-12-30 21:52:47',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 44,'M0401001','M0401','一键更新','CreateAll',3,'createstatic/createall.aspx','main_body','一键更新','2009-12-30 21:54:47',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 45,'M0401002','M0401','生成首页','CreateHomePage',3,'createstatic/createhome.aspx','main_body','生成首页','2009-12-30 21:55:09',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 46,'M0401003','M0401','生成列表页','CreateList',3,'createstatic/createlist.aspx','main_body','生成列表页','2009-12-30 21:56:44',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 47,'M0401004','M0401','生成内容页','CreateContent',3,'createstatic/createcontent.aspx','main_body','生成内容页','2009-12-30 21:57:22',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 48,'M0401005','M0401','生成专题页','CreateSpecial',3,'createstatic/createspecial.aspx','main_body','生成专题页','2009-12-30 21:58:24',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 49,'M0402','M04','其他生成','CreateOther',2,'createstatic/','main_body','其他生成','2009-12-30 21:53:55',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 50,'M0402001','M0402','生成广告JS','CreateADJS',3,'createstatic/createadjs.aspx','main_body','生成广告JS','2009-12-30 21:59:16',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 51,'M0402002','M0402','生成调用JS','CreateInvokeJS',3,'createstatic/createinvokejs.aspx','main_body','生成调用JS','2009-12-30 21:59:37',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 52,'M0402003','M0402','生成站点地图','CreateSitemap',3,'createstatic/createsitemap.aspx','main_body','生成站点地图','2009-12-30 22:01:51',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 53,'M0402004','M0402','生成RSS','CreateRSS',3,'createstatic/createrss.aspx','main_body','生成RSS','2009-12-30 22:02:36',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 54,'M05','M0','用户管理','UserManage',1,'user/user_list.aspx','main_body','用户管理','2010-1-17 17:06:44',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 55,'M0501','M05','用户管理','UserManage',2,'user/','main_body','用户管理','2009-12-30 22:04:39',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 56,'M0501001','M0501','添加用户','UserAdd',3,'user/user_add.aspx','main_body','添加用户','2009-12-30 22:07:57',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 57,'M0501002','M0501','审核用户','UserVerify',3,'user/user_verify.aspx','main_body','审核用户','2009-12-30 22:08:38',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 58,'M0501003','M0501','管理用户','UserList',3,'user/user_list.aspx','main_body','管理用户','2009-12-30 22:09:51',1,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 59,'M0501004','M0501','注册管理','UserSetting',3,'user/user_setting.aspx','main_body','用户注册管理','2009-12-30 23:15:54',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 60,'M0502','M05','用户空间管理','SpaceManage',2,'user/','main_body','用户空间管理','2009-12-30 22:05:31',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 61,'M0502001','M0502','空间配置','SpaceSetting',3,'user/space_setting.aspx','main_body','空间配置','2009-12-30 22:12:02',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 62,'M0502002','M0502','管理空间','SpaceList',3,'user/sapce_list.aspx','main_body','管理空间','2009-12-30 22:12:31',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 63,'M0503','M05','权限管理','PermissionManage',2,'user/','main_body','权限管理','2009-12-30 22:06:41',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 64,'M0503001','M0503','权限配置','PermissionSetting',3,'user/permission_setting.aspx','main_body','添加权限','2009-12-30 22:14:06',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 65,'M0503002','M0503','角色管理','PermissionList',3,'user/permission_list.aspx','main_body','权限配置','2009-12-30 22:14:57',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 66,'M0504','M05','用户组管理','GroupManage',2,'user/','main_body','用户组管理','2009-12-30 22:07:08',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 67,'M0504001','M0504','添加用户组','GroupAdd',3,'user/group_add.aspx','main_body','添加用户组','2009-12-30 22:15:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 68,'M0504002','M0504','管理用户组','GroupList',3,'user/group_list.aspx','main_body','管理用户组','2009-12-30 22:17:24',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 69,'M06','M0','模块管理','ModuleManage',1,'module/module_list.aspx','main_body','插件管理','2010-1-17 17:08:30',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 70,'M0601','M06','网站投票','VoteManage',2,'modules/vote/','main_body','网站投票','2009-12-30 22:19:52',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 71,'M0601001','M0601','添加投票','VoteAdd',3,'modules/vote/vote_add.aspx','main_body','添加投票','2009-12-30 22:31:21',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 72,'M0601002','M0601','管理投票','VoteList',3,'modules/vote/vote_list.aspx','main_body','管理投票','2009-12-30 22:32:47',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 73,'M0602001','M0602','添加问卷','QuestionnaireAdd',3,'modules/questionnaire/questionnaire_add.aspx','main_body','添加问卷','2009-12-30 22:33:21',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 74,'M0602','M06','问卷调查','QuestionnaireManage',2,'modules/questionnaire/','main_body','问卷调查','2009-12-30 22:22:00',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 75,'M0602002','M0602','管理问卷','QuestionnaireList',3,'modules/questionnaire/questionnaire_list_aspx','main_body','管理问卷','2009-12-30 22:34:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 76,'M0602003','M0602','问卷报表','QuestionnaireResult',3,'modules/questionnaire/questionnaire_result.aspx','main_body','问卷报表','2009-12-30 22:34:43',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 77,'M0603','M06','广告管理','ADManage',2,'modules/ad/','main_body','广告管理','2009-12-30 22:27:11',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 78,'M0603001','M0603','添加广告','ADAdd',3,'modules/ad/ad_add.aspx','main_body','添加广告','2009-12-30 22:38:00',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 79,'M0603002','M0603','管理广告','ADList',3,'modules/ad/ad_list.aspx','main_body','管理广告','2009-12-30 22:42:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 80,'M0604','M06','友情连接','FlinkManage',2,'modules/flink/','main_body','友情连接','2009-12-30 22:27:56',1,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 81,'M0604001','M0604','添加链接','FlinkAdd',3,'modules/flink/flink_add.aspx','main_body','添加链接','2009-12-30 22:43:25',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 82,'M0604002','M0604','管理链接','FlinkList',3,'modules/flink/flink_list.aspx','main_body','管理链接','2009-12-30 22:44:04',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 83,'M0604003','M0604','链接检测','FlinkVerify',3,'modules/flink/flink_verify.aspx','main_body','链接检测','2009-12-30 22:45:14',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 84,'M0605','M06','问答模块','AskManage',2,'modules/ask/','main_body','问答模块','2009-12-30 22:29:50',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 85,'M0605001','M0605','新建问答','AskAdd',3,'modules/ask/ask_add.aspx','main_body','新建问答','2009-12-30 22:45:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 86,'M0605002','M0605','管理问答','AskList',3,'modules/ask/ask_list.aspx','main_body','管理问答','2009-12-30 22:47:20',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 87,'M0606','M06','访客留言','LeavewordManage',2,'modules/leaveword/','main_body','访客留言','2009-12-30 22:49:17',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 88,'M0606001','M0606','管理留言','LeavewordList',3,'modules/leaveword/leaveword_list.aspx','main_body','添加留言','2009-12-30 22:58:12',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 89,'M07','M0','系统管理','SystemManage',1,'admin/system/baseconfig.aspx','main_body','系统管理','2010-1-29 13:37:23',0,1,1,8)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 90,'M0701','M07','系统设置','SystemSetting',2,'system/','main_body','系统设置','2009-12-30 23:00:51',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 91,'M0701001','M0701','基本设置','BaseSetting',3,'system/base_setting.aspx','main_body','基本信息设置','2009-12-30 23:06:43',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 92,'M0701002','M0701','访问控制','VisitSetting',3,'system/visit_setting.aspx','main_body','访问设置','2009-12-30 23:14:33',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 93,'M0701003','M0701','安全控制','SafeSetting',3,'system/safe_setting.aspx','main_body','安全控制','2009-12-30 23:20:35',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 94,'M0701004','M0701','附件设置','AttchmentSetting',3,'system/attchment_setting.aspx','main_body','附件设置','2009-12-30 23:22:20',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 95,'M0701005','M0701','邮件设置','SMTPSetting',3,'system/smtp_setting.aspx','main_body','邮件设置','2009-12-30 23:24:57',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 96,'M0701006','M0701','高级设置','AdvancedSetting',3,'system/advanced_setting.aspx','main_body','高级设置','2009-12-30 23:26:02',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 97,'M0703','M07','数据库管理','DatabaseManage',2,'system/','main_body','数据库管理','2009-12-30 23:04:10',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 98,'M0703001','M0703','运行SQL语句','RunSQL',3,'system/database_runsql.aspx','main_body','运行指定SQL语句','2009-12-30 23:29:35',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 99,'M0703002','M0703','数据库备份','DatabaseBackup',3,'system/database_backup.aspx','main_body','数据库备份','2009-12-30 23:30:18',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 100,'M0703003','M0703','数据库恢复','DatabaseRevert',3,'system/database_revert.aspx','main_body','数据库恢复','2009-12-30 23:31:49',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 101,'M0703004','M0703','收缩数据库','DatabaseCompress',3,'system/database_compress.aspx','main_body','数据库收缩','2009-12-30 23:33:37',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 102,'M0704','M07','日志管理','LogManage',2,'system/','main_body','日志管理','2009-12-30 23:05:21',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 103,'M0704001','M0704','后台操作日志','OperateLog',3,'system/log_operate.aspx','main_body','后台操作日志','2009-12-30 23:36:04',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 104,'M0704002','M0704','错误日志','ErrorLog',3,'system/log_error.aspx','main_body','错误日志','2009-12-30 23:36:39',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 105,'M08','M0','数据维护','DataManage',1,'data/tag_list.aspx','main_body','数据维护','2008-1-2 22:27:48',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 106,'M0801','M08','信息维护','DataInfo',2,'data/','main_body','信息维护','2008-1-2 22:30:50',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 107,'M0801001','M0801','文档评论管理','CommentList',3,'data/commen_list.aspx','main_body','文档评论管理','2010-1-29 16:29:41',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 108,'M0801002','M0801','搜索关键字管理','SearchwordtList',3,'data/searchword_list.aspx','main_body','搜索关键字管理','2010-2-1 14:26:15',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 109,'M0801003','M0801','文档信息统计','ArchivesInfo',3,'data/archives_info.aspx','main_body','评论管理','2010-2-1 14:27:49',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 110,'M0801004','M0801','附件数据管理','AttachmentList',3,'content/attachment/attachment_list.aspx','main_body','附件数据管理','2010-1-29 17:31:52',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 111,'M0802','M08','基础数据维护','DataBasic',2,'data/','main_body','基础数据维护','2008-1-2 22:35:55',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 112,'M0802001','M0802','TAG关键字维护','TAGManage',3,'data/tag_list.aspx','main_body','TAG关键字维护','2010-1-29 16:30:49',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 113,'M0802002','M0802','文档关键字维护','KeywordManage',3,'data/keyword_list.aspx','main_body','文档关键字维护','2010-1-29 16:34:35',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 114,'M0802003','M0802','来源管理','SourceList',3,'data/source_list.aspx','main_body','来源管理','2008-1-2 22:44:28',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 115,'M0802004','M0802','作者管理','AuthorList',3,'data/author_list.aspx','main_body','作者管理','2008-1-2 22:45:24',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 116,'M0802005','M0802','自定义文档属性','CustomAttr',3,'data/customattr.aspx','main_body','自定义文档属性','2008-1-2 22:50:13',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 117,'M0803','M08','数据字典维护','DataDicManage',2,'data/','main_body','基础数据','2009-12-30 23:02:24',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 118,'M0803001','M0803','数据字典维护','DataBatch',3,'data/','main_body','批量数据维护','2008-1-2 23:24:30',0,1,1,3)

SET IDENTITY_INSERT [DT_Modules] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Roles]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Roles]

CREATE TABLE [DT_Roles] (
[ID] [int]  NOT NULL,
[RoleName] [nvarchar]  (50) NOT NULL,
[Description] [nvarchar]  (200) NULL,
[AddDate] [datetime]  NULL,
[OrderID] [int]  NULL DEFAULT ((0)))

ALTER TABLE [DT_Roles] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Roles] PRIMARY KEY  NONCLUSTERED ( [ID] )
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 1,'超级管理员','具有系统所有权限(系统内置角色,不能被删除)','2010-2-14 15:08:19',1)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 2,'系统管理员','具有系统所有权限','2010-2-14 15:08:19',2)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 3,'信息发布员','具有文章发布删除审核等权限','2010-2-14 23:28:20',3)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 4,'注册会员','没有后台管理权限','2010-2-14 23:27:09',4)
if exists (select * from sysobjects where id = OBJECT_ID('[DT_RolesInModules]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_RolesInModules]

CREATE TABLE [DT_RolesInModules] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[RoleID] [int]  NOT NULL,
[ModuleID] [char]  (8) NOT NULL,
[ControlValue] [int]  NOT NULL)

ALTER TABLE [DT_RolesInModules] WITH NOCHECK ADD  CONSTRAINT [PK_DT_RolesInModules] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_RolesInModules] ON

INSERT [DT_RolesInModules] ([ID],[RoleID],[ModuleID],[ControlValue]) VALUES ( 1,1,'M0101001',15)
INSERT [DT_RolesInModules] ([ID],[RoleID],[ModuleID],[ControlValue]) VALUES ( 2,1,'M0101002',31)

SET IDENTITY_INSERT [DT_RolesInModules] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Sys_Dict]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Sys_Dict]

CREATE TABLE [DT_Sys_Dict] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[Type] [varchar]  (50) NULL,
[Title] [nvarchar]  (50) NULL,
[Url] [varchar]  (255) NULL,
[Email] [varchar]  (50) NULL,
[Click] [int]  NULL DEFAULT ((0)))

ALTER TABLE [DT_Sys_Dict] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Sys_Dict] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_Sys_Dict] ON


SET IDENTITY_INSERT [DT_Sys_Dict] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Sys_Template]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Sys_Template]

CREATE TABLE [DT_Sys_Template] (
[TemplateID] [int]  IDENTITY (1, 1)  NOT NULL,
[TemplateName] [nvarchar]  (50) NOT NULL,
[TemplateDirectory] [varchar]  (255) NOT NULL,
[IsEnable] [tinyint]  NOT NULL,
[CreateDateTime] [datetime]  NULL,
[TemplateImg] [varchar]  (255) NULL,
[Author] [nvarchar]  (50) NULL)

ALTER TABLE [DT_Sys_Template] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Sys_Template] PRIMARY KEY  NONCLUSTERED ( [TemplateID] )
SET IDENTITY_INSERT [DT_Sys_Template] ON


SET IDENTITY_INSERT [DT_Sys_Template] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Userfields]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Userfields]

CREATE TABLE [DT_Userfields] (
[UID] [int]  NOT NULL,
[Realname] [nvarchar]  (50) NULL,
[QQ] [varchar]  (50) NULL,
[MSN] [varchar]  (50) NULL,
[Skype] [varchar]  (50) NULL,
[Phone] [char]  (16) NULL,
[Mobilephone] [char]  (11) NULL,
[Location] [nvarchar]  (50) NULL,
[Adress] [nvarchar]  (200) NULL,
[IDcard] [varchar]  (18) NULL,
[Signature] [nvarchar]  (200) NULL,
[Introduce] [nvarchar]  (500) NULL,
[Website] [varchar]  (200) NULL)

ALTER TABLE [DT_Userfields] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Userfields] PRIMARY KEY  NONCLUSTERED ( [UID] )
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Usergroup]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Usergroup]

CREATE TABLE [DT_Usergroup] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[Type] [tinyint]  NOT NULL DEFAULT ((0)),
[IsSystem] [tinyint]  NULL DEFAULT ((0)),
[GroupName] [nvarchar]  (50) NULL,
[Description] [nvarchar]  (255) NULL,
[CreditBegin] [int]  NULL DEFAULT ((0)),
[CreditEnd] [int]  NULL DEFAULT ((0)),
[stars] [tinyint]  NULL DEFAULT ((0)),
[GroupAvatar] [varchar]  (255) NULL,
[Readaccess] [int]  NULL DEFAULT ((0)),
[AllowPost] [tinyint]  NULL DEFAULT ((0)),
[AllowComment] [tinyint]  NULL DEFAULT ((0)),
[AllowDownload] [tinyint]  NULL DEFAULT ((0)),
[AllowAvatar] [tinyint]  NULL DEFAULT ((0)),
[AllowSpace] [tinyint]  NULL DEFAULT ((0)),
[AllowTransfer] [tinyint]  NULL DEFAULT ((0)),
[AllowViewInfo] [tinyint]  NULL DEFAULT ((0)),
[AllowNickname] [tinyint]  NULL DEFAULT ((0)),
[MaxPMNum] [smallint]  NULL,
[MaxSignSize] [smallint]  NULL,
[MaxAttachSize] [int]  NULL,
[MaxAttachTotalSize] [int]  NULL,
[AttachExtension] [varchar]  (255) NULL,
[OrderID] [int]  NULL)

ALTER TABLE [DT_Usergroup] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Usergroup] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [DT_Usergroup] ON

INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 1,0,1,'系统管理组','拥有系统最高权限',0,0,16,200,1,1,1,1,1,1,1,1,200,200,1024,10240,1)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 2,1,1,'管理组','具用所有管理权限，无系统配置权限',0,0,15,180,1,1,1,1,1,1,1,1,100,200,1024,10240,2)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 3,2,1,'等待验证会员','等待验证会员',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 4,2,0,'新手上路','新手上路',0,100,1,10,1,0,0,0,0,0,0,0,30,50,200,1000,4)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 5,2,0,'初级会员','初级会员',100,300,2,0,0,0,0,0,0,0,0,0,40,60,300,2000,5)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 6,2,0,'中级会员','中级会员',300,1000,3,0,0,0,0,0,0,0,0,0,50,70,500,3000,6)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 7,2,0,'高级会员','高级会员',1000,2000,4,0,0,0,0,0,0,0,0,0,60,80,500,4000,7)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 8,2,0,'金牌会员','金牌会员',2000,999999999,5,1,1,1,1,1,1,1,1,1,70,90,500,5000,8)

SET IDENTITY_INSERT [DT_Usergroup] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[DT_Users]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [DT_Users]

CREATE TABLE [DT_Users] (
[UID] [int]  IDENTITY (1, 1)  NOT NULL,
[UserName] [varchar]  (50) NOT NULL,
[NickName] [nvarchar]  (50) NULL,
[Password] [varchar]  (64) NOT NULL,
[SecureQuestion] [nvarchar]  (50) NULL,
[SecureAnswer] [nvarchar]  (50) NULL,
[Sex] [tinyint]  NULL DEFAULT ((1)),
[Email] [varchar]  (50) NULL,
[RoleID] [int]  NULL DEFAULT ((0)),
[UsergroupID] [int]  NULL DEFAULT ((0)),
[RegisterIP] [char]  (15) NULL,
[RegisterTime] [datetime]  NULL DEFAULT (getdate()),
[LastloginIP] [char]  (15) NULL,
[LastloginTime] [datetime]  NULL DEFAULT (getdate()),
[LoginCount] [int]  NULL DEFAULT ((0)),
[PostCount] [int]  NULL DEFAULT ((0)),
[OnlineTime] [int]  NULL DEFAULT ((0)),
[Credits] [int]  NULL DEFAULT ((0)),
[ExtCredits1] [decimal]  (18,0) NULL DEFAULT ((0)),
[ExtCredits2] [decimal]  (18,0) NULL DEFAULT ((0)),
[ExtCredits3] [decimal]  (18,0) NULL DEFAULT ((0)),
[ExtCredits4] [decimal]  (18,0) NULL,
[ExtCredits5] [decimal]  (18,0) NULL,
[Avatar] [varchar]  (200) NULL,
[Birthday] [smalldatetime]  NULL,
[PMCount] [int]  NULL DEFAULT ((0)),
[IsVerify] [tinyint]  NULL DEFAULT ((0)),
[IsLock] [tinyint]  NULL DEFAULT ((0)))

ALTER TABLE [DT_Users] WITH NOCHECK ADD  CONSTRAINT [PK_DT_Users] PRIMARY KEY  NONCLUSTERED ( [UID] )
SET IDENTITY_INSERT [DT_Users] ON

INSERT [DT_Users] ([UID],[UserName],[NickName],[Password],[Sex],[Email],[RoleID],[UsergroupID],[RegisterIP],[RegisterTime],[LastloginIP],[LastloginTime],[LoginCount],[PostCount],[OnlineTime],[Credits],[ExtCredits1],[ExtCredits2],[ExtCredits3],[PMCount],[IsVerify],[IsLock]) VALUES ( 1,'admin','admin','admin',1,'admin@91aspx.com',1,1,'192.168.1.1','2010-2-10 20:26:42','127.0.0.1','2010-2-16 16:37:34',127,0,0,0,0,0,0,0,1,0)
INSERT [DT_Users] ([UID],[UserName],[NickName],[Password],[Sex],[Email],[RoleID],[UsergroupID],[RegisterIP],[RegisterTime],[LastloginIP],[LastloginTime],[LoginCount],[PostCount],[OnlineTime],[Credits],[ExtCredits1],[ExtCredits2],[ExtCredits3],[PMCount],[IsVerify],[IsLock]) VALUES ( 2,'admin','admin','admin',1,'admin888@91aspx.com',1,1,'192.168.1.1','2010-2-10 20:26:42','127.0.0.1','2010-2-12 20:20:15',29,0,0,0,0,0,0,0,1,0)

SET IDENTITY_INSERT [DT_Users] OFF
