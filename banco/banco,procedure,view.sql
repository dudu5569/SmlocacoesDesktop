create database smlocacoesdb;

use smlocacoesdb;

create table clientes(
id INT(8) AUTO_INCREMENT NOT NULL,
nome VARCHAR(40) NOT NULL,
cpf VARCHAR(11) NOT NULL UNIQUE,
data_nascimento DATE NOT NULL,
data_cad DATETIME NOT NULL,
PRIMARY KEY (id)
);

create table administracao(
id INT(8) AUTO_INCREMENT NOT NULL,
nome VARCHAR(40) NOT NULL,
cpf VARCHAR(11) NOT NULL UNIQUE,
data_nascimento DATE NOT NULL,
PRIMARY KEY (id)
);

create table fornecedores(
id INT(8) AUTO_INCREMENT NOT NULL,
razao_Social VARCHAR(100) NOT NULL,
fantasia VARCHAR(40) NOT NULL,
cnpj VARCHAR(14) NOT NULL UNIQUE,
PRIMARY KEY (id)
); 


create table niveis(
id INT(8) AUTO_INCREMENT NOT NULL,
nome VARCHAR(20) NOT NULL,
sigla VARCHAR(20) NOT NULL,
PRIMARY KEY (id)
);

create table formas_pagamentos(
id INT(8) AUTO_INCREMENT NOT NULL,
forma VARCHAR(10) NOT NULL,
PRIMARY KEY (id)
);

create table funcionarios(
id INT(8) AUTO_INCREMENT NOT NULL,
id_nivel INT(8) NOT NULL,
nome VARCHAR(40) NOT NULL,
cpf VARCHAR(11) NOT NULL UNIQUE,
data_nasc DATE NOT NULL,
data_cad DATETIME NOT NULL,
ativo BOOL NOT NULL,
CONSTRAINT FK_funcionarios_niveis FOREIGN KEY (id_nivel) REFERENCES niveis(id),
PRIMARY KEY (id)
);

create table telefones(
id INT(8) AUTO_INCREMENT NOT NULL,
telefone VARCHAR(12) NOT NULL,
tipo VARCHAR(15) NOT NULL,
PRIMARY KEY(id)
);

create table enderecos(
id INT(8) AUTO_INCREMENT NOT NULL,
logradouro VARCHAR(100) NOT NULL,
numero INT(5) NOT NULL,
bairro VARCHAR(60) NOT NULL,
cidade VARCHAR(30) NOT NULL,
uf VARCHAR(20) NOT NULL,
cep int(7) NOT NULL,
tipo VARCHAR(3) NOT NULL,
PRIMARY KEY (id)
);

create table emails(
id INT(8) AUTO_INCREMENT NOT NULL,
email VARCHAR(40) NOT NULL,
PRIMARY KEY(id)
);

create table categorias(
id INT(8) AUTO_INCREMENT NOT NULL,
nome VARCHAR(40) NOT NULL,
PRIMARY KEY(id)
);

create table clientes_telefones(
id INT(8) AUTO_INCREMENT NOT NULL,
id_cliente INT(8) NOT NULL,
id_telefone INT(8) NOT NULL,
CONSTRAINT FK_clientes_telefones_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_clientes_telefones_telefones FOREIGN KEY (id_telefone) REFERENCES telefones(id),
PRIMARY KEY(id)
);

create table clientes_enderecos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_cliente INT(8) NOT NULL,
id_endereco INT(8) NOT NULL,
CONSTRAINT FK_clientes_enderecos_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_clientes_enderecos_enderecos FOREIGN KEY (id_endereco) REFERENCES enderecos(id),
PRIMARY KEY(id)
);

create table clientes_emails(
id INT(8) AUTO_INCREMENT NOT NULL,
id_cliente INT(8) NOT NULL,
id_email INT(8) NOT NULL,
CONSTRAINT FK_clientes_emails_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_clientes_emails_emails FOREIGN KEY (id_email) REFERENCES emails(id),
PRIMARY KEY(id)
);

create table funcionarios_telefones(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
id_telefone INT(8) NOT NULL,
CONSTRAINT FK_funcionarios_telefones_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
CONSTRAINT FK_funcionarios_telefones_telefones FOREIGN KEY (id_telefone) REFERENCES telefones(id),
PRIMARY KEY(id)
);

create table funcionarios_enderecos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
id_endereco INT(8) NOT NULL,
CONSTRAINT FK_funcionarios_enderecos_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
CONSTRAINT FK_funcionarios_enderecos_enderecos FOREIGN KEY (id_endereco) REFERENCES enderecos(id),
PRIMARY KEY(id)
);

create table funcionarios_emails(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
id_email INT(8) NOT NULL,
CONSTRAINT FK_funcionarios_emails_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
CONSTRAINT FK_funcionarios_emails_emails FOREIGN KEY (id_email) REFERENCES emails(id),
PRIMARY KEY(id)
);

create table usuarios_descktop(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
usuario VARCHAR(40) NOT NULL,
senha VARCHAR(20) NOT NULL,
ativo BOOL NOT NULL,
CONSTRAINT FK_usuarios_descktop_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
PRIMARY KEY(id)
);

create table usuarios_web(
id INT(8) AUTO_INCREMENT NOT NULL,
id_adm INT(8) NOT NULL,
id_cliente INT(8) NOT NULL,
usuario VARCHAR(40) NOT NULL,
senha VARCHAR(20) NOT NULL,
ativo BOOL NOT NULL,
CONSTRAINT FK_usuarios_web_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_usuarios_web_administracao FOREIGN KEY (id_adm) REFERENCES administracao(id),
PRIMARY KEY(id)
);

create table produtos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_categoria INT(8) NOT NULL,
estoque_min DECIMAL(10,2) NOT NULL,
nome_produto VARCHAR(50) NOT NULL,
imagem VARCHAR(50) NOT NULL,
valor_unit DECIMAL(10,2) NOT NULL,
unidade_venda VARCHAR(12) NOT NULL,
data_cad DATETIME NOT NULL,
descricao VARCHAR(50) NOT NULL,
destaque ENUM('Sim','Não') NOT NULL,
CONSTRAINT FK_produtos_categorias FOREIGN KEY (id_categoria) REFERENCES categorias(id),
PRIMARY KEY(id)
);

create table locacoes(
id INT(8) AUTO_INCREMENT NOT NULL,
id_cliente INT(8) NOT NULL,
id_funcionario INT(8) NOT NULL,
data_retirada DATETIME NOT NULL,
data_entrega DATETIME NOT NULL,
CONSTRAINT FK_locacoes_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_locacoes_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
PRIMARY KEY(id)
);


create table pedidos (
id INT(8) AUTO_INCREMENT NOT NULL,
id_usuario_web INT(8) NOT NULL,
id_usuario_descktop INT(8) NOT NULL,
id_cliente INT(8) NOT NULL,
data_pedido DATETIME NOT NULL,
status_produto VARCHAR(1) NOT NULL,
CONSTRAINT FK_pedidos_usuarios_web FOREIGN KEY (id_usuario_web) REFERENCES usuarios_web(id),
CONSTRAINT FK_pedidos_usuarios_descktop FOREIGN KEY (id_usuario_web) REFERENCES usuarios_web(id),
CONSTRAINT FK_pedidos_clientes FOREIGN KEY (id_cliente ) REFERENCES clientes(id),
PRIMARY KEY(id)
);

create table estoques(
id_produto INT(8)AUTO_INCREMENT NOT NULL,
quantidade DECIMAL(10,2) NOT NULL,
data_ultimo_movimento DATETIME NOT NULL,
CONSTRAINT FK_estoques_produtos FOREIGN KEY (id_produto) REFERENCES produtos(id),
PRIMARY KEY(id_produto)
);

create table fornecedores_produtos(
id_produto INT(8)AUTO_INCREMENT NOT NULL,
id_fornecedor INT(8) NOT NULL,
PRIMARY KEY(id_produto),
CONSTRAINT FK_fornecedores_produtos_produtos FOREIGN KEY (id_produto) REFERENCES produtos(id),
CONSTRAINT FK_fornecedores_produtos_fornecedores FOREIGN KEY (id_fornecedor) REFERENCES fornecedores(id)
);

create table fornecedores_telefones(
id INT(8) AUTO_INCREMENT NOT NULL,
id_fornecedor INT(8) NOT NULL,
id_telefone INT(8) NOT NULL,
CONSTRAINT FK_fornecedores_telefones_fornecedores FOREIGN KEY (id_fornecedor) REFERENCES fornecedores(id),
CONSTRAINT FK_fornecedores_telefones_telefones FOREIGN KEY (id_telefone) REFERENCES telefones(id),
PRIMARY KEY(id)
);

create table fornecedores_enderecos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_fornecedor INT(8) NOT NULL,
id_endereco INT(8) NOT NULL,
CONSTRAINT FK_fornecedores_enderecos_fornecedores FOREIGN KEY (id_fornecedor) REFERENCES fornecedores(id),
CONSTRAINT FK_fornecedores_enderecos_enderecos FOREIGN KEY (id_endereco) REFERENCES enderecos(id),
PRIMARY KEY(id)
);

create table fornecedores_emails(
id INT(8) AUTO_INCREMENT NOT NULL,
id_fornecedor INT(8) NOT NULL,
id_email INT(8) NOT NULL,
CONSTRAINT FK_fornecedores_emails_fornecedores FOREIGN KEY (id_fornecedor) REFERENCES fornecedores(id),
CONSTRAINT FK_fornecedores_emails_emails FOREIGN KEY (id_email) REFERENCES emails(id),
PRIMARY KEY(id)
);

create table administracao_telefones(
id INT(8) AUTO_INCREMENT NOT NULL,
id_adm INT(8) NOT NULL,
id_telefone INT(8) NOT NULL,
CONSTRAINT FK_administracao_telefones_administracao FOREIGN KEY (id_adm) REFERENCES administracao(id),
CONSTRAINT FK_administracao_telefones_telefones FOREIGN KEY (id_telefone) REFERENCES telefones(id),
PRIMARY KEY(id)
);

create table administracao_enderecos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_adm INT(8) NOT NULL,
id_endereco INT(8) NOT NULL,
CONSTRAINT FK_administracao_enderecos_administracao FOREIGN KEY (id_adm) REFERENCES administracao(id),
CONSTRAINT FK_administracao_enderecos_enderecos FOREIGN KEY (id_endereco) REFERENCES enderecos(id),
PRIMARY KEY(id)
);

create table administracao_emails(
id INT(8) AUTO_INCREMENT NOT NULL,
id_adm INT(8) NOT NULL,
id_email INT(8) NOT NULL,
CONSTRAINT FK_administracao_emails_administracao FOREIGN KEY (id_adm) REFERENCES administracao(id),
CONSTRAINT FK_administracao_emails_emails FOREIGN KEY (id_email) REFERENCES emails(id),
PRIMARY KEY(id)
);

create table pagamentos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_locacao INT(8) NOT NULL,
id_formapagto INT(8) NOT NULL,
valor DECIMAL(10,2) NOT NULL,
CONSTRAINT FK_pagamentos_locacoes FOREIGN KEY (id_locacao) REFERENCES locacoes(id),
CONSTRAINT FK_pagamentos_formas_pagamentos FOREIGN KEY (id_formapagto) REFERENCES formas_pagamentos(id),
PRIMARY KEY(id)
);

create table cartoes(
id INT(8) AUTO_INCREMENT NOT NULL,
id_cliente INT(8) NOT NULL,
nome_cartao VARCHAR(20) NOT NULL,
bandeira VARCHAR(20) NOT NULL,
numero_cartao INT(16) NOT NULL,
validade INT(4) NOT NULL,
cvv INT(3) NOT NULL,
tipo VARCHAR(10) NOT NULL,
CONSTRAINT FK_cartoes_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
PRIMARY KEY(id)
);

create table items_locacoes(
id INT(8) AUTO_INCREMENT NOT NULL,
id_locacao INT(8) NOT NULL,
id_produto INT(8) NOT NULL,
id_pedido INT(8) NOT NULL,
varlor_unit DECIMAL(10,2) NOT NULL,
quantidade INT(3) NOT NULL,
CONSTRAINT FK_items_locacoes_locacoes FOREIGN KEY (id_locacao) REFERENCES locacoes(id),
CONSTRAINT FK_items_locacoes_produtos FOREIGN KEY (id_produto) REFERENCES produtos(id),
CONSTRAINT FK_items_locacoes_pedidos FOREIGN KEY (id_pedido) REFERENCES pedidos(id),
PRIMARY KEY(id)
); 


#################################################################################

-------------------------------------------------------
 procedure sp_insert_clientes
--------------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_clientes`(
spid int(8),
spnome varchar(40), 
spcpf char(11), 
spdata_nascimento date
)
begin
   insert into clientes 
   values(0,
   spnome, 
   spcpf,
   spdata_nascimento
   );
 select last_insert_id();
end$$

DELIMITER ;

-------------------------------------------------------
 procedure sp_insert_administracao
--------------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_administracao`(
spid int(8),
spnome varchar(40), 
spcpf char(11), 
spdata_nascimento date
)
begin
   insert into administracao 
   values(0,
   spnome, 
   spcpf,
   spdata_nascimento
   );
 select last_insert_id();
end$$

DELIMITER ;

-------------------------------------------------------
 procedure sp_insert_fornecedores
-------------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_fornecedores`(
spid int(8),
sprazao_Social varchar(100), 
spfantasia varchar(40), 
spcnpj varchar(14)
)
begin
   insert into fornecedores
   values(0,
   sprazao_Social, 
   spfantasia,
   spcnpj
   );
 select last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_fornecedores
-- -----------------------------------------------------

DELIMITER $$

USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_fornecedores`(
spid int(8),
sprazao_Social varchar(100), 
spfantasia varchar(40), 
spcnpj varchar(14)
)
begin
update fornecedores set razao_Social = sprazao_Social, 
fantasia = spfantasia,
cnpj = spcnpj  
where id = spid;
end$$

-------------------------------------------------------
 procedure sp_insert_niveis
-------------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_niveis`(
spnome varchar(20), 
spsigla varchar(20) 
)
begin
   insert into niveis 
   values(0,
   spnome, 
   spsigla
   );
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_niveis
-- -----------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_niveis`(
spid int(8),
spnome varchar(20), 
spsigla varchar(20) 
)
begin
update niveis set nome = spnome, 
sigla = spsigla  
where id = spid;
end$$
DELIMITER ;

-------------------------------------------------------
 procedure sp_insert_funcionarios
-------------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_funcionarios`(
spid_nivel int(8),
spnome varchar(40),
spcpf varchar(11),
spdata_nasc date,
spdata_cad datetime,
ativo bool
)
begin
   insert into funcionarios
   values(0,
   spid_nivel, 
   spnome,
   spcpf,
   spdata_nasc,
   spdata_cad,
   ativo
   );
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_funcionarios
-- -----------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_funcionarios`(
spid int(8),
spativo bool 
)
begin
update funcionarios set ativo = spativo 
where id = spid;
end$$

-- -----------------------------------------------------
-- procedure sp_insert_telefones
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_insert_telefones`( 
sptelefone varchar(12),
sptipo varchar(15)
)
begin
insert into telefones
values (0,
sptelefone, 
sptipo
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_telefones
-- -----------------------------------------------------

DELIMITER $$

USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_telefones`(
spid int(8),
sptelefone varchar(12),
sptipo varchar(15)
)
begin
update telefones set telefone = sptelefone, 
tipo = sptipo 
where id = spid;
end$$

-- -----------------------------------------------------
-- procedure sp_insert_enderecos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_enderecos`( 
    spid int(8),
    splogradouro varchar(100),
    spnumero varchar(5),
    spbairro varchar(60),
    spcidade varchar(30),
    spuf varchar(20),
    spcep int(7),
    sptipo varchar(3)
)
begin
insert into enderecos 
values (0,
splogradouro, 
spnumero,
spbairro, 
spcidade, 
spuf, 
spcep, 
sptipo
);
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_enderecos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_enderecos`(
spid int(8),
splogradouro varchar(100),
spnumero varchar(5),
spbairro varchar(60),
spcidade varchar(30),
spuf varchar(20),
spcep int(7),
sptipo varchar(3)
)
begin
update enderecos set logradouro = splogradouro, 
numero = spnumero, 
bairro = spbairro, 
cidade = spcidade, 
uf = spuf, 
cep = spcep,
tipo = sptipo 
where id = spid;
end$$

-- -----------------------------------------------------
-- procedure sp_inserir_emails
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_emails`( 
spid int(8),
spemail varchar(40)
)
begin
insert into emails
values (0,
spemail
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_emails
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_emails`(
spid int(8),
spemail varchar(40)
)
begin
update emails set email = spemail
where id = spid;
end$$
-- -----------------------------------------------------
-- procedure sp_inserir_categorias
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_categorias`( 
spid int(8),
spnome varchar(40)
)
begin
insert into categorias
values (0,
spnome
);
 select  last_insert_id();
end$$
DELIMITER ;


-- -----------------------------------------------------
-- procedure sp_inserir_usuarios_descktop
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_usuarios_descktop`( 
spid int(8),
spid_funcionario int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo bool
)
begin
insert into usuarios_descktop
values (0,
spid_funcionario,
spusuario,
spsenha,
spativo
);
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_usuarios_descktop
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_usuarios_descktop`(
spid int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo bool
)
begin 
update usuarios_descktop set usuario = spusuario,
senha = spsenha,
ativo = spativo
where id = spid;
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_usuarios_web
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_usuarios_web`( 
spid int(8),
spid_adm int(8),
spid_cliente int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo bool
)
begin
insert into usuarios_descktop
values (0,
spid_adm,
spid_cliente, 
spusuario,
spsenha,
spativo
);
 select  last_insert_id();
end$$
DELIMITER;


-- -----------------------------------------------------
-- procedure sp_update_usuarios_web
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_usuarios_web`(
spid int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo bool
)
begin 
update usuarios_web set usuario = spusuario,
senha =spsenha,
ativo = spativo
where id = spid;
end$$
DELIMITER ;
-- -----------------------------------------------------
-- procedure sp_inserir_produtos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_produtos`( 
spid int(8),
spid_categoria int(8),
spnome varchar(40),
soimagem varchar(50),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spdata_cad datetime,
spdescricao varchar(50),
spdestaque ENUM('Sim','Não')
)
begin
insert into produtos
values (0,
spid_categoria,
spnome,
spimagem,
spvalor_unit,
spunidade_venda,
spdata_cad,
spdescicao,
spdestaque
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_produtos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_produtos`(
spid int(8),
spnome varchar(40),
spimagem varchar(50),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spdescricao varchar(50),
spdestaque ENUM('Sim','Não')
)
begin 
update produtos set nome = spnome,
imagem = spimagem,
valor_unit =spvalor_unit,
unidade_venda = spunidade_venda,
descricao = spdescricao,
destaque = spdestaque
where id = spid;
end$$
DELIMITER ;

-- -----------------------------------------------------
-- view vw_select_produtos
-- -----------------------------------------------------
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `vw_produtos` AS
    SELECT 
        `pro`.`id` AS `produto_id`,  
        `ped`.`id` AS `pedido_id`,   
        `ped`.`id_usuario_web` AS `id_usuario_web`,
        `pro`.`id_categoria` AS `id_categoria`,
	`pro`.`nome_produto` AS `nome_produto`, 
        `pro`.`estoque_min` AS `estoque_min`,
        `pro`.`imagem` AS `imagem`,
        `pro`.`valor_unit` AS `valor_unit`,
        `pro`.`unidade_venda` AS `unidade_venda`,
        `pro`.`data_cad` AS `data_cad`,
        `pro`.`descricao` AS `descricao`,
        `pro`.`destaque` AS `destaque`
    FROM
        `produtos` `pro`
    JOIN `pedidos` `ped` ON `pro`.`id` = `ped`.`id`;



-- -----------------------------------------------------
-- procedure sp_inserir_locacoes
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_locacoes`( 
spid int(8),
spid_cliente int(8),
spid_funcionario int(8),
spdata_retirada datetime,
spdata_entrega datetime
)
begin
insert into locacoes
values (0,
spid_cliente,
spnome,
spid_funcionario,
spdata_retirada,
spdata_entrega
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_items_locacoes
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_items_locacoes`( 
spid int(8),
spid_locacao int (8),
spid_produto int(8),
spvalor_unit decimal(10,2),
spquantidade int(3)
)
begin
insert into items_locacoes
values (0,
spid_locacao,
spid_produto,
spvalor_unit,
spquantidade
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_items_locacoes
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_items_locacoes`(
spid int(8),
spvalor_unit decimal(10,2),
spquantidade int(3)
)
begin 
update items_locacoes set valor_unit = spvalor_unit,
quantidade = spquantidade
where id = spid;
end$$


-- -----------------------------------------------------
-- procedure sp_inserir_pedidos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_pedidos`( 
spid int(8),
spid_usuario_web int(8),
spid_usuario_descktop int(8),
spid_cliente int(8),
spdata_pedido datetime,
spstatus_produto varchar(1)
)
begin
insert into pedidos
values (0,
spid_usuario_web,
spid_usuario_descktop,
spid_cliente,
spdata_pedido,
spstatus_produto
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_pedidos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_pedidos`(
spid int(8),
spdata_pedido datetime,
spstatus_produto varchar(1)
)
begin 
update pedidos set data_pedido = spdata_pedido,
status_produto = spstatus_produto
where id = spid;
end$$

-- -----------------------------------------------------
-- procedure sp_inserir_estoques
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_estoques`( 
spid_produto INT(8),
spquantidade DECIMAL(10,2),
spdata_ultimo_movimento datetime
)
begin
insert into estoques
values (spid_produto,
spquantidade,
spdata_ultimo_movimento
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_estoques
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_estoques`(
spid_produto INT(8),
spquantidade DECIMAL(10,2)
)
begin 
update estoques set quantidade = spquantidade
where id = spid;
end$$

-- -----------------------------------------------------
-- trigger trigger_atualizar_estoques
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `smlocacoesdb`.`trigger_atualizar_estoques`
AFTER INSERT ON `smlocacoesdb`.`produtos`
FOR EACH ROW
BEGIN
INSERT INTO estoques values(new.id, 0, current_date());
END$$

USE `smlocacoesdb`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `smlocacoesdb`.`trigger_baixa_estoque`
AFTER INSERT ON `smlocacoesdb`.`items_locacoes`
FOR EACH ROW
BEGIN
update estoques SET quantidade = quantidade - NEW.quantidade, data_ultimo_movimento = current_date()
where id_produto = new.id_produto
;
END$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_pagamentos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_pagamentos`(
spid INT(8), 
spid_locacao INT(8),
spid_formapagto INT(8),
spvalor decimal(10,2)
)
begin
insert into pagamentos
values (0,spid_locacao,
spid_locacao,
spid_formapagto,
spvalor
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_pagamentos
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_pagamentos`(
spid INT(8), 
spvalor decimal(10,2)
)
begin 
update pagamentos set valor = spvalor
where id = spid;
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_inserir_cartoes
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_cartoes`(
spid INT(8), 
spid_cliente INT(8),
spnome_cartao varchar(20),
spbandeira varchar(20),
spnumero_cartao INT(16),
spvalidade INT(4),
spcvv INT(3),
tipo varchar(10)
)
begin
insert into catoes
values (0,spid_cliente,
spnome_cartao,
spid_formapagto,
spbandeira,
spnumero_cartao,
spvalidade,
spcvv,
tipo
);
 select  last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_cartoes
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_cartoes`(
spid INT(8), 
spnome_cartao varchar(20),
spbandeira varchar(20),
spnumero_cartao INT(16),
spvalidade INT(4),
spcvv INT(3),
tipo varchar(10)
)
begin 
update cartoes set nome_cartao = spnome_cartao,
bandeira = spbandeira,
numero_cartao = spnumero_cartao,
validade = spvalidade,
cvv = spcvv,
tipo = sptipo
where id = spid;
end$$
DELIMITER ;














