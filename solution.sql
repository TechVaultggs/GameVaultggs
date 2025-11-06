-- a) Filtrar los campos nombres, agencia, categoría y salario de la tabla Persona,
-- provenientes de una categoría específica y ordenados alfabéticamente.
SELECT nombres, agencia, categoria, salario
FROM Persona
WHERE categoria = 'Profesional' -- Reemplace 'Profesional' con la categoría que desea filtrar
ORDER BY nombres ASC;

-- b) Mostrar las instituciones de una especialidad específica, ordenados por
-- pais y nombre.
SELECT *
FROM Institucion
WHERE especialidad = 'Ciencias de la Computación' -- Reemplace 'Ciencias de la Computación' con la especialidad que desea filtrar
ORDER BY pais ASC, nombre ASC;

-- c) Mostrar los empleados provenientes de una categoria y agencia especifica.
SELECT *
FROM Persona
WHERE categoria = 'Auxiliar' -- Reemplace 'Auxiliar' con la categoría que desea filtrar
  AND agencia = 'UNC'; -- Reemplace 'UNC' con la agencia que desea filtrar

-- d) Mostrar salario promedio de empleados agrupados por ciudad y ordenado por
-- Nombres.
-- Nota: Ordenar por 'Nombres' en una consulta agregada puede no ser ideal,
-- ya que 'Nombres' no está en la cláusula GROUP BY.
-- Ordenaremos por 'ciudad' en su lugar, que es más estándar.
SELECT ciudad, AVG(salario) AS salario_promedio
FROM Persona
GROUP BY ciudad
ORDER BY ciudad;

-- e) Mostrar los empleados registrados para la unión de ambas tablas, de un
-- país específico.
SELECT P.*
FROM Persona P
JOIN Institucion I ON P.agencia = I.sigla
WHERE I.pais = 'Chile'; -- Reemplace 'Chile' con el país que desea filtrar
