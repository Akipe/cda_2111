-- base structure for first part

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_sql_exercice')
    BEGIN
        CREATE DATABASE [db_sql_exercice]
    END
GO


USE db_sql_exercice;


IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'dept' AND xtype = 'U')
BEGIN
    CREATE TABLE dept(
        deptno SMALLINT NOT NULL UNIQUE,
        dname NVARCHAR(32) NOT NULL,
        loc NVARCHAR(32) NOT NULL,
        CONSTRAINT PK_dept_deptno_id PRIMARY KEY (deptno)
    );
END;
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'emp' AND xtype = 'U')
BEGIN
    CREATE TABLE emp(
        empno SMALLINT NOT NULL UNIQUE,
        ename NVARCHAR(32) NOT NULL,
        job NVARCHAR(32) NOT NULL,
        mgr SMALLINT NULL,
        hiredate DATE NOT NULL,
        sal MONEY NOT NULL,
        comm MONEY NULL,
        deptno SMALLINT NOT NULL,
        CONSTRAINT PK_emp_id PRIMARY KEY (empno),
        CONSTRAINT FK_emp_manager FOREIGN KEY (mgr) REFERENCES emp(empno),
        CONSTRAINT FK_emp_dept FOREIGN KEY (deptno) REFERENCES dept(deptno)
    );
END
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'CK_emp_job' AND xtype = 'C')
BEGIN
    ALTER TABLE emp
        ADD CONSTRAINT CK_emp_job CHECK (job IN ('SALESMAN', 'PRESIDENT', 'MANAGER', 'ANALYST', 'CLERK'));
END
GO;