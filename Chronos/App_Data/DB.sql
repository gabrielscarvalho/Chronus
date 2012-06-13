create table usuario(
    usu_id int not null,
    usu_nome varchar(40) not null,
    usu_email varchar(120) not null,
    usu_senha varchar(120) not null,
    constraint pk_usuario primary key(usu_id)
)

insert into usuario
(usu_id, usu_nome, usu_email, usu_senha) VALUES
(1,'Jose da Silva','jose@silva.com','senha123')