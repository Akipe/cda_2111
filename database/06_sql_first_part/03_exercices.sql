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

SELECT  e.deptno, job, SUM(e.sal) as wage_bill, COUNT(*) as number_employees, AVG(e.sal) as salary_average
    FROM emp AS e
    GROUP BY e.deptno, job
    ORDER BY e.deptno, job
GO;
