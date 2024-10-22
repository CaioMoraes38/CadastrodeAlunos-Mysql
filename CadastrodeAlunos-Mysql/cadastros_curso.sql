create table cadastros_curso (
	id int not null auto_increment,
	nome varchar(255) not null,
	descricao text not null,
	carga_horaria int not null,
	primary key (id)
);