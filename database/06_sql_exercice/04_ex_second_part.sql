-- Exercices second part

USE db_sql_exercice;

-- ex01: Afficher la liste des managers des départements 20 et 30

SELECT e.ename, e.job, e.deptno FROM emp AS e
    WHERE e.deptno IN (20, 30);

-- ex02: Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81

SELECT e.ename, FORMAT(e.hiredate, 'yy'), e.job FROM emp AS e
    WHERE e.job = 'MANAGER' AND FORMAT(e.hiredate, 'yy') = 81;

-- ex03: Afficher la liste des employés ayant une commission

SELECT e.ename, e.comm FROM emp AS e
    WHERE e.comm > 0;

-- ex04: Afficher la liste des noms, numéros de département,
--       jobs et date d'embauche triés par Numero de
--       Département et JOB les derniers embauches d'abord.

SELECT e.ename, e.deptno, e.job, e.hiredate FROM emp AS e
    ORDER BY e.deptno, e.hiredate DESC;

-- ex05: Afficher la liste des employés travaillant à DALLAS

SELECT e.ename, d.dname, d.loc FROM emp AS e
    INNER JOIN dept AS d
    ON e.deptno = d.deptno
    WHERE d.loc = 'DALLAS';

-- ex06: Afficher les noms et dates d'embauche des employés embauchés avant leur manager,
--       avec le nom et date d'embauche du manager.

SELECT e.ename, e.hiredate, e.job, m.ename, m.hiredate, m.job FROM emp AS e
    INNER JOIN emp AS m
    ON e.mgr = m.empno
    WHERE e.hiredate < m.hiredate;

-- ex07: Lister les numéros des employés n'ayant pas de subordonné.

SELECT e.ename FROM emp AS subordonate
    RIGHT JOIN emp AS e
    ON e.empno = subordonate.mgr
    WHERE subordonate.empno IS NULL;

-- ex08: Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.

SELECT e.ename, e.hiredate FROM emp AS e
    WHERE e.hiredate < (SELECT blake.hiredate FROM emp AS blake WHERE blake.ename = 'BLAKE');

-- ex09: Afficher les employés embauchés le même jour que FORD.

SELECT e.ename, e.hiredate FROM emp AS e
    WHERE e.hiredate = (SELECT ford.hiredate FROM emp AS ford WHERE ford.ename = 'FORD') AND
    e.ename != 'FORD';

-- ex10: Lister les employés ayant le même manager que CLARK.

SELECT e.ename, e.mgr FROM emp AS e
    WHERE e.mgr = (SELECT clark.mgr FROM emp AS clark WHERE clark.ename = 'CLARK') AND
    e.ename != 'CLARK';

SELECT e.ename, e.mgr FROM emp AS e
    LEFT JOIN emp AS e2 ON e2.mgr = e.mgr
    WHERE e2.ename = 'CLARK';

-- ex11: Lister les employés ayant même job et même manager que TURNER.

SELECT e.ename, e.job, e.mgr FROM emp AS e
    WHERE
        e.job = (SELECT job FROM emp WHERE ename = 'TURNER') AND
        e.mgr = (SELECT mgr FROM emp WHERE ename = 'TURNER');

-- ex12: Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du
--       département SALES.

SELECT e1.ename, e1.hiredate, d1.dname FROM emp AS e1
    INNER JOIN dept AS d1 ON e1.deptno = d1.deptno
    INNER JOIN emp AS e2 ON e1.hiredate = e2.hiredate
    INNER JOIN dept AS d2 ON e2.deptno = d2.deptno
    WHERE d1.dname = 'RESEARCH' AND d2.dname = 'SALES';

-- ex13: Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date
--       d'embauche.

SELECT e.ename, FORMAT(e.hiredate, 'dddd', 'FR-fr') AS name_day_hire FROM emp AS e;

-- ex14: Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche
--       et la date actuelle.

SELECT e.ename, DATEDIFF(month, e.hiredate, GETDATE()) FROM emp AS e;

-- ex15: Afficher la liste des employés ayant un M et un A dans leur nom.

SELECT e.ename FROM emp AS e
    WHERE e.ename LIKE '%M%' AND e.ename LIKE '%A%';

-- ex16: Afficher la liste des employés ayant deux 'A' dans leur nom.

SELECT e.ename FROM emp AS e
    WHERE e.ename LIKE '%A%A%';

-- ex17: Afficher les employés embauchés avant tous les employés du département 10.

SELECT e1.ename, e1.hiredate, e1.deptno FROM emp AS e1
    WHERE e1.hiredate < (SELECT MIN(edep10.hiredate) FROM emp AS edep10 WHERE edep10.deptno = 10);

-- ex18: Sélectionner le métier où le salaire moyen est le plus faible.

-- List jobs with average salary
SELECT e1.job, AVG(e1.sal) FROM emp AS e1
    GROUP BY e1.job;

-- The smallest average salary from all jobs
SELECT MIN(average_sal_job.salary) FROM
    (SELECT AVG(e2.sal) AS salary FROM emp AS e2 GROUP BY e2.job)
    AS average_sal_job;

-- The job with the smallest average salary
WITH jobs_avg_salary AS (
    SELECT employe.job as name, AVG(employe.sal) AS salary
    FROM emp AS employe
    GROUP BY employe.job
), job_lowest_salary AS (
    SELECT MIN(jobs.salary) AS salary
    FROM jobs_avg_salary AS jobs
)
SELECT jobs_avg_salary.name, jobs_avg_salary.salary FROM jobs_avg_salary
    INNER JOIN job_lowest_salary
    ON jobs_avg_salary.salary = job_lowest_salary.salary;

-- ex19: Sélectionner le département ayant le plus d'employés.

WITH departments_employees AS (
    SELECT d.dname AS name, COUNT(d.dname) AS number FROM dept AS d
    INNER JOIN emp AS e
    ON d.deptno = e.deptno
    GROUP BY d.dname
), departments_employees_biggest AS (
    SELECT MAX(departments_employees.number) AS number FROM departments_employees
)
SELECT departments_employees.name, departments_employees.number FROM departments_employees
    INNER JOIN departments_employees_biggest
    ON departments_employees.number = departments_employees_biggest.number;

-- ex20: Donner la répartition en pourcentage du nombre d'employés par département
--       selon le modèle ci-dessous :
--
-- Département Répartition en %
-- ----------- ----------------
-- 10 21.43
-- 20 35.71
-- 30 42.86

WITH departement_employees AS ( -- on récupére de nombre d'employé par département
    SELECT d.deptno as id, COUNT(d.deptno) as number FROM dept AS d
    INNER JOIN emp AS e
    ON d.deptno = e.deptno
    GROUP BY d.deptno
), employees_total AS ( -- on récupére le nombre total d'employé
    SELECT COUNT(*) as max FROM emp AS e
)
    SELECT
        de.id AS department_id,
        ROUND((CAST(de.number AS FLOAT) / CAST(et.max AS FLOAT) * 100), 2) AS number_employees
    FROM departement_employees AS de, employees_total AS et
