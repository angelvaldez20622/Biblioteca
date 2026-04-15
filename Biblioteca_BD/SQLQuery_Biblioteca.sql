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
id_categoria int foreign key (id_categoria) references CategoriaLibros
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

insert into Roles (id_rol,nombre) values (1,'Administrador')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (1,'Angel','1234',1, 'no asignado', '6683235367')
insert into Usuarios (id_usuario, nombre,clave, id_rol, correo, telefono) values (2,'Dilan','1234',1, 'no asignado', '6981147670')
