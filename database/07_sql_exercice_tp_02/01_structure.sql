IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_sql_tp_02' )
    BEGIN
        CREATE DATABASE [db_sql_tp_02];
    END
ELSE
    BEGIN
        DROP DATABASE [db_sql_tp_02];
        CREATE DATABASE [db_sql_tp_02];
    END
GO;

USE db_sql_tp_02;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'avion' AND type = 'U')
    BEGIN
        CREATE TABLE avion(
            av SMALLINT IDENTITY(100, 1),
            avmarq NVARCHAR(16) NOT NULL,
            avtype NVARCHAR(16) NOT NULL,
            cap SMALLINT NOT NULL,
            loc NVARCHAR(16) NOT NULL,
            CONSTRAINT PK_avion_id PRIMARY KEY (av)
        );
    END
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'pilote' AND type = 'U')
    BEGIN
        CREATE TABLE pilote(
            pil SMALLINT IDENTITY(1, 1),
            pilnom NVARCHAR(16) NOT NULL,
            adr NVARCHAR(16) NOT NULL,
            CONSTRAINT PK_pilote_id PRIMARY KEY (pil)
        );
    END
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'vol' AND type = 'U')
    BEGIN
        CREATE TABLE vol(
            vol NCHAR(5) NOT NULL UNIQUE,
            pil SMALLINT NOT NULL,
            av SMALLINT NOT NULL,
            vd NVARCHAR(16) NOT NULL,
            va NVARCHAR(16) NOT NULL,
            hd TINYINT NOT NULL,
            ha TINYINT NOT NULL,
            CONSTRAINT PK_vol_id PRIMARY KEY (vol),
            CONSTRAINT FK_vol_pilote FOREIGN KEY (pil) REFERENCES pilote(pil),
            CONSTRAINT FK_vol_avion FOREIGN KEY (av) REFERENCES avion(av)
        );
    END
GO;
