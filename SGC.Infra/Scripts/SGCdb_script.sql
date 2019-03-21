/****************************************************************
 * Project:.....: Projeto SGC                            		*
 * Title:.......: Script Criar esquema SGCdb               		*
 * Author.......: Ronaldo Torre                                 *
 * Reference....: Release 1.0.0                                 *
 *--------------------------------------------------------------*
 ***************************************************************/

print 'Script Create Schema SGCdb';
print '=============================================';

Use master;
go

-- check existing database
IF EXISTS(select * from sys.databases where name='SGCdb')
begin
	drop database SGCdb;
	print 'Database existing and delete!';
end;


Create database SGCdb;
print 'Create new database SGCdb';
go

Use SGCdb;
go

print 'Access SGCdb';
print 'Create tables';


-- Categoria

Create table Category
(
	Id							integer			not null identity,
	Name						varchar(100)	not null,
	Description					text			not null,
	AddDate                  	datetime     	not null,
	AddUser						varchar(25)		null,
	LastUpdateDate				datetime     	null,
	LastUpdateUser				varchar(25)		null,
	Constraint Pk_Category primary key(Id)
);

-- Produto

Create table Product
(
	Id							integer			not null identity,
	Title						varchar(max)	not null,
	Description					text			not null,
	Image						varchar(max)	null,
	CategoryId					integer			not null,
	AddDate                  	datetime     	not null,
	AddUser						varchar(25)		null,
	LastUpdateDate				datetime     	null,
	LastUpdateUser				varchar(25)		null,
	Constraint Pk_Product primary key(Id)						
);


-- REGISTROS DE TESTES
-- -------------------------------------------------------------------------------

-- CATEGORIAS
INSERT INTO CATEGORY(NAME,DESCRIPTION,ADDDATE)VALUES('ELETRÔNICOS','PRODUTOS ELETRÔNICOS.',CONVERT(DATETIME,'12/03/2019 09:05',103));
INSERT INTO CATEGORY(NAME,DESCRIPTION,ADDDATE)VALUES('ELETRODOMESTICO','PRODUTOS ELETRÔNICOS DOMESTICOS, MICROONDAS, FOGÃO, GELADEIRA, ETC.',CONVERT(DATETIME,'12/03/2019 09:05',103));
INSERT INTO CATEGORY(NAME,DESCRIPTION,ADDDATE)VALUES('INFORMÁTICA','PRODUTOS DE INFORMÁTICA E ACESSÁRIOS.',CONVERT(DATETIME,'12/03/2019 09:05',103));

-- PRODUTO
INSERT INTO PRODUCT(TITLE,DESCRIPTION,IMAGE,CATEGORYID,ADDDATE)VALUES('SAMSUNG STYLE S50','NOTEBOOK SAMSUNG STYLE S50, I7 8GB 256 SSD', NULL,3,CONVERT(DATETIME,'12/03/2019 09:05',103));