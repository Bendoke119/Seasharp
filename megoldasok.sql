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
    
 
-- 15. feladat:

