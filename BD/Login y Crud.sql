CREATE DATABASE LoginCrud;

USE LoginCrud;

CREATE TABLE TablaLogin(
	Id int PRIMARY KEY NOT NULL,
	Contraseña varchar (50),
	Roll varchar (50),
	Nombre varchar (50),
	Correo varchar (50),
	Pais varchar (50),
	Ocupacion varchar (50)
);

INSERT INTO TablaLogin VALUES (100,'Chiripa','Administrador','Ivan','ivan2020@gmai.com','Guatemala','Estudiante');
INSERT INTO TablaLogin VALUES (200,'Nose','Secretario','Jhonatan','jhona20@gmail.com','Guatemala','Estudiante');
INSERT INTO TablaLogin VALUES (300,'NoseA','Usuario','Santizo','a@gmail.com','Guatemala','Estudiante');
SELECT *FROM TablaLogin;