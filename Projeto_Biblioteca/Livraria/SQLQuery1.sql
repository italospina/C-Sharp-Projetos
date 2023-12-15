USE Projeto_App_SQL_SERVER;

--editora
CREATE TABLE tblEditoras (
    edi_id INT not null PRIMARY KEY,
    edi_nome VARCHAR(50) not null,
	edi_sigla VARCHAR(25) not null,
    edi_observacoes VARCHAR(500)
);

INSERT INTO tblEditoras values(1,'Saraiva','Editora Saraiva',null);
INSERT INTO tblEditoras values(2,'Aleph','Editora Aleph'    ,null);
INSERT INTO tblEditoras values(3,'Suma','Editora Suma'      ,'Suma é um selo ligado ao Grupo Companhia das Letras');
INSERT INTO tblEditoras values(4,'Rocco','Editora Rocco'    ,null);


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

INSERT INTO tblLivros values(1,'Harry Potter e a Pedra Filosofal'       ,'1997','9788532511010',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(2,'Harry Potter e a Câmara Secreta'        ,'1998','9788532530783',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(3,'Harry Potter e o Prisioneiro de Azkaban','1999','9788532531784',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(4,'Harry Potter e o Cálice de Fogo'        ,'2000','9788532531797',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(5,'Harry Potter e a Ordem da Fênix'        ,'2003','9788532531803',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(6,'Harry Potter e o Enigma do Príncipe'    ,'2005','9788532531810',Null,Null,Null,Null,Null);
INSERT INTO tblLivros values(7,'Harry Potter e as Relíquias da Morte'   ,'2007','9788532531827',Null,Null,Null,Null,Null);

--autores
CREATE TABLE tblAutores (
    aut_id INT not null PRIMARY KEY,
    aut_nome VARCHAR(50) not null,
    aut_pseudonimo VARCHAR(50) not null,
    aut_observacoes VARCHAR(500)
);

INSERT INTO tblAutores values(1, 'Joanne ','J.K. Rowlling','Escritora de Harry Potter');

/*--autores livros
CREATE TABLE tblAutoresLivros (
    liv_id INT not null,
    aut_id INT not null,
    CONSTRAINT pfk_liv_id FOREIGN KEY (liv_id) REFERENCES tblLivros (liv_id),
    CONSTRAINT pfk_aut FOREIGN KEY (aut_id) REFERENCES tblAutores (aut_id)
);

INSERT INTO tblAutoresLivros values(1,1);
INSERT INTO tblAutoresLivros values(2,1);
INSERT INTO tblAutoresLivros values(3,1);
INSERT INTO tblAutoresLivros values(4,1);
INSERT INTO tblAutoresLivros values(5,1);
INSERT INTO tblAutoresLivros values(6,1);
INSERT INTO tblAutoresLivros values(7,1);
*/
/*
selects
*/

SELECT* FROM tblEditoras;
SELECT* FROM tblAutores;

SELECT* FROM tblLivros;
select liv_id, liv_nome, liv_ano_publicacao, liv_isbn, liv_observacao, fk_aut_nome
 from tblLivros 
 order by liv_nome                 


Alter table tblLivros
add fk_aut_nome VARCHAR(50), fk_edi_nome VARCHAR(50);
/*
Alter table tblLivros
add FOREIGN KEY (fk_aut_nome) REFERENCES tblAutores (aut_nome)
ON DELETE CASCADE
ON UPDATE CASCADE;

Alter table tblLivros
add FOREIGN KEY (fk_edi_nome) REFERENCES tblAutores (edi_nome)
ON DELETE CASCADE
ON UPDATE CASCADE;
*/



select ISNULL (max(aut_id), 0) + 1 as id
from tblAutores

select isnull (max(edi_id), 0) + 1 as id
 from tblEditoras;

select isnull (max(liv_id), 0) + 1 as id
 from tblLivros;

 select edi_id, edi_nome, edi_sigla, edi_observacoes 
   from tblEditoras                                   
order by edi_nome asc

select aut_id, aut_nome, aut_pseudonimo, aut_observacoes 
  from tblAutores
  order by aut_nome asc

/*
updates
*/
UPDATE tblEditoras
SET edi_id = 5
WHERE edi_id = -1;


/*
deletes
*/
delete from tblAutores
where aut_id =-1;

drop table tblAutoresLivros;
delete from tblAutoresLivros;

delete from tblLivros;

delete from tblEditoras;






