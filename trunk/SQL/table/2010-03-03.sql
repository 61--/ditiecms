/****** 对象:  Default [DF_DT_Arc_Article_ViceClassID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_ViceClassID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_ViceClassID]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Click]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Click]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Click]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Good]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Good]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Good]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Bad]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Bad]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Bad]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Readaccess]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Readaccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Readaccess]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Money]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Money]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Money]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Status]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Status]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsChecked]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsChecked]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_IsChecked]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsRecycle]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsRecycle]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_IsRecycle]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsRedirect]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsRedirect]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_IsRedirect]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsHtml]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsHtml]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_IsHtml]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsPaging]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsPaging]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_IsPaging]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Sort]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Sort]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] DROP CONSTRAINT [DF_DT_Arc_Article_Sort]

END
GO
/****** 对象:  Default [DF_DT_Arc_Class_ParentID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Class_ParentID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Class] DROP CONSTRAINT [DF_DT_Arc_Class_ParentID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Help_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Help_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Help] DROP CONSTRAINT [DF_DT_SYS_Help_OrderID]

END
GO
/****** 对象:  Default [DF_DT_Pre_ModuleControl_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_ModuleControl_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_ModuleControl] DROP CONSTRAINT [DF_DT_Pre_ModuleControl_OrderID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_CreateTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_CreateTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] DROP CONSTRAINT [DF_DT_SYS_Navigate_CreateTime]

END
GO
/****** 对象:  Default [DF_DT_SYS_Modules_IsQuickMenu]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Modules_IsQuickMenu]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] DROP CONSTRAINT [DF_DT_SYS_Modules_IsQuickMenu]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_ISSys]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_ISSys]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] DROP CONSTRAINT [DF_DT_SYS_Navigate_ISSys]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_ISEnable]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_ISEnable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] DROP CONSTRAINT [DF_DT_SYS_Navigate_ISEnable]

END
GO
/****** 对象:  Default [DF_Sys_Navigate_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Sys_Navigate_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] DROP CONSTRAINT [DF_Sys_Navigate_OrderID]

END
GO
/****** 对象:  Default [DF_DT_Roles_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Roles_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Roles] DROP CONSTRAINT [DF_DT_Roles_OrderID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Dict_Hits]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Dict_Hits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Sys_Dict] DROP CONSTRAINT [DF_DT_SYS_Dict_Hits]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_GroupType]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_GroupType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_GroupType]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_IsSystem]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_IsSystem]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_IsSystem]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_CreditBegin]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_CreditBegin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_CreditBegin]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_CreditEnd]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_CreditEnd]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_CreditEnd]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_stars]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_stars]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_stars]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_Readaccess]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_Readaccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_Readaccess]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowPost]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowPost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowPost]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowComment]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowComment]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowComment]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowDownload]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowDownload]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowDownload]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowAvatar]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowAvatar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowAvatar]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowSpace]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowSpace]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowSpace]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowTransfer]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowTransfer]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowTransfer]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowViewInfo]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowViewInfo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowViewInfo]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowNickname]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowNickname]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] DROP CONSTRAINT [DF_DT_Pre_Usergroup_AllowNickname]

END
GO
/****** 对象:  Default [DF_DT_Users_Sex]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_Sex]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_Sex]

END
GO
/****** 对象:  Default [DF_DT_Users_RoleID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_RoleID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_RoleID]

END
GO
/****** 对象:  Default [DF_DT_Users_UsergroupID]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_UsergroupID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_UsergroupID]

END
GO
/****** 对象:  Default [DF_DT_Users_RegisterDate]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_RegisterDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_RegisterDate]

END
GO
/****** 对象:  Default [DF_DT_Users_LastloginTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_LastloginTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_LastloginTime]

END
GO
/****** 对象:  Default [DF_DT_Users_LoginCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_LoginCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_LoginCount]

END
GO
/****** 对象:  Default [DF_DT_Users_PostCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_PostCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_PostCount]

END
GO
/****** 对象:  Default [DF_DT_Users_OnlineTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_OnlineTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_OnlineTime]

END
GO
/****** 对象:  Default [DF_DT_Users_Credits]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_Credits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_Credits]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits1]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_ExtCredits1]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits2]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_ExtCredits2]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits3]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_ExtCredits3]

END
GO
/****** 对象:  Default [DF_DT_Users_PmCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_PmCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_PmCount]

END
GO
/****** 对象:  Default [DF_DT_Users_IsVerify]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_IsVerify]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_IsVerify]

END
GO
/****** 对象:  Default [DF_DT_Users_IsForbidden]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_IsForbidden]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] DROP CONSTRAINT [DF_DT_Users_IsForbidden]

END
GO
/****** 对象:  Table [dbo].[DT_Help]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Help]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Help]
GO
/****** 对象:  Table [dbo].[DT_Users]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Users]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Users]
GO
/****** 对象:  Table [dbo].[DT_Modules]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Modules]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Modules]
GO
/****** 对象:  StoredProcedure [dbo].[OutputData]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[OutputData]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[OutputData]
GO
/****** 对象:  Table [dbo].[DT_Usergroup]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Usergroup]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Usergroup]
GO
/****** 对象:  Table [dbo].[DT_Arc_Soft]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Soft]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Arc_Soft]
GO
/****** 对象:  Table [dbo].[DT_Userfields]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Userfields]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Userfields]
GO
/****** 对象:  Table [dbo].[DT_Sys_Template]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Sys_Template]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Sys_Template]
GO
/****** 对象:  Table [dbo].[DT_Sys_Dict]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Sys_Dict]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Sys_Dict]
GO
/****** 对象:  StoredProcedure [dbo].[pagehelper]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[pagehelper]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[pagehelper]
GO
/****** 对象:  Table [dbo].[DT_AttachMent]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_AttachMent]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_AttachMent]
GO
/****** 对象:  Table [dbo].[DT_Arc_Class]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Class]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Arc_Class]
GO
/****** 对象:  Table [dbo].[DT_ModuleControl]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_ModuleControl]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_ModuleControl]
GO
/****** 对象:  Table [dbo].[DT_Arc_Article]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Article]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Arc_Article]
GO
/****** 对象:  Table [dbo].[DT_Roles]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Roles]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_Roles]
GO
/****** 对象:  Table [dbo].[DT_RolesInModules]    脚本日期: 03/03/2010 20:39:28 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_RolesInModules]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[DT_RolesInModules]
GO
/****** 对象:  Table [dbo].[DT_RolesInModules]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_RolesInModules]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_RolesInModules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NOT NULL,
	[ModuleID] [char](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ControlValue] [int] NOT NULL,
 CONSTRAINT [PK_DT_RolesInModules] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_RolesInModules', N'COLUMN',N'RoleID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_RolesInModules', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_RolesInModules', N'COLUMN',N'ModuleID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_RolesInModules', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_RolesInModules', N'COLUMN',N'ControlValue'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'操作值' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_RolesInModules', @level2type=N'COLUMN',@level2name=N'ControlValue'
GO
SET IDENTITY_INSERT [dbo].[DT_RolesInModules] ON
INSERT [dbo].[DT_RolesInModules] ([ID], [RoleID], [ModuleID], [ControlValue]) VALUES (1, 1, convert(text, N'M0101001' collate Chinese_PRC_CI_AS), 15)
INSERT [dbo].[DT_RolesInModules] ([ID], [RoleID], [ModuleID], [ControlValue]) VALUES (2, 1, convert(text, N'M0101002' collate Chinese_PRC_CI_AS), 31)
SET IDENTITY_INSERT [dbo].[DT_RolesInModules] OFF
/****** 对象:  Table [dbo].[DT_Roles]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Roles]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Roles](
	[ID] [int] NOT NULL,
	[RoleName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Description] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[AddDate] [datetime] NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_DT_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Roles', N'COLUMN',N'ID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Roles', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Roles', N'COLUMN',N'RoleName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Roles', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Roles', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'角色描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Roles', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Roles', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Roles', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
INSERT [dbo].[DT_Roles] ([ID], [RoleName], [Description], [AddDate], [OrderID]) VALUES (1, N'超级管理员', N'具有系统所有权限(系统内置角色,不能被删除)', CAST(0x00009D1D00F97A04 AS DateTime), 1)
INSERT [dbo].[DT_Roles] ([ID], [RoleName], [Description], [AddDate], [OrderID]) VALUES (2, N'系统管理员', N'具有系统所有权限', CAST(0x00009D1D00F97A04 AS DateTime), 2)
INSERT [dbo].[DT_Roles] ([ID], [RoleName], [Description], [AddDate], [OrderID]) VALUES (3, N'信息发布员', N'具有文章发布删除审核等权限', CAST(0x00009D1D0182CF70 AS DateTime), 3)
INSERT [dbo].[DT_Roles] ([ID], [RoleName], [Description], [AddDate], [OrderID]) VALUES (4, N'注册会员', N'没有后台管理权限', CAST(0x00009D1D01827C3C AS DateTime), 4)
/****** 对象:  Table [dbo].[DT_Arc_Article]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Article]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Arc_Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NOT NULL,
	[ViceClassID] [int] NULL,
	[Title] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ShortTitle] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[TitleStyle] [varchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[TitleFlag] [tinyint] NULL,
	[Tags] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[ImgUrl] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Author] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Editor] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[PubLisher] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Source] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[Templet] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Keywords] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Description] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
	[AContent] [ntext] COLLATE Chinese_PRC_CI_AS NULL,
	[Click] [int] NULL,
	[Good] [int] NULL,
	[Bad] [int] NULL,
	[Readaccess] [smallint] NULL,
	[Money] [smallint] NULL,
	[Attribute] [smallint] NULL,
	[IsComment] [tinyint] NULL,
	[IsVerify] [tinyint] NULL,
	[IsRecycle] [tinyint] NULL,
	[IsRedirect] [tinyint] NULL,
	[IsHtml] [tinyint] NULL,
	[IsPaging] [tinyint] NULL,
	[FilePath] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[SimilarArticle] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[AddDate] [datetime] NOT NULL,
	[PubDate] [datetime] NOT NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_DT_Arc_Article] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'ID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'ClassID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ClassID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'ViceClassID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'副栏目ID,-1没有副栏目' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ViceClassID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Title'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章标题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'ShortTitle'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章缩略标题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ShortTitle'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'TitleStyle'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'标题样式' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'TitleStyle'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'TitleFlag'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'标题标签，如原创、转载' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'TitleFlag'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Tags'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章TAG' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Tags'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'ImgUrl'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章缩略图' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'ImgUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Author'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章作者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Author'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Editor'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'责任编辑' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Editor'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'PubLisher'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'PubLisher'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Source'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章来源' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Source'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Templet'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章模版' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Templet'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Keywords'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'关键字' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Keywords'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'AContent'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章正文' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'AContent'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Click'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章点击' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Click'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Good'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'顶' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Good'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Bad'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'踩' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Bad'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Readaccess'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'阅读权限，会员组' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Readaccess'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Money'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'消费点数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Money'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'Attribute'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章属性，1头条，2推荐，4图片，8灯幻，16滚动' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'Attribute'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsComment'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否允许评论，1允许，0不允许' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsComment'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsVerify'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否审核，0未审核，1审核' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsVerify'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsRecycle'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否放入回收站，0正常，1回收站' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsRecycle'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsRedirect'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否跳转地址，1是，0否' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsRedirect'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsHtml'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否生成静态页，1生成静态，0动态访问' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsHtml'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'IsPaging'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否分页，1分页，0不分页' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'IsPaging'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'FilePath'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'存储路径' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'FilePath'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'SimilarArticle'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'相关文章' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'SimilarArticle'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'AddDate'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'PubDate'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'PubDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Article', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文章排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Article', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
SET IDENTITY_INSERT [dbo].[DT_Arc_Article] ON
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (7, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (9, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (10, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (11, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (25, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (26, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (27, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (28, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (29, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (30, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (31, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (32, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (33, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (34, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (35, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (36, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (37, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (38, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (39, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (40, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (41, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (42, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (43, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (44, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (45, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (46, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (47, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (48, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (49, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (50, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (51, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (52, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (53, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (54, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (55, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (56, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (57, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (58, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (59, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (60, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (61, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (62, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (63, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (64, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (65, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (66, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (67, 50, -1, N'换的', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103115850703_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'admin', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>字数</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF30159AAA0 AS DateTime), CAST(0x00009CF30152A4F8 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (68, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (69, 47, -1, N'堆(heap)和堆栈(stack)的区别s', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET,JAVA', convert(text, N'/uploads/users/200912/20091223234440640_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin2', N'', N'', N'admin1', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>&lt;p&gt;&amp;lt;p&amp;gt;&amp;amp;lt;p&amp;amp;gt;&amp;amp;amp;lt;p&amp;amp;amp;gt;预备知识&amp;amp;amp;amp;mdash;程序的内存分配 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 一个由C/C++编译的程序占用的内存分为以下几个部分 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 1、栈区（stack）&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;由编译器自动分配释放&amp;amp;amp;amp;nbsp;，存放函数的参数值，局部变量的值等。其操作方式类似于数据结构中的栈。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2、堆区（heap）&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;&amp;amp;amp;amp;nbsp;一般由程序员分配释放，&amp;amp;amp;amp;nbsp;若程序员不释放，程序结束时可能由OS回收&amp;amp;amp;amp;nbsp;。注意它与数据结构中的堆是两回事，分配方式倒是类似于链表，呵呵。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 3、全局区（静态区）（static）&amp;amp;amp;amp;mdash;，全局变量和静态变量的存储是放在一块的，初始化的全局变量和静态变量在一块区域，&amp;amp;amp;amp;nbsp;未初始化的全局变量和未初始化的静态变量在相邻的另一块区域。&amp;amp;amp;amp;nbsp;-&amp;amp;amp;amp;nbsp;程序结束后有系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 4、文字常量区&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;mdash;常量字符串就是放在这里的。&amp;amp;amp;amp;nbsp;程序结束后由系统释放 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 5、程序代码区&amp;amp;amp;amp;mdash;存放函数体的二进制代码。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、例子程序 &amp;amp;amp;lt;br /&amp;amp;amp;gt; //main.cpp &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;0;&amp;amp;amp;amp;nbsp;全局初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p1;&amp;amp;amp;amp;nbsp;全局未初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;abc&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p2;&amp;amp;amp;amp;nbsp;栈 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p3&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456在常量区，p3在栈上。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; static&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;c&amp;amp;amp;amp;nbsp;=0；&amp;amp;amp;amp;nbsp;全局（静态）初始化区 &amp;amp;amp;lt;br /&amp;amp;amp;gt; p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(20); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 分配得来得10和20字节的区域就在堆区。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; strcpy(p1,&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;;&amp;amp;amp;amp;nbsp;123456放在常量区，编译器可能会将它与p3所指向的&amp;amp;amp;amp;quot;123456&amp;amp;amp;amp;quot;优化成一个地方。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 二、堆和栈的理论知识 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.1申请方式 &amp;amp;amp;lt;br /&amp;amp;amp;gt; stack: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 由系统自动分配。&amp;amp;amp;amp;nbsp;例如，声明在函数中一个局部变量&amp;amp;amp;amp;nbsp;int&amp;amp;amp;amp;nbsp;b;&amp;amp;amp;amp;nbsp;系统自动在栈中为b开辟空间 &amp;amp;amp;lt;br /&amp;amp;amp;gt; heap: &amp;amp;amp;lt;br /&amp;amp;amp;gt; 需要程序员自己申请，并指明大小，在c中malloc函数 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p1&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 在C++中用new运算符 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 如p2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;(char&amp;amp;amp;amp;nbsp;*)malloc(10); &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是注意p1、p2本身是在栈中的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.2 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 申请后系统的响应 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：只要栈的剩余空间大于所申请空间，系统将为程序提供内存，否则将报异常提示栈溢出。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：首先应该知道操作系统有一个记录空闲内存地址的链表，当系统收到程序的申请时， &amp;amp;amp;lt;br /&amp;amp;amp;gt; 会遍历该链表，寻找第一个空间大于所申请空间的堆结点，然后将该结点从空闲结点链表中删除，并将该结点的空间分配给程序，另外，对于大多数系统，会在这块内存空间中的首地址处记录本次分配的大小，这样，代码中的delete语句才能正确的释放本内存空间。另外，由于找到的堆结点的大小不一定正好等于申请的大小，系统会自动的将多余的那部分重新放入空闲链表中。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.3申请大小的限制 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：在Windows下,栈是向低地址扩展的数据结构，是一块连续的内存的区域。这句话的意思是栈顶的地址和栈的最大容量是系统预先规定好的，在&amp;amp;amp;amp;nbsp;WINDOWS下，栈的大小是2M（也有的说是1M，总之是一个编译时就确定的常数），如果申请的空间超过栈的剩余空间时，将提示overflow。因此，能从栈获得的空间较小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：堆是向高地址扩展的数据结构，是不连续的内存区域。这是由于系统是用链表来存储的空闲内存地址的，自然是不连续的，而链表的遍历方向是由低地址向高地址。堆的大小受限于计算机系统中有效的虚拟内存。由此可见，堆获得的空间比较灵活，也比较大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.4申请效率的比较： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈由系统自动分配，速度较快。但程序员是无法控制的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆是由new分配的内存，一般速度比较慢，而且容易产生内存碎片,不过用起来最方便. &amp;amp;amp;lt;br /&amp;amp;amp;gt; 另外，在WINDOWS下，最好的方式是用VirtualAlloc分配内存，他不是在堆，也不是在栈是直接在进程的地址空间中保留一快内存，虽然用起来最不方便。但是速度快，也最灵活 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.5堆和栈中的存储内容 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 栈：&amp;amp;amp;amp;nbsp;在函数调用时，第一个进栈的是主函数中后的下一条指令（函数调用语句的下一条可执行语句）的地址，然后是函数的各个参数，在大多数的C编译器中，参数是由右往左入栈的，然后是函数中的局部变量。注意静态变量是不入栈的。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 当本次函数调用结束后，局部变量先出栈，然后是参数，最后栈顶指针指向最开始存的地址，也就是主函数中的下一条指令，程序由该点继续运行。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆：一般是在堆的头部用一个字节存放堆的大小。堆中的具体内容有程序员安排。&amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.6存取效率的比较 &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;s1[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;aaaaaaaaaaaaaaa&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*s2&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;bbbbbbbbbbbbbbbbb&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; aaaaaaaaaaa是在运行时刻赋值的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 而bbbbbbbbbbb是在编译时就确定的； &amp;amp;amp;lt;br /&amp;amp;amp;gt; 但是，在以后的存取中，在栈上的数组比指针所指向的字符串(例如堆)快。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 比如： &amp;amp;amp;lt;br /&amp;amp;amp;gt; #include&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;lt;stdio.h&amp;amp;amp;amp;gt;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; void&amp;amp;amp;amp;nbsp;main() &amp;amp;amp;lt;br /&amp;amp;amp;gt; { &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;1; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;c[]&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; char&amp;amp;amp;amp;nbsp;*p&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;quot;1234567890&amp;amp;amp;amp;quot;; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; return; &amp;amp;amp;lt;br /&amp;amp;amp;gt; } &amp;amp;amp;lt;br /&amp;amp;amp;gt; 对应的汇编代码 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 10:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;c[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401067&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;F1&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;cl,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-0Fh] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106A&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;4D&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],cl &amp;amp;amp;lt;br /&amp;amp;amp;gt; 11:&amp;amp;amp;amp;nbsp;a&amp;amp;amp;amp;nbsp;=&amp;amp;amp;amp;nbsp;p[1]; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 0040106D&amp;amp;amp;amp;nbsp;8B&amp;amp;amp;amp;nbsp;55&amp;amp;amp;amp;nbsp;EC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;edx,dword&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-14h] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401070&amp;amp;amp;amp;nbsp;8A&amp;amp;amp;amp;nbsp;42&amp;amp;amp;amp;nbsp;01&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;al,byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[edx+1] &amp;amp;amp;lt;br /&amp;amp;amp;gt; 00401073&amp;amp;amp;amp;nbsp;88&amp;amp;amp;amp;nbsp;45&amp;amp;amp;amp;nbsp;FC&amp;amp;amp;amp;nbsp;mov&amp;amp;amp;amp;nbsp;byte&amp;amp;amp;amp;nbsp;ptr&amp;amp;amp;amp;nbsp;[ebp-4],al &amp;amp;amp;lt;br /&amp;amp;amp;gt; 第一种在读取时直接就把字符串中的元素读到寄存器cl中，而第二种则要先把指针值读到edx中，在根据edx读取字符，显然慢了。&amp;amp;amp;amp;nbsp;&amp;amp;amp;amp;nbsp; &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 2.7小结： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别可以用如下的比喻来看出： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用栈就象我们去饭馆里吃饭，只管点菜（发出申请）、付钱、和吃（使用），吃饱了就走，不必理会切菜、洗菜等准备工作和洗碗、刷锅等扫尾工作，他的好处是快捷，但是自由度小。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 使用堆就象是自己动手做喜欢吃的菜肴，比较麻烦，但是比较符合自己的口味，而且自由度大。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; &amp;amp;amp;lt;br /&amp;amp;amp;gt; 堆和栈的区别主要分： &amp;amp;amp;lt;br /&amp;amp;amp;gt; 操作系统方面的堆和栈，如上面说的那些，不多说了。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 还有就是数据结构方面的堆和栈，这些都是不同的概念。这里的堆实际上指的就是（满足堆性质的）优先队列的一种数据结构，第1个元素有最高的优先权；栈实际上就是满足先进后出的性质的数学或数据结构。 &amp;amp;amp;lt;br /&amp;amp;amp;gt; 虽然堆栈，堆栈的说法是连起来叫，但是他们还是有很大区别的，连着叫只是由于历史的原因。&amp;amp;amp;lt;/p&amp;amp;amp;gt;&amp;amp;lt;/p&amp;amp;gt;&amp;lt;/p&amp;gt;&lt;/p&gt;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC0133B570 AS DateTime), CAST(0x00009CEC012E4EA0 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (70, 42, -1, N'的工作的幸福感', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01354638 AS DateTime), CAST(0x00009CEC01296408 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (71, 42, -1, N'的师傅告诉对方', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC01359A98 AS DateTime), CAST(0x00009CEC012CB0F4 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (72, 42, -1, N'撒旦发射点', N'', convert(text, N'' collate Chinese_PRC_CI_AS), 0, N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', N'', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CEC013720D4 AS DateTime), CAST(0x00009CEC0135C720 AS DateTime), 0)
INSERT [dbo].[DT_Arc_Article] ([ID], [ClassID], [ViceClassID], [Title], [ShortTitle], [TitleStyle], [TitleFlag], [Tags], [ImgUrl], [Author], [Editor], [PubLisher], [Source], [Templet], [Keywords], [Description], [AContent], [Click], [Good], [Bad], [Readaccess], [Money], [Attribute], [IsComment], [IsVerify], [IsRecycle], [IsRedirect], [IsHtml], [IsPaging], [FilePath], [SimilarArticle], [AddDate], [PubDate], [OrderID]) VALUES (74, 51, -1, N'斗破苍穹* 第二章 斗气大陆', N'斗气大陆', convert(text, N'' collate Chinese_PRC_CI_AS), 1, N'C#,ASP.NET', convert(text, N'/uploads/users/201001/20100103124451781_abbr.jpg' collate Chinese_PRC_CI_AS), N'admin', N'', N'', N'admin', convert(text, N'' collate Chinese_PRC_CI_AS), N'', N'', N'<p>月如银盘，漫天繁星。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;山崖之颠，萧炎斜躺在草地之上，嘴中叼中一根青草，微微嚼动，任由那淡淡的苦涩在嘴中弥漫开来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;举起有些白皙的手掌，挡在眼前，目光透过手指缝隙，遥望着天空上那轮巨大的银月。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;想起下午的测试，萧炎轻叹了一口气，懒懒的抽回手掌，双手枕着脑袋，眼神有些恍惚&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;十五年了呢&hellip;&rdquo;低低的自喃声，忽然毫无边际的从少年嘴中轻吐了出来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎的心中，有一个仅有他自己知道的秘密：他并不是这个世界的人，或者说，萧炎的灵魂，并不属于这个世界，他来自一个名叫地球的蔚蓝星球，至于为什么会来到这里，这种离奇经过，他也无法解释，不过在生活了一段时间之后，他还是后知后觉的明白了过来：他穿越了！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;随着年龄的增长，对这块大陆，萧炎也是有了些模糊的了解&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;大陆名为斗气大陆，大陆上并没有小说中常见的各系魔法，而斗气，才是大陆的唯一主调！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在这片大陆上，斗气的修炼，几乎已经在无数代人的努力之下，发展到了巅峰地步，而且由于斗气的不断繁衍，最后甚至扩散到了民间之中，这也导致，斗气，与人类的日常生活，变得息息相关，如此，斗气在大陆中的重要性，更是变得无可替代！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;因为斗气的极端繁衍，同时也导致从这条主线中分化出了无数条斗气修炼之法，所谓手有长短，分化出来的斗气修炼之法，自然也是有强有弱。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;经过归纳统计，斗气大陆将斗气功法的等级，由高到低分为四阶十二级：天.地.玄.黄！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;而每一阶，又分初，中，高三级！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;修炼的斗气功法等级的高低，也是决定日后成就高低的关键，比如修炼玄阶中级功法的人，自然要比修炼黄阶高级功法的同等级的人要强上几分。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆，分辩强弱，取决于三种条件。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;首先，最重要的，当然是自身的实力，如果本身实力只有一星斗者级别，那就算你修炼的是天阶高级的稀世功法，那也难以战胜一名修炼黄阶功法的斗师。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;其次，便是功法！同等级的强者，如果你的功法等级较之对方要高级许多，那么在比试之时，种种优势，一触既知。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;最后一种，名叫斗技！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;顾名思义，这是一种发挥斗气的特殊技能，斗技在大陆之上，也有着等级之分，总的说来，同样也是分为天地玄黄四级。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;斗气大陆斗技数不胜数，不过一般流传出来的大众斗技，大多都只是黄级左右，想要获得更高深的斗技，便必须加入宗派，或者大陆上的斗气学院。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，一些依靠奇遇所得到前人遗留而下的功法，或者有着自己相配套的斗技，这种由功法衍变而出的斗技，互相配合起来，威力要更强上一些。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;依靠这三种条件，方才能判出究竟孰强孰弱，总的说来，如果能够拥有等级偏高的斗气功法，日后的好处，不言而喻&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;不过高级斗气修炼功法常人很难得到，流传在普通阶层的功法，顶多只是黄阶功法，一些比较强大的家族或者中小宗派，应该有玄阶的修炼之法，比如萧炎所在的家族，最为顶层的功法，便是只有族长才有资格修炼的：狂狮怒罡，这是一种风属性，并且是玄阶中级的斗气功法。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;玄阶之上，便是地阶了，不过这种高深功法，或许便只有那些超然势力与大帝国，方才可能拥有&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;至于天阶&hellip;已经几百年未曾出现了。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;从理论上来说，常人想要获得高级功法，基本上是难如登天，然而事无绝对，斗气大陆地域辽阔，万族林立，大陆之北，有号称力大无穷，可与兽魂合体的蛮族，大陆之南，也有各种智商奇高的高级魔兽家族，更有那以诡异阴狠而著名的黑暗种族等等&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;由于地域的辽阔，也有很多不为人知的无名隐士，在生命走到尽头之后，性子孤僻的他们，或许会将平生所创功法隐于某处，等待有缘人取之，在斗气大陆上，流传一句话：如果某日，你摔落悬崖，掉落山洞，不要惊慌，往前走两步，或许，你，将成为强者！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;此话，并不属假，大陆近千年历史中，并不泛这种依靠奇遇而成为强者的故事.<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;这个故事所造成的后果，便是造就了大批每天等在悬崖边，准备跳崖得绝世功法的怀梦之人，当然了，这些人大多都是以断胳膊断腿归来&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;总之，这是一片充满奇迹，以及创造奇迹的大陆！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当然，想要修炼斗气秘籍，至少需要成为一名真正的斗者之后，方才够资格，而现在的萧炎隔那段距离，似乎还很是遥远&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呸。&rdquo;吐出嘴中的草根，萧炎忽然跳起身来，脸庞狰狞，对着夜空失态的咆哮道：&ldquo;我草你奶奶的，把劳资穿过来当废物玩吗？草！&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在前世，萧炎只是庸碌众生中极其平凡的一员，金钱，美人，这些东西与他根本就是两条平行线，永远没有交叉点，然而，当来到这片斗气大陆之后，萧炎却是惊喜的发现，因为两世的经验，他的灵魂，竟然比常人要强上许多！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;要知道，在斗气大陆，灵魂是天生的，或许它能随着年龄的增长而稍稍变强，可却从没有什么功法能够单独修炼灵魂，就算是天阶功法，也不可能！这是斗气大陆的常识。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;灵魂的强化，也造就出萧炎的修炼天赋，同样，也造就了他的天才之名。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;当一个平凡庸碌之人，在知道他有成为无数人瞩目的本钱之后，若是没有足够的定力，很难能够把握本心，很显然的，前世仅仅是普通人的萧炎，并没有这种超人般的定力，所以，在他开始修炼斗之气后，他选择了成为受人瞩目的天才之路，而并非是在安静中逐渐成长！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;若是没有意外发生的话，萧炎或许还真能够顶着天才的名头越长越大，不过，很可惜，在十一岁那年，天才之名，逐渐被突如其来的变故剥夺而去，而天才，也是在一夜间，沦落成了路人口中嘲笑的废物！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&hellip;&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在咆哮了几嗓子之后，萧炎的情绪也是缓缓的平息了下来，脸庞再次回复了平日的落寞，事与至此，不管他如何暴怒，也是挽不回辛苦修炼而来的斗之气旋。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;苦涩的摇了摇头，萧炎心中其实有些委屈，毕竟他对自己身体究竟发生了什么事，也是一概不知，平日检查，却没有发现丝毫不对劲的地方，灵魂，随着年龄的增加，也是越来越强大，而且吸收斗之气的速度，比几年前最巅峰的状态还要强盛上几分，这种种条件，都说明自己的天赋从不曾减弱，可那些进入体内的斗之气，却都是无一例外的消失得干干净净，诡异的情形，让得萧炎黯然神伤&hellip;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;黯然的叹了口气，萧炎抬起手掌，手指上有一颗黑色戒指，戒指很是古朴，不知是何材料所铸，其上还绘有些模糊的纹路，这是母亲临死前送给他的唯一礼物，从四岁开始，他已经佩戴了十年，母亲的遗物，让得萧炎对它也是有着一份眷恋，手指轻轻的抚摸着戒指，萧炎苦笑道：&ldquo;这几年，还真是辜负母亲的期望了&hellip;&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;深深的吐了一口气，萧炎忽然回转过头，对着漆黑的树林温暖的笑道：&ldquo;父亲，您来了？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;虽然斗之气只有三段，不过萧炎的灵魂感知，却是比一名五星斗者都要敏锐许多，在先前说起母亲的时候，他便察觉到了树林中的一丝动静。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，炎儿，这么晚了，怎么还待在这上面呢？&rdquo;树林中，在静了片刻后，传出男子的关切笑声。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;树枝一阵摇摆，一位中年人跃了出来，脸庞上带着笑意，凝视着自己那站在月光下的儿子。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;中年人身着华贵的灰色衣衫，龙行虎步间颇有几分威严，脸上一对粗眉更是为其添了几分豪气，他便是萧家现任族长，同时也是萧炎的父亲，五星大斗师，萧战！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，您不也还没休息么？&rdquo;望着中年男子，萧炎脸庞上的笑容更浓了一分，虽然自己有着前世的记忆，不过自出生以来，面前这位父亲便是对自己百般宠爱，在自己落魄之后，宠爱不减反增，如此行径，却是让得萧炎甘心叫他一声父亲。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;炎儿，还在想下午测验的事呢？&rdquo;大步上前，萧战笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;呵呵，有什么好想的，意料之中而已。&rdquo;萧炎少年老成的摇了摇头，笑容却是有些勉强。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;唉&hellip;&rdquo;望着萧炎那依旧有些稚嫩的清秀脸庞，萧战叹了一口气，沉默了片刻，忽然道：&ldquo;炎儿，你十五岁了吧？&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;嗯，父亲。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;再有一年，似乎&hellip;就该进行成年仪式了&hellip;&rdquo;萧战苦笑道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;是的，父亲，还有一年！&rdquo;手掌微微一紧，萧炎平静的回道，成年仪式代表什么，他自然非常清楚，只要度过了成年仪式，那么没有修炼潜力的他，便将会被取消进入斗气阁寻找斗气功法的资格，从而被分配到家族的各处产业之中，为家族打理一些普通事物，这是家族的族规，就算他的父亲是族长，那也不可能改变！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;毕竟，若是在二十五岁之前没有成为一名斗者，那将不会被家族所认可！<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;对不起了，炎儿，如果在一年后你的斗之气达不到七段，那么父亲也只得忍痛把你分配到家族的产业中去，毕竟，这个家族，还并不是父亲一人说了算，那几个老家伙，可随时等着父亲犯错呢&hellip;&rdquo;望着平静的萧炎，萧战有些歉疚的叹道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;父亲，我会努力的，一年后，我一定会到达七段斗之气的！&rdquo;萧炎微笑着安慰道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;一年，四段？呵呵，如果是以前，或许还有可能吧，不过现在&hellip;基本没半点机会&hellip;&rdquo;虽然口中在安慰着父亲，不过萧炎心中却是自嘲的苦笑了起来。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;同样非常清楚萧炎底细的萧战，也只得叹息着应了一声，他知道一年修炼四段斗之气有多困难，轻拍了拍他的脑袋，忽然笑道：&ldquo;不早了，回去休息吧，明天，家族中有贵客，你可别失了礼。&rdquo;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;贵客？谁啊？&rdquo;萧炎好奇的问道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;明天就知道了.&rdquo;对着萧炎挤了挤眼睛，萧战大笑而去，留下无奈的萧炎。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&ldquo;放心吧，父亲，我会尽力的！&rdquo;抚摸着手指上的古朴戒指，萧炎抬头喃喃道。<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;在萧炎抬头的那一刹，手指中的黑色古戒，却是忽然亮起了一抹极其微弱的诡异毫光，毫光眨眼便逝，没有引起任何人的察觉&hellip;</p>', 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, convert(text, N'' collate Chinese_PRC_CI_AS), convert(text, N'         ' collate Chinese_PRC_CI_AS), CAST(0x00009CF60179E950 AS DateTime), CAST(0x00009CF6017A2E74 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[DT_Arc_Article] OFF
/****** 对象:  Table [dbo].[DT_ModuleControl]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_ModuleControl]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_ModuleControl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ControlName] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ModuleID] [varchar](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ControlValue] [int] NOT NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_DT_Pre_ModuleControl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_ModuleControl', N'COLUMN',N'ControlName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'操作名字' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_ModuleControl', @level2type=N'COLUMN',@level2name=N'ControlName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_ModuleControl', N'COLUMN',N'ModuleID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_ModuleControl', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_ModuleControl', N'COLUMN',N'ControlValue'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'操作值' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_ModuleControl', @level2type=N'COLUMN',@level2name=N'ControlValue'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_ModuleControl', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_ModuleControl', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
SET IDENTITY_INSERT [dbo].[DT_ModuleControl] ON
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (5, N'查看', convert(text, N'M02' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (6, N'查看', convert(text, N'M0201' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (7, N'查看', convert(text, N'M0202' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (8, N'查看', convert(text, N'M0203' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (9, N'查看', convert(text, N'M0204' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (10, N'查看', convert(text, N'M03' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (11, N'查看', convert(text, N'M0301' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (12, N'查看', convert(text, N'M0302' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (13, N'查看', convert(text, N'M0303' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (14, N'查看', convert(text, N'M04' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (15, N'查看', convert(text, N'M0401' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (16, N'查看', convert(text, N'M0402' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (17, N'查看', convert(text, N'M05' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (18, N'查看', convert(text, N'M0501' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (19, N'查看', convert(text, N'M0502' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (20, N'查看', convert(text, N'M0503' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (21, N'查看', convert(text, N'M0504' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (22, N'查看', convert(text, N'M06' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (23, N'查看', convert(text, N'M0601' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (24, N'查看', convert(text, N'M0602' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (25, N'查看', convert(text, N'M0603' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (26, N'查看', convert(text, N'M0604' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (27, N'查看', convert(text, N'M0605' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (28, N'查看', convert(text, N'M0606' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (29, N'查看', convert(text, N'M07' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (30, N'查看', convert(text, N'M0701' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (31, N'查看', convert(text, N'M0703' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (32, N'查看', convert(text, N'M0704' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (33, N'查看', convert(text, N'M08' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (34, N'查看', convert(text, N'M0801' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (35, N'查看', convert(text, N'M0802' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (36, N'查看', convert(text, N'M0803' collate Chinese_PRC_CI_AS), 1, 0)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (61, N'查看', convert(text, N'M0201001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (62, N'添加', convert(text, N'M0201001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (63, N'编辑', convert(text, N'M0201001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (64, N'删除', convert(text, N'M0201001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (65, N'查看', convert(text, N'M0201003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (66, N'添加', convert(text, N'M0201003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (67, N'编辑', convert(text, N'M0201003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (68, N'删除', convert(text, N'M0201003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (69, N'查看', convert(text, N'M0201002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (70, N'添加', convert(text, N'M0201002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (71, N'编辑', convert(text, N'M0201002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (72, N'删除', convert(text, N'M0201002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (73, N'查看', convert(text, N'M0202001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (74, N'添加', convert(text, N'M0202001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (75, N'编辑', convert(text, N'M0202001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (76, N'删除', convert(text, N'M0202001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (77, N'查看', convert(text, N'M0202002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (78, N'添加', convert(text, N'M0202002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (79, N'编辑', convert(text, N'M0202002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (80, N'删除', convert(text, N'M0202002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (81, N'查看', convert(text, N'M0202003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (82, N'添加', convert(text, N'M0202003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (83, N'编辑', convert(text, N'M0202003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (84, N'删除', convert(text, N'M0202003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (85, N'查看', convert(text, N'M0202004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (86, N'添加', convert(text, N'M0202004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (87, N'编辑', convert(text, N'M0202004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (88, N'删除', convert(text, N'M0202004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (89, N'查看', convert(text, N'M0203001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (90, N'添加', convert(text, N'M0203001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (91, N'编辑', convert(text, N'M0203001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (92, N'删除', convert(text, N'M0203001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (93, N'查看', convert(text, N'M0203002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (94, N'添加', convert(text, N'M0203002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (95, N'编辑', convert(text, N'M0203002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (96, N'删除', convert(text, N'M0203002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (97, N'查看', convert(text, N'M0204001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (98, N'添加', convert(text, N'M0204001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (99, N'编辑', convert(text, N'M0204001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (100, N'删除', convert(text, N'M0204001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (105, N'查看', convert(text, N'M0301002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (106, N'添加', convert(text, N'M0301002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (107, N'编辑', convert(text, N'M0301002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (108, N'删除', convert(text, N'M0301002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (109, N'查看', convert(text, N'M0301008' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (110, N'添加', convert(text, N'M0301008' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (111, N'编辑', convert(text, N'M0301008' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (112, N'删除', convert(text, N'M0301008' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (113, N'查看', convert(text, N'M0301009' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (114, N'添加', convert(text, N'M0301009' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (115, N'编辑', convert(text, N'M0301009' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (116, N'删除', convert(text, N'M0301009' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (117, N'查看', convert(text, N'M0301010' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (118, N'添加', convert(text, N'M0301010' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (119, N'编辑', convert(text, N'M0301010' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (120, N'删除', convert(text, N'M0301010' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (121, N'查看', convert(text, N'M0302001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (122, N'添加', convert(text, N'M0302001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (123, N'编辑', convert(text, N'M0302001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (124, N'删除', convert(text, N'M0302001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (125, N'查看', convert(text, N'M0302002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (126, N'添加', convert(text, N'M0302002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (127, N'编辑', convert(text, N'M0302002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (128, N'删除', convert(text, N'M0302002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (129, N'查看', convert(text, N'M0303003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (130, N'添加', convert(text, N'M0303003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (131, N'编辑', convert(text, N'M0303003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (132, N'删除', convert(text, N'M0303003' collate Chinese_PRC_CI_AS), 8, 4)
GO
print 'Processed 100 total records'
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (133, N'查看', convert(text, N'M0303004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (134, N'添加', convert(text, N'M0303004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (135, N'编辑', convert(text, N'M0303004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (136, N'删除', convert(text, N'M0303004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (137, N'查看', convert(text, N'M0303005' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (138, N'添加', convert(text, N'M0303005' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (139, N'编辑', convert(text, N'M0303005' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (140, N'删除', convert(text, N'M0303005' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (141, N'查看', convert(text, N'M0303006' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (142, N'添加', convert(text, N'M0303006' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (143, N'编辑', convert(text, N'M0303006' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (144, N'删除', convert(text, N'M0303006' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (145, N'查看', convert(text, N'M0303007' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (146, N'添加', convert(text, N'M0303007' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (147, N'编辑', convert(text, N'M0303007' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (148, N'删除', convert(text, N'M0303007' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (149, N'查看', convert(text, N'M0401001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (150, N'添加', convert(text, N'M0401001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (151, N'编辑', convert(text, N'M0401001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (152, N'删除', convert(text, N'M0401001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (153, N'查看', convert(text, N'M0401002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (154, N'添加', convert(text, N'M0401002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (155, N'编辑', convert(text, N'M0401002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (156, N'删除', convert(text, N'M0401002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (157, N'查看', convert(text, N'M0401003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (158, N'添加', convert(text, N'M0401003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (159, N'编辑', convert(text, N'M0401003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (160, N'删除', convert(text, N'M0401003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (161, N'查看', convert(text, N'M0401004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (162, N'添加', convert(text, N'M0401004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (163, N'编辑', convert(text, N'M0401004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (164, N'删除', convert(text, N'M0401004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (165, N'查看', convert(text, N'M0401005' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (166, N'添加', convert(text, N'M0401005' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (167, N'编辑', convert(text, N'M0401005' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (168, N'删除', convert(text, N'M0401005' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (169, N'查看', convert(text, N'M0402001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (170, N'添加', convert(text, N'M0402001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (171, N'编辑', convert(text, N'M0402001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (172, N'删除', convert(text, N'M0402001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (173, N'查看', convert(text, N'M0402002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (174, N'添加', convert(text, N'M0402002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (175, N'编辑', convert(text, N'M0402002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (176, N'删除', convert(text, N'M0402002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (177, N'查看', convert(text, N'M0402003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (178, N'添加', convert(text, N'M0402003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (179, N'编辑', convert(text, N'M0402003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (180, N'删除', convert(text, N'M0402003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (181, N'查看', convert(text, N'M0402004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (182, N'添加', convert(text, N'M0402004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (183, N'编辑', convert(text, N'M0402004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (184, N'删除', convert(text, N'M0402004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (185, N'查看', convert(text, N'M0501001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (186, N'添加', convert(text, N'M0501001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (187, N'编辑', convert(text, N'M0501001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (188, N'删除', convert(text, N'M0501001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (189, N'查看', convert(text, N'M0501002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (190, N'添加', convert(text, N'M0501002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (191, N'编辑', convert(text, N'M0501002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (192, N'删除', convert(text, N'M0501002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (193, N'查看', convert(text, N'M0501003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (194, N'添加', convert(text, N'M0501003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (195, N'编辑', convert(text, N'M0501003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (196, N'删除', convert(text, N'M0501003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (197, N'查看', convert(text, N'M0501004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (198, N'添加', convert(text, N'M0501004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (199, N'编辑', convert(text, N'M0501004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (200, N'删除', convert(text, N'M0501004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (201, N'查看', convert(text, N'M0502001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (202, N'添加', convert(text, N'M0502001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (203, N'编辑', convert(text, N'M0502001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (204, N'删除', convert(text, N'M0502001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (205, N'查看', convert(text, N'M0502002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (206, N'添加', convert(text, N'M0502002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (207, N'编辑', convert(text, N'M0502002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (208, N'删除', convert(text, N'M0502002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (209, N'查看', convert(text, N'M0503001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (210, N'添加', convert(text, N'M0503001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (211, N'编辑', convert(text, N'M0503001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (212, N'删除', convert(text, N'M0503001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (213, N'查看', convert(text, N'M0503002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (214, N'添加', convert(text, N'M0503002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (215, N'编辑', convert(text, N'M0503002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (216, N'删除', convert(text, N'M0503002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (217, N'查看', convert(text, N'M0504001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (218, N'添加', convert(text, N'M0504001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (219, N'编辑', convert(text, N'M0504001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (220, N'删除', convert(text, N'M0504001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (221, N'查看', convert(text, N'M0504002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (222, N'添加', convert(text, N'M0504002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (223, N'编辑', convert(text, N'M0504002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (224, N'删除', convert(text, N'M0504002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (225, N'查看', convert(text, N'M0601001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (226, N'添加', convert(text, N'M0601001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (227, N'编辑', convert(text, N'M0601001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (228, N'删除', convert(text, N'M0601001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (229, N'查看', convert(text, N'M0601002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (230, N'添加', convert(text, N'M0601002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (231, N'编辑', convert(text, N'M0601002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (232, N'删除', convert(text, N'M0601002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (233, N'查看', convert(text, N'M0602001' collate Chinese_PRC_CI_AS), 1, 1)
GO
print 'Processed 200 total records'
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (234, N'添加', convert(text, N'M0602001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (235, N'编辑', convert(text, N'M0602001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (236, N'删除', convert(text, N'M0602001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (237, N'查看', convert(text, N'M0602002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (238, N'添加', convert(text, N'M0602002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (239, N'编辑', convert(text, N'M0602002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (240, N'删除', convert(text, N'M0602002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (241, N'查看', convert(text, N'M0602003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (242, N'添加', convert(text, N'M0602003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (243, N'编辑', convert(text, N'M0602003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (244, N'删除', convert(text, N'M0602003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (245, N'查看', convert(text, N'M0603001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (246, N'添加', convert(text, N'M0603001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (247, N'编辑', convert(text, N'M0603001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (248, N'删除', convert(text, N'M0603001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (249, N'查看', convert(text, N'M0603002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (250, N'添加', convert(text, N'M0603002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (251, N'编辑', convert(text, N'M0603002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (252, N'删除', convert(text, N'M0603002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (253, N'查看', convert(text, N'M0604001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (254, N'添加', convert(text, N'M0604001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (255, N'编辑', convert(text, N'M0604001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (256, N'删除', convert(text, N'M0604001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (257, N'查看', convert(text, N'M0604002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (258, N'添加', convert(text, N'M0604002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (259, N'编辑', convert(text, N'M0604002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (260, N'删除', convert(text, N'M0604002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (261, N'查看', convert(text, N'M0604003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (262, N'添加', convert(text, N'M0604003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (263, N'编辑', convert(text, N'M0604003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (264, N'删除', convert(text, N'M0604003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (265, N'查看', convert(text, N'M0605001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (266, N'添加', convert(text, N'M0605001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (267, N'编辑', convert(text, N'M0605001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (268, N'删除', convert(text, N'M0605001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (269, N'查看', convert(text, N'M0605002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (270, N'添加', convert(text, N'M0605002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (271, N'编辑', convert(text, N'M0605002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (272, N'删除', convert(text, N'M0605002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (273, N'查看', convert(text, N'M0606001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (274, N'添加', convert(text, N'M0606001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (275, N'编辑', convert(text, N'M0606001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (276, N'删除', convert(text, N'M0606001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (277, N'查看', convert(text, N'M0701001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (278, N'添加', convert(text, N'M0701001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (279, N'编辑', convert(text, N'M0701001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (280, N'删除', convert(text, N'M0701001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (281, N'查看', convert(text, N'M0701002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (282, N'添加', convert(text, N'M0701002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (283, N'编辑', convert(text, N'M0701002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (284, N'删除', convert(text, N'M0701002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (285, N'查看', convert(text, N'M0701003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (286, N'添加', convert(text, N'M0701003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (287, N'编辑', convert(text, N'M0701003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (288, N'删除', convert(text, N'M0701003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (289, N'查看', convert(text, N'M0701004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (290, N'添加', convert(text, N'M0701004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (291, N'编辑', convert(text, N'M0701004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (292, N'删除', convert(text, N'M0701004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (293, N'查看', convert(text, N'M0701005' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (294, N'添加', convert(text, N'M0701005' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (295, N'编辑', convert(text, N'M0701005' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (296, N'删除', convert(text, N'M0701005' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (297, N'查看', convert(text, N'M0701006' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (298, N'添加', convert(text, N'M0701006' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (299, N'编辑', convert(text, N'M0701006' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (300, N'删除', convert(text, N'M0701006' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (301, N'查看', convert(text, N'M0703001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (302, N'添加', convert(text, N'M0703001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (303, N'编辑', convert(text, N'M0703001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (304, N'删除', convert(text, N'M0703001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (305, N'查看', convert(text, N'M0703002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (306, N'添加', convert(text, N'M0703002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (307, N'编辑', convert(text, N'M0703002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (308, N'删除', convert(text, N'M0703002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (309, N'查看', convert(text, N'M0703003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (310, N'添加', convert(text, N'M0703003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (311, N'编辑', convert(text, N'M0703003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (312, N'删除', convert(text, N'M0703003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (313, N'查看', convert(text, N'M0703004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (314, N'添加', convert(text, N'M0703004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (315, N'编辑', convert(text, N'M0703004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (316, N'删除', convert(text, N'M0703004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (317, N'查看', convert(text, N'M0704001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (318, N'添加', convert(text, N'M0704001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (319, N'编辑', convert(text, N'M0704001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (320, N'删除', convert(text, N'M0704001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (321, N'查看', convert(text, N'M0704002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (322, N'添加', convert(text, N'M0704002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (323, N'编辑', convert(text, N'M0704002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (324, N'删除', convert(text, N'M0704002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (325, N'查看', convert(text, N'M0801001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (326, N'添加', convert(text, N'M0801001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (327, N'编辑', convert(text, N'M0801001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (328, N'删除', convert(text, N'M0801001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (329, N'查看', convert(text, N'M0801002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (330, N'添加', convert(text, N'M0801002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (331, N'编辑', convert(text, N'M0801002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (332, N'删除', convert(text, N'M0801002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (333, N'查看', convert(text, N'M0801003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (334, N'添加', convert(text, N'M0801003' collate Chinese_PRC_CI_AS), 2, 2)
GO
print 'Processed 300 total records'
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (335, N'编辑', convert(text, N'M0801003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (336, N'删除', convert(text, N'M0801003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (337, N'查看', convert(text, N'M0801004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (338, N'添加', convert(text, N'M0801004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (339, N'编辑', convert(text, N'M0801004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (340, N'删除', convert(text, N'M0801004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (341, N'查看', convert(text, N'M0802001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (342, N'添加', convert(text, N'M0802001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (343, N'编辑', convert(text, N'M0802001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (344, N'删除', convert(text, N'M0802001' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (345, N'查看', convert(text, N'M0802002' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (346, N'添加', convert(text, N'M0802002' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (347, N'编辑', convert(text, N'M0802002' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (348, N'删除', convert(text, N'M0802002' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (349, N'查看', convert(text, N'M0802003' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (350, N'添加', convert(text, N'M0802003' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (351, N'编辑', convert(text, N'M0802003' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (352, N'删除', convert(text, N'M0802003' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (353, N'查看', convert(text, N'M0802004' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (354, N'添加', convert(text, N'M0802004' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (355, N'编辑', convert(text, N'M0802004' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (356, N'删除', convert(text, N'M0802004' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (357, N'查看', convert(text, N'M0802005' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (358, N'添加', convert(text, N'M0802005' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (359, N'编辑', convert(text, N'M0802005' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (360, N'删除', convert(text, N'M0802005' collate Chinese_PRC_CI_AS), 8, 4)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (361, N'查看', convert(text, N'M0803001' collate Chinese_PRC_CI_AS), 1, 1)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (362, N'添加', convert(text, N'M0803001' collate Chinese_PRC_CI_AS), 2, 2)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (363, N'编辑', convert(text, N'M0803001' collate Chinese_PRC_CI_AS), 4, 3)
INSERT [dbo].[DT_ModuleControl] ([ID], [ControlName], [ModuleID], [ControlValue], [OrderID]) VALUES (364, N'删除', convert(text, N'M0803001' collate Chinese_PRC_CI_AS), 8, 4)
SET IDENTITY_INSERT [dbo].[DT_ModuleControl] OFF
/****** 对象:  Table [dbo].[DT_Arc_Class]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Class]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Arc_Class](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[Attribute] [tinyint] NOT NULL,
	[ClassName] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ClassEName] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[ClassType] [tinyint] NOT NULL,
	[ClassDomain] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ClassPath] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[IndexTemplet] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ListTemplet] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ArchiveTemplet] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[IndexRule] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ListRule] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ArchiveRule] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[ClassPage] [tinyint] NULL,
	[Description] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
	[IsHidden] [tinyint] NOT NULL,
	[IsHtml] [tinyint] NOT NULL,
	[CheckLevel] [tinyint] NOT NULL,
	[IsContribute] [tinyint] NOT NULL,
	[IsComment] [tinyint] NOT NULL,
	[Readaccess] [smallint] NULL,
	[SiteID] [tinyint] NULL,
	[AddDate] [datetime] NOT NULL,
	[Relation] [varchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[OrderID] [smallint] NOT NULL,
	[ImgUrl] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Keywords] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[CrossID] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[ClassContent] [ntext] COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_DT_Arc_Class] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'CID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'CID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ParentID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目父ID，默认0为顶级栏目' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ParentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'Attribute'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目属性，1封面，2列表，3单页面，4链接地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'Attribute'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassEName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目英文名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassEName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassType'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目类型' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassDomain'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目二级域名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassDomain'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassPath'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目目录，{#CmsPath}/Archive/' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassPath'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IndexTemplet'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'封面模版' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IndexTemplet'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ListTemplet'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'列表模版' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ListTemplet'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ArchiveTemplet'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文档模版' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ArchiveTemplet'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IndexRule'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'封面页规则' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IndexRule'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ListRule'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'列表页规则，访问路径' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ListRule'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ArchiveRule'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'文档页规则，访问路径' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ArchiveRule'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassPage'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目分页大小,列表条数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassPage'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IsHidden'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否隐藏，1启用，0隐藏' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IsHidden'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IsHtml'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否允许生成静态页，1生成静态，0动态访问' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IsHtml'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'CheckLevel'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'审核机制' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'CheckLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IsContribute'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否允许投稿，1允许，0不允许' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IsContribute'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'IsComment'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'本栏目文章是否允许评论，1允许，0不允许' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'IsComment'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'Readaccess'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'阅读权限' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'Readaccess'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'SiteID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'站点ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'SiteID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'AddDate'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'Relation'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目关系' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'Relation'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目排序，升序排列' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ImgUrl'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目图片地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ImgUrl'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'Keywords'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目关键字' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'Keywords'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'CrossID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'交叉栏目，多个栏目用,号隔开' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'CrossID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Arc_Class', N'COLUMN',N'ClassContent'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目内容' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Arc_Class', @level2type=N'COLUMN',@level2name=N'ClassContent'
GO
SET IDENTITY_INSERT [dbo].[DT_Arc_Class] ON
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (9, 0, 1, N'WEB技术', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 10, NULL, NULL, NULL, NULL)
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (10, 9, 1, N'HTML基础', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 10, NULL, NULL, NULL, NULL)
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (11, 9, 1, N'Javascript', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 30, NULL, NULL, NULL, NULL)
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (12, 9, 1, N'DIV+CSS', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 50, NULL, NULL, NULL, NULL)
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (22, 9, 1, N'AJAX技术', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 40, NULL, NULL, NULL, NULL)
INSERT [dbo].[DT_Arc_Class] ([CID], [ParentID], [Attribute], [ClassName], [ClassEName], [ClassType], [ClassDomain], [ClassPath], [IndexTemplet], [ListTemplet], [ArchiveTemplet], [IndexRule], [ListRule], [ArchiveRule], [ClassPage], [Description], [IsHidden], [IsHtml], [CheckLevel], [IsContribute], [IsComment], [Readaccess], [SiteID], [AddDate], [Relation], [OrderID], [ImgUrl], [Keywords], [CrossID], [ClassContent]) VALUES (23, 9, 1, N'AJAX技术', convert(text, N'webjs' collate Chinese_PRC_CI_AS), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 1, 1, 1, 1, NULL, CAST(0x00009CF100000000 AS DateTime), NULL, 40, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DT_Arc_Class] OFF
/****** 对象:  Table [dbo].[DT_AttachMent]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_AttachMent]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_AttachMent](
	[AID] [int] IDENTITY(1,1) NOT NULL,
	[Attribute] [tinyint] NOT NULL,
	[DisplayName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[AttachMentPath] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[AttachMentSize] [int] NULL,
	[AbbrPhotoPath] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[PubLisher] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[AddDate] [datetime] NULL,
	[PhotoDescription] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_DT_Atr_AttachMent_Phone] PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'AID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'AID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'Attribute'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件类型属性，1图片、2视频、3音频、4flash、5附件、6其它' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'Attribute'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'DisplayName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件显示名称，上传文件名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'DisplayName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'AttachMentPath'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'AttachMentPath'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'AttachMentSize'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件大小' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'AttachMentSize'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'AbbrPhotoPath'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'缩略图地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'AbbrPhotoPath'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'PubLisher'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'PubLisher'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'AddDate'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_AttachMent', N'COLUMN',N'PhotoDescription'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_AttachMent', @level2type=N'COLUMN',@level2name=N'PhotoDescription'
GO
/****** 对象:  StoredProcedure [dbo].[pagehelper]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[pagehelper]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'



-- 字符串缓存实现的通用分页存储过程(转自邹建)  
CREATE PROC [dbo].[pagehelper]  
@tbname     nvarchar(1000)='''',               --要分页显示的表名，可以使用表联合  
@FieldKey   nvarchar(1000)='''',               --用于定位记录的主键(惟一键)字段,只能是单个字段  
@PageCurrent int=1,                 --要显示的页码  
@PageSize   int=10,                --每页的大小(记录数)  
@FieldShow  nvarchar(1000)='''',      --以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段  
@FieldOrder  nvarchar(1000)='''',     --以逗号分隔的排序字段列表,可以指定在字段后面指定DESC/ASC  
                                    -- 用于指定排序顺序  
@Where     nvarchar(1000)='''',      --查询条件  
@PageCount  int OUTPUT            --总页数  
AS  
DECLARE @sql nvarchar(4000)  
SET NOCOUNT ON  

--分页字段检查  
IF ISNULL(@FieldKey,N'''')=''''  
BEGIN  
    RAISERROR(N''分页处理需要主键（或者惟一键）'',1,16)  
    RETURN  
END  
--其他参数检查及规范  
IF ISNULL(@PageCurrent,0)<1 SET @PageCurrent=1  
IF ISNULL(@PageSize,0)<1 SET @PageSize=10  
IF ISNULL(@FieldShow,N'''')=N'''' SET @FieldShow=N''*''  
IF ISNULL(@FieldOrder,N'''')=N''''  
    SET @FieldOrder=N''''  
ELSE  IF CHARINDEX(''ORDER BY'',@FieldOrder)!=0
	SET @FieldOrder=LTRIM(@FieldOrder)
ELSE
    SET @FieldOrder=N''ORDER BY ''+LTRIM(@FieldOrder)  
IF ISNULL(@Where,N'''')=N''''  
    SET @Where=N''''  
ELSE  
    SET @Where=N''WHERE (''+@Where+N'')''  
--如果@PageCount为NULL值,则计算总页数(这样设计可以只在第一次计算总页数,以后调用时,把总页数传回给存储过程,避免再次计算总页数,对于不想计算总页数的处理而言,可以给@PageCount赋值)  
IF @PageCount IS NULL  
BEGIN  
    SET @sql=N''SELECT @PageCount=COUNT(*)''  
        +N'' FROM ''+@tbname  
        +N'' ''+@Where  
    EXEC sp_executesql @sql,N''@PageCount int OUTPUT'',@PageCount OUTPUT  
    --SET @PageCount=(@PageCount+@PageSize-1)/@PageSize  
END  

--@PageCount总记录数为0退出
IF @PageCount = 0
BEGIN
return 
END

--计算分页显示的TOPN值  
DECLARE @TopN varchar(20),@TopN1 varchar(20)  
SELECT @TopN=@PageSize,  
    @TopN1=@PageCurrent*@PageSize      
--第一页直接显示  
IF @PageCurrent=1  
    EXEC(N''SELECT TOP ''+@TopN  
        +N'' ''+@FieldShow  
        +N'' FROM ''+@tbname  
        +N'' ''+@Where  
        +N'' ''+@FieldOrder)  
ELSE  
BEGIN  
    SELECT @PageCurrent=@TopN1,  
        @sql=N''SELECT @n=@n-1,@s=CASE WHEN @n<''+@TopN  
            +N'' THEN @s+N'''',''''+QUOTENAME(RTRIM(CAST(''+@FieldKey  
            +N'' as varchar(8000))),N'''''''''''''''') ELSE N'''''''' END FROM ''+@tbname  
            +N'' ''+@Where  
            +N'' ''+@FieldOrder  

    SET ROWCOUNT @PageCurrent  
    EXEC sp_executesql @sql,  
        N''@n int,@s nvarchar(4000) OUTPUT'',  
        @PageCurrent,@sql OUTPUT  
    SET ROWCOUNT 0  
    IF @sql=N''''  
        EXEC(N''SELECT TOP 0''  
            +N'' ''+@FieldShow  
            +N'' FROM ''+@tbname)  
    ELSE  
    BEGIN  
        SET @sql=STUFF(@sql,1,1,N'''')          
        --执行查询   EXEC
        EXEC (N''SELECT TOP ''+@TopN  
            +N'' ''+@FieldShow  
            +N'' FROM ''+@tbname  
            +N'' ''+@Where + '' and '' + @FieldKey  
            +N'' IN(''+@sql  
            +N'') ''+@FieldOrder ) 
	END
END




' 
END
GO
/****** 对象:  Table [dbo].[DT_Sys_Dict]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Sys_Dict]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Sys_Dict](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Title] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Url] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Email] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Click] [int] NULL,
 CONSTRAINT [PK_DT_SYS_Dict] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Dict', N'COLUMN',N'Type'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Dict', @level2type=N'COLUMN',@level2name=N'Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Dict', N'COLUMN',N'Title'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Dict', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Dict', N'COLUMN',N'Click'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'点击数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Dict', @level2type=N'COLUMN',@level2name=N'Click'
GO
/****** 对象:  Table [dbo].[DT_Sys_Template]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Sys_Template]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Sys_Template](
	[TemplateID] [int] IDENTITY(1,1) NOT NULL,
	[TemplateName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[TemplateDirectory] [varchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[IsEnable] [tinyint] NOT NULL,
	[CreateDateTime] [datetime] NULL,
	[TemplateImg] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Author] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_DT_SYS_Template] PRIMARY KEY CLUSTERED 
(
	[TemplateID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'TemplateID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模板主键' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'TemplateID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'TemplateName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模板名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'TemplateName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'TemplateDirectory'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模板目录' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'TemplateDirectory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'IsEnable'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否启用' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'CreateDateTime'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'CreateDateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'TemplateImg'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模板缩略图' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'TemplateImg'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Sys_Template', N'COLUMN',N'Author'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Sys_Template', @level2type=N'COLUMN',@level2name=N'Author'
GO
/****** 对象:  Table [dbo].[DT_Userfields]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Userfields]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Userfields](
	[UID] [int] NOT NULL,
	[Realname] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[QQ] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[MSN] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Skype] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Phone] [char](16) COLLATE Chinese_PRC_CI_AS NULL,
	[Mobilephone] [char](11) COLLATE Chinese_PRC_CI_AS NULL,
	[Location] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Adress] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[IDcard] [varchar](18) COLLATE Chinese_PRC_CI_AS NULL,
	[Signature] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Introduce] [nvarchar](500) COLLATE Chinese_PRC_CI_AS NULL,
	[Website] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_DT_Userfields] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'UID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID，user表外键' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'UID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Realname'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Realname'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'QQ'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ号码，支持Email帐号' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'QQ'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'MSN'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'MSN帐号' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'MSN'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Skype'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Skype帐号' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Skype'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Phone'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'固定电话' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Phone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Adress'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Adress'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'IDcard'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'IDcard'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Signature'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'个性签名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Signature'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Introduce'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'个人简介' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Introduce'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Userfields', N'COLUMN',N'Website'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'个人网站' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Userfields', @level2type=N'COLUMN',@level2name=N'Website'
GO
/****** 对象:  Table [dbo].[DT_Arc_Soft]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Arc_Soft]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Arc_Soft](
	[AID] [int] NOT NULL
)
END
GO
/****** 对象:  Table [dbo].[DT_Usergroup]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Usergroup]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Usergroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [tinyint] NOT NULL,
	[IsSystem] [tinyint] NULL,
	[GroupName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Description] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[CreditBegin] [int] NULL,
	[CreditEnd] [int] NULL,
	[stars] [tinyint] NULL,
	[GroupAvatar] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Readaccess] [int] NULL,
	[AllowPost] [tinyint] NULL,
	[AllowComment] [tinyint] NULL,
	[AllowDownload] [tinyint] NULL,
	[AllowAvatar] [tinyint] NULL,
	[AllowSpace] [tinyint] NULL,
	[AllowTransfer] [tinyint] NULL,
	[AllowViewInfo] [tinyint] NULL,
	[AllowNickname] [tinyint] NULL,
	[MaxPMNum] [smallint] NULL,
	[MaxSignSize] [smallint] NULL,
	[MaxAttachSize] [int] NULL,
	[MaxAttachTotalSize] [int] NULL,
	[AttachExtension] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_DT_Pre_Usergroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'ID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'Type'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组类型，0系统组，1管理组，2用户组' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'Type'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'IsSystem'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否系统内置组，系统内置组不能被删除' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'GroupName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'GroupName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组描述' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'CreditBegin'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'开始积分' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'CreditBegin'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'CreditEnd'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'结束积分' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'CreditEnd'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'stars'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'星星等级' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'stars'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'GroupAvatar'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组头像' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'GroupAvatar'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'Readaccess'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'阅读权限' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'Readaccess'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowPost'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许发布文章，1允许，0不允许' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowPost'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowComment'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许评论' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowComment'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowDownload'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许下载附件' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowDownload'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowAvatar'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许使用头像，0不允许，1允许使用系统自带头像，2允许使用URL地址头像，3允许使用上传头像' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowAvatar'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowSpace'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许开通个人空间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowSpace'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowTransfer'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许积分转账' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowTransfer'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowViewInfo'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许查看其他用户资料' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowViewInfo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AllowNickname'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许使用昵称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AllowNickname'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'MaxPMNum'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'短消息最大条数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'MaxPMNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'MaxSignSize'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'签名最大字节数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'MaxSignSize'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'MaxAttachSize'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件最大尺寸' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'MaxAttachSize'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'MaxAttachTotalSize'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'附件最大总尺寸' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'MaxAttachTotalSize'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'AttachExtension'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'允许上传附件类型，例：.txt,.rar,.jpg' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'AttachExtension'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Usergroup', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Usergroup', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
SET IDENTITY_INSERT [dbo].[DT_Usergroup] ON
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (1, 0, 1, N'系统管理组', N'拥有系统最高权限', 0, 0, 16, NULL, 200, 1, 1, 1, 1, 1, 1, 1, 1, 200, 200, 1024, 10240, NULL, 1)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (2, 1, 1, N'管理组', N'具用所有管理权限，无系统配置权限', 0, 0, 15, NULL, 180, 1, 1, 1, 1, 1, 1, 1, 1, 100, 200, 1024, 10240, NULL, 2)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (3, 2, 1, N'等待验证会员', N'等待验证会员', 0, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, 3)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (4, 2, 0, N'新手上路', N'新手上路', 0, 100, 1, NULL, 10, 1, 0, 0, 0, 0, 0, 0, 0, 30, 50, 200, 1000, NULL, 4)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (5, 2, 0, N'初级会员', N'初级会员', 100, 300, 2, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 40, 60, 300, 2000, NULL, 5)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (6, 2, 0, N'中级会员', N'中级会员', 300, 1000, 3, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 50, 70, 500, 3000, NULL, 6)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (7, 2, 0, N'高级会员', N'高级会员', 1000, 2000, 4, NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 60, 80, 500, 4000, NULL, 7)
INSERT [dbo].[DT_Usergroup] ([ID], [Type], [IsSystem], [GroupName], [Description], [CreditBegin], [CreditEnd], [stars], [GroupAvatar], [Readaccess], [AllowPost], [AllowComment], [AllowDownload], [AllowAvatar], [AllowSpace], [AllowTransfer], [AllowViewInfo], [AllowNickname], [MaxPMNum], [MaxSignSize], [MaxAttachSize], [MaxAttachTotalSize], [AttachExtension], [OrderID]) VALUES (8, 2, 0, N'金牌会员', N'金牌会员', 2000, 999999999, 5, NULL, 1, 1, 1, 1, 1, 1, 1, 1, 1, 70, 90, 500, 5000, NULL, 8)
SET IDENTITY_INSERT [dbo].[DT_Usergroup] OFF
/****** 对象:  StoredProcedure [dbo].[OutputData]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[OutputData]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE   [dbo].[OutputData]     
  @tablename   sysname      
  AS      
  declare   @column   varchar(1000)     
  declare   @columndata   varchar(1000)     
  declare   @sql   varchar(4000)     
  declare   @xtype   tinyint      
  declare   @name   sysname      
  declare   @objectId   int      
  declare   @objectname   sysname      
  declare   @ident   int      

  set   nocount   on      
  set   @objectId=object_id(@tablename)     
  if  @objectId   is   null   --   判断对象是否存在     
     begin      
      print  @tablename +  ''对象不存在''     
      return      
    end     

  set @objectname=rtrim(object_name(@objectId))     
  if @objectname is null or charindex(@objectname,@tablename)=0
    begin      
      print  @tablename +  ''对象不在当前数据库中''      
      return      
    end         

  if  OBJECTPROPERTY(@objectId,''IsTable'')   <   >   1   --   判断对象是否是表     
    begin      
      print  @tablename +  ''对象不是表''     
      return      
    end         

  select   @ident=status&0x80   from   syscolumns   where   id=@objectid   and   status&0x80=0x80          

  if @ident is   not   null      
    print   ''SET   IDENTITY_INSERT   ''+ @TableName + ''   ON''     


  --定义游标，循环取数据并生成Insert语句
  declare  syscolumns_cursor  cursor for   
    select   c.name,c.xtype   from   syscolumns   c     
      where   c.id=@objectid     
      order   by   c.colid     

  --打开游标
  open   syscolumns_cursor     
  set  @column=''''     
  set  @columndata=''''     
  fetch   next   from   syscolumns_cursor   into   @name,@xtype     
  while   @@fetch_status   <> -1     
    begin      
    if   @@fetch_status   <> -2     
      begin      
      if   @xtype   not   in(189,34,35,99,98)   --timestamp不需处理，image,text,ntext,sql_variant 暂时不处理     
        begin      
        set   @column=@column + 
          case   when   len(@column)=0   then ''''  
                 else   '',''
                 end + @name     
        set   @columndata = @columndata + 
          case   when   len(@columndata)=0   then   ''''   
                 else   '','''','''',''
                 end  + 
          case   when  @xtype   in(167,175)  then   ''''''''''''''''''+''+@name+''+''''''''''''''''''                --varchar,char     
                 when   @xtype   in(231,239)   then   ''''''N''''''''''''+''+@name+''+''''''''''''''''''             --nvarchar,nchar     
                 when   @xtype=61   then   ''''''''''''''''''+convert(char(23),''+@name+'',121)+''''''''''''''''''   --datetime     
                 when   @xtype=58   then   ''''''''''''''''''+convert(char(16),''+@name+'',120)+''''''''''''''''''   --smalldatetime     
                  when   @xtype=36   then   ''''''''''''''''''+convert(char(36),''+@name+'')+''''''''''''''''''       --uniqueidentifier     
                 else   @name   
                 end      
        end      
      end      
    fetch   next   from   syscolumns_cursor   into   @name,@xtype     
    end      
  close   syscolumns_cursor     
  deallocate   syscolumns_cursor          

  set  @sql=''set   nocount   on   select   ''''insert   ''+@tablename+''(''+@column+'')   values(''''as   ''''--'''',''+@columndata+'','''')''''   from   ''+@tablename         

  print   ''--''+@sql     
  exec(@sql)          

  if   @ident   is   not   null      
  print  ''SET   IDENTITY_INSERT   ''+@TableName+''   OFF''     
' 
END
GO
/****** 对象:  Table [dbo].[DT_Modules]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Modules]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Modules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [varchar](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ParentID] [varchar](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[ModuleName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[EName] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[ModuleDepth] [tinyint] NULL,
	[ModuleURL] [varchar](255) COLLATE Chinese_PRC_CI_AS NULL,
	[Target] [varchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[Description] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[CreateTime] [datetime] NULL,
	[IsQuickMenu] [tinyint] NULL,
	[IsSystem] [tinyint] NULL,
	[IsEnable] [tinyint] NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_Sys_Navigate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'ModuleID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'ModuleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'ParentID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块父ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'ParentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'ModuleName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块名称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'ModuleName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'EName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块英文名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'EName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'ModuleDepth'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块深度，1为顶级模块分类' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'ModuleDepth'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'ModuleURL'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块URL地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'ModuleURL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'Target'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'页面打开方式' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'Target'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'模块说明' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'CreateTime'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'IsQuickMenu'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否添加到快捷菜单' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'IsQuickMenu'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'IsSystem'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否系统导航' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'IsEnable'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否应用' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Modules', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Modules', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
SET IDENTITY_INSERT [dbo].[DT_Modules] ON
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (1, convert(text, N'M01' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'控制面板', convert(text, N'ControlPanel' collate Chinese_PRC_CI_AS), 1, convert(text, N'controlpanel.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'附件管理', CAST(0x00009D01011A1C50 AS DateTime), 1, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (2, convert(text, N'M0101' collate Chinese_PRC_CI_AS), convert(text, N'M01' collate Chinese_PRC_CI_AS), N'快捷导航', convert(text, N'QuickMenu' collate Chinese_PRC_CI_AS), 2, NULL, convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'快捷导航', CAST(0x00009D01011D87B4 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (3, convert(text, N'M0102' collate Chinese_PRC_CI_AS), convert(text, N'M01' collate Chinese_PRC_CI_AS), N'个人信息', convert(text, N'PersonalInfo' collate Chinese_PRC_CI_AS), 2, convert(text, N'user/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'个人信息', CAST(0x00009D01011DCBAC AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (4, convert(text, N'M0102001' collate Chinese_PRC_CI_AS), convert(text, N'M0102' collate Chinese_PRC_CI_AS), N'我的资料', convert(text, N'MyInfo' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/myinfo.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'我的资料', CAST(0x00009D01011DF384 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (5, convert(text, N'M0102002' collate Chinese_PRC_CI_AS), convert(text, N'M0102' collate Chinese_PRC_CI_AS), N'短消息', convert(text, N'MyPM' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/pm_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'短消息', CAST(0x00009D0D0104373C AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (6, convert(text, N'M0102003' collate Chinese_PRC_CI_AS), convert(text, N'M0102' collate Chinese_PRC_CI_AS), N'我的权限', convert(text, N'MyPermission' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/mypermission.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'我的权限', CAST(0x00009D0D01046040 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (7, convert(text, N'M0103' collate Chinese_PRC_CI_AS), convert(text, N'M01' collate Chinese_PRC_CI_AS), N'系统帮助', convert(text, N'SystemHelp' collate Chinese_PRC_CI_AS), 2, convert(text, N'help/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'系统帮助', CAST(0x00009D1000F67818 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (8, convert(text, N'M0103001' collate Chinese_PRC_CI_AS), convert(text, N'M0103' collate Chinese_PRC_CI_AS), N'系统使用帮助', convert(text, N'SystemHelp' collate Chinese_PRC_CI_AS), 3, convert(text, N'http://www.91aspx.com/help/' collate Chinese_PRC_CI_AS), convert(text, N'_blank' collate Chinese_PRC_CI_AS), N'系统使用帮助', CAST(0x00009D1000F6E640 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (9, convert(text, N'M0103002' collate Chinese_PRC_CI_AS), convert(text, N'M0103' collate Chinese_PRC_CI_AS), N'模版标签帮助', convert(text, N'TemplateHelp' collate Chinese_PRC_CI_AS), 3, convert(text, N'http://www.91aspx.com/help/' collate Chinese_PRC_CI_AS), convert(text, N'_blank' collate Chinese_PRC_CI_AS), N'模版标签帮助', CAST(0x00009D1000F7452C AS DateTime), 0, 0, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (10, convert(text, N'M0103003' collate Chinese_PRC_CI_AS), convert(text, N'M0103' collate Chinese_PRC_CI_AS), N'官方网站', convert(text, N'OfficialSite' collate Chinese_PRC_CI_AS), 3, convert(text, N'http://www.91aspx.com/' collate Chinese_PRC_CI_AS), convert(text, N'_blank' collate Chinese_PRC_CI_AS), N'官方网站', CAST(0x00009D1000F84A80 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (11, convert(text, N'M02' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'站点管理', convert(text, N'SiteManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'site/class_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'频道管理', CAST(0x00009D01011885AC AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (12, convert(text, N'M0201' collate Chinese_PRC_CI_AS), convert(text, N'M02' collate Chinese_PRC_CI_AS), N'频道管理', convert(text, N'ChannelManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'site/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'频道管理', CAST(0x00009D0D010833F0 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (13, convert(text, N'M0201001' collate Chinese_PRC_CI_AS), convert(text, N'M0201' collate Chinese_PRC_CI_AS), N'内容模型管理', convert(text, N'ModelList' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/model_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'内容模型管理', CAST(0x00009D0D0109C5E4 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (14, convert(text, N'M0201003' collate Chinese_PRC_CI_AS), convert(text, N'M0201' collate Chinese_PRC_CI_AS), N'单页文档管理', convert(text, N'SimpleArchiveList' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/simplearchive_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'单页文档管理', CAST(0x00009D0D010A08B0 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (15, convert(text, N'M0201002' collate Chinese_PRC_CI_AS), convert(text, N'M0201' collate Chinese_PRC_CI_AS), N'网站栏目管理', convert(text, N'ClassList' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/class_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'网站栏目管理', CAST(0x00009D0D010B2B50 AS DateTime), 1, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (16, convert(text, N'M0202' collate Chinese_PRC_CI_AS), convert(text, N'M02' collate Chinese_PRC_CI_AS), N'频道设置', convert(text, N'ChannelSetting' collate Chinese_PRC_CI_AS), 2, convert(text, N'site/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'频道设置', CAST(0x00009D0D01086654 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (17, convert(text, N'M0202001' collate Chinese_PRC_CI_AS), convert(text, N'M0202' collate Chinese_PRC_CI_AS), N'栏目默认字段', convert(text, N'ClassAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/class_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'栏目默认字段', CAST(0x00009D0D010B12B4 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (18, convert(text, N'M0202002' collate Chinese_PRC_CI_AS), convert(text, N'M0202' collate Chinese_PRC_CI_AS), N'栏目防采集设置', convert(text, N'ClassImport' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/class_import.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'栏目防采集设置', CAST(0x00009D0D010BA080 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (19, convert(text, N'M0202003' collate Chinese_PRC_CI_AS), convert(text, N'M0202' collate Chinese_PRC_CI_AS), N'文档默认字段', convert(text, N'ArchivesDefault' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/archivesdefault_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文档默认字段', CAST(0x00009D1100EFC478 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (20, convert(text, N'M0202004' collate Chinese_PRC_CI_AS), convert(text, N'M0202' collate Chinese_PRC_CI_AS), N'软件下载设置', convert(text, N'SoftDownload' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/softdownload_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'软件下载设置', CAST(0x00009D1100F03AD4 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (21, convert(text, N'M0203' collate Chinese_PRC_CI_AS), convert(text, N'M02' collate Chinese_PRC_CI_AS), N'文件管理', convert(text, N'FileManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'site/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文件管理', CAST(0x00009D0D01089B10 AS DateTime), 0, 1, 1, 6)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (22, convert(text, N'M0203001' collate Chinese_PRC_CI_AS), convert(text, N'M0203' collate Chinese_PRC_CI_AS), N'文件管理器', convert(text, N'FileList' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/file_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文件管理器', CAST(0x00009D0D010C3428 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (23, convert(text, N'M0203002' collate Chinese_PRC_CI_AS), convert(text, N'M0203' collate Chinese_PRC_CI_AS), N'木马检测', convert(text, N'FileTrojanDetect' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/file_detect.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文件木马检测', CAST(0x00009D0D010CD4B4 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (24, convert(text, N'M0204' collate Chinese_PRC_CI_AS), convert(text, N'M02' collate Chinese_PRC_CI_AS), N'模版管理', convert(text, N'TemplateManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'site/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'模版管理', CAST(0x00009D0D0108EF70 AS DateTime), 0, 1, 1, 7)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (25, convert(text, N'M0204001' collate Chinese_PRC_CI_AS), convert(text, N'M0204' collate Chinese_PRC_CI_AS), N'模版管理', convert(text, N'TemplateList' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/template_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'模版管理', CAST(0x00009D0D010D5470 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (26, convert(text, N'M0204002' collate Chinese_PRC_CI_AS), convert(text, N'M0204' collate Chinese_PRC_CI_AS), N'添加模版', convert(text, N'TemplateAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'site/template_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加模版', CAST(0x00009D0D010D973C AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (27, convert(text, N'M03' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'内容管理', convert(text, N'ContentManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'content/news/article_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'内容管理', CAST(0x00009D01011914A4 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (28, convert(text, N'M0301' collate Chinese_PRC_CI_AS), convert(text, N'M03' collate Chinese_PRC_CI_AS), N'信息管理', convert(text, N'NewsManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'content/news/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'信息管理', CAST(0x00009D0D010EF924 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (29, convert(text, N'M0301002' collate Chinese_PRC_CI_AS), convert(text, N'M0301' collate Chinese_PRC_CI_AS), N'文档发布', convert(text, N'ArchivsAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'javascript:;" onclick="alert();' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文档发布', CAST(0x00009D0D011768E8 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (30, convert(text, N'M0301008' collate Chinese_PRC_CI_AS), convert(text, N'M0301' collate Chinese_PRC_CI_AS), N'内容审核', convert(text, N'NewsVerify' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/new_sverify.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'内容审核', CAST(0x00009D0D011D6F18 AS DateTime), 0, 1, 1, 8)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (31, convert(text, N'M0301009' collate Chinese_PRC_CI_AS), convert(text, N'M0301' collate Chinese_PRC_CI_AS), N'重复标题检测', convert(text, N'NewsTitleDetect' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/news_detect.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'重复标题检测', CAST(0x00009D0D011E6E90 AS DateTime), 0, 1, 1, 9)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (32, convert(text, N'M0301010' collate Chinese_PRC_CI_AS), convert(text, N'M0301' collate Chinese_PRC_CI_AS), N'内容回收站', convert(text, N'NewsRecycle' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/newsrecycle.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'内容回收站', CAST(0x00009D0D011ED22C AS DateTime), 0, 1, 1, 10)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (33, convert(text, N'M0302' collate Chinese_PRC_CI_AS), convert(text, N'M03' collate Chinese_PRC_CI_AS), N'专题管理', convert(text, N'SpecialManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'content/news/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'专题管理', CAST(0x00009D0D010F7FE8 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (34, convert(text, N'M0302001' collate Chinese_PRC_CI_AS), convert(text, N'M0302' collate Chinese_PRC_CI_AS), N'添加专题', convert(text, N'SpecialAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/special_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加专题', CAST(0x00009D0D011F8DAC AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (35, convert(text, N'M0302002' collate Chinese_PRC_CI_AS), convert(text, N'M0302' collate Chinese_PRC_CI_AS), N'专题列表', convert(text, N'SpecialList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/special_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'专题列表', CAST(0x00009D0D011FBB60 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (36, convert(text, N'M0303' collate Chinese_PRC_CI_AS), convert(text, N'M03' collate Chinese_PRC_CI_AS), N'文档管理', convert(text, N'ContentPublish' collate Chinese_PRC_CI_AS), 2, convert(text, N'content/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文档管理', CAST(0x00009D1100E5ECF0 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (37, convert(text, N'M0303003' collate Chinese_PRC_CI_AS), convert(text, N'M0303' collate Chinese_PRC_CI_AS), N'文章管理', convert(text, N'ArticleList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/article_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文章管理', CAST(0x00009D0D011B88C4 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (38, convert(text, N'M0303004' collate Chinese_PRC_CI_AS), convert(text, N'M0303' collate Chinese_PRC_CI_AS), N'软件管理', convert(text, N'SoftList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/soft_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'软件管理', CAST(0x00009D0D011BAF70 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (39, convert(text, N'M0303005' collate Chinese_PRC_CI_AS), convert(text, N'M0303' collate Chinese_PRC_CI_AS), N'图片管理', convert(text, N'PictureList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/picture_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'图片文档管理', CAST(0x00009D0D011C48F4 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (40, convert(text, N'M0303006' collate Chinese_PRC_CI_AS), convert(text, N'M0303' collate Chinese_PRC_CI_AS), N'视频管理', convert(text, N'VedioList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/vedio_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'视频文档管理', CAST(0x00009D0D011CA330 AS DateTime), 0, 1, 1, 6)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (41, convert(text, N'M0303007' collate Chinese_PRC_CI_AS), convert(text, N'M0303' collate Chinese_PRC_CI_AS), N'产品管理', convert(text, N'ProductList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/news/product_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'产品管理', CAST(0x00009D0D011CE4D0 AS DateTime), 0, 1, 1, 7)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (42, convert(text, N'M04' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'生成管理', convert(text, N'CreatStatic' collate Chinese_PRC_CI_AS), 1, convert(text, N'createstatic/createhtml.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成管理', CAST(0x00009D0101194960 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (43, convert(text, N'M0401' collate Chinese_PRC_CI_AS), convert(text, N'M04' collate Chinese_PRC_CI_AS), N'网站生成', convert(text, N'CreateWeb' collate Chinese_PRC_CI_AS), 2, convert(text, N'createstatic/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成管理', CAST(0x00009CEF01689114 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (44, convert(text, N'M0401001' collate Chinese_PRC_CI_AS), convert(text, N'M0401' collate Chinese_PRC_CI_AS), N'一键更新', convert(text, N'CreateAll' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createall.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'一键更新', CAST(0x00009CEF01691DB4 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (45, convert(text, N'M0401002' collate Chinese_PRC_CI_AS), convert(text, N'M0401' collate Chinese_PRC_CI_AS), N'生成首页', convert(text, N'CreateHomePage' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createhome.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成首页', CAST(0x00009CEF0169377C AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (46, convert(text, N'M0401003' collate Chinese_PRC_CI_AS), convert(text, N'M0401' collate Chinese_PRC_CI_AS), N'生成列表页', convert(text, N'CreateList' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createlist.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成列表页', CAST(0x00009CEF0169A6D0 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (47, convert(text, N'M0401004' collate Chinese_PRC_CI_AS), convert(text, N'M0401' collate Chinese_PRC_CI_AS), N'生成内容页', convert(text, N'CreateContent' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createcontent.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成内容页', CAST(0x00009CEF0169D358 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (48, convert(text, N'M0401005' collate Chinese_PRC_CI_AS), convert(text, N'M0401' collate Chinese_PRC_CI_AS), N'生成专题页', convert(text, N'CreateSpecial' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createspecial.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成专题页', CAST(0x00009CEF016A1C00 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (49, convert(text, N'M0402' collate Chinese_PRC_CI_AS), convert(text, N'M04' collate Chinese_PRC_CI_AS), N'其他生成', convert(text, N'CreateOther' collate Chinese_PRC_CI_AS), 2, convert(text, N'createstatic/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'其他生成', CAST(0x00009CEF0168E0C4 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (50, convert(text, N'M0402001' collate Chinese_PRC_CI_AS), convert(text, N'M0402' collate Chinese_PRC_CI_AS), N'生成广告JS', convert(text, N'CreateADJS' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createadjs.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成广告JS', CAST(0x00009CEF016A58F0 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (51, convert(text, N'M0402002' collate Chinese_PRC_CI_AS), convert(text, N'M0402' collate Chinese_PRC_CI_AS), N'生成调用JS', convert(text, N'CreateInvokeJS' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createinvokejs.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成调用JS', CAST(0x00009CEF016A718C AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (52, convert(text, N'M0402003' collate Chinese_PRC_CI_AS), convert(text, N'M0402' collate Chinese_PRC_CI_AS), N'生成站点地图', convert(text, N'CreateSitemap' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createsitemap.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成站点地图', CAST(0x00009CEF016B0E94 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (53, convert(text, N'M0402004' collate Chinese_PRC_CI_AS), convert(text, N'M0402' collate Chinese_PRC_CI_AS), N'生成RSS', convert(text, N'CreateRSS' collate Chinese_PRC_CI_AS), 3, convert(text, N'createstatic/createrss.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'生成RSS', CAST(0x00009CEF016B4350 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (54, convert(text, N'M05' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'用户管理', convert(text, N'UserManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'user/user_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'用户管理', CAST(0x00009D01011A0030 AS DateTime), 0, 1, 1, 6)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (55, convert(text, N'M0501' collate Chinese_PRC_CI_AS), convert(text, N'M05' collate Chinese_PRC_CI_AS), N'用户管理', convert(text, N'UserManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'user/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'用户管理', CAST(0x00009CEF016BD374 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (56, convert(text, N'M0501001' collate Chinese_PRC_CI_AS), convert(text, N'M0501' collate Chinese_PRC_CI_AS), N'添加用户', convert(text, N'UserAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/user_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加用户', CAST(0x00009CEF016CBB7C AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (57, convert(text, N'M0501002' collate Chinese_PRC_CI_AS), convert(text, N'M0501' collate Chinese_PRC_CI_AS), N'审核用户', convert(text, N'UserVerify' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/user_verify.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'审核用户', CAST(0x00009CEF016CEB88 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (58, convert(text, N'M0501003' collate Chinese_PRC_CI_AS), convert(text, N'M0501' collate Chinese_PRC_CI_AS), N'管理用户', convert(text, N'UserList' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/user_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理用户', CAST(0x00009CEF016D4114 AS DateTime), 1, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (59, convert(text, N'M0501004' collate Chinese_PRC_CI_AS), convert(text, N'M0501' collate Chinese_PRC_CI_AS), N'注册管理', convert(text, N'UserSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/user_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'用户注册管理', CAST(0x00009CEF017F6538 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (60, convert(text, N'M0502' collate Chinese_PRC_CI_AS), convert(text, N'M05' collate Chinese_PRC_CI_AS), N'用户空间管理', convert(text, N'SpaceManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'user/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'用户空间管理', CAST(0x00009CEF016C1064 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (61, convert(text, N'M0502001' collate Chinese_PRC_CI_AS), convert(text, N'M0502' collate Chinese_PRC_CI_AS), N'空间配置', convert(text, N'SpaceSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/space_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'空间配置', CAST(0x00009CEF016DDA98 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (62, convert(text, N'M0502002' collate Chinese_PRC_CI_AS), convert(text, N'M0502' collate Chinese_PRC_CI_AS), N'管理空间', convert(text, N'SpaceList' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/sapce_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理空间', CAST(0x00009CEF016DFC94 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (63, convert(text, N'M0503' collate Chinese_PRC_CI_AS), convert(text, N'M05' collate Chinese_PRC_CI_AS), N'权限管理', convert(text, N'PermissionManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'user/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'权限管理', CAST(0x00009CEF016C626C AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (64, convert(text, N'M0503001' collate Chinese_PRC_CI_AS), convert(text, N'M0503' collate Chinese_PRC_CI_AS), N'权限配置', convert(text, N'PermissionSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/permission_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加权限', CAST(0x00009CEF016E6BE8 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (65, convert(text, N'M0503002' collate Chinese_PRC_CI_AS), convert(text, N'M0503' collate Chinese_PRC_CI_AS), N'角色管理', convert(text, N'PermissionList' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/permission_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'权限配置', CAST(0x00009CEF016EA7AC AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (66, convert(text, N'M0504' collate Chinese_PRC_CI_AS), convert(text, N'M05' collate Chinese_PRC_CI_AS), N'用户组管理', convert(text, N'GroupManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'user/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'用户组管理', CAST(0x00009CEF016C8210 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (67, convert(text, N'M0504001' collate Chinese_PRC_CI_AS), convert(text, N'M0504' collate Chinese_PRC_CI_AS), N'添加用户组', convert(text, N'GroupAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/group_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加用户组', CAST(0x00009CEF016ED1DC AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (68, convert(text, N'M0504002' collate Chinese_PRC_CI_AS), convert(text, N'M0504' collate Chinese_PRC_CI_AS), N'管理用户组', convert(text, N'GroupList' collate Chinese_PRC_CI_AS), 3, convert(text, N'user/group_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理用户组', CAST(0x00009CEF016F53F0 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (69, convert(text, N'M06' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'模块管理', convert(text, N'ModuleManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'module/module_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'插件管理', CAST(0x00009D01011A7C68 AS DateTime), 0, 1, 1, 7)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (70, convert(text, N'M0601' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'网站投票', convert(text, N'VoteManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/vote/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'网站投票', CAST(0x00009CEF01700160 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (71, convert(text, N'M0601001' collate Chinese_PRC_CI_AS), convert(text, N'M0601' collate Chinese_PRC_CI_AS), N'添加投票', convert(text, N'VoteAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/vote/vote_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加投票', CAST(0x00009CEF017328CC AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (72, convert(text, N'M0601002' collate Chinese_PRC_CI_AS), convert(text, N'M0601' collate Chinese_PRC_CI_AS), N'管理投票', convert(text, N'VoteList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/vote/vote_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理投票', CAST(0x00009CEF01738D94 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (73, convert(text, N'M0602001' collate Chinese_PRC_CI_AS), convert(text, N'M0602' collate Chinese_PRC_CI_AS), N'添加问卷', convert(text, N'QuestionnaireAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/questionnaire/questionnaire_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加问卷', CAST(0x00009CEF0173B56C AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (74, convert(text, N'M0602' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'问卷调查', convert(text, N'QuestionnaireManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/questionnaire/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'问卷调查', CAST(0x00009CEF01709760 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (75, convert(text, N'M0602002' collate Chinese_PRC_CI_AS), convert(text, N'M0602' collate Chinese_PRC_CI_AS), N'管理问卷', convert(text, N'QuestionnaireList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/questionnaire/questionnaire_list_aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理问卷', CAST(0x00009CEF0173EC80 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (76, convert(text, N'M0602003' collate Chinese_PRC_CI_AS), convert(text, N'M0602' collate Chinese_PRC_CI_AS), N'问卷报表', convert(text, N'QuestionnaireResult' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/questionnaire/questionnaire_result.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'问卷报表', CAST(0x00009CEF01741584 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (77, convert(text, N'M0603' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'广告管理', convert(text, N'ADManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/ad/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'广告管理', CAST(0x00009CEF017203D4 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (78, convert(text, N'M0603001' collate Chinese_PRC_CI_AS), convert(text, N'M0603' collate Chinese_PRC_CI_AS), N'添加广告', convert(text, N'ADAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/ad/ad_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加广告', CAST(0x00009CEF0174FC60 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (79, convert(text, N'M0603002' collate Chinese_PRC_CI_AS), convert(text, N'M0603' collate Chinese_PRC_CI_AS), N'管理广告', convert(text, N'ADList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/ad/ad_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理广告', CAST(0x00009CEF01761F00 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (80, convert(text, N'M0604' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'友情连接', convert(text, N'FlinkManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/flink/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'友情连接', CAST(0x00009CEF01723890 AS DateTime), 1, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (81, convert(text, N'M0604001' collate Chinese_PRC_CI_AS), convert(text, N'M0604' collate Chinese_PRC_CI_AS), N'添加链接', convert(text, N'FlinkAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/flink/flink_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加链接', CAST(0x00009CEF0176793C AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (82, convert(text, N'M0604002' collate Chinese_PRC_CI_AS), convert(text, N'M0604' collate Chinese_PRC_CI_AS), N'管理链接', convert(text, N'FlinkList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/flink/flink_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理链接', CAST(0x00009CEF0176A6F0 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (83, convert(text, N'M0604003' collate Chinese_PRC_CI_AS), convert(text, N'M0604' collate Chinese_PRC_CI_AS), N'链接检测', convert(text, N'FlinkVerify' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/flink/flink_verify.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'链接检测', CAST(0x00009CEF0176F8F8 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (84, convert(text, N'M0605' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'问答模块', convert(text, N'AskManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/ask/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'问答模块', CAST(0x00009CEF0172BE28 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (85, convert(text, N'M0605001' collate Chinese_PRC_CI_AS), convert(text, N'M0605' collate Chinese_PRC_CI_AS), N'新建问答', convert(text, N'AskAdd' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/ask/ask_add.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'新建问答', CAST(0x00009CEF01772A30 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (86, convert(text, N'M0605002' collate Chinese_PRC_CI_AS), convert(text, N'M0605' collate Chinese_PRC_CI_AS), N'管理问答', convert(text, N'AskList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/ask/ask_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'管理问答', CAST(0x00009CEF01778CA0 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (87, convert(text, N'M0606' collate Chinese_PRC_CI_AS), convert(text, N'M06' collate Chinese_PRC_CI_AS), N'访客留言', convert(text, N'LeavewordManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'modules/leaveword/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'访客留言', CAST(0x00009CEF017815BC AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (88, convert(text, N'M0606001' collate Chinese_PRC_CI_AS), convert(text, N'M0606' collate Chinese_PRC_CI_AS), N'管理留言', convert(text, N'LeavewordList' collate Chinese_PRC_CI_AS), 3, convert(text, N'modules/leaveword/leaveword_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'添加留言', CAST(0x00009CEF017A88B0 AS DateTime), 1, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (89, convert(text, N'M07' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'系统管理', convert(text, N'SystemManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'admin/system/baseconfig.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'系统管理', CAST(0x00009D0D00E08044 AS DateTime), 0, 1, 1, 8)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (90, convert(text, N'M0701' collate Chinese_PRC_CI_AS), convert(text, N'M07' collate Chinese_PRC_CI_AS), N'系统设置', convert(text, N'SystemSetting' collate Chinese_PRC_CI_AS), 2, convert(text, N'system/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'系统设置', CAST(0x00009CEF017B4304 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (91, convert(text, N'M0701001' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'基本设置', convert(text, N'BaseSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/base_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'基本信息设置', CAST(0x00009CEF017CDF84 AS DateTime), 1, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (92, convert(text, N'M0701002' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'访问控制', convert(text, N'VisitSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/visit_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'访问设置', CAST(0x00009CEF017F064C AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (93, convert(text, N'M0701003' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'安全控制', convert(text, N'SafeSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/safe_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'安全控制', CAST(0x00009CEF0180AE84 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (94, convert(text, N'M0701004' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'附件设置', convert(text, N'AttchmentSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/attchment_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'附件设置', CAST(0x00009CEF01812990 AS DateTime), 0, 1, 1, 6)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (95, convert(text, N'M0701005' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'邮件设置', convert(text, N'SMTPSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/smtp_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'邮件设置', CAST(0x00009CEF0181E18C AS DateTime), 0, 1, 1, 7)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (96, convert(text, N'M0701006' collate Chinese_PRC_CI_AS), convert(text, N'M0701' collate Chinese_PRC_CI_AS), N'高级设置', convert(text, N'AdvancedSetting' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/advanced_setting.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'高级设置', CAST(0x00009CEF01822DB8 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (97, convert(text, N'M0703' collate Chinese_PRC_CI_AS), convert(text, N'M07' collate Chinese_PRC_CI_AS), N'数据库管理', convert(text, N'DatabaseManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'system/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'数据库管理', CAST(0x00009CEF017C2C38 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (98, convert(text, N'M0703001' collate Chinese_PRC_CI_AS), convert(text, N'M0703' collate Chinese_PRC_CI_AS), N'运行SQL语句', convert(text, N'RunSQL' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/database_runsql.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'运行指定SQL语句', CAST(0x00009CEF01832754 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (99, convert(text, N'M0703002' collate Chinese_PRC_CI_AS), convert(text, N'M0703' collate Chinese_PRC_CI_AS), N'数据库备份', convert(text, N'DatabaseBackup' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/database_backup.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'数据库备份', CAST(0x00009CEF018359B8 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (100, convert(text, N'M0703003' collate Chinese_PRC_CI_AS), convert(text, N'M0703' collate Chinese_PRC_CI_AS), N'数据库恢复', convert(text, N'DatabaseRevert' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/database_revert.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'数据库恢复', CAST(0x00009CEF0183C45C AS DateTime), 0, 1, 1, 3)
GO
print 'Processed 100 total records'
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (101, convert(text, N'M0703004' collate Chinese_PRC_CI_AS), convert(text, N'M0703' collate Chinese_PRC_CI_AS), N'收缩数据库', convert(text, N'DatabaseCompress' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/database_compress.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'数据库收缩', CAST(0x00009CEF018442EC AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (102, convert(text, N'M0704' collate Chinese_PRC_CI_AS), convert(text, N'M07' collate Chinese_PRC_CI_AS), N'日志管理', convert(text, N'LogManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'system/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'日志管理', CAST(0x00009CEF017C7F6C AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (103, convert(text, N'M0704001' collate Chinese_PRC_CI_AS), convert(text, N'M0704' collate Chinese_PRC_CI_AS), N'后台操作日志', convert(text, N'OperateLog' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/log_operate.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'后台操作日志', CAST(0x00009CEF0184EF30 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (104, convert(text, N'M0704002' collate Chinese_PRC_CI_AS), convert(text, N'M0704' collate Chinese_PRC_CI_AS), N'错误日志', convert(text, N'ErrorLog' collate Chinese_PRC_CI_AS), 3, convert(text, N'system/log_error.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'错误日志', CAST(0x00009CEF01851834 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (105, convert(text, N'M08' collate Chinese_PRC_CI_AS), convert(text, N'M0' collate Chinese_PRC_CI_AS), N'数据维护', convert(text, N'DataManage' collate Chinese_PRC_CI_AS), 1, convert(text, N'data/tag_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'数据维护', CAST(0x00009A1701722F30 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (106, convert(text, N'M0801' collate Chinese_PRC_CI_AS), convert(text, N'M08' collate Chinese_PRC_CI_AS), N'信息维护', convert(text, N'DataInfo' collate Chinese_PRC_CI_AS), 2, convert(text, N'data/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'信息维护', CAST(0x00009A1701730478 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (107, convert(text, N'M0801001' collate Chinese_PRC_CI_AS), convert(text, N'M0801' collate Chinese_PRC_CI_AS), N'文档评论管理', convert(text, N'CommentList' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/commen_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文档评论管理', CAST(0x00009D0D010FD31C AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (108, convert(text, N'M0801002' collate Chinese_PRC_CI_AS), convert(text, N'M0801' collate Chinese_PRC_CI_AS), N'搜索关键字管理', convert(text, N'SearchwordtList' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/searchword_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'搜索关键字管理', CAST(0x00009D1000EDEC34 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (109, convert(text, N'M0801003' collate Chinese_PRC_CI_AS), convert(text, N'M0801' collate Chinese_PRC_CI_AS), N'文档信息统计', convert(text, N'ArchivesInfo' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/archives_info.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'评论管理', CAST(0x00009D1000EE5A5C AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (110, convert(text, N'M0801004' collate Chinese_PRC_CI_AS), convert(text, N'M0801' collate Chinese_PRC_CI_AS), N'附件数据管理', convert(text, N'AttachmentList' collate Chinese_PRC_CI_AS), 3, convert(text, N'content/attachment/attachment_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'附件数据管理', CAST(0x00009D0D0120E760 AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (111, convert(text, N'M0802' collate Chinese_PRC_CI_AS), convert(text, N'M08' collate Chinese_PRC_CI_AS), N'基础数据维护', convert(text, N'DataBasic' collate Chinese_PRC_CI_AS), 2, convert(text, N'data/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'基础数据维护', CAST(0x00009A17017469E4 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (112, convert(text, N'M0802001' collate Chinese_PRC_CI_AS), convert(text, N'M0802' collate Chinese_PRC_CI_AS), N'TAG关键字维护', convert(text, N'TAGManage' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/tag_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'TAG关键字维护', CAST(0x00009D0D011022CC AS DateTime), 0, 1, 1, 4)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (113, convert(text, N'M0802002' collate Chinese_PRC_CI_AS), convert(text, N'M0802' collate Chinese_PRC_CI_AS), N'文档关键字维护', convert(text, N'KeywordManage' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/keyword_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'文档关键字维护', CAST(0x00009D0D01112BA4 AS DateTime), 0, 1, 1, 5)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (114, convert(text, N'M0802003' collate Chinese_PRC_CI_AS), convert(text, N'M0802' collate Chinese_PRC_CI_AS), N'来源管理', convert(text, N'SourceList' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/source_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'来源管理', CAST(0x00009A170176C310 AS DateTime), 0, 1, 1, 1)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (115, convert(text, N'M0802004' collate Chinese_PRC_CI_AS), convert(text, N'M0802' collate Chinese_PRC_CI_AS), N'作者管理', convert(text, N'AuthorList' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/author_list.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'作者管理', CAST(0x00009A17017704B0 AS DateTime), 0, 1, 1, 2)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (116, convert(text, N'M0802005' collate Chinese_PRC_CI_AS), convert(text, N'M0802' collate Chinese_PRC_CI_AS), N'自定义文档属性', convert(text, N'CustomAttr' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/customattr.aspx' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'自定义文档属性', CAST(0x00009A170178575C AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (117, convert(text, N'M0803' collate Chinese_PRC_CI_AS), convert(text, N'M08' collate Chinese_PRC_CI_AS), N'数据字典维护', convert(text, N'DataDicManage' collate Chinese_PRC_CI_AS), 2, convert(text, N'data/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'基础数据', CAST(0x00009CEF017BB000 AS DateTime), 0, 1, 1, 3)
INSERT [dbo].[DT_Modules] ([ID], [ModuleID], [ParentID], [ModuleName], [EName], [ModuleDepth], [ModuleURL], [Target], [Description], [CreateTime], [IsQuickMenu], [IsSystem], [IsEnable], [OrderID]) VALUES (118, convert(text, N'M0803001' collate Chinese_PRC_CI_AS), convert(text, N'M0803' collate Chinese_PRC_CI_AS), N'数据字典维护', convert(text, N'DataBatch' collate Chinese_PRC_CI_AS), 3, convert(text, N'data/' collate Chinese_PRC_CI_AS), convert(text, N'main_body' collate Chinese_PRC_CI_AS), N'批量数据维护', CAST(0x00009A170181C1E8 AS DateTime), 0, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[DT_Modules] OFF
/****** 对象:  Table [dbo].[DT_Users]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Users]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Users](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[NickName] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Password] [varchar](64) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[SecureQuestion] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[SecureAnswer] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[Sex] [tinyint] NULL,
	[Email] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[RoleID] [int] NULL,
	[UsergroupID] [int] NULL,
	[RegisterIP] [char](15) COLLATE Chinese_PRC_CI_AS NULL,
	[RegisterTime] [datetime] NULL,
	[LastloginIP] [char](15) COLLATE Chinese_PRC_CI_AS NULL,
	[LastloginTime] [datetime] NULL,
	[LoginCount] [int] NULL,
	[PostCount] [int] NULL,
	[OnlineTime] [int] NULL,
	[Credits] [int] NULL,
	[ExtCredits1] [decimal](18, 0) NULL,
	[ExtCredits2] [decimal](18, 0) NULL,
	[ExtCredits3] [decimal](18, 0) NULL,
	[ExtCredits4] [decimal](18, 0) NULL,
	[ExtCredits5] [decimal](18, 0) NULL,
	[Avatar] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[Birthday] [smalldatetime] NULL,
	[PMCount] [int] NULL,
	[IsVerify] [tinyint] NULL,
	[IsLock] [tinyint] NULL,
 CONSTRAINT [PK_DT_Users] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'UID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户UID编号' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'UID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'UserName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'UserName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'NickName'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户昵称' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'NickName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'SecureQuestion'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'安全提示问题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'SecureQuestion'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'SecureAnswer'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'安全提示答案' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'SecureAnswer'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'Sex'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'Sex'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'Email'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Email地址' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'Email'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'RoleID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户权限ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'UsergroupID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户组ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'UsergroupID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'RegisterIP'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'注册IP' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'RegisterIP'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'RegisterTime'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'注册时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'RegisterTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'LastloginIP'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'上次登陆IP' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'LastloginIP'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'LastloginTime'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'上次登陆时间' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'LastloginTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'LoginCount'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆次数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'LoginCount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'PostCount'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'发布文章数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'PostCount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'OnlineTime'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'在线时间（单位：分钟）' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'OnlineTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'Credits'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户积分' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'Credits'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'ExtCredits1'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'ExtCredits1'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'ExtCredits2'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分2' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'ExtCredits2'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'ExtCredits3'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分3' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'ExtCredits3'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'ExtCredits4'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分4' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'ExtCredits4'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'ExtCredits5'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'扩展积分' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'ExtCredits5'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'Avatar'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'用户头像' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'Avatar'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'Birthday'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'生日' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'Birthday'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'PMCount'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'新短消息数' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'PMCount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'IsVerify'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否审核' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'IsVerify'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Users', N'COLUMN',N'IsLock'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'是否锁定' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Users', @level2type=N'COLUMN',@level2name=N'IsLock'
GO
SET IDENTITY_INSERT [dbo].[DT_Users] ON
INSERT [dbo].[DT_Users] ([UID], [UserName], [NickName], [Password], [SecureQuestion], [SecureAnswer], [Sex], [Email], [RoleID], [UsergroupID], [RegisterIP], [RegisterTime], [LastloginIP], [LastloginTime], [LoginCount], [PostCount], [OnlineTime], [Credits], [ExtCredits1], [ExtCredits2], [ExtCredits3], [ExtCredits4], [ExtCredits5], [Avatar], [Birthday], [PMCount], [IsVerify], [IsLock]) VALUES (1, convert(text, N'admin' collate Chinese_PRC_CI_AS), N'admin', convert(text, N'admin' collate Chinese_PRC_CI_AS), NULL, NULL, 1, convert(text, N'admin@91aspx.com' collate Chinese_PRC_CI_AS), 1, 1, convert(text, N'192.168.1.1    ' collate Chinese_PRC_CI_AS), CAST(0x00009D190150EC58 AS DateTime), convert(text, N'127.0.0.1      ' collate Chinese_PRC_CI_AS), CAST(0x00009D2401363120 AS DateTime), 128, 0, 0, 0, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0, 1, 0)
INSERT [dbo].[DT_Users] ([UID], [UserName], [NickName], [Password], [SecureQuestion], [SecureAnswer], [Sex], [Email], [RoleID], [UsergroupID], [RegisterIP], [RegisterTime], [LastloginIP], [LastloginTime], [LoginCount], [PostCount], [OnlineTime], [Credits], [ExtCredits1], [ExtCredits2], [ExtCredits3], [ExtCredits4], [ExtCredits5], [Avatar], [Birthday], [PMCount], [IsVerify], [IsLock]) VALUES (2, convert(text, N'admin' collate Chinese_PRC_CI_AS), N'admin', convert(text, N'admin' collate Chinese_PRC_CI_AS), NULL, NULL, 1, convert(text, N'admin888@91aspx.com' collate Chinese_PRC_CI_AS), 1, 1, convert(text, N'192.168.1.1    ' collate Chinese_PRC_CI_AS), CAST(0x00009D190150EC58 AS DateTime), convert(text, N'127.0.0.1      ' collate Chinese_PRC_CI_AS), CAST(0x00009D1B014F26D4 AS DateTime), 29, 0, 0, 0, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[DT_Users] OFF
/****** 对象:  Table [dbo].[DT_Help]    脚本日期: 03/03/2010 20:39:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DT_Help]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[DT_Help](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HelpID] [char](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[PID] [char](8) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[Title] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[Message] [nvarchar](1000) COLLATE Chinese_PRC_CI_AS NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_DT_SYS_Help] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'ID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'ID，自增列' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'HelpID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帮助ID，例：H0201001' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'HelpID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'PID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帮助父ID' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'PID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'Title'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帮助主题' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'Message'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帮助信息' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'Message'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'DT_Help', N'COLUMN',N'OrderID'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'帮助排序' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DT_Help', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
/****** 对象:  Default [DF_DT_Arc_Article_ViceClassID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_ViceClassID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_ViceClassID]  DEFAULT ((-1)) FOR [ViceClassID]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Click]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Click]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Click]  DEFAULT (0) FOR [Click]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Good]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Good]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Good]  DEFAULT (0) FOR [Good]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Bad]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Bad]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Bad]  DEFAULT (0) FOR [Bad]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Readaccess]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Readaccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Readaccess]  DEFAULT (0) FOR [Readaccess]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Money]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Money]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Money]  DEFAULT (0) FOR [Money]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Status]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Status]  DEFAULT (0) FOR [Attribute]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsChecked]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsChecked]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_IsChecked]  DEFAULT (1) FOR [IsVerify]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsRecycle]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsRecycle]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_IsRecycle]  DEFAULT (0) FOR [IsRecycle]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsRedirect]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsRedirect]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_IsRedirect]  DEFAULT (0) FOR [IsRedirect]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsHtml]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsHtml]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_IsHtml]  DEFAULT (0) FOR [IsHtml]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_IsPaging]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_IsPaging]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_IsPaging]  DEFAULT (0) FOR [IsPaging]

END
GO
/****** 对象:  Default [DF_DT_Arc_Article_Sort]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Article_Sort]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Article] ADD  CONSTRAINT [DF_DT_Arc_Article_Sort]  DEFAULT (0) FOR [OrderID]

END
GO
/****** 对象:  Default [DF_DT_Arc_Class_ParentID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Arc_Class_ParentID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Arc_Class] ADD  CONSTRAINT [DF_DT_Arc_Class_ParentID]  DEFAULT (0) FOR [ParentID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Help_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Help_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Help] ADD  CONSTRAINT [DF_DT_SYS_Help_OrderID]  DEFAULT (0) FOR [OrderID]

END
GO
/****** 对象:  Default [DF_DT_Pre_ModuleControl_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_ModuleControl_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_ModuleControl] ADD  CONSTRAINT [DF_DT_Pre_ModuleControl_OrderID]  DEFAULT (0) FOR [OrderID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_CreateTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_CreateTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] ADD  CONSTRAINT [DF_DT_SYS_Navigate_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]

END
GO
/****** 对象:  Default [DF_DT_SYS_Modules_IsQuickMenu]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Modules_IsQuickMenu]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] ADD  CONSTRAINT [DF_DT_SYS_Modules_IsQuickMenu]  DEFAULT (0) FOR [IsQuickMenu]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_ISSys]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_ISSys]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] ADD  CONSTRAINT [DF_DT_SYS_Navigate_ISSys]  DEFAULT (0) FOR [IsSystem]

END
GO
/****** 对象:  Default [DF_DT_SYS_Navigate_ISEnable]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Navigate_ISEnable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] ADD  CONSTRAINT [DF_DT_SYS_Navigate_ISEnable]  DEFAULT (1) FOR [IsEnable]

END
GO
/****** 对象:  Default [DF_Sys_Navigate_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Sys_Navigate_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Modules] ADD  CONSTRAINT [DF_Sys_Navigate_OrderID]  DEFAULT (0) FOR [OrderID]

END
GO
/****** 对象:  Default [DF_DT_Roles_OrderID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Roles_OrderID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Roles] ADD  CONSTRAINT [DF_DT_Roles_OrderID]  DEFAULT (0) FOR [OrderID]

END
GO
/****** 对象:  Default [DF_DT_SYS_Dict_Hits]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_SYS_Dict_Hits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Sys_Dict] ADD  CONSTRAINT [DF_DT_SYS_Dict_Hits]  DEFAULT (0) FOR [Click]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_GroupType]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_GroupType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_GroupType]  DEFAULT (0) FOR [Type]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_IsSystem]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_IsSystem]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_IsSystem]  DEFAULT (0) FOR [IsSystem]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_CreditBegin]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_CreditBegin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_CreditBegin]  DEFAULT (0) FOR [CreditBegin]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_CreditEnd]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_CreditEnd]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_CreditEnd]  DEFAULT (0) FOR [CreditEnd]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_stars]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_stars]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_stars]  DEFAULT (0) FOR [stars]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_Readaccess]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_Readaccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_Readaccess]  DEFAULT (0) FOR [Readaccess]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowPost]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowPost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowPost]  DEFAULT (0) FOR [AllowPost]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowComment]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowComment]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowComment]  DEFAULT (0) FOR [AllowComment]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowDownload]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowDownload]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowDownload]  DEFAULT (0) FOR [AllowDownload]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowAvatar]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowAvatar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowAvatar]  DEFAULT (0) FOR [AllowAvatar]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowSpace]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowSpace]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowSpace]  DEFAULT (0) FOR [AllowSpace]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowTransfer]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowTransfer]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowTransfer]  DEFAULT (0) FOR [AllowTransfer]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowViewInfo]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowViewInfo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowViewInfo]  DEFAULT (0) FOR [AllowViewInfo]

END
GO
/****** 对象:  Default [DF_DT_Pre_Usergroup_AllowNickname]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Pre_Usergroup_AllowNickname]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Usergroup] ADD  CONSTRAINT [DF_DT_Pre_Usergroup_AllowNickname]  DEFAULT (0) FOR [AllowNickname]

END
GO
/****** 对象:  Default [DF_DT_Users_Sex]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_Sex]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_Sex]  DEFAULT (1) FOR [Sex]

END
GO
/****** 对象:  Default [DF_DT_Users_RoleID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_RoleID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_RoleID]  DEFAULT (0) FOR [RoleID]

END
GO
/****** 对象:  Default [DF_DT_Users_UsergroupID]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_UsergroupID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_UsergroupID]  DEFAULT (0) FOR [UsergroupID]

END
GO
/****** 对象:  Default [DF_DT_Users_RegisterDate]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_RegisterDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_RegisterDate]  DEFAULT (getdate()) FOR [RegisterTime]

END
GO
/****** 对象:  Default [DF_DT_Users_LastloginTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_LastloginTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_LastloginTime]  DEFAULT (getdate()) FOR [LastloginTime]

END
GO
/****** 对象:  Default [DF_DT_Users_LoginCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_LoginCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_LoginCount]  DEFAULT (0) FOR [LoginCount]

END
GO
/****** 对象:  Default [DF_DT_Users_PostCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_PostCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_PostCount]  DEFAULT (0) FOR [PostCount]

END
GO
/****** 对象:  Default [DF_DT_Users_OnlineTime]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_OnlineTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_OnlineTime]  DEFAULT (0) FOR [OnlineTime]

END
GO
/****** 对象:  Default [DF_DT_Users_Credits]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_Credits]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_Credits]  DEFAULT (0) FOR [Credits]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits1]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_ExtCredits1]  DEFAULT (0) FOR [ExtCredits1]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits2]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_ExtCredits2]  DEFAULT (0) FOR [ExtCredits2]

END
GO
/****** 对象:  Default [DF_DT_Users_ExtCredits3]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_ExtCredits3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_ExtCredits3]  DEFAULT (0) FOR [ExtCredits3]

END
GO
/****** 对象:  Default [DF_DT_Users_PmCount]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_PmCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_PmCount]  DEFAULT (0) FOR [PMCount]

END
GO
/****** 对象:  Default [DF_DT_Users_IsVerify]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_IsVerify]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_IsVerify]  DEFAULT (0) FOR [IsVerify]

END
GO
/****** 对象:  Default [DF_DT_Users_IsForbidden]    脚本日期: 03/03/2010 20:39:28 ******/
IF Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DT_Users_IsForbidden]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DT_Users] ADD  CONSTRAINT [DF_DT_Users_IsForbidden]  DEFAULT (0) FOR [IsLock]

END
GO
