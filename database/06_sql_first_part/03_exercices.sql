-- Exercices first part

USE db_sql_ex_part_one;

-- ex01 : Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10

SELECT ename, job, empno, sal
    FROM emp;
GO;

SELECT ename, job, empno, sal
    FROM emp
    WHERE deptno = 10;
GO;

-- ex02 : Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800

SELECT e.ename, e.job, e.sal
    FROM emp AS e
    WHERE e.job = 'MANAGER' AND e.sal > 2800;
GO;

-- ex03 : Donner la liste des MANAGER n'appartenant pas au département 30

SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno
    FROM emp AS e
    WHERE e.job = 'MANAGER' AND e.deptno != 30;
GO;

-- ex04 : Liste des employés de salaire compris entre 1200 et 1400

SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno
    FROM emp AS e
    WHERE e.sal >= 1200 AND e.sal <= 1400;
GO;

-- ex05 : Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique

SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno
    FROM emp AS e
    WHERE e.deptno = 10 OR e.deptno = 30
    ORDER BY e.ename ASC;
GO;

-- ex06 : Liste des employés du département 30 classés dans l'ordre des salaires croissants

SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno
    FROM emp AS e
    WHERE e.deptno = 30
    ORDER BY e.sal ASC;
GO;

-- ex07: Liste de tous les employés classés par emploi et salaires décroissants

SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno
    FROM emp AS e
    ORDER BY e.job ASC, e.sal DESC;
GO;

-- ex08: Liste des différents emplois

SELECT e.job AS uniques_jobs
    FROM emp AS e
    GROUP BY e.job;
GO;

-- ex09: Donner le nom du département où travaille ALLEN

SELECT d.dname as departement_name
    FROM emp as e
    INNER JOIN dept AS d ON e.deptno = d.deptno
    WHERE e.ename = 'ALLEN'
GO;

-- ex10: Liste des employés avec nom du département, nom, job,
--       salaire classés par noms de départements et par salaires décroissants.

SELECT d.dname, e.ename, e.job, e.sal
    FROM emp AS e
    LEFT JOIN dept AS d ON e.deptno = d.deptno
    ORDER BY d.dname ASC, e.sal DESC;
GO;

-- ex11: Liste des employés vendeurs (SALESMAN) avec affichage de
--        nom, salaire, commissions, salaire + commissions

SELECT e.ename, e.sal, e.comm, e.sal + e.comm AS total_revenue
    FROM emp AS e
    WHERE e.job = 'SALESMAN';
GO;

-- ex12: Liste des employés du département 20:
--       nom, job, date d'embauche sous forme VEN 28 FEV 1997'

SELECT e.ename, e.job, UPPER(FORMAT(e.hiredate, 'ddd dd MMM yyyy', 'fr-FR')) AS hire_date
    FROM emp AS e
    WHERE e.deptno = 20;
GO;

-- ex13: Donner le salaire le plus élevé par département

SELECT MAX(e.sal) as maximal_salary
    FROM emp AS e
    GROUP BY e.deptno;
GO;

-- ex14: Donner département par département masse salariale,
--       nombre d'employés, salaire moyen par type d'emploi.

SELECT  e.deptno, e.job, SUM(e.sal) AS wage_bill, COUNT(*) AS number_employees, AVG(e.sal) AS salary_average
    FROM emp AS e
    GROUP BY e.deptno, job
    ORDER BY e.deptno, job
GO;

-- ex15: Même question mais on se limite aux sous-ensembles d'au moins 2 employés

SELECT  e.deptno, e.job, SUM(e.sal) AS wage_bill, COUNT(*) AS number_employees, AVG(e.sal) AS salary_average
    FROM emp AS e
    GROUP BY e.deptno, job
    HAVING COUNT(*) >= 2
    ORDER BY e.deptno, job;
GO;

-- ex16: Liste des employés (Nom, département, salaire) de même emploi que JONES

SELECT e.ename, e.deptno, e.sal FROM emp AS e
    WHERE e.job = (SELECT e.job
    FROM emp AS e
    WHERE e.ename = 'JONES');
GO;

-- ex17: Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires

SELECT e.ename, e.sal FROM emp AS e
    WHERE e.sal > (SELECT AVG(f.sal) FROM emp AS f);
GO;

-- ex18: Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres),
--       nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
--       101, ALPHA, 96000
--       102, BETA, 82000
--       103, GAMMA, 15000

IF OBJECT_ID('projects', 'U') IS NOT NULL
    DROP TABLE projects;
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'projects' AND xtype = 'U')
BEGIN
    CREATE TABLE projects(
        project_number SMALLINT IDENTITY(101, 1),
        project_name CHAR(5) UNIQUE NOT NULL,
        project_budget MONEY NOT NULL,
        CONSTRAINT PK_project_number PRIMARY KEY (project_number)
    );
END
GO;

IF NOT EXISTS (SELECT * FROM projects)
BEGIN
    INSERT INTO projects(project_name, project_budget) VALUES
        ('ALPHA', 96000),
        ('BETA', 82000),
        ('GAMMA', 15000)
    ;
END
GO;

SELECT * FROM projects;
GO;

-- ex19: Ajouter l'attribut numéro de projet à la table EMP
--       et affecter tous les vendeurs du département 30 au projet 101,
--       et les autres au projet 102

ALTER TABLE emp ADD emp_project_number SMALLINT NULL;
GO;
UPDATE emp SET emp_project_number = 101 WHERE job = 'SALESMAN' AND deptno != 30;
GO;
UPDATE emp SET emp_project_number = 102 WHERE emp_project_number IS NULL;
GO;
ALTER TABLE emp ALTER COLUMN emp_project_number SMALLINT NOT NULL;
GO;
ALTER TABLE emp
    ADD CONSTRAINT FK_emp_project_number
    FOREIGN KEY (emp_project_number)
    REFERENCES projects(project_number);
GO;

SELECT * FROM emp;
GO;

-- ex20: Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet

IF OBJECT_ID('employees_resume', 'V') IS NOT NULL
BEGIN
    DROP VIEW employees_resume;
END;
GO;

IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'employees_resume' AND xtype = 'V')
    CREATE VIEW employees_resume AS
        SELECT e.ename AS employe_name, e.job AS employe_job, d.dname AS departement_name, p.project_name FROM emp AS e
        INNER JOIN dept AS d ON e.deptno = d.deptno
        INNER JOIN projects AS p ON e.emp_project_number = p.project_number
    ;
GO;

SELECT * FROM employees_resume;
GO;

-- ex21: A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département
--       et nom de projet triés sur nom de département et nom de projet

SELECT er.employe_name, er.employe_job, er.departement_name, er.project_name FROM employees_resume AS er
    ORDER BY er.departement_name, er.project_name;

-- ex22: Donner le nom du projet associé à chaque manager

SELECT er.employe_name, er.employe_job, er.departement_name, er.project_name FROM employees_resume AS er
    WHERE er.employe_job = 'MANAGER'
    ORDER BY er.departement_name, er.project_name;
