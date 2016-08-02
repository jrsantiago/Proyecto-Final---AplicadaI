
create table Usuario
( 
  idUsuario int primary key identity(1,1),
  contrasena varchar(35) ,
  userName varchar(30),
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
idAlumi int primary key identity,
idCliente int references Cliente(idCliente),
tipoMaterial varchar(7),
color varchar(10),
ancho float,
altura float,
colores varchar(10),
PrecioPieCuadrado float
);
go


create table FabricarVentanaAluminio(
id int primary key identity,
idVentana int references ventanaAluminio(idAlumi),

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
fundaRemaches int

);

go

create table VentanaCorredisa(
idCorredi int primary key identity,
idCliente int references Cliente(idCliente),

ancho float,
altura float,
color varchar(10),
tipoCristal varchar(12),
TipoMaterial varchar(7),
precioPieCuadrado float
);

go
create table FabricarVentanaCorredisa(

id int primary key identity,
idCorredisa int references VentanaCorredisa(idCorredi),
--accesorios..........
guiaArriba int,
guiaAbajo int,
ruedas  int,
tornillosUna int,
tornillosMedia int,
tarugos int,
cerradura int,
masilla int,
--....Fabricar.................
llavinPie float,
cristalPie float,
cabezalMovilPie float,
lateralPie float,
cabezalPie float,
cristalAltura float,
cristalAncho float,
gomaPie float,
enganchePie float,
alfeciaPie float,
rielPie float

);
go

create table Toldos(
 idToldo int primary key identity,
 idCliente int references Cliente(idCliente), 
 ancho float,
 salida float,
 color varchar(30),
 );

 go
 create table FabricarToldos(
 id int primary key identity,
 idToldos int references Toldos(idToldo),

 pieMacho float,
 precioPieCuadrado float,
 bajoAlero float,
 juegoTapa float,
 baston float,
 tornillosMedia float,
 tapaPie float,
 lamina float,
 tuboUnoPorUnoPie float

);
go

create table Screen(
idScreen int primary key identity,
idCliente int references Cliente(idCliente),
ancho float,
altura float,
);
go
create table FabricarScreen(
id int primary key identity,
idScreen int references Screen(idScreen),
orejitas int,
Lscreem int,
sogaLibra float,
precioPieCuadrado float,
MorduraScreemPie float,
yardasTela float,
tornillos int

);
go 
create table CristalFijo(
idCristalFi int primary key identity,
idCliente int references Cliente(idCliente),
ancho float,
altura float,
tipoCristal varchar(10),
);
go
create table FabricarCristalFijo(
id int primary key identity,
idCristalFijo int references CristalFijo(idCristalFi),

cristalAncho float,
cristalAltura float,

masilla int,
tornillosUna int,
gomaPie float,

precioPieCuadrado float,

basePrecionAncho float,
basePrecionAltura float,

tapaAncho float,
tapaAltura float,
basBarra float,
tapaBarra float
);
go



create table puertaComercial(
idPuComercial int primary key identity,
idCliente int references Cliente(idCliente), 
ancho float,
altura float,
);
go
create table FabricarPuertaComercial(
id int primary key identity,
idPuertaComercial int references puertaComercial(idPuComercial),

precioPieCuadrado float,
tubo float,
janibalComercial float,
cabezalComercialPie float,
tapaBarra float,
gomaPrecion float,
barilla float,

cabezal float, --..Aqui va como va cortado el cabezal..

--...Accesorios.........
tuercas int,
cerraduraCompleta int,
juegoPibot int,
punoOBarraEmpuje int,
tornillosCincoDies int,
tarugoUncuarto int,
tornillosUnaYMediaPorDies int,
cierreBotella int,
masilla int,

alfeciaComercialPie float,
alfecia float, --Aqui dice a como va cortada...
jamba float,
cristalAncho float,
cristalAltura float
);
