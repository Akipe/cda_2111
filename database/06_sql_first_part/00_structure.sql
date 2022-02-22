-- base structure for first part

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_sql_ex_part_one')
    BEGIN
        CREATE DATABASE [db_sql_ex_part_one]
    END
GO


USE db_sql_ex_part_one;


DROP TABLE IF EXISTS dept;
DROP TABLE IF EXISTS emp;


CREATE TABLE dept(
    deptno INT NOT NULL UNIQUE,
    dname VARCHAR(32) NOT NULL,
    loc VARCHAR(32) NOT NULL,
    CONSTRAINT PK_dept_deptno_id PRIMARY KEY (deptno)
);

CREATE TABLE emp(
    empno INT NOT NULL UNIQUE,
    ename VARCHAR(32) NOT NULL,
    job VARCHAR(32) NOT NULL,
    mgr INT NULL,
    hiredate DATE NOT NULL,
    sal SMALLINT NOT NULL,
    comm SMALLINT NULL,
    deptno INT NOT NULL,
    CONSTRAINT PK_emp_id PRIMARY KEY (empno),
    CONSTRAINT FK_emp_manager FOREIGN KEY (mgr) REFERENCES emp(empno),
    CONSTRAINT FK_emp_dept_deptno FOREIGN KEY (deptno) REFERENCES dept(deptno)
);
