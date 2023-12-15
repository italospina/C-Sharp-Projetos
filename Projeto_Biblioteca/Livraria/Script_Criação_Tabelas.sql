USE Projeto_App_SQL_SERVER;

--editora
CREATE TABLE tblEditoras (
    edi_id INT not null PRIMARY KEY,
    edi_nome VARCHAR(50) not null,
	edi_sigla VARCHAR(25) not null,
    edi_observacoes VARCHAR(500)
);

--livro
CREATE TABLE tblLivros (
    liv_id INT not null PRIMARY KEY,
    liv_nome VARCHAR(50) not null,
    liv_ano_publicacao int not null,
    liv_isbn decimal(14) not null,
	liv_observacao VARCHAR(500),
    fk_edi_id INT not null,
    FOREIGN KEY (fk_edi_id) REFERENCES tblEditoras (edi_id)
);
--autores
CREATE TABLE tblAutores (
    aut_id INT not null PRIMARY KEY,
    aut_nome VARCHAR(50) not null,
    aut_pseudonimo VARCHAR(50) not null,
    aut_observacoes VARCHAR(500)
);

/* -- Gambiarra que deu errado
Alter table tblLivros
add FOREIGN KEY (fk_aut_nome) REFERENCES tblAutores (aut_nome)
ON DELETE CASCADE
ON UPDATE CASCADE;

Alter table tblLivros
add FOREIGN KEY (fk_edi_nome) REFERENCES tblAutores (edi_nome)
ON DELETE CASCADE
ON UPDATE CASCADE;*/




