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
    WHERE p.adr = a.loc OR a.avmarq = 'AIRBUS';

-- ex09: Quels sont les noms des pilotes qui conduisent un Airbus
--       sauf ceux qui habitent dans la ville de localisation d'un Airbus ?

SELECT p.pilnom, p.adr FROM pilote AS p

SELECT p.pilnom, p.adr, a.avmarq AS plane_drive FROM pilote AS p
    INNER JOIN vol AS v ON p.pil = v.pil
    INNER JOIN avion AS a ON a.av = v.av
    WHERE
          a.avmarq = 'AIRBUS' AND
          p.adr NOT IN (SELECT av.loc FROM avion AS av WHERE av.avmarq = 'AIRBUS')
    GROUP BY p.pilnom, p.adr, a.avmarq;

-- ex10: Quels sont les vols ayant un trajet identique ( VD, VA )
--       à ceux assurés par Serge ?

WITH serge_villes_vol AS (
    SELECT v.vd, v.va FROM vol AS v INNER JOIN pilote AS p ON v.pil = p.pil WHERE p.pilnom = 'Serge'
)
SELECT v.vol, v.vd, v.va, v.hd, v.ha FROM vol AS v
    WHERE
          v.vd IN (SELECT s.vd FROM serge_villes_vol AS s) AND
          v.va IN (SELECT s.va FROM serge_villes_vol AS s);

-- ex11: Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).

SELECT
        p1.pilnom AS first_pilote,
        p1.adr AS first_pilote_address,
        p2.pilnom AS second_pilote,
        p2.adr AS second_pilote_address
    FROM pilote AS p1
    INNER JOIN pilote AS p2 ON p1.adr = p2.adr
    WHERE p1.pilnom > p2.pilnom;

-- ex12: Quels sont les noms des pilotes qui conduisent
--       un avion que conduit aussi le pilote n°1 ?

SELECT p.pilnom, v.av FROM pilote AS p
    INNER JOIN vol AS v ON p.pil = v.pil
    WHERE v.av IN (SELECT v.av FROM vol AS v WHERE v.pil = 1);

-- ex13: Donner toutes les paires de villes telles qu'un avion localisé
--       dans la ville de départ soit conduit
--       par un pilote résidant dans la ville d'arrivée.

SELECT v.vd AS vol_start, v.va AS vol_end, p.adr AS addr_pilot, a.loc AS addr_plane FROM vol AS v
    INNER JOIN avion AS a ON v.av = a.av
    INNER JOIN pilote AS p ON v.pil = p.pil
    WHERE a.loc = v.vd AND p.adr = v.va;

-- ex014 Sélectionner les numéros des pilotes qui conduisent tous les Airbus ?

SELECT p.pil, p.pilnom, a.avmarq FROM pilote AS p
    INNER JOIN vol AS v ON v.pil = p.pil
    INNER JOIN avion AS a ON v.av = a.av
    WHERE a.avmarq = 'AIRBUS'
    GROUP BY p.pil, p.pilnom, a.avmarq;
