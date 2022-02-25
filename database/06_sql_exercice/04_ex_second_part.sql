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

/*SELECT e.job, AVG(e.sal) AS average_salary_job FROM emp AS e
    HAVING average_salary_job = MIN(e.sal)
    GROUP BY e.job*/

-- ex19: Sélectionner le département ayant le plus d'employés.

-- ex20: Donner la répartition en pourcentage du nombre d'employés par département
--       selon le modèle ci-dessous :
--
-- Département Répartition en %
-- ----------- ----------------
-- 10 21.43
-- 20 35.71
-- 30 42.86

