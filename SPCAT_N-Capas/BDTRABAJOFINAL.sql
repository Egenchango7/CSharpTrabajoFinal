USE master

DROP DATABASE IF EXISTS BDTRABAJOFINAL;
CREATE DATABASE BDTRABAJOFINAL;
GO
USE BDTRABAJOFINAL
/*
CREATE TABLE Nivel (
codigo CHAR(15) PRIMARY KEY NOT NULL,
dniTrabajador CHAR(8),
anno CHAR(4),
numNivel INT
sueldoBasico FLOAT
FOREIGN KEY (dniTrabajador) REFERENCES Trabajador(dni)
)
*/
CREATE TABLE Nivel (
numNivel INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
sueldoBasico FLOAT
)
CREATE TABLE Trabajador(
dni CHAR(8) PRIMARY KEY NOT NULL,
nombre VARCHAR(100),
cargo VARCHAR(100),
numNivel INT,
nomUsuario VARCHAR(100),
contrasena VARCHAR(100)
FOREIGN KEY(numNivel) REFERENCES Nivel(numNivel)
)
CREATE TABLE Horario(
codigo CHAR(15) PRIMARY KEY NOT NULL,
dniTrabajador CHAR(8),
annoMes CHAR(7), 
hrEntrada TIME,
hrSalida TIME
FOREIGN KEY (dniTrabajador) REFERENCES Trabajador(dni)
)
CREATE TABLE Registro(
codigo CHAR(17) PRIMARY KEY NOT NULL,
dniTrabajador CHAR(8),
fechaRegistro DATE,
hrEntradaReg TIME,
hrSalidaReg TIME,
refrigObtenido BIT,
minutosTardanzas INT,
minutosAnticipadas INT
FOREIGN KEY (dniTrabajador) REFERENCES Trabajador(dni)
)
CREATE TABLE Boleta(
codigo CHAR(17) PRIMARY KEY NOT NULL,
codRegistro CHAR(17),
fechaEmision DATE
FOREIGN KEY (codRegistro) REFERENCES Registro(codigo)
)

INSERT INTO Nivel(sueldoBasico) VALUES (0)
INSERT INTO Nivel(sueldoBasico) VALUES (2500)
INSERT INTO Nivel(sueldoBasico) VALUES (2000)
INSERT INTO Nivel(sueldoBasico) VALUES (1500)

INSERT INTO Trabajador VALUES ('79625989','Esteban Chaname','Jefe RRHH',0,'admin','12345')
INSERT INTO Trabajador VALUES ('72411624','Roger Flores', 'Jefe RRHH',0,'admin2', '12345')
INSERT INTO Trabajador VALUES ('74382895','Seminario Jauregui Jorge','Jefe RRHH',0,'admin3','12345')
INSERT INTO Trabajador VALUES ('35724869','Daniel Acevedo Jhong','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('89108120','Miguel Vicente Agurto Rondoy','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('10831715','Christian Nelson Alcalá Negrón','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('14822598','Raul Eduardo Almora Hernandez','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('57016327','Jorge Alosilla Velazco Vera','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('38977534','Victor Alva Campos','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('12405696','Javier Arevalo Lopez','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('96868681','Rosario Arias Hernandez','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('41531274','Efraín Arroyo Ramírez','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('32506347','Marco Tulio Alocen Barrera','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('73204541','Cesar Baiocchi Ureta','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('99711950','Isela Flor Baylón Rojas','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('53656826','Leoncia Bedoya Castillo','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('75589160','Luz Marina Bedregal Canales','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('49056165','Ramiro Alberto Bejar Torres','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('24745465','Javier Benavides Espejo','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('41085981','Nelson Boza Solis','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('10231242','Cielito Mercedes Calle Betancourt','Obrero',3,'','')
INSERT INTO Trabajador VALUES ('81945669','Isabel Florisa Caraza Villegas','Obrero',2,'','')
INSERT INTO Trabajador VALUES ('73698419','Gizella Carrera Abanto','Obrero',1,'','')
INSERT INTO Trabajador VALUES ('12345678','Trabajador Prueba','Obrero',1,'','')

SELECT * FROM Trabajador

GO
Create Proc EstablecerHorario
@dni varchar(8),
@HorE time,
@HorS time,
@AnnoMes varchar(7)
AS
BEGIN
Declare @AM varchar(4) = CONCAT(substring(@AnnoMes,6,2),substring(@AnnoMes,3,2))
Declare @Cod varchar(15) = CONCAT('HR',@dni,'-',@AM)
INSERT INTO Horario values (@Cod, @dni, @AnnoMes, @HorE, @HorS)
END
GO
/*
execute EstablecerHorario '72411624', '07:00', '15:00', '2020-08'
execute EstablecerHorario '79625989', '07:00', '15:00', '2020-08'
execute EstablecerHorario '74382895', '07:00', '15:00', '2020-08'
*/

execute EstablecerHorario '81945669', '07:00', '15:00', '2020-08'
execute EstablecerHorario '73698419', '07:00', '15:00', '2020-08'
execute EstablecerHorario '12345678', '07:00', '15:00', '2020-08'
execute EstablecerHorario '35724869', '07:00', '15:00', '2020-08'
execute EstablecerHorario '89108120', '07:00', '15:00', '2020-08'
execute EstablecerHorario '10831715', '07:00', '15:00', '2020-08'
execute EstablecerHorario '14822598', '07:00', '15:00', '2020-08'
execute EstablecerHorario '57016327', '07:00', '15:00', '2020-08'
execute EstablecerHorario '38977534', '07:00', '15:00', '2020-08'
execute EstablecerHorario '12405696', '07:00', '15:00', '2020-08'
execute EstablecerHorario '96868681', '15:00', '23:00', '2020-08'
execute EstablecerHorario '41531274', '15:00', '23:00', '2020-08'
execute EstablecerHorario '32506347', '15:00', '23:00', '2020-08'
execute EstablecerHorario '73204541', '15:00', '23:00', '2020-08'
execute EstablecerHorario '99711950', '15:00', '23:00', '2020-08'
execute EstablecerHorario '53656826', '15:00', '23:00', '2020-08'
execute EstablecerHorario '75589160', '15:00', '23:00', '2020-08'
execute EstablecerHorario '49056165', '15:00', '23:00', '2020-08'
execute EstablecerHorario '24745465', '15:00', '23:00', '2020-08'
execute EstablecerHorario '41085981', '15:00', '23:00', '2020-08'
execute EstablecerHorario '10231242', '15:00', '23:00', '2020-08'

SELECT * FROM Horario
--SELECT * FROM Registro
GO

CREATE PROC HorarioByDniAnnoMes
@dni CHAR(8),
@annoMes CHAR(7)
AS
BEGIN
SELECT codigo, annoMes, hrEntrada, hrSalida FROM Horario INNER JOIN Trabajador ON Horario.dniTrabajador = Trabajador.dni WHERE dni = @dni AND annoMes = @annoMes
END
GO
--EXEC HorarioByDniAnnoMes '12345678', '2020-09'
CREATE PROC ListaTrabajador
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND h.annoMes = @annoMes
END
GO
--EXEC ListaTrabajador '2020-09'
GO
CREATE PROC TrabajadorByDni
@dni VARCHAR(8),
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND t.dni LIKE '%'+@dni+'%' AND h.annoMes = @annoMes
END
GO
--EXEC TrabajadorByDni '1234567','2020-08'
CREATE PROC TrabajadorByNombre
@nombre VARCHAR(100),
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND t.nombre LIKE '%'+@nombre+'%' AND h.annoMes = @annoMes
END
GO
--EXEC TrabajadorByNombre 'Trabajador Prueb'
CREATE PROC TrabajadorByNivel
@nivel int,
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND t.numNivel = @nivel AND h.annoMes = @annoMes
END
GO
--EXEC TrabajadorByNivel 1
CREATE PROC TrabajadorByEntrada
@hr TIME,
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND h.hrEntrada = @hr AND h.annoMes = @annoMes
END
GO
--EXEC TrabajadorByEntrada '08:00'
CREATE PROC TrabajadorBySalida
@hr TIME,
@annoMes CHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA, t.numNivel AS NIVEL, n.sueldoBasico AS SUELDO FROM Trabajador t 
INNER JOIN Nivel n ON t.numNivel = n.numNivel 
INNER JOIN Horario h ON t.dni = h.dniTrabajador
WHERE t.cargo = 'Obrero' AND h.hrSalida = @hr AND h.annoMes = @annoMes
END
GO
--EXEC TrabajadorBySalida '16:00'
CREATE PROC PlanillaMes
@annoMes VARCHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA,
--SUM(r.minutosTardanzas) AS TotalTardanzas, 
COUNT(CASE WHEN r.minutosTardanzas > 0 THEN 1 END) as TARDANZAS,
--SUM(r.minutosAnticipadas) as TotalAnticipadas, 
COUNT(CASE WHEN r.minutosAnticipadas > 0 THEN 1 END) as 'SALIDAS ANTICIPADAS',
n.sueldoBasico AS 'SUELDO BÁSICO', (n.sueldoBasico / 100 * COUNT(CASE WHEN r.refrigObtenido = 1 THEN r.refrigObtenido END)) as REFRIGERIO,
ROUND((n.sueldoBasico / 60 / 8 / 30 * sum(r.minutosTardanzas + r.minutosAnticipadas)),2)as DESCUENTO
FROM Trabajador t
INNER JOIN Registro r ON r.dniTrabajador = t.dni
INNER JOIN Horario h ON t.dni = h.dniTrabajador
INNER JOIN Nivel n ON t.numNivel = n.numNivel
WHERE MONTH(fechaRegistro) = SUBSTRING(@annoMes,6,2) AND annoMes = @annoMes
GROUP BY t.dni, t.nombre, h.hrEntrada, h.hrSalida, n.sueldoBasico, MONTH(fechaRegistro)
END
GO
--EXEC PlanillaMes '2020-04'

CREATE Procedure MostrarMes
AS
Begin
set language Spanish

Select CONCAT(YEAR(fechaRegistro),'-',(CASE WHEN LEN(MONTH(fechaRegistro)) < 2 THEN '0' END),MONTH(fechaRegistro)) as Numero,
CONCAT(UPPER(DATENAME(MONTH, fechaRegistro)),'-',YEAR(fechaRegistro)) as Nombre from Registro 
group by DATENAME(MONTH, fechaRegistro),MONTH(fechaRegistro),YEAR(fechaRegistro)
ORDER BY Numero
End
Go
--EXEC MostrarMes
CREATE PROC RegistrosByDia
@fecha DATE
AS
BEGIN
SELECT r.dniTrabajador AS DNI, t.nombre AS NOMBRE,
r.hrEntradaReg AS ENTRADA, r.hrSalidaReg AS SALIDA, 
(CASE WHEN r.minutosTardanzas > 0 THEN 'SÍ' ELSE 'NO' END) AS TARDANZA, 
(CASE WHEN r.minutosAnticipadas > 0 THEN 'SÍ' ELSE 'NO' END) AS 'SALIDA ANTICIPADA' 
FROM Registro r
INNER JOIN Trabajador t ON r.dniTrabajador = t.dni
WHERE r.fechaRegistro = @fecha
END
GO
--EXEC RegistrosByDia '2020-08-13'
CREATE PROC RangoMeses
@annoMesInicio VARCHAR(7),
@annoMesFin VARCHAR(7)
AS
BEGIN 
SELECT t.dni AS DNI, t.nombre AS NOMBRE,-- h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA,
COUNT(CASE WHEN r.minutosTardanzas > 0 THEN 1 END) as TARDANZAS,
COUNT(CASE WHEN r.minutosAnticipadas > 0 THEN 1 END) as 'SALIDAS ANTICIPADAS',
(n.sueldoBasico / 100 * COUNT(CASE WHEN r.refrigObtenido = 1 THEN r.refrigObtenido END)) as REFRIGERIO,
ROUND((n.sueldoBasico / 60 / 8 / 30 * SUM(r.minutosTardanzas + r.minutosAnticipadas)),2) as DESCUENTO
FROM Trabajador t
INNER JOIN Registro r ON r.dniTrabajador = t.dni
--INNER JOIN Horario h ON t.dni = h.dniTrabajador
INNER JOIN Nivel n ON t.numNivel = n.numNivel
WHERE MONTH(fechaRegistro) >= CAST(SUBSTRING(@annoMesInicio,6,2) AS INT) AND MONTH(fechaRegistro) <= CAST(SUBSTRING(@annoMesFin,6,2) AS INT) 
AND YEAR(fechaRegistro) >= CAST(SUBSTRING(@annoMesInicio,1,4) AS INT) AND YEAR(fechaRegistro) <= CAST(SUBSTRING(@annoMesFin,1,4) AS INT)
--AND CAST(SUBSTRING(annoMes,6,2) AS INT) >= @mesInicio AND CAST(SUBSTRING(annoMes,6,2) AS INT) <= @mesFin
GROUP BY t.dni, t.nombre,
--h.hrEntrada, h.hrSalida, 
n.sueldoBasico--, MONTH(fechaRegistro)
END
GO
--EXEC RangoMeses '2020-04','2020-06'
CREATE PROC PlanillaAnual
@anno INT
AS
BEGIN 
SELECT t.dni AS DNI, t.nombre AS NOMBRE, n.numNivel AS NIVEL, n.sueldoBasico AS SUELDO,
COUNT(CASE WHEN r.minutosTardanzas > 0 THEN 1 END) as TARDANZAS,
COUNT(CASE WHEN r.minutosAnticipadas > 0 THEN 1 END) as 'SALIDAS ANTICIPADAS',
(n.sueldoBasico / 100 * COUNT(CASE WHEN r.refrigObtenido = 1 THEN r.refrigObtenido END)) as REFRIGERIO,
ROUND((n.sueldoBasico / 60 / 8 / 30 * SUM(r.minutosTardanzas + r.minutosAnticipadas)),2) as DESCUENTO
FROM Trabajador t
INNER JOIN Registro r ON r.dniTrabajador = t.dni
INNER JOIN Nivel n ON t.numNivel = n.numNivel
WHERE YEAR(fechaRegistro) = @anno
GROUP BY t.dni, t.nombre, n.numNivel, n.sueldoBasico--, MONTH(fechaRegistro)
END
GO
--EXEC PlanillaAnual 2020
CREATE PROC RegistroBoleta
@dni CHAR(8),
@annoMes VARCHAR(7)
AS
BEGIN
SELECT t.dni AS DNI, t.nombre AS NOMBRE, h.hrEntrada AS ENTRADA, h.hrSalida AS SALIDA,
--SUM(r.minutosTardanzas) AS TotalTardanzas, 
COUNT(CASE WHEN r.minutosTardanzas > 0 THEN 1 END) as TARDANZAS,
--SUM(r.minutosAnticipadas) as TotalAnticipadas, 
COUNT(CASE WHEN r.minutosAnticipadas > 0 THEN 1 END) as 'SALIDAS ANTICIPADAS',
n.sueldoBasico AS SUELDO, (n.sueldoBasico / 100 * COUNT(CASE WHEN r.refrigObtenido = 1 THEN r.refrigObtenido END)) as REFRIGERIO,
ROUND((n.sueldoBasico / 60 / 8 / 30 * sum(r.minutosTardanzas + r.minutosAnticipadas)),2)as DESCUENTO
FROM Trabajador t
INNER JOIN Registro r ON r.dniTrabajador = t.dni
INNER JOIN Horario h ON t.dni = h.dniTrabajador
INNER JOIN Nivel n ON t.numNivel = n.numNivel
WHERE MONTH(fechaRegistro) = CAST(SUBSTRING(@annoMes,6,2) AS INT) AND annoMes = @annoMes AND t.dni = @dni
GROUP BY t.dni, t.nombre, h.hrEntrada, h.hrSalida, n.sueldoBasico, MONTH(fechaRegistro)
END
GO
--EXEC RegistroBoleta '12345678','2020-07'

CREATE PROC MostrarAnno
AS
BEGIN
SELECT YEAR(fechaRegistro) AS Anno FROM Registro GROUP BY YEAR(fechaRegistro)
END
