-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 9. feladat:
CREATE DATABASE vedettmadarak
DEFAULT CHARACTER SET='UTF8'
COLLATE utf8_hungarian_ci

-- 11. feladat:

UPDATE faj
SET faj.ertek = 25
WHERE faj.id = 352

-- 12. feladat: 
SELECT faj.nev, faj.latin
FROM faj    
ORDER BY faj.nev;

-- 13. feladat:
SELECT faj.nev, faj.evszam, COUNT(faj.id) AS db
FROM faj
WHERE faj.evszam > 2000
GROUP BY faj.evszam
ORDER BY faj.evszam


-- 14. feladat:
SELECT faj.nev AS "faj", csalad.nev AS "csalad", rend.nev AS "rend", (faj.ertek * 1000) AS "eszmei ertek"
FROM faj
JOIN csalad ON faj.csaladid = csalad.id
JOIN rend ON csalad.rendId = rend.id
WHERE faj.ertek > 500;    
 
-- 15. feladat:
SELECT csalad.nev, AVG(faj.ertek) AS "atlag"
FROM csalad
JOIN faj ON csalad.id = faj.csaladid
GROUP BY csalad.nev;
