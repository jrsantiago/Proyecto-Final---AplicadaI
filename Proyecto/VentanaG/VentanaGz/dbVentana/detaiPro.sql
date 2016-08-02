create table Usuario
( 
  idUsuario int primary key identity(1,1),
  userName varchar(30),
  contrasena varchar(35) ,
  nombre varchar(35),
  apellido varchar(40),
  sexo varchar(2) 
);
go

create table Cliente(
idCliente int primary key identity,
nombre varchar(60),
telefono varchar(15),
cedula varchar(14),
Direccion varchar(50),
Email varchar(40),
);
go

create table ventanaAluminio(
idAlumi int primary key identity(1,1),
idCliente int references Cliente(idCliente),
ancho float,
altura float,
tipoMaterial varchar(7),
color varchar(10),
precio float,
Total float,
fecha datetime
);
go


create table FabricarVentanaAluminio(
id int primary key identity,
idAlumi int references ventanaAluminio(idAlumi),

balancin float,
operadores int,
masilla int,
pieCabezal float,
pieAlfecia float,
pieJamba float,
pieCelocia float,

--......Accesorios.............
tornillosUna int,
tornillosMedia int,
tarugos int,
fundaRemaches int,
precio float,
precioPieCuadrado float
);
go

create table Screen(
idScreen int primary key identity,
idCliente int references Cliente(idCliente),
ancho float,
altura float,
precio float,
total float,
fecha datetime
);
go
create table FabricarScreen(
id int primary key identity,
idScreen int references Screen(idScreen),
MorduraScreemPie float,
orejitas int,
Lscreem int,
sogaLibra float,

yardasTela float,
tornillos int,
Precio float,
precioPieCuadrado float --Este es A cuanto se esta vendiendo el pie
);
go 
create table Materiales(
idMateriale int primary key identity,
Descripcion varchar(110),
unidad int,
CantidadPie float,
precio float
);

go
create table Proyecto(
id int primary key identity,
idCliente int references Cliente(idCliente),
idAlumi int references ventanaAluminio(idAlumi)
);