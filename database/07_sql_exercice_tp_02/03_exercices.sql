-- Exercices

USE db_sql_tp_02;

-- ex01: Quels sont les vols au départ de Paris entre 12h et 14h ?

SELECT v.hd FROM vol AS v
    WHERE v.hd >= 12 AND v.hd <= 14 AND v.vd = 'PARIS';

-- ex02: Quels sont les pilotes dont le nom commence par "S" ?

SELECT p.pilnom FROM pilote AS p
    WHERE p.pilnom LIKE 'S%';

-- ex03: Pour chaque ville, donner le nombre et les capacités minimum
--       et maximum des avions qui s'y trouvent.

SELECT
       loc AS location,
       COUNT(a.loc) AS number_planes,
       MIN(a.cap) AS minimal_capacity,
       MAX(a.cap) AS maximal_capacity
    FROM avion AS a
    GROUP BY loc;

-- ex04: Pour chaque ville, donner la capacité moyenne des avions
--       qui s'y trouvent et cela par type d'avion.

SELECT a.avtype, AVG(a.cap) AS average_capacity FROM avion AS a
    GROUP BY a.avtype;

-- ex05: Quelle est la capacité moyenne des avions
--       pour chaque ville ayant plus de 1 avion ?

SELECT a.loc, AVG(a.cap) AS average_capacity FROM avion AS a
    GROUP BY a.loc
    HAVING COUNT(a.loc) > 1;

-- ex06: Quels sont les noms des pilotes qui habitent
--       dans la ville de localisation d'un Airbus

SELECT p.pilnom, a.avmarq, p.adr FROM pilote AS p
    INNER JOIN avion AS a ON p.adr = a.loc
    WHERE a.avmarq = 'AIRBUS';

-- ex07: Quels sont les noms des pilotes qui conduisent
--       un Airbus et qui habitent dans la ville de localisation d'un Airbus ?

SELECT p.pilnom, a.avmarq, a.loc FROM pilote AS p
    INNER JOIN vol AS v ON p.pil = v.pil
    INNER JOIN avion AS a ON v.av = a.av
    WHERE a.avmarq = 'AIRBUS' AND p.adr = a.loc;

-- ex08: Quels sont les noms des pilotes qui conduisent un Airbus
--       ou qui habitent dans la ville de localisation d'un Airbus ?

SELECT p.pilnom, a.avmarq, p.adr FROM pilote AS p
    INNER JOIN vol AS v ON v.pil = p.pil
    INNER JOIN avion AS a ON v.av = a.av
    WHERE (p.adr = a.loc AND a.avmarq = 'AIRBUS')
WHERE v.avmarq = 'AIRBUS' OR

-- ex09: Quels sont les noms des pilotes qui conduisent un Airbus
--       sauf ceux qui habitent dans la ville de localisation d'un Airbus ?
-- ex10: Quels sont les vols ayant un trajet identique ( VD, VA )
--       à ceux assurés par Serge ?
-- ex11: Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).
-- ex12: Quels sont les noms des pilotes qui conduisent
--       un avion que conduit aussi le pilote n°1 ?
-- ex13: Donner toutes les paires de villes telles qu'un avion localisé
--       dans la ville de départ soit conduit
--       par un pilote résidant dans la ville d'arrivée.
-- ex014 Sélectionner les numéros des pilotes qui conduisent tous les Airbus ?