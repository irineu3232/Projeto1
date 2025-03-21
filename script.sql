-- Criando a Banco de Dados
create database dbsistema1;

-- Usando o Banco de Dados
use dbsistema1;

-- Criando as tabelas do Banco

/*Usuario*/
create table tbUsuario(
	Id int primary Key auto_increment,
	Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
);

-- Consultando as tabelas do banco

Select * from tbUsuario;