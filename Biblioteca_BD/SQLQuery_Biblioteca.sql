create table CategoriaLibros(
id_categoria int primary key,
nombre varchar(100)
)

create table Roles(
id_rol int primary key,
nombre varchar(100)
)

create table Autores(
id_autor int primary key,
nombre varchar(100)
)

create table Libros(
id_libro int primary key,
nombre varchar(100) not null,
id_autor int foreign key (id_autor) references Autores,
año int not null,
id_categoria int foreign key (id_categoria) references CategoriaLibros,
existencias int,
)

--drop table Usuarios
create table Usuarios(
id_usuario int primary key,
nombre varchar(100) not null,
clave varchar(100) not null,
id_rol int foreign key (id_rol) references Roles,
correo varchar(100) not null,
telefono varchar(100) not null
)

--drop table Prestamos
create table Prestamos(
id_prestamo int primary key,
id_usuario int foreign key (id_usuario) references Usuarios,
id_cliente int foreign key (id_cliente) references Usuarios,
fecha_inicio datetime not null,
fecha_inicio2 as convert(char(8),fecha_inicio,112),
fecha_termino datetime not null,
fecha_termino2 as convert(char(8),fecha_termino,112),
id_libro int foreign key (id_libro) references Libros,
devuelto varchar(3)
)

----------------------------------------------inserts----------------------------------------------------------
insert into Roles (id_rol,nombre) values (1,'Administrador')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (1,'Angel','1234',1, 'no asignado', '6683235367')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (2,'Dilan','1234',1, 'no asignado', '6981147670')

INSERT INTO Roles (id_rol, nombre)
VALUES 
    (2, 'Cliente'),
    (3, 'Empleado');

-- 5 Empleados (id_rol = 2)
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (3, 'Laura', 'emp123', 2, 'no asignado', '6681001122');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (4, 'Roberto', 'emp123', 2, 'no asignado', '6681334455');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (5, 'Sofia', 'emp123', 2, 'no asignado', '6681667788');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (6, 'Carlos', 'emp123', 2, 'no asignado', '6681990011');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (7, 'Elena', 'emp123', 2, 'no asignado', '6682223344');

-- 23 Clientes adicionales (id_rol = 3)
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (8, 'Ricardo', '1234', 3, 'no asignado', '6682556677');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (9, 'Patricia', '1234', 3, 'no asignado', '6682889900');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (10, 'Fernando', '1234', 3, 'no asignado', '6683112233');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (11, 'Monica', '1234', 3, 'no asignado', '6683445566');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (12, 'Diego', '1234', 3, 'no asignado', '6683778899');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (13, 'Gabriela', '1234', 3, 'no asignado', '6684001122');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (14, 'Hugo', '1234', 3, 'no asignado', '6684334455');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (15, 'Isabel', '1234', 3, 'no asignado', '6684667788');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (16, 'Julian', '1234', 3, 'no asignado', '6684990011');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (17, 'Karina', '1234', 3, 'no asignado', '6685223344');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (18, 'Luis', '1234', 3, 'no asignado', '6685556677');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (19, 'Mariana', '1234', 3, 'no asignado', '6685889900');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (20, 'Natalia', '1234', 3, 'no asignado', '6686112233');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (21, 'Oscar', '1234', 3, 'no asignado', '6686445566');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (22, 'Paola', '1234', 3, 'no asignado', '6686778899');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (23, 'Quentin', '1234', 3, 'no asignado', '6687001122');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (24, 'Rosa', '1234', 3, 'no asignado', '6687334455');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (25, 'Sergio', '1234', 3, 'no asignado', '6687667788');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (26, 'Teresa', '1234', 3, 'no asignado', '6687990011');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (27, 'Ulises', '1234', 3, 'no asignado', '6688223344');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (28, 'Valeria', '1234', 3, 'no asignado', '6688556677');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (29, 'Walter', '1234', 3, 'no asignado', '6688889900');
INSERT INTO Usuarios (id_usuario, nombre, clave, id_rol, correo, telefono) VALUES (30, 'Ximena', '1234', 3, 'no asignado', '6689112233');

    INSERT INTO CategoriaLibros (id_categoria, nombre)
VALUES 
    (1, 'Ficción'),
    (2, 'Ciencia Ficción'),
    (3, 'Historia'),
    (4, 'Biografías'),
    (5, 'Terror');

INSERT INTO Autores (id_autor, nombre)
VALUES 
    (1, 'Miguel de Cervantes'),
    (2, 'Gabriel García Márquez'),
    (3, 'Isaac Asimov'),
    (4, 'Stephen Hawking'),
    (5, 'Ana Frank'),
    (6, 'Stephen King'); 

INSERT INTO Libros (id_libro, nombre, id_autor, año, id_categoria, existencias)
VALUES 
    (1, 'El Quijote', 1, 1605, 1, 15),
    (2, 'Cien años de soledad', 2, 1967, 1, 20),
    (3, 'Fundación', 3, 1951, 2, 8),
    (4, 'Breve historia del tiempo', 4, 1988, 3, 12),
    (5, 'El diario de Ana Frank', 5, 1947, 4, 30),
    (6, 'It', 6, 1986, 5, 5),
    (7, 'Crónica de una muerte anunciada', 2, 1981, 1, 10),
    (8, 'Libro Antiguo Descatalogado', 1, 1850, 3, 0),
    (9, 'Proyecto Abandonado', 3, 2010, 2, 0),
    (10, 'Edición Agotada', 4, 1995, 4, 0);

INSERT INTO Prestamos (id_prestamo, id_usuario, id_cliente, fecha_inicio, fecha_termino, id_libro, devuelto)
VALUES 
    (1, 1, 2, '2026-03-01', '2026-03-08', 1, 'si'),
    (2, 1, 3, '2026-03-02', '2026-03-09', 2, 'si'),
    (3, 1, 4, '2026-03-03', '2026-03-10', 3, 'si'),
    (4, 1, 5, '2026-03-04', '2026-03-11', 4, 'si'),
    (5, 1, 6, '2026-03-05', '2026-03-12', 5, 'si'),
    (6, 1, 2, '2026-03-06', '2026-03-13', 6, 'si'),
    (7, 1, 3, '2026-03-07', '2026-03-14', 7, 'si'),
    (8, 1, 4, '2026-03-08', '2026-03-15', 8, 'si'),
    (9, 1, 5, '2026-03-09', '2026-03-16', 9, 'si'),
    (10, 1, 6, '2026-03-10', '2026-03-17', 10, 'si'),
    (11, 1, 2, '2026-03-11', '2026-03-18', 1, 'si'),
    (12, 1, 3, '2026-03-12', '2026-03-19', 2, 'si'),
    (13, 1, 4, '2026-03-13', '2026-03-20', 3, 'si'),
    (14, 1, 5, '2026-03-14', '2026-03-21', 4, 'si'),
    (15, 1, 6, '2026-03-15', '2026-03-22', 5, 'si'),
    (16, 1, 2, '2026-04-01', '2026-04-08', 6, 'no'),
    (17, 1, 3, '2026-04-02', '2026-04-09', 7, 'no'),
    (18, 1, 4, '2026-04-03', '2026-04-10', 8, 'no'),
    (19, 1, 5, '2026-04-04', '2026-04-11', 9, 'no'),
    (20, 1, 6, '2026-04-05', '2026-04-12', 10, 'no'),
    (21, 1, 2, '2026-04-10', '2026-04-17', 1, 'no'),
    (22, 1, 3, '2026-04-11', '2026-04-18', 2, 'no'),
    (23, 1, 4, '2026-04-12', '2026-04-19', 3, 'no'),
    (24, 1, 5, '2026-04-13', '2026-04-20', 4, 'no'),
    (25, 1, 6, '2026-04-14', '2026-04-21', 5, 'no'),
    (26, 1, 2, '2026-04-15', '2026-04-22', 6, 'no'),
    (27, 1, 3, '2026-04-16', '2026-04-23', 7, 'no'),
    (28, 1, 4, '2026-04-17', '2026-04-24', 8, 'no'),
    (29, 1, 5, '2026-04-18', '2026-04-25', 9, 'no'),
    (30, 1, 6, '2026-04-19', '2026-04-26', 10, 'no');
--------------------------------------------vistas------------------------------------------------------------
CREATE VIEW v_BuscadorPrestamos AS
SELECT 
    P.id_prestamo AS [Clave],U_Emp.nombre AS [Atendido Por],U_Cli.nombre AS [Cliente], P.fecha_inicio AS [Fecha Inicio],P.fecha_termino AS [Fecha Término],L.nombre AS [Libro],P.devuelto AS [Devuelto]
FROM Prestamos P JOIN Usuarios U_Emp ON P.id_usuario = U_Emp.id_usuario JOIN Usuarios U_Cli ON P.id_cliente = U_Cli.id_usuario JOIN Libros L ON P.id_libro = L.id_libro;             
-----------------------------------------consultas------------------------------------------------------------
select * from Roles
select top 10 * from Roles
select top 1 * from Usuarios order by id_usuario desc
select * from Usuarios
SELECT TOP 10 id_categoria FROM CategoriaLibros ORDER BY id_categoria DESc
select * from CategoriaLibros
select * from Autores
select * from Libros
select * from Libros where nombre like '%p%'
select * from Prestamos
SELECT U.id_usuario,U.nombre,U.clave,R.nombre AS [Rol],U.correo,U.telefono FROM Usuarios U JOIN Roles R ON U.id_rol = R.id_rol;
SELECT L.id_libro AS [ID Libro],L.nombre AS [Título],A.nombre AS [Autor], L.año AS [Año],C.nombre AS [Categoría],L.existencias AS [Existencias] FROM Libros L JOIN Autores A ON L.id_autor = A.id_autor JOIN CategoriaLibros C ON L.id_categoria = C.id_categoria;
-----------------------------------procedimiento almacenados--------------------------------------------------
CREATE PROCEDURE sp_RegistrarPrestamo
    @id_prestamo INT,
    @id_usuario INT,
    @id_cliente INT,
    @fecha_inicio DATETIME,
    @fecha_termino DATETIME,
    @id_libro INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Validar si hay existencias del libro
    IF (SELECT existencias FROM Libros WHERE id_libro = @id_libro) > 0
    BEGIN
        -- 2. Insertar el préstamo (la columna devuelto se pone en 'no' por defecto)
        INSERT INTO Prestamos (id_prestamo, id_usuario, id_cliente, fecha_inicio, fecha_termino, id_libro, devuelto)
        VALUES (@id_prestamo, @id_usuario, @id_cliente, @fecha_inicio, @fecha_termino, @id_libro, 'no');

        -- 3. Restar 1 a las existencias del libro
        UPDATE Libros
        SET existencias = existencias - 1
        WHERE id_libro = @id_libro;

        PRINT 'Préstamo registrado con éxito y stock actualizado.';
    END
    ELSE
    BEGIN
        -- Si no hay existencias, lanza un mensaje de error
        RAISERROR('No hay existencias disponibles para este libro.', 16, 1);
    END
END;

CREATE PROCEDURE sp_RegistrarDevolucion
    @id_prestamo INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar primero si el préstamo existe y no ha sido devuelto ya
    IF EXISTS (SELECT 1 FROM Prestamos WHERE id_prestamo = @id_prestamo AND devuelto = 'no')
    BEGIN
        -- 1. Declarar variable para saber qué libro se está devolviendo
        DECLARE @id_libro INT;
        SELECT @id_libro = id_libro FROM Prestamos WHERE id_prestamo = @id_prestamo;

        -- 2. Actualizar el estado del préstamo
        UPDATE Prestamos
        SET devuelto = 'si'
        WHERE id_prestamo = @id_prestamo;

        -- 3. Sumar 1 a las existencias del libro regresado
        UPDATE Libros
        SET existencias = existencias + 1
        WHERE id_libro = @id_libro;

        PRINT 'Devolución procesada correctamente y stock recuperado.';
    END
    ELSE
    BEGIN
        RAISERROR('El préstamo no existe o ya fue devuelto anteriormente.', 16, 1);
    END
END;

CREATE PROCEDURE sp_AltaLibroNuevo
    @id_libro INT,
    @nombre VARCHAR(100),
    @id_autor INT,
    @año INT,
    @id_categoria INT,
    @existencias INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Validar si el ID del libro ya está registrado
    IF EXISTS (SELECT 1 FROM Libros WHERE id_libro = @id_libro)
    BEGIN
        RAISERROR('El ID de libro ya existe. Elige un código diferente.', 16, 1);
        RETURN;
    END

    -- 2. Validar si el Autor realmente existe en la tabla Autores
    IF NOT EXISTS (SELECT 1 FROM Autores WHERE id_autor = @id_autor)
    BEGIN
        RAISERROR('El ID de Autor especificado no existe. Regístralo primero.', 16, 1);
        RETURN;
    END

    -- 3. Validar si la Categoría realmente existe
    IF NOT EXISTS (SELECT 1 FROM CategoriaLibros WHERE id_categoria = @id_categoria)
    BEGIN
        RAISERROR('El ID de Categoría especificado no existe.', 16, 1);
        RETURN;
    END

    -- 4. Si todo está bien, se realiza la inserción segura
    INSERT INTO Libros (id_libro, nombre, id_autor, año, id_categoria, existencias)
    VALUES (@id_libro, @nombre, @id_autor, @año, @id_categoria, @existencias);

    PRINT 'Libro registrado con éxito en el inventario.';
END;