ALTER TABLE dbo.AUTH_DB_CONNECTION
	DROP CONSTRAINT AUTH_DB_CONNECTION_PK
GO
ALTER TABLE dbo.AUTH_DB_CONNECTION SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE AUTH_DB_CONNECTION
DROP CONSTRAINT AUTH_CONNECTION_STRING_AUTH_DB_CONNECTION_FK1;
GO
ALTER TABLE AUTH_DB_CONNECTION
DROP CONSTRAINT AUTH_CONNECTION_STRING_AUTH_DB_CONNECTION_FK2;
GO
ALTER TABLE AUTH_DB_CONNECTION
ALTER COLUMN DDB_CONN bigint null;
GO
ALTER TABLE AUTH_DB_CONNECTION
ALTER COLUMN RMDB_CONN bigint null;