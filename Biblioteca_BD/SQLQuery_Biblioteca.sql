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
id_prestamos int primary key,
id_usuario int foreign key (id_usuario) references Usuarios,
id_cliente int foreign key (id_cliente) references Usuarios,
fecha_inicio varchar(100) not null,
fecha_termino varchar(100) not null,
id_libro int foreign key (id_libro) references Libros
)


----------------------------------------------inserts----------------------------------------------------------
insert into Roles (id_rol,nombre) values (1,'Administrador')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (1,'Angel','1234',1, 'no asignado', '6683235367')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (2,'Dilan','1234',1, 'no asignado', '6981147670')

INSERT INTO Roles (id_rol, nombre)
VALUES 
    (2, 'Cliente'),
    (3, 'Empleado');

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

-----------------------------------------consultas------------------------------------------------------------
select * from Roles
select top 10 * from Roles
select top 1 * from Usuarios order by id_usuario desc
select * from Usuarios
SELECT TOP 10 id_categoria FROM CategoriaLibros ORDER BY id_categoria DESc
select * from CategoriaLibros
select * from Autores
select * from Libros