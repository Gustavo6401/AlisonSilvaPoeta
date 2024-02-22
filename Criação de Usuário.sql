USE [master]
GO

Drop Login [Gustavo]

CREATE LOGIN [Gustavo] WITH PASSWORD=N'', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Português], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER SERVER ROLE [##MS_DatabaseConnector##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_DatabaseManager##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_DefinitionReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_LoginManager##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_PerformanceDefinitionReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_SecurityDefinitionReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_ServerPerformanceStateReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_ServerSecurityStateReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_ServerStateManager##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [##MS_ServerStateReader##] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [diskadmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [setupadmin] ADD MEMBER [Gustavo]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Gustavo]
GO
use [tempdb];
GO
USE [AlisonSilvaPoeta]
GO
CREATE USER [Gustavo] FOR LOGIN [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_owner] ADD MEMBER [Gustavo]
GO
USE [AlisonSilvaPoeta]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Gustavo]
GO
use [AlisonSilvaPoeta];
GO
USE [master]
GO
CREATE USER [Gustavo] FOR LOGIN [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_owner] ADD MEMBER [Gustavo]
GO
USE [master]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Gustavo]
GO
use [master];
GO
USE [model]
GO
CREATE USER [Gustavo] FOR LOGIN [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_owner] ADD MEMBER [Gustavo]
GO
USE [model]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Gustavo]
GO
use [model];
GO
USE [msdb]
GO
CREATE USER [Gustavo] FOR LOGIN [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [DatabaseMailUserRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_owner] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisadmin] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisltduser] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [db_ssisoperator] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [dc_admin] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [dc_operator] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [dc_proxy] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [PolicyAdministratorRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [ServerGroupAdministratorRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [ServerGroupReaderRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentOperatorRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentReaderRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [SQLAgentUserRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [TargetServersRole] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [UtilityCMRReader] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [UtilityIMRReader] ADD MEMBER [Gustavo]
GO
USE [msdb]
GO
ALTER ROLE [UtilityIMRWriter] ADD MEMBER [Gustavo]
GO
use [msdb];
GO
USE [tempdb]
GO
CREATE USER [Gustavo] FOR LOGIN [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_owner] ADD MEMBER [Gustavo]
GO
USE [tempdb]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Gustavo]
GO
