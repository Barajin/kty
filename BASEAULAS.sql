CREATE DATABASE ControlAulas
GO
USE ControlAulas
GO

CREATE TABLE AULA(
ClaveAula VARCHAR(10) not null,
Descripcion VARCHAR(20) not null,
Edificio CHAR(1) not null,
Asignada Int not null,
PRIMARY KEY(ClaveAula)
)
CREATE TABLE Maestro(
ClaveMaestro INT IDENTITY not null,
NombreMaestro VARCHAR(20)not null,
FormacionAcademica VARCHAR(20) not null,
Domicilio VARCHAR(50) not null
PRIMARY KEY(ClaveMaestro)
)

CREATE TABLE MATERIA(
NombreMateria VARCHAR(30) not null,
ClaveMaestro INT not null,
ClaveAula VARCHAR(10) not null,
Horario INT not null,
PRIMARY KEY(NombreMateria),
FOREIGN KEY(ClaveMaestro) References Maestro(ClaveMaestro),
FOREIGN KEY(ClaveAula) References Aula(ClaveAula)
)



CREATE PROCEDURE dbo.VerificarAula
  @ClaveAula Varchar(3)
            
 AS   
  
    SELECT * FROM MATERIA
    WHERE ClaveAula = @ClaveAula
	
GO  

Exec dbo.VerificarAula B2


CREATE PROCEDURE dbo.VerificarNombreMaestro
  @NombreMaestro Varchar(30)
            
 AS   
  
    SELECT NombreMaestro FROM Maestro
    WHERE NombreMaestro = @NombreMaestro
	
GO  

Exec dbo.VerificarNombreMaestro 'JUAN'



