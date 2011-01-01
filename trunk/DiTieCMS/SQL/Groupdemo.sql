 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_AuthorityDir]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_AuthorityDir] 
 CREATE TABLE [RGP_AuthorityDir] (  [AuthorityID] [int] IDENTITY (1, 1) NOT NULL , [AuthorityName] [nvarchar] (30) NOT NULL , [AuthorityTag] [nvarchar] (50) NOT NULL , [AuthorityDescription] [nvarchar] (50) NULL ,  [AuthorityOrder] [int] NOT NULL )
 ALTER TABLE [RGP_AuthorityDir] WITH NOCHECK ADD CONSTRAINT [DF_RGP_AuthorityDir_AuthorityOrder] DEFAULT ((0)) FOR [AuthorityOrder],CONSTRAINT [PK_RGP_AuthorityDir] PRIMARY KEY  NONCLUSTERED ( [AuthorityID] )

 SET IDENTITY_INSERT [RGP_AuthorityDir] ON

 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 1 , '浏览' , 'RGP_BROWSE' , '页面访问权限' , 1 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 2 , '新增' , 'RGP_ADD' , '页面中的添加操作权限' , 2 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 3 , '编辑' , 'RGP_EDIT' , '页面中的编辑修改操作权限' , 3 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 4 , '删除' , 'RGP_DELETE' , '页面中的删除操作权限' , 4 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 5 , '搜索' , 'RGP_SEARCH' , '数据搜索权限' , 5 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 6 , '审核' , 'RGP_VERIFY' , '记录审核权限' , 6 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 7 , '移动' , 'RGP_MOVE' , '移动记录的权限' , 7 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 8 , '打印' , 'RGP_PRINT' , '打印文档权限' , 8 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 9 , '下载' , 'RGP_DOWNLOAD' , '下载权限' , 9 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 10 , '备份' , 'RGP_BACKUP' , '资料备份权限' , 10 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 11 , '受权' , 'RGP_GRANT' , '模块授权权限' , 11 )
 INSERT [RGP_AuthorityDir] ( [AuthorityID] , [AuthorityName] , [AuthorityTag] , [AuthorityDescription] , [AuthorityOrder] ) VALUES ( 12 , '查看' , 'RGP_VIEW' , '查看详细信息的权限' , 12 )

 SET IDENTITY_INSERT [RGP_AuthorityDir] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_Configuration]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_Configuration] 
 CREATE TABLE [RGP_Configuration] (  [ItemID] [int] IDENTITY (1, 1) NOT NULL , [ItemName] [nvarchar] (50) NOT NULL , [ItemValue] [nvarchar] (500) NULL , [ItemDescription] [nvarchar] (500) NULL )
 ALTER TABLE [RGP_Configuration] WITH NOCHECK ADD CONSTRAINT [PK_RGP_Configuration] PRIMARY KEY  NONCLUSTERED ( [ItemID] )

 SET IDENTITY_INSERT [RGP_Configuration] ON

 INSERT [RGP_Configuration] ( [ItemID] , [ItemName] , [ItemValue] , [ItemDescription] ) VALUES ( 1 , 'InitRoleID' , '1' , '注册时初始化权限，设置值必须大于0，设定值必须在角色列表中存在' )
 INSERT [RGP_Configuration] ( [ItemID] , [ItemName] , [ItemValue] , [ItemDescription] ) VALUES ( 2 , 'initGroupID' , '4' , '注册时初始化用户组，设置值必须大于0，设定值必须在用户组列表中存在' )
 INSERT [RGP_Configuration] ( [ItemID] , [ItemName] , [ItemValue] , [ItemDescription] ) VALUES ( 3 , 'IsVerifyUser' , '0' , '注册时是否启用审核，启用则不写入用户权限和用户组信息，审核时写入,输入值只能为0或1' )

 SET IDENTITY_INSERT [RGP_Configuration] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_Groups]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_Groups] 
 CREATE TABLE [RGP_Groups] (  [GroupID] [int] IDENTITY (1, 1) NOT NULL , [GroupName] [nvarchar] (30) NOT NULL ,  [GroupOrder] [int] NOT NULL , [GroupDescription] [nvarchar] (50) NULL ,  [GroupType] [int] NOT NULL )
 ALTER TABLE [RGP_Groups] WITH NOCHECK ADD CONSTRAINT [DF_RGP_Groups_GroupOrder] DEFAULT ((0)) FOR [GroupOrder],CONSTRAINT [DF_RGP_Groups_GroupType] DEFAULT ((0)) FOR [GroupType],CONSTRAINT [PK_RGP_Groups] PRIMARY KEY  NONCLUSTERED ( [GroupID] )

 SET IDENTITY_INSERT [RGP_Groups] ON

 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 1 , '系统管理组' , 1 , '拥有系统最高权限' , 1 )
 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 2 , '管理组' , 2 , '具用所有管理权限，无系统配置权限' , 1 )
 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 3 , '用户组' , 3 , '无后台管理权限' , 1 )
 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 4 , '系统管理组' , 1 , '系统维护人员' , 0 )
 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 5 , '管理组' , 2 , '管理阶层' , 0 )
 INSERT [RGP_Groups] ( [GroupID] , [GroupName] , [GroupOrder] , [GroupDescription] , [GroupType] ) VALUES ( 6 , '用户组' , 3 , '一般用户' , 0 )

 SET IDENTITY_INSERT [RGP_Groups] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_ModuleAuthorityList]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_ModuleAuthorityList] 
 CREATE TABLE [RGP_ModuleAuthorityList] (  [ID] [int] IDENTITY (1, 1) NOT NULL ,  [ModuleID] [int] NOT NULL , [AuthorityTag] [nvarchar] (50) NOT NULL )
 ALTER TABLE [RGP_ModuleAuthorityList] WITH NOCHECK ADD CONSTRAINT [PK_RGP_ModuleAuthorityList] PRIMARY KEY  NONCLUSTERED ( [ID] )

 SET IDENTITY_INSERT [RGP_ModuleAuthorityList] ON

 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 1 , 8 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 2 , 8 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 3 , 8 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 4 , 8 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 5 , 8 , 'RGP_SEARCH' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 6 , 8 , 'RGP_VERIFY' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 7 , 8 , 'RGP_MOVE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 8 , 8 , 'RGP_PRINT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 9 , 8 , 'RGP_DOWNLOAD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 10 , 8 , 'RGP_BACKUP' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 11 , 8 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 12 , 1 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 13 , 1 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 14 , 1 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 15 , 1 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 16 , 1 , 'RGP_SEARCH' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 17 , 1 , 'RGP_VERIFY' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 18 , 1 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 19 , 7 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 20 , 7 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 21 , 6 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 22 , 6 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 23 , 6 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 24 , 6 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 25 , 3 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 26 , 3 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 27 , 3 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 28 , 3 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 29 , 3 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 30 , 2 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 31 , 2 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 32 , 2 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 33 , 2 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 34 , 2 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 35 , 4 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 36 , 4 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 37 , 4 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 38 , 4 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 39 , 4 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 40 , 5 , 'RGP_BROWSE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 41 , 5 , 'RGP_ADD' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 42 , 5 , 'RGP_EDIT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 43 , 5 , 'RGP_DELETE' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 44 , 5 , 'RGP_GRANT' )
 INSERT [RGP_ModuleAuthorityList] ( [ID] , [ModuleID] , [AuthorityTag] ) VALUES ( 45 , 1 , 'RGP_VIEW' )

 SET IDENTITY_INSERT [RGP_ModuleAuthorityList] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_Modules]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_Modules] 
 CREATE TABLE [RGP_Modules] (  [ModuleID] [int] IDENTITY (1, 1) NOT NULL ,  [ModuleTypeID] [int] NOT NULL , [ModuleName] [nvarchar] (30) NOT NULL , [ModuleTag] [nvarchar] (50) NOT NULL , [ModuleURL] [nvarchar] (500) NULL , [ModuleDisabled] [bit] NOT NULL ,  [ModuleOrder] [int] NOT NULL , [ModuleDescription] [nvarchar] (50) NULL , [IsMenu] [bit] NOT NULL )
 ALTER TABLE [RGP_Modules] WITH NOCHECK ADD CONSTRAINT [DF_RGP_Modules_ModuleDisabled] DEFAULT ((1)) FOR [ModuleDisabled],CONSTRAINT [DF_RGP_Modules_ModuleOrder] DEFAULT ((0)) FOR [ModuleOrder],CONSTRAINT [DF_RGP_Modules_IsMenu] DEFAULT ((1)) FOR [IsMenu],CONSTRAINT [PK_RGP_Modules] PRIMARY KEY  NONCLUSTERED ( [ModuleID] )

 SET IDENTITY_INSERT [RGP_Modules] ON

 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 1 , 2 , '会员管理' , 'admin_ListUsers' , '../admin/Modubles/ListUsers.aspx' , 1 , 1 , '外部注册会员管理' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 2 , 4 , '分组管理' , 'admin_GroupsPage' , '../admin/Modubles/GroupsPage.aspx' , 1 , 3 , '用户分组，角色分组' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 3 , 4 , '角色管理' , 'admin_RolesPage' , '../admin/Modubles/RolesPage.aspx' , 1 , 2 , '管理角色' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 4 , 4 , '模块管理' , 'admin_ModulesPage' , '../admin/Modubles/ModulesPage.aspx' , 1 , 4 , '模块管理' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 5 , 4 , '角色授权' , 'admin_RolesAuthorizedPage' , '../admin/Modubles/RolesAuthorizedPage.aspx' , 1 , 5 , '' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 6 , 4 , '权限列表' , 'admin_AuthorityPage' , '../admin/Modubles/AuthorityPage.aspx' , 1 , 1 , '' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 7 , 3 , '系统设定' , 'admin_ConfigPage' , '../admin/Modubles/ConfigPage.aspx' , 1 , 1 , '系统管理设置' , 1 )
 INSERT [RGP_Modules] ( [ModuleID] , [ModuleTypeID] , [ModuleName] , [ModuleTag] , [ModuleURL] , [ModuleDisabled] , [ModuleOrder] , [ModuleDescription] , [IsMenu] ) VALUES ( 8 , 1 , '一般组件控制' , 'Demo_Control' , '../admin/Demo/ExampleGerneral.aspx' , 1 , 1 , '一般组件的控制' , 1 )

 SET IDENTITY_INSERT [RGP_Modules] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_ModuleType]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_ModuleType] 
 CREATE TABLE [RGP_ModuleType] (  [ModuleTypeID] [int] IDENTITY (1, 1) NOT NULL , [ModuleTypeName] [nvarchar] (30) NOT NULL ,  [ModuleTypeOrder] [int] NOT NULL , [ModuleTypeDescription] [nvarchar] (50) NULL ,  [ModuleTypeDepth] [int] NOT NULL ,  [ModuleTypeSuperiorID] [int] NOT NULL ,  [ModuleTypeCount] [int] NOT NULL )
 ALTER TABLE [RGP_ModuleType] WITH NOCHECK ADD CONSTRAINT [DF_RGP_ModuleType_ModuleTypeOrder] DEFAULT ((0)) FOR [ModuleTypeOrder],CONSTRAINT [DF_RGP_ModuleType_ModuleTypeDepth] DEFAULT ((0)) FOR [ModuleTypeDepth],CONSTRAINT [DF_RGP_ModuleType_ModuleTypeSuperiorID] DEFAULT ((0)) FOR [ModuleTypeSuperiorID],CONSTRAINT [DF_RGP_ModuleType_ModuleTypeCount] DEFAULT ((0)) FOR [ModuleTypeCount],CONSTRAINT [PK_RGP_ModuleType] PRIMARY KEY  NONCLUSTERED ( [ModuleTypeID] )

 SET IDENTITY_INSERT [RGP_ModuleType] ON

 INSERT [RGP_ModuleType] ( [ModuleTypeID] , [ModuleTypeName] , [ModuleTypeOrder] , [ModuleTypeDescription] , [ModuleTypeDepth] , [ModuleTypeSuperiorID] , [ModuleTypeCount] ) VALUES ( 1 , '样例演示' , 4 , '样例演示' , 1 , 0 , 0 )
 INSERT [RGP_ModuleType] ( [ModuleTypeID] , [ModuleTypeName] , [ModuleTypeOrder] , [ModuleTypeDescription] , [ModuleTypeDepth] , [ModuleTypeSuperiorID] , [ModuleTypeCount] ) VALUES ( 2 , '用户管理' , 3 , '所有用户管理' , 1 , 0 , 0 )
 INSERT [RGP_ModuleType] ( [ModuleTypeID] , [ModuleTypeName] , [ModuleTypeOrder] , [ModuleTypeDescription] , [ModuleTypeDepth] , [ModuleTypeSuperiorID] , [ModuleTypeCount] ) VALUES ( 3 , '系统配置' , 2 , '系统配置相关功能' , 1 , 0 , 0 )
 INSERT [RGP_ModuleType] ( [ModuleTypeID] , [ModuleTypeName] , [ModuleTypeOrder] , [ModuleTypeDescription] , [ModuleTypeDepth] , [ModuleTypeSuperiorID] , [ModuleTypeCount] ) VALUES ( 4 , '权限配置' , 1 , '系统权限管理' , 1 , 0 , 0 )

 SET IDENTITY_INSERT [RGP_ModuleType] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_RoleAuthorityList]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_RoleAuthorityList] 
 CREATE TABLE [RGP_RoleAuthorityList] (  [ID] [int] IDENTITY (1, 1) NOT NULL ,  [UserID] [int] NOT NULL ,  [RoleID] [int] NOT NULL ,  [GroupID] [int] NOT NULL ,  [ModuleID] [int] NOT NULL , [AuthorityTag] [nvarchar] (50) NOT NULL , [Flag] [bit] NOT NULL )
 ALTER TABLE [RGP_RoleAuthorityList] WITH NOCHECK ADD CONSTRAINT [DF_RGP_RoleAuthorityList_UserID] DEFAULT ((0)) FOR [UserID],CONSTRAINT [DF_RGP_RoleAuthorityList_RoleID] DEFAULT ((0)) FOR [RoleID],CONSTRAINT [DF_RGP_RoleAuthorityList_GroupID] DEFAULT ((0)) FOR [GroupID],CONSTRAINT [DF_RGP_RoleAuthorityList_Flag] DEFAULT ((1)) FOR [Flag],CONSTRAINT [PK_RGP_RoleAuthorityList] PRIMARY KEY  NONCLUSTERED ( [ID] )

 SET IDENTITY_INSERT [RGP_RoleAuthorityList] ON

 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 1 , 0 , 1 , 0 , 8 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 2 , 0 , 1 , 0 , 8 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 3 , 0 , 1 , 0 , 8 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 4 , 0 , 1 , 0 , 8 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 5 , 0 , 1 , 0 , 8 , 'RGP_SEARCH' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 6 , 0 , 1 , 0 , 8 , 'RGP_VERIFY' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 7 , 0 , 1 , 0 , 8 , 'RGP_MOVE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 8 , 0 , 1 , 0 , 8 , 'RGP_PRINT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 9 , 0 , 1 , 0 , 8 , 'RGP_DOWNLOAD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 10 , 0 , 1 , 0 , 8 , 'RGP_BACKUP' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 11 , 0 , 1 , 0 , 8 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 12 , 0 , 2 , 0 , 8 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 13 , 0 , 2 , 0 , 8 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 14 , 0 , 2 , 0 , 8 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 15 , 0 , 2 , 0 , 8 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 16 , 0 , 2 , 0 , 8 , 'RGP_SEARCH' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 17 , 0 , 3 , 0 , 8 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 18 , 0 , 3 , 0 , 1 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 19 , 0 , 2 , 0 , 1 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 20 , 0 , 2 , 0 , 1 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 21 , 0 , 2 , 0 , 1 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 22 , 0 , 2 , 0 , 1 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 23 , 0 , 2 , 0 , 1 , 'RGP_SEARCH' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 24 , 0 , 2 , 0 , 1 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 25 , 0 , 1 , 0 , 1 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 26 , 0 , 1 , 0 , 1 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 27 , 0 , 1 , 0 , 1 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 28 , 0 , 1 , 0 , 1 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 29 , 0 , 1 , 0 , 1 , 'RGP_SEARCH' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 30 , 0 , 1 , 0 , 1 , 'RGP_VERIFY' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 31 , 0 , 1 , 0 , 1 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 32 , 0 , 1 , 0 , 7 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 33 , 0 , 1 , 0 , 7 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 34 , 0 , 1 , 0 , 6 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 35 , 0 , 1 , 0 , 6 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 36 , 0 , 1 , 0 , 6 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 37 , 0 , 1 , 0 , 6 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 38 , 0 , 1 , 0 , 3 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 39 , 0 , 1 , 0 , 3 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 40 , 0 , 1 , 0 , 3 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 41 , 0 , 1 , 0 , 3 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 42 , 0 , 1 , 0 , 3 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 43 , 0 , 1 , 0 , 2 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 44 , 0 , 1 , 0 , 2 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 45 , 0 , 1 , 0 , 2 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 46 , 0 , 1 , 0 , 2 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 47 , 0 , 1 , 0 , 2 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 48 , 0 , 1 , 0 , 4 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 49 , 0 , 1 , 0 , 4 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 50 , 0 , 1 , 0 , 4 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 51 , 0 , 1 , 0 , 4 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 52 , 0 , 1 , 0 , 4 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 53 , 0 , 1 , 0 , 5 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 54 , 0 , 1 , 0 , 5 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 55 , 0 , 1 , 0 , 5 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 56 , 0 , 1 , 0 , 5 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 57 , 0 , 1 , 0 , 5 , 'RGP_GRANT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 58 , 0 , 1 , 0 , 1 , 'RGP_VIEW' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 59 , 0 , 2 , 0 , 1 , 'RGP_VIEW' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 60 , 0 , 3 , 0 , 1 , 'RGP_VIEW' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 61 , 0 , 1 , 0 , 11 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 62 , 0 , 1 , 0 , 11 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 63 , 0 , 1 , 0 , 11 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 64 , 0 , 1 , 0 , 11 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 65 , 0 , 1 , 0 , 11 , 'RGP_SEARCH' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 66 , 0 , 1 , 0 , 11 , 'RGP_VERIFY' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 67 , 0 , 1 , 0 , 11 , 'RGP_VIEW' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 68 , 0 , 1 , 0 , 10 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 69 , 0 , 1 , 0 , 10 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 70 , 0 , 1 , 0 , 10 , 'RGP_EDIT' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 71 , 0 , 1 , 0 , 10 , 'RGP_DELETE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 72 , 8 , 0 , 0 , 8 , 'RGP_BROWSE' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 73 , 8 , 0 , 0 , 8 , 'RGP_ADD' , 1 )
 INSERT [RGP_RoleAuthorityList] ( [ID] , [UserID] , [RoleID] , [GroupID] , [ModuleID] , [AuthorityTag] , [Flag] ) VALUES ( 74 , 0 , 0 , 4 , 7 , 'RGP_BROWSE' , 1 )

 SET IDENTITY_INSERT [RGP_RoleAuthorityList] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[RGP_Roles]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [RGP_Roles] 
 CREATE TABLE [RGP_Roles] (  [RoleID] [int] IDENTITY (1, 1) NOT NULL ,  [RoleGroupID] [int] NOT NULL , [RoleName] [nvarchar] (30) NOT NULL , [RoleDescription] [nvarchar] (50) NULL )
 ALTER TABLE [RGP_Roles] WITH NOCHECK ADD CONSTRAINT [PK_RGP_Roles] PRIMARY KEY  NONCLUSTERED ( [RoleID] )

 SET IDENTITY_INSERT [RGP_Roles] ON

 INSERT [RGP_Roles] ( [RoleID] , [RoleGroupID] , [RoleName] , [RoleDescription] ) VALUES ( 1 , 1 , '超级管理员' , '具有系统所有权限' )
 INSERT [RGP_Roles] ( [RoleID] , [RoleGroupID] , [RoleName] , [RoleDescription] ) VALUES ( 2 , 2 , '帐户管理员' , '用户信息管理' )
 INSERT [RGP_Roles] ( [RoleID] , [RoleGroupID] , [RoleName] , [RoleDescription] ) VALUES ( 3 , 3 , '公司员工' , '内部用户信息' )
 INSERT [RGP_Roles] ( [RoleID] , [RoleGroupID] , [RoleName] , [RoleDescription] ) VALUES ( 4 , 3 , '会员' , '外部注册会员' )

 SET IDENTITY_INSERT [RGP_Roles] OFF

 if exists (select * from sysobjects where id = OBJECT_ID('[t_Users]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) DROP TABLE [t_Users] 
 CREATE TABLE [t_Users] (  [UserID] [int] IDENTITY (1, 1) NOT NULL , [UserName] [nvarchar] (128) NOT NULL , [Password] [nvarchar] (128) NOT NULL , [Email] [nvarchar] (100) NULL , [Question] [nvarchar] (100) NULL , [Answer] [nvarchar] (100) NULL ,  [RoleID] [int] NOT NULL ,  [UserGroup] [int] NOT NULL , [CreateTime] [datetime]  NOT NULL , [LastLoginTime] [datetime]  NULL ,  [Status] [int] NOT NULL , [IsOnline] [bit] NOT NULL , [IsLimit] [bit] NOT NULL )
 ALTER TABLE [t_Users] WITH NOCHECK ADD CONSTRAINT [DF_t_Users_RoleID] DEFAULT ((0)) FOR [RoleID],CONSTRAINT [DF_t_Users_UserGroup] DEFAULT ((0)) FOR [UserGroup],CONSTRAINT [DF_t_Users_Status] DEFAULT ((1)) FOR [Status],CONSTRAINT [DF_t_Users_IsOnline] DEFAULT ((0)) FOR [IsOnline],CONSTRAINT [DF_t_Users_IsLimit] DEFAULT ((0)) FOR [IsLimit],CONSTRAINT [PK_t_Users] PRIMARY KEY  NONCLUSTERED ( [UserID] )

 SET IDENTITY_INSERT [t_Users] ON

 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Question] , [Answer] , [RoleID] , [UserGroup] , [CreateTime] , [LastLoginTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 1 , 'admin' , '4297F44B13955235245B2497399D7A93' , 'Who' , '系统管理员' , 1 , 4 , '2008-12-16 18:19:40.737' , '2009-04-02 14:10:26.140' , 1 , 0 , 1 )
 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Email] , [RoleID] , [UserGroup] , [CreateTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 7 , 'test1' , '4297F44B13955235245B2497399D7A93' , 'test1@163.com' , 2 , 5 , '2009-03-24 19:11:04.657' , 1 , 0 , 0 )
 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Email] , [RoleID] , [UserGroup] , [CreateTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 8 , 'test2' , '4297F44B13955235245B2497399D7A93' , 'test2@163.com' , 3 , 6 , '2009-03-24 19:11:30.843' , 1 , 0 , 0 )
 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Email] , [RoleID] , [UserGroup] , [CreateTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 9 , 'test3' , '4297F44B13955235245B2497399D7A93' , 'test3@163.com' , 4 , 6 , '2009-03-24 19:11:57.390' , 1 , 0 , 0 )
 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Email] , [RoleID] , [UserGroup] , [CreateTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 10 , 'nick' , '4297F44B13955235245B2497399D7A93' , 'nick@163.com' , 1 , 4 , '2009-03-24 19:12:29.890' , 1 , 0 , 0 )
 INSERT [t_Users] ( [UserID] , [UserName] , [Password] , [Email] , [RoleID] , [UserGroup] , [CreateTime] , [Status] , [IsOnline] , [IsLimit] ) VALUES ( 11 , 'game' , '4297F44B13955235245B2497399D7A93' , 'game@163.com' , 1 , 4 , '2009-04-02 14:10:01.953' , 1 , 0 , 0 )

 SET IDENTITY_INSERT [t_Users] OFF

