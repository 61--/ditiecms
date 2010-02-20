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

INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 9,0,1,'WEB����','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',10)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 10,9,1,'HTML����','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',10)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 11,9,1,'Javascript','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',30)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 12,9,1,'DIV+CSS','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',50)
INSERT [DT_Arc_Class] ([CID],[ParentID],[Attribute],[ClassName],[ClassEName],[ClassType],[IsHidden],[IsHtml],[CheckLevel],[IsContribute],[IsComment],[Readaccess],[AddDate],[OrderID]) VALUES ( 13,9,1,'AJAX����','webjs',1,0,1,1,1,1,1,'2010-1-1 0:00:00',40)

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

INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 5,'�鿴','M02',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 6,'�鿴','M0201',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 7,'�鿴','M0202',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 8,'�鿴','M0203',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 9,'�鿴','M0204',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 10,'�鿴','M03',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 11,'�鿴','M0301',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 12,'�鿴','M0302',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 13,'�鿴','M0303',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 14,'�鿴','M04',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 15,'�鿴','M0401',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 16,'�鿴','M0402',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 17,'�鿴','M05',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 18,'�鿴','M0501',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 19,'�鿴','M0502',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 20,'�鿴','M0503',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 21,'�鿴','M0504',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 22,'�鿴','M06',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 23,'�鿴','M0601',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 24,'�鿴','M0602',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 25,'�鿴','M0603',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 26,'�鿴','M0604',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 27,'�鿴','M0605',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 28,'�鿴','M0606',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 29,'�鿴','M07',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 30,'�鿴','M0701',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 31,'�鿴','M0703',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 32,'�鿴','M0704',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 33,'�鿴','M08',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 34,'�鿴','M0801',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 35,'�鿴','M0802',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 36,'�鿴','M0803',1,0)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 61,'�鿴','M0201001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 62,'���','M0201001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 63,'�༭','M0201001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 64,'ɾ��','M0201001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 65,'�鿴','M0201003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 66,'���','M0201003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 67,'�༭','M0201003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 68,'ɾ��','M0201003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 69,'�鿴','M0201002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 70,'���','M0201002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 71,'�༭','M0201002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 72,'ɾ��','M0201002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 73,'�鿴','M0202001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 74,'���','M0202001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 75,'�༭','M0202001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 76,'ɾ��','M0202001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 77,'�鿴','M0202002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 78,'���','M0202002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 79,'�༭','M0202002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 80,'ɾ��','M0202002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 81,'�鿴','M0202003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 82,'���','M0202003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 83,'�༭','M0202003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 84,'ɾ��','M0202003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 85,'�鿴','M0202004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 86,'���','M0202004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 87,'�༭','M0202004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 88,'ɾ��','M0202004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 89,'�鿴','M0203001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 90,'���','M0203001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 91,'�༭','M0203001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 92,'ɾ��','M0203001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 93,'�鿴','M0203002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 94,'���','M0203002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 95,'�༭','M0203002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 96,'ɾ��','M0203002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 97,'�鿴','M0204001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 98,'���','M0204001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 99,'�༭','M0204001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 100,'ɾ��','M0204001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 105,'�鿴','M0301002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 106,'���','M0301002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 107,'�༭','M0301002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 108,'ɾ��','M0301002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 109,'�鿴','M0301008',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 110,'���','M0301008',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 111,'�༭','M0301008',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 112,'ɾ��','M0301008',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 113,'�鿴','M0301009',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 114,'���','M0301009',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 115,'�༭','M0301009',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 116,'ɾ��','M0301009',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 117,'�鿴','M0301010',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 118,'���','M0301010',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 119,'�༭','M0301010',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 120,'ɾ��','M0301010',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 121,'�鿴','M0302001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 122,'���','M0302001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 123,'�༭','M0302001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 124,'ɾ��','M0302001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 125,'�鿴','M0302002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 126,'���','M0302002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 127,'�༭','M0302002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 128,'ɾ��','M0302002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 129,'�鿴','M0303003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 130,'���','M0303003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 131,'�༭','M0303003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 132,'ɾ��','M0303003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 133,'�鿴','M0303004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 134,'���','M0303004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 135,'�༭','M0303004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 136,'ɾ��','M0303004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 137,'�鿴','M0303005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 138,'���','M0303005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 139,'�༭','M0303005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 140,'ɾ��','M0303005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 141,'�鿴','M0303006',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 142,'���','M0303006',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 143,'�༭','M0303006',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 144,'ɾ��','M0303006',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 145,'�鿴','M0303007',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 146,'���','M0303007',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 147,'�༭','M0303007',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 148,'ɾ��','M0303007',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 149,'�鿴','M0401001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 150,'���','M0401001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 151,'�༭','M0401001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 152,'ɾ��','M0401001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 153,'�鿴','M0401002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 154,'���','M0401002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 155,'�༭','M0401002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 156,'ɾ��','M0401002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 157,'�鿴','M0401003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 158,'���','M0401003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 159,'�༭','M0401003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 160,'ɾ��','M0401003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 161,'�鿴','M0401004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 162,'���','M0401004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 163,'�༭','M0401004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 164,'ɾ��','M0401004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 165,'�鿴','M0401005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 166,'���','M0401005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 167,'�༭','M0401005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 168,'ɾ��','M0401005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 169,'�鿴','M0402001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 170,'���','M0402001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 171,'�༭','M0402001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 172,'ɾ��','M0402001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 173,'�鿴','M0402002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 174,'���','M0402002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 175,'�༭','M0402002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 176,'ɾ��','M0402002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 177,'�鿴','M0402003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 178,'���','M0402003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 179,'�༭','M0402003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 180,'ɾ��','M0402003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 181,'�鿴','M0402004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 182,'���','M0402004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 183,'�༭','M0402004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 184,'ɾ��','M0402004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 185,'�鿴','M0501001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 186,'���','M0501001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 187,'�༭','M0501001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 188,'ɾ��','M0501001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 189,'�鿴','M0501002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 190,'���','M0501002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 191,'�༭','M0501002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 192,'ɾ��','M0501002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 193,'�鿴','M0501003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 194,'���','M0501003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 195,'�༭','M0501003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 196,'ɾ��','M0501003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 197,'�鿴','M0501004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 198,'���','M0501004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 199,'�༭','M0501004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 200,'ɾ��','M0501004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 201,'�鿴','M0502001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 202,'���','M0502001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 203,'�༭','M0502001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 204,'ɾ��','M0502001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 205,'�鿴','M0502002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 206,'���','M0502002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 207,'�༭','M0502002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 208,'ɾ��','M0502002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 209,'�鿴','M0503001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 210,'���','M0503001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 211,'�༭','M0503001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 212,'ɾ��','M0503001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 213,'�鿴','M0503002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 214,'���','M0503002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 215,'�༭','M0503002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 216,'ɾ��','M0503002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 217,'�鿴','M0504001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 218,'���','M0504001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 219,'�༭','M0504001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 220,'ɾ��','M0504001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 221,'�鿴','M0504002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 222,'���','M0504002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 223,'�༭','M0504002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 224,'ɾ��','M0504002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 225,'�鿴','M0601001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 226,'���','M0601001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 227,'�༭','M0601001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 228,'ɾ��','M0601001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 229,'�鿴','M0601002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 230,'���','M0601002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 231,'�༭','M0601002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 232,'ɾ��','M0601002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 233,'�鿴','M0602001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 234,'���','M0602001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 235,'�༭','M0602001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 236,'ɾ��','M0602001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 237,'�鿴','M0602002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 238,'���','M0602002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 239,'�༭','M0602002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 240,'ɾ��','M0602002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 241,'�鿴','M0602003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 242,'���','M0602003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 243,'�༭','M0602003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 244,'ɾ��','M0602003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 245,'�鿴','M0603001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 246,'���','M0603001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 247,'�༭','M0603001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 248,'ɾ��','M0603001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 249,'�鿴','M0603002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 250,'���','M0603002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 251,'�༭','M0603002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 252,'ɾ��','M0603002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 253,'�鿴','M0604001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 254,'���','M0604001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 255,'�༭','M0604001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 256,'ɾ��','M0604001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 257,'�鿴','M0604002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 258,'���','M0604002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 259,'�༭','M0604002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 260,'ɾ��','M0604002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 261,'�鿴','M0604003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 262,'���','M0604003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 263,'�༭','M0604003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 264,'ɾ��','M0604003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 265,'�鿴','M0605001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 266,'���','M0605001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 267,'�༭','M0605001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 268,'ɾ��','M0605001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 269,'�鿴','M0605002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 270,'���','M0605002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 271,'�༭','M0605002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 272,'ɾ��','M0605002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 273,'�鿴','M0606001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 274,'���','M0606001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 275,'�༭','M0606001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 276,'ɾ��','M0606001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 277,'�鿴','M0701001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 278,'���','M0701001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 279,'�༭','M0701001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 280,'ɾ��','M0701001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 281,'�鿴','M0701002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 282,'���','M0701002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 283,'�༭','M0701002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 284,'ɾ��','M0701002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 285,'�鿴','M0701003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 286,'���','M0701003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 287,'�༭','M0701003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 288,'ɾ��','M0701003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 289,'�鿴','M0701004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 290,'���','M0701004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 291,'�༭','M0701004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 292,'ɾ��','M0701004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 293,'�鿴','M0701005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 294,'���','M0701005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 295,'�༭','M0701005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 296,'ɾ��','M0701005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 297,'�鿴','M0701006',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 298,'���','M0701006',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 299,'�༭','M0701006',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 300,'ɾ��','M0701006',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 301,'�鿴','M0703001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 302,'���','M0703001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 303,'�༭','M0703001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 304,'ɾ��','M0703001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 305,'�鿴','M0703002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 306,'���','M0703002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 307,'�༭','M0703002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 308,'ɾ��','M0703002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 309,'�鿴','M0703003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 310,'���','M0703003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 311,'�༭','M0703003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 312,'ɾ��','M0703003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 313,'�鿴','M0703004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 314,'���','M0703004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 315,'�༭','M0703004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 316,'ɾ��','M0703004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 317,'�鿴','M0704001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 318,'���','M0704001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 319,'�༭','M0704001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 320,'ɾ��','M0704001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 321,'�鿴','M0704002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 322,'���','M0704002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 323,'�༭','M0704002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 324,'ɾ��','M0704002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 325,'�鿴','M0801001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 326,'���','M0801001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 327,'�༭','M0801001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 328,'ɾ��','M0801001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 329,'�鿴','M0801002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 330,'���','M0801002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 331,'�༭','M0801002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 332,'ɾ��','M0801002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 333,'�鿴','M0801003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 334,'���','M0801003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 335,'�༭','M0801003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 336,'ɾ��','M0801003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 337,'�鿴','M0801004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 338,'���','M0801004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 339,'�༭','M0801004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 340,'ɾ��','M0801004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 341,'�鿴','M0802001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 342,'���','M0802001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 343,'�༭','M0802001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 344,'ɾ��','M0802001',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 345,'�鿴','M0802002',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 346,'���','M0802002',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 347,'�༭','M0802002',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 348,'ɾ��','M0802002',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 349,'�鿴','M0802003',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 350,'���','M0802003',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 351,'�༭','M0802003',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 352,'ɾ��','M0802003',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 353,'�鿴','M0802004',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 354,'���','M0802004',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 355,'�༭','M0802004',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 356,'ɾ��','M0802004',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 357,'�鿴','M0802005',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 358,'���','M0802005',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 359,'�༭','M0802005',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 360,'ɾ��','M0802005',8,4)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 361,'�鿴','M0803001',1,1)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 362,'���','M0803001',2,2)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 363,'�༭','M0803001',4,3)
INSERT [DT_ModuleControl] ([ID],[ControlName],[ModuleID],[ControlValue],[OrderID]) VALUES ( 364,'ɾ��','M0803001',8,4)

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

INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 1,'M01','M0','�������','ControlPanel',1,'controlpanel.aspx','main_body','��������','2010-1-17 17:07:08',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 2,'M0101','M01','��ݵ���','QuickMenu',2,'main_body','��ݵ���','2010-1-17 17:19:35',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 3,'M0102','M01','������Ϣ','PersonalInfo',2,'user/','main_body','������Ϣ','2010-1-17 17:20:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 4,'M0102001','M0102','�ҵ�����','MyInfo',3,'user/myinfo.aspx','main_body','�ҵ�����','2010-1-17 17:21:07',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 5,'M0102002','M0102','����Ϣ','MyPM',3,'user/pm_list.aspx','main_body','����Ϣ','2010-1-29 15:47:25',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 6,'M0102003','M0102','�ҵ�Ȩ��','MyPermission',3,'user/mypermission.aspx','main_body','�ҵ�Ȩ��','2010-1-29 15:48:00',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 7,'M0103','M01','ϵͳ����','SystemHelp',2,'help/','main_body','ϵͳ����','2010-2-1 14:57:22',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 8,'M0103001','M0103','ϵͳʹ�ð���','SystemHelp',3,'http://www.91aspx.com/help/','_blank','ϵͳʹ�ð���','2010-2-1 14:58:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 9,'M0103002','M0103','ģ���ǩ����','TemplateHelp',3,'http://www.91aspx.com/help/','_blank','ģ���ǩ����','2010-2-1 15:00:17',0,0,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 10,'M0103003','M0103','�ٷ���վ','OfficialSite',3,'http://www.91aspx.com/','_blank','�ٷ���վ','2010-2-1 15:04:00',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 11,'M02','M0','վ�����','SiteManage',1,'site/class_list.aspx','main_body','Ƶ������','2010-1-17 17:01:21',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 12,'M0201','M02','Ƶ������','ChannelManage',2,'site/','main_body','Ƶ������','2010-1-29 16:01:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 13,'M0201001','M0201','����ģ�͹���','ModelList',3,'site/model_list.aspx','main_body','����ģ�͹���','2010-1-29 16:07:39',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 14,'M0201003','M0201','��ҳ�ĵ�����','SimpleArchiveList',3,'site/simplearchive_list.aspx','main_body','��ҳ�ĵ�����','2010-1-29 16:08:36',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 15,'M0201002','M0201','��վ��Ŀ����','ClassList',3,'site/class_list.aspx','main_body','��վ��Ŀ����','2010-1-29 16:12:44',1,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 16,'M0202','M02','Ƶ������','ChannelSetting',2,'site/','main_body','Ƶ������','2010-1-29 16:02:39',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 17,'M0202001','M0202','��ĿĬ���ֶ�','ClassAdd',3,'site/class_add.aspx','main_body','��ĿĬ���ֶ�','2010-1-29 16:12:23',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 18,'M0202002','M0202','��Ŀ���ɼ�����','ClassImport',3,'site/class_import.aspx','main_body','��Ŀ���ɼ�����','2010-1-29 16:14:24',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 19,'M0202003','M0202','�ĵ�Ĭ���ֶ�','ArchivesDefault',3,'site/archivesdefault_setting.aspx','main_body','�ĵ�Ĭ���ֶ�','2010-2-2 14:32:58',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 20,'M0202004','M0202','�����������','SoftDownload',3,'site/softdownload_setting.aspx','main_body','�����������','2010-2-2 14:34:39',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 21,'M0203','M02','�ļ�����','FileManage',2,'site/','main_body','�ļ�����','2010-1-29 16:03:24',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 22,'M0203001','M0203','�ļ�������','FileList',3,'site/file_list.aspx','main_body','�ļ�������','2010-1-29 16:16:30',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 23,'M0203002','M0203','ľ����','FileTrojanDetect',3,'site/file_detect.aspx','main_body','�ļ�ľ����','2010-1-29 16:18:47',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 24,'M0204','M02','ģ�����','TemplateManage',2,'site/','main_body','ģ�����','2010-1-29 16:04:36',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 25,'M0204001','M0204','ģ�����','TemplateList',3,'site/template_list.aspx','main_body','ģ�����','2010-1-29 16:20:36',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 26,'M0204002','M0204','���ģ��','TemplateAdd',3,'site/template_add.aspx','main_body','���ģ��','2010-1-29 16:21:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 27,'M03','M0','���ݹ���','ContentManage',1,'content/news/article_list.aspx','main_body','���ݹ���','2010-1-17 17:03:23',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 28,'M0301','M03','��Ϣ����','NewsManage',2,'content/news/','main_body','��Ϣ����','2010-1-29 16:26:35',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 29,'M0301002','M0301','�ĵ�����','ArchivsAdd',3,'javascript:;" onclick="alert('test');','main_body','�ĵ�����','2010-1-29 16:57:18',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 30,'M0301008','M0301','�������','NewsVerify',3,'content/news/new_sverify.aspx','main_body','�������','2010-1-29 17:19:14',0,1,1,8)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 31,'M0301009','M0301','�ظ�������','NewsTitleDetect',3,'content/news/news_detect.aspx','main_body','�ظ�������','2010-1-29 17:22:52',0,1,1,9)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 32,'M0301010','M0301','���ݻ���վ','NewsRecycle',3,'content/news/newsrecycle.aspx','main_body','���ݻ���վ','2010-1-29 17:24:17',0,1,1,10)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 33,'M0302','M03','ר�����','SpecialManage',2,'content/news/','main_body','ר�����','2010-1-29 16:28:30',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 34,'M0302001','M0302','���ר��','SpecialAdd',3,'content/special_add.aspx','main_body','���ר��','2010-1-29 17:26:57',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 35,'M0302002','M0302','ר���б�','SpecialList',3,'content/special_list.aspx','main_body','ר���б�','2010-1-29 17:27:36',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 36,'M0303','M03','�ĵ�����','ContentPublish',2,'content/','main_body','�ĵ�����','2010-2-2 13:57:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 37,'M0303003','M0303','���¹���','ArticleList',3,'content/news/article_list.aspx','main_body','���¹���','2010-1-29 17:12:19',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 38,'M0303004','M0303','�������','SoftList',3,'content/news/soft_list.aspx','main_body','�������','2010-1-29 17:12:52',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 39,'M0303005','M0303','ͼƬ����','PictureList',3,'content/news/picture_list.aspx','main_body','ͼƬ�ĵ�����','2010-1-29 17:15:03',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 40,'M0303006','M0303','��Ƶ����','VedioList',3,'content/news/vedio_list.aspx','main_body','��Ƶ�ĵ�����','2010-1-29 17:16:20',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 41,'M0303007','M0303','��Ʒ����','ProductList',3,'content/news/product_list.aspx','main_body','��Ʒ����','2010-1-29 17:17:16',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 42,'M04','M0','���ɹ���','CreatStatic',1,'createstatic/createhtml.aspx','main_body','���ɹ���','2010-1-17 17:04:08',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 43,'M0401','M04','��վ����','CreateWeb',2,'createstatic/','main_body','���ɹ���','2009-12-30 21:52:47',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 44,'M0401001','M0401','һ������','CreateAll',3,'createstatic/createall.aspx','main_body','һ������','2009-12-30 21:54:47',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 45,'M0401002','M0401','������ҳ','CreateHomePage',3,'createstatic/createhome.aspx','main_body','������ҳ','2009-12-30 21:55:09',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 46,'M0401003','M0401','�����б�ҳ','CreateList',3,'createstatic/createlist.aspx','main_body','�����б�ҳ','2009-12-30 21:56:44',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 47,'M0401004','M0401','��������ҳ','CreateContent',3,'createstatic/createcontent.aspx','main_body','��������ҳ','2009-12-30 21:57:22',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 48,'M0401005','M0401','����ר��ҳ','CreateSpecial',3,'createstatic/createspecial.aspx','main_body','����ר��ҳ','2009-12-30 21:58:24',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 49,'M0402','M04','��������','CreateOther',2,'createstatic/','main_body','��������','2009-12-30 21:53:55',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 50,'M0402001','M0402','���ɹ��JS','CreateADJS',3,'createstatic/createadjs.aspx','main_body','���ɹ��JS','2009-12-30 21:59:16',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 51,'M0402002','M0402','���ɵ���JS','CreateInvokeJS',3,'createstatic/createinvokejs.aspx','main_body','���ɵ���JS','2009-12-30 21:59:37',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 52,'M0402003','M0402','����վ���ͼ','CreateSitemap',3,'createstatic/createsitemap.aspx','main_body','����վ���ͼ','2009-12-30 22:01:51',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 53,'M0402004','M0402','����RSS','CreateRSS',3,'createstatic/createrss.aspx','main_body','����RSS','2009-12-30 22:02:36',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 54,'M05','M0','�û�����','UserManage',1,'user/user_list.aspx','main_body','�û�����','2010-1-17 17:06:44',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 55,'M0501','M05','�û�����','UserManage',2,'user/','main_body','�û�����','2009-12-30 22:04:39',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 56,'M0501001','M0501','����û�','UserAdd',3,'user/user_add.aspx','main_body','����û�','2009-12-30 22:07:57',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 57,'M0501002','M0501','����û�','UserVerify',3,'user/user_verify.aspx','main_body','����û�','2009-12-30 22:08:38',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 58,'M0501003','M0501','�����û�','UserList',3,'user/user_list.aspx','main_body','�����û�','2009-12-30 22:09:51',1,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 59,'M0501004','M0501','ע�����','UserSetting',3,'user/user_setting.aspx','main_body','�û�ע�����','2009-12-30 23:15:54',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 60,'M0502','M05','�û��ռ����','SpaceManage',2,'user/','main_body','�û��ռ����','2009-12-30 22:05:31',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 61,'M0502001','M0502','�ռ�����','SpaceSetting',3,'user/space_setting.aspx','main_body','�ռ�����','2009-12-30 22:12:02',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 62,'M0502002','M0502','����ռ�','SpaceList',3,'user/sapce_list.aspx','main_body','����ռ�','2009-12-30 22:12:31',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 63,'M0503','M05','Ȩ�޹���','PermissionManage',2,'user/','main_body','Ȩ�޹���','2009-12-30 22:06:41',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 64,'M0503001','M0503','Ȩ������','PermissionSetting',3,'user/permission_setting.aspx','main_body','���Ȩ��','2009-12-30 22:14:06',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 65,'M0503002','M0503','��ɫ����','PermissionList',3,'user/permission_list.aspx','main_body','Ȩ������','2009-12-30 22:14:57',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 66,'M0504','M05','�û������','GroupManage',2,'user/','main_body','�û������','2009-12-30 22:07:08',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 67,'M0504001','M0504','����û���','GroupAdd',3,'user/group_add.aspx','main_body','����û���','2009-12-30 22:15:33',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 68,'M0504002','M0504','�����û���','GroupList',3,'user/group_list.aspx','main_body','�����û���','2009-12-30 22:17:24',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 69,'M06','M0','ģ�����','ModuleManage',1,'module/module_list.aspx','main_body','�������','2010-1-17 17:08:30',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 70,'M0601','M06','��վͶƱ','VoteManage',2,'modules/vote/','main_body','��վͶƱ','2009-12-30 22:19:52',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 71,'M0601001','M0601','���ͶƱ','VoteAdd',3,'modules/vote/vote_add.aspx','main_body','���ͶƱ','2009-12-30 22:31:21',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 72,'M0601002','M0601','����ͶƱ','VoteList',3,'modules/vote/vote_list.aspx','main_body','����ͶƱ','2009-12-30 22:32:47',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 73,'M0602001','M0602','����ʾ�','QuestionnaireAdd',3,'modules/questionnaire/questionnaire_add.aspx','main_body','����ʾ�','2009-12-30 22:33:21',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 74,'M0602','M06','�ʾ����','QuestionnaireManage',2,'modules/questionnaire/','main_body','�ʾ����','2009-12-30 22:22:00',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 75,'M0602002','M0602','�����ʾ�','QuestionnaireList',3,'modules/questionnaire/questionnaire_list_aspx','main_body','�����ʾ�','2009-12-30 22:34:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 76,'M0602003','M0602','�ʾ���','QuestionnaireResult',3,'modules/questionnaire/questionnaire_result.aspx','main_body','�ʾ���','2009-12-30 22:34:43',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 77,'M0603','M06','������','ADManage',2,'modules/ad/','main_body','������','2009-12-30 22:27:11',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 78,'M0603001','M0603','��ӹ��','ADAdd',3,'modules/ad/ad_add.aspx','main_body','��ӹ��','2009-12-30 22:38:00',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 79,'M0603002','M0603','������','ADList',3,'modules/ad/ad_list.aspx','main_body','������','2009-12-30 22:42:08',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 80,'M0604','M06','��������','FlinkManage',2,'modules/flink/','main_body','��������','2009-12-30 22:27:56',1,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 81,'M0604001','M0604','�������','FlinkAdd',3,'modules/flink/flink_add.aspx','main_body','�������','2009-12-30 22:43:25',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 82,'M0604002','M0604','��������','FlinkList',3,'modules/flink/flink_list.aspx','main_body','��������','2009-12-30 22:44:04',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 83,'M0604003','M0604','���Ӽ��','FlinkVerify',3,'modules/flink/flink_verify.aspx','main_body','���Ӽ��','2009-12-30 22:45:14',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 84,'M0605','M06','�ʴ�ģ��','AskManage',2,'modules/ask/','main_body','�ʴ�ģ��','2009-12-30 22:29:50',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 85,'M0605001','M0605','�½��ʴ�','AskAdd',3,'modules/ask/ask_add.aspx','main_body','�½��ʴ�','2009-12-30 22:45:56',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 86,'M0605002','M0605','�����ʴ�','AskList',3,'modules/ask/ask_list.aspx','main_body','�����ʴ�','2009-12-30 22:47:20',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 87,'M0606','M06','�ÿ�����','LeavewordManage',2,'modules/leaveword/','main_body','�ÿ�����','2009-12-30 22:49:17',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 88,'M0606001','M0606','��������','LeavewordList',3,'modules/leaveword/leaveword_list.aspx','main_body','�������','2009-12-30 22:58:12',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 89,'M07','M0','ϵͳ����','SystemManage',1,'admin/system/baseconfig.aspx','main_body','ϵͳ����','2010-1-29 13:37:23',0,1,1,8)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 90,'M0701','M07','ϵͳ����','SystemSetting',2,'system/','main_body','ϵͳ����','2009-12-30 23:00:51',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 91,'M0701001','M0701','��������','BaseSetting',3,'system/base_setting.aspx','main_body','������Ϣ����','2009-12-30 23:06:43',1,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 92,'M0701002','M0701','���ʿ���','VisitSetting',3,'system/visit_setting.aspx','main_body','��������','2009-12-30 23:14:33',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 93,'M0701003','M0701','��ȫ����','SafeSetting',3,'system/safe_setting.aspx','main_body','��ȫ����','2009-12-30 23:20:35',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 94,'M0701004','M0701','��������','AttchmentSetting',3,'system/attchment_setting.aspx','main_body','��������','2009-12-30 23:22:20',0,1,1,6)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 95,'M0701005','M0701','�ʼ�����','SMTPSetting',3,'system/smtp_setting.aspx','main_body','�ʼ�����','2009-12-30 23:24:57',0,1,1,7)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 96,'M0701006','M0701','�߼�����','AdvancedSetting',3,'system/advanced_setting.aspx','main_body','�߼�����','2009-12-30 23:26:02',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 97,'M0703','M07','���ݿ����','DatabaseManage',2,'system/','main_body','���ݿ����','2009-12-30 23:04:10',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 98,'M0703001','M0703','����SQL���','RunSQL',3,'system/database_runsql.aspx','main_body','����ָ��SQL���','2009-12-30 23:29:35',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 99,'M0703002','M0703','���ݿⱸ��','DatabaseBackup',3,'system/database_backup.aspx','main_body','���ݿⱸ��','2009-12-30 23:30:18',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 100,'M0703003','M0703','���ݿ�ָ�','DatabaseRevert',3,'system/database_revert.aspx','main_body','���ݿ�ָ�','2009-12-30 23:31:49',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 101,'M0703004','M0703','�������ݿ�','DatabaseCompress',3,'system/database_compress.aspx','main_body','���ݿ�����','2009-12-30 23:33:37',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 102,'M0704','M07','��־����','LogManage',2,'system/','main_body','��־����','2009-12-30 23:05:21',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 103,'M0704001','M0704','��̨������־','OperateLog',3,'system/log_operate.aspx','main_body','��̨������־','2009-12-30 23:36:04',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 104,'M0704002','M0704','������־','ErrorLog',3,'system/log_error.aspx','main_body','������־','2009-12-30 23:36:39',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 105,'M08','M0','����ά��','DataManage',1,'data/tag_list.aspx','main_body','����ά��','2008-1-2 22:27:48',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 106,'M0801','M08','��Ϣά��','DataInfo',2,'data/','main_body','��Ϣά��','2008-1-2 22:30:50',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 107,'M0801001','M0801','�ĵ����۹���','CommentList',3,'data/commen_list.aspx','main_body','�ĵ����۹���','2010-1-29 16:29:41',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 108,'M0801002','M0801','�����ؼ��ֹ���','SearchwordtList',3,'data/searchword_list.aspx','main_body','�����ؼ��ֹ���','2010-2-1 14:26:15',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 109,'M0801003','M0801','�ĵ���Ϣͳ��','ArchivesInfo',3,'data/archives_info.aspx','main_body','���۹���','2010-2-1 14:27:49',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 110,'M0801004','M0801','�������ݹ���','AttachmentList',3,'content/attachment/attachment_list.aspx','main_body','�������ݹ���','2010-1-29 17:31:52',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 111,'M0802','M08','��������ά��','DataBasic',2,'data/','main_body','��������ά��','2008-1-2 22:35:55',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 112,'M0802001','M0802','TAG�ؼ���ά��','TAGManage',3,'data/tag_list.aspx','main_body','TAG�ؼ���ά��','2010-1-29 16:30:49',0,1,1,4)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 113,'M0802002','M0802','�ĵ��ؼ���ά��','KeywordManage',3,'data/keyword_list.aspx','main_body','�ĵ��ؼ���ά��','2010-1-29 16:34:35',0,1,1,5)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 114,'M0802003','M0802','��Դ����','SourceList',3,'data/source_list.aspx','main_body','��Դ����','2008-1-2 22:44:28',0,1,1,1)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 115,'M0802004','M0802','���߹���','AuthorList',3,'data/author_list.aspx','main_body','���߹���','2008-1-2 22:45:24',0,1,1,2)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 116,'M0802005','M0802','�Զ����ĵ�����','CustomAttr',3,'data/customattr.aspx','main_body','�Զ����ĵ�����','2008-1-2 22:50:13',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 117,'M0803','M08','�����ֵ�ά��','DataDicManage',2,'data/','main_body','��������','2009-12-30 23:02:24',0,1,1,3)
INSERT [DT_Modules] ([ID],[ModuleID],[ParentID],[ModuleName],[EName],[ModuleDepth],[ModuleURL],[Target],[Description],[CreateTime],[IsQuickMenu],[IsSystem],[IsEnable],[OrderID]) VALUES ( 118,'M0803001','M0803','�����ֵ�ά��','DataBatch',3,'data/','main_body','��������ά��','2008-1-2 23:24:30',0,1,1,3)

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
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 1,'��������Ա','����ϵͳ����Ȩ��(ϵͳ���ý�ɫ,���ܱ�ɾ��)','2010-2-14 15:08:19',1)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 2,'ϵͳ����Ա','����ϵͳ����Ȩ��','2010-2-14 15:08:19',2)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 3,'��Ϣ����Ա','�������·���ɾ����˵�Ȩ��','2010-2-14 23:28:20',3)
INSERT [DT_Roles] ([ID],[RoleName],[Description],[AddDate],[OrderID]) VALUES ( 4,'ע���Ա','û�к�̨����Ȩ��','2010-2-14 23:27:09',4)
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

INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 1,0,1,'ϵͳ������','ӵ��ϵͳ���Ȩ��',0,0,16,200,1,1,1,1,1,1,1,1,200,200,1024,10240,1)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 2,1,1,'������','�������й���Ȩ�ޣ���ϵͳ����Ȩ��',0,0,15,180,1,1,1,1,1,1,1,1,100,200,1024,10240,2)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 3,2,1,'�ȴ���֤��Ա','�ȴ���֤��Ա',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 4,2,0,'������·','������·',0,100,1,10,1,0,0,0,0,0,0,0,30,50,200,1000,4)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 5,2,0,'������Ա','������Ա',100,300,2,0,0,0,0,0,0,0,0,0,40,60,300,2000,5)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 6,2,0,'�м���Ա','�м���Ա',300,1000,3,0,0,0,0,0,0,0,0,0,50,70,500,3000,6)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 7,2,0,'�߼���Ա','�߼���Ա',1000,2000,4,0,0,0,0,0,0,0,0,0,60,80,500,4000,7)
INSERT [DT_Usergroup] ([ID],[Type],[IsSystem],[GroupName],[Description],[CreditBegin],[CreditEnd],[stars],[Readaccess],[AllowPost],[AllowComment],[AllowDownload],[AllowAvatar],[AllowSpace],[AllowTransfer],[AllowViewInfo],[AllowNickname],[MaxPMNum],[MaxSignSize],[MaxAttachSize],[MaxAttachTotalSize],[OrderID]) VALUES ( 8,2,0,'���ƻ�Ա','���ƻ�Ա',2000,999999999,5,1,1,1,1,1,1,1,1,1,70,90,500,5000,8)

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
