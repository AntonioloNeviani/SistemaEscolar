create database SistemaEscolar;

use SistemaEscolar;

create table Estudiante (
id int not null auto_increment,
codigo varchar (20) not null,
nombre varchar (20) not null,
apellidoP varchar (20) not null,
apellidoM varchar (20) not null,
calle varchar (20) not null,
numero varchar (10) not null,
numeroInt varchar (10),
ciudad varchar (20) not null,
colonia varchar (20) not null,
telefono varchar (20) not null,
celular varchar (20),
avisarA varchar (20) not null,
telEm varchar (20),
observaciones varchar (255),
usuario varchar (20) not null,
password varchar (20) not null,
primary key (id)
);

create table Maestro (
id int not null auto_increment,
codigo varchar (20) not null,
nombre varchar (20) not null,
apellidoP varchar (20) not null,
apellidoM varchar (20) not null,
calle varchar (20) not null,
numero varchar (10) not null,
numeroInt varchar (10),
ciudad varchar (20) not null,
colonia varchar (20) not null,
telefono varchar (20) not null,
celular varchar (20),
avisarA varchar (20) not null,
telEm varchar (20),
observaciones varchar (255),
usuario varchar (20) not null,
password varchar (20) not null,
primary key (id)
);

create table Materia (
id int not null auto_increment,
id_Estudiante int,
id_Maestro int,
codigo varchar (20) not null,
nombre varchar (20) not null,
area varchar (20) not null,
horas varchar (20) not null,
calificacion varchar (20),
faltas varchar (20),
primary key (id),
foreign key (id_Estudiante) references Estudiante(id) on delete cascade,
foreign key (id_Maestro) references Maestro(id) on delete cascade
);

create table Grado (
id int not null auto_increment,
id_Estudiante int not null,
id_Maestro int not null,
numGrado varchar (10) not null,
aula varchar (30),
edificio varchar (30),
primary key (id),
foreign key (id_Estudiante) references Estudiante(id) on delete cascade,
foreign key (id_Maestro) references Maestro(id) on delete cascade
);

create table Cursos (
id int not null auto_increment,
id_Estudiante int,
id_Maestro int,
codigo varchar (20) not null,
nombre varchar (20) not null,
area varchar (20) not null,
horas varchar (20) not null,
acreditacion varchar (10),
faltas varchar (20),
primary key (id),
foreign key (id_Estudiante) references Estudiante (id) on delete cascade,
foreign key (id_Maestro) references Maestro (id) on delete cascade
);

create table Cordinacion (
id int not null auto_increment,
codigo varchar (20) not null,
nombre varchar (20) not null,
apellidoP varchar (20) not null,
apellidoM varchar (20) not null,
calle varchar (20) not null,
numero varchar (10) not null,
numeroInt varchar (10),
ciudad varchar (20) not null,
colonia varchar (20) not null,
telefono varchar (20) not null,
celular varchar (20),
avisarA varchar (20) not null,
telEm varchar (20),
cargo varchar (20) not null,
observaciones varchar (255),
usuario varchar (20) not null,
password varchar (20) not null,
primary key (id)
);

create table Pagos (
id int not null auto_increment,
id_Estudiante int not null,
id_cordinacion int not null,
codigo varchar (20) not null,
fecha varchar (30) not null,
tipoPago varchar (30) not null,
importe varchar (30) not null,
observaciones varchar (255),
primary key (id),
foreign key (id_Estudiante) references Estudiante (id) on delete cascade,
foreign key (id_Cordinacion) references Cordinacion (id)on delete cascade
);

create table Nomina (
id int not null auto_increment,
id_Maestro int,
id_cordinacion int,
codigo varchar (20) not null,
fecha varchar (30) not null,
horasTrabajadas varchar (15) not null,
horasExtra varchar (15),
observaciones varchar (255),
primary key (id),
foreign key (id_Maestro) references Maestro(id) on delete cascade,
foreign key (id_Cordinacion) references Cordinacion (id) on delete cascade
);


