USE [master]
GO

/****** Object:  Login [NT Service\MSSQL$SQLEXPRESS]    Script Date: 2/15/2024 19:12:32 ******/
CREATE LOGIN [IIS APPPOOL\AlisonSilvaPoeta] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO

Create User AlisonSilvaPoeta For Login [IIS APPPOOL\AlisonSilvaPoeta]


