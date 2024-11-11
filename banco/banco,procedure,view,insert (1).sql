
drop database smlocacoesdb;

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



create table niveis(
id INT(8) AUTO_INCREMENT NOT NULL,
cargo VARCHAR(20) NOT NULL,
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
ativo ENUM('Sim', 'Nao') NOT NULL DEFAULT 'Sim',
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
sigla varchar(4) NOT NULL,
rotulo VARCHAR(40) NOT NULL,
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
PRIMARY KEY(id)
);

create table usuarios_desktop(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
usuario VARCHAR(70) NOT NULL,
senha VARCHAR(20) NOT NULL,
ativo ENUM('Sim', 'Nao') NOT NULL DEFAULT 'Sim',
CONSTRAINT FK_usuarios_descktop_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
PRIMARY KEY(id)
);

create table usuarios_web(
id INT(8) AUTO_INCREMENT NOT NULL,
id_funcionario INT(8) NOT NULL,
id_cliente INT(8) NOT NULL,
usuario VARCHAR(70) NOT NULL,
senha VARCHAR(20) NOT NULL,
ativo ENUM('Sim', 'Nao') NOT NULL DEFAULT 'Sim',
CONSTRAINT FK_usuarios_web_clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT FK_usuarios_web_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
PRIMARY KEY(id)
);

create table produtos(
id INT(8) AUTO_INCREMENT NOT NULL,
id_categoria INT(8) NOT NULL,
nome_produto VARCHAR(50) NOT NULL,
imagem VARCHAR(255) NOT NULL,
valor DECIMAL(10,2) NOT NULL,
unidade_venda VARCHAR(12) NOT NULL,
descricao VARCHAR(50) NOT NULL,
destaque ENUM('Sim', 'Nao') NOT NULL DEFAULT 'Sim',
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
id_funcionario INT(8) NOT NULL,
id_cliente INT(8) NOT NULL,
data_pedido DATETIME NOT NULL,
status_produto VARCHAR(1) NOT NULL,
CONSTRAINT FK_pedidos_funcionarios FOREIGN KEY (id_funcionario) REFERENCES funcionarios(id),
CONSTRAINT FK_pedidos_clientes FOREIGN KEY (id_cliente ) REFERENCES clientes(id),
PRIMARY KEY(id)
);

create table estoques(
id_produto INT(8)AUTO_INCREMENT NOT NULL,
estoque_min DECIMAL(10,2) NOT NULL,
quantidade DECIMAL(10,2) NOT NULL,
data_ultimo_movimento DATETIME NOT NULL,
CONSTRAINT FK_estoques_produtos FOREIGN KEY (id_produto) REFERENCES produtos(id),
PRIMARY KEY(id_produto)
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

-- -----------------------------------------------------
-- procedure sp_insert_niveis
-- -----------------------------------------------------

USE `smlocacoesdb`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_niveis`(
    spcargo VARCHAR(20), 
    spsigla VARCHAR(20)
)
BEGIN
    INSERT INTO niveis (cargo, sigla)
    VALUES (spcargo, spsigla);
   
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_niveis
-- -----------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_niveis`(
spid int(8),
spcargo varchar(20), 
spsigla varchar(20) 
)
begin
update niveis set cargo = spcargo, 
sigla = spsigla  
where id = spid;
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_funcionarios
-- -----------------------------------------------------

USE `smlocacoesdb`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_funcionarios`(
    spid_nivel INT(8),
    spnome VARCHAR(40),
    spcpf VARCHAR(11),
    spdata_nasc DATE,
    spdata_cad DATETIME,
    spativo CHAR(3)
)
BEGIN
    INSERT INTO funcionarios
    VALUES (0, spid_nivel, spnome, spcpf, spdata_nasc, spdata_cad, spativo);
    
    SELECT LAST_INSERT_ID();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_funcionarios
-- -----------------------------------------------------

DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_funcionarios`(
spid int(8),
spativo ENUM('Sim', 'Nao')
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
 select last_insert_id();
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
spsigla varchar(4),
sprotulo varchar(40)
)
begin
insert into categorias
values (0,
spsigla,
sprotulo
);
 select  last_insert_id();
end$$
DELIMITER ;


-- -----------------------------------------------------
-- procedure sp_inserir_usuarios_desktop
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_usuarios_desktop`( 
spid int(8),
spid_funcionario int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo ENUM('Sim', 'Nao')
)
begin
insert into usuarios_desktop
values (0,
spid_funcionario,
spusuario,
md5(spsenha),
spativo
);
 select last_insert_id();
end$$
DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_usuarios_desktop
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_usuarios_desktop`(
spid int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo ENUM('Sim', 'Nao')
)
begin 
update usuarios_desctop set usuario = spusuario,
senha = spsenha,
ativo = spativo
where id = spid;
end$$
DELIMITER ;

DELIMITER $$
-- -----------------------------------------------------
-- procedure sp_inserir_usuarios_web
-- -----------------------------------------------------
USE `smlocacoesdb`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_inserir_usuarios_web`( 
    spid INT(8),
    spid_cliente INT(8),
    spid_funcionario INT(8),
    spusuario VARCHAR(40),
    spsenha VARCHAR(20),
    spativo ENUM('Sim', 'Nao')
)
BEGIN
  INSERT INTO usuarios_web (id, id_funcionario, id_cliente, usuario, senha, ativo)
    VALUES (
        0,
        spid_funcionario,
        spid_cliente, 
        spusuario,
        MD5(spsenha),
        spativo
    );

    SELECT LAST_INSERT_ID() AS id;
END$$

DELIMITER ;



-- -----------------------------------------------------
-- procedure sp_update_usuarios_web
-- -----------------------------------------------------
DELIMITER $$
USE `smlocacoesdb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE ` sp_update_usuarios_web`(
spid int(8),
spusuario varchar(40),
spsenha varchar(20),
spativo ENUM('Sim', 'Nao')
)
begin 
update usuarios_web set usuario = spusuario,
senha = spsenha,
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
spimagem varchar(255),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spdescricao varchar(50),
spdestaque ENUM('Sim', 'Nao')
)
begin
insert into produtos
values (0,
spid_categoria,
spnome,
spimagem,
spvalor_unit,
spunidade_venda,
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
spimagem varchar(255),
spvalor decimal(10,2),
spunidade_venda varchar(12),
spdescricao varchar(50),
spdestaque ENUM('Sim', 'Nao')
)
begin 
update produtos set nome = spnome,
imagem = spimagem,
valor =spvalor_unit,
unidade_venda = spunidade_venda,
descricao = spdescricao,
destaque = spdestque
where id = spid;
end$$
DELIMITER ;


-- ---------------------------------------------------
-- view vw_produtos
-- -----------------------------------------------------
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `smlocacoesdb`.`vw_produtos` AS
    SELECT 
        `pro`.`id` AS `produto_id`,
        `cat`.`rotulo` AS `rotulo`,
        `pro`.`nome_produto` AS `nome_produto`, 
        `pro`.`imagem` AS `imagem`,
        `pro`.`valor` AS `valor`,
	`pro`.`unidade_venda` AS `unidade_venda`,
        `pro`.`descricao` AS `descricao`,
        `pro`.`destaque` AS `destaque`
    FROM
        `smlocacoesdb`.`produtos` `pro`
    JOIN `smlocacoesdb`.`categorias` `cat` 
        ON `pro`.`id_categoria` = `cat`.`id`;


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
spid_funcionario int(8),
spid_cliente int(8),
spdata_pedido datetime,
spstatus_produto varchar(1)
)
begin
insert into pedidos
values (0,
spid_funcionario,
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

CREATE DEFINER=`root`@`localhost`
TRIGGER `trigger_baixa_estoque`
AFTER INSERT ON `items_locacoes`
FOR EACH ROW
BEGIN
    UPDATE estoques 
    SET quantidade = quantidade - NEW.quantidade, 
        data_ultimo_movimento = CURRENT_DATE()
    WHERE id_produto = NEW.id_produto;
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

########################################################################

INSERT INTO `categorias` (`id`, `sigla`,`rotulo` ) VALUES
(0,'cop','copo'),
(0,'tac','tacas'),
(0,'cri','cristais'),
(0,'inox','inox'),
(0,'mcp','mesas/cadeiras/pranchao'),
(0,'pra','pratas'),
(0,'prt','pratos'),
(0,'sou','sousplat'),
(0,'suq','suqueira'),
(0,'rec','rechaud'),
(0,'tal','talheres'),
(0,'uts','utensilios cozinha'),
(0,'xica','xicaras');

INSERT INTO produtos (id, id_categoria, nome_produto, imagem, valor,unidade_venda, descricao,destaque) VALUES
(0,1, 'Copo Paulista', 'copo-paulista.jpg', 0.40,'200','Pode ser usado para degustar qualquer tipo de bebida','Sim'),
(0,1, 'Copo de Chopp', 'copo-chopp.jpg', 0.40,'100','É um copo ideal para manter a sua bebida gelada', 'Nao'),
(0,1, 'Copo Long Drink', 'copo-long-drink.jpg', 0.40,'100', 'Um belo copo para beber uma bebida sem ou com álcool', 'Sim'),
(0,1, 'Copo Stylo', 'copo-stylo.jpg', 0.40,'80','Copo transparente parar deixar o seu dink mais elegante', 'Sim'),
(0,1, 'Copo de Whisky', 'copo-whisky.jpg', 0.40,'80', 'Um belo copo para quem gosta de beber um Whisky', 'Nao'),
(0,2, 'Taça diamante', 'taça-diamante.png', 0.70,'250','Uma taça muito linda quanto parar beber um drink e também doces', 'Nao'),
(0,2, 'Taça champanhe', 'taça-champanhe.jpg', 0.50,'100','Uma bela taça para beber um champanhe gelado em momentos comemorativos', 'Nao'),
(0,2, 'Taça De Vinho', 'taça-vinho.png', 0.80, '100','Uma bela de uma taça para degustar um vinho', 'Nao'),
(0,2, 'Taça bico de J.', 'taça-bico-de-jaca.jpg', 0.70,'250','Essa taça ela é bastante utilizada para servir bebidas e doces', 'Nao'),
(0,2, 'Taça Rosa', 'taça-rosa.jpg', 0.70, '150', 'Uma taça rosa linda para decoração', 'Nao'),
(0,2, 'Taça Verde', 'taça-bico-de-jaca-verde.png', 0.70,'150','Uma taça elegante verde ela é bastante utilizada para servir bebidas e doces', 'Nao'),
(0,2, 'Taça Dourada', 'taça-bico-de-jaca-dourada.png', 0.70,'150','Uma taça elegante dourada ela é bastante utilizada para servir bebidas e doces', 'Nao'),
(0,2, 'Taça Vermelha', 'taça-vermelha.jpg', 0.70, '150','Uma taça vermelha linda para decoração', 'Nao'),
(0,2, 'Taça Azul', 'taça-azul.png', 0.70,'150' , 'Uma taça azul linda para decoração', 'Nao'),
(0,3, 'saladeira', 'saladeira.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'saladeira', 'saladeira2.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'saladeira', 'saladeira3.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'saladeira', 'saladeira4.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'saladeira hawai', 'saladeira-hawai.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'saladeira kedaung', 'saladeira-kedaung.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'prato bara bolo', 'prato-para-bolo.jpg', 10.00,'10','saladeira perfeita para sua festa', 'Nao'),
(0,3, 'jarra de suco', 'jarra-de-suco.jpg', 15.00,'25','jarra de suco perfeita para sua festa', 'Nao'),
(0,4, 'Rechaud 1 Cuba', 'rechaud-cuba-retangular.jpg', 35.00, '15','Rechaud 1 cuba retangular perfeito para a sua festa', 'Nao'),
(0,4, 'Rechaud 2 Cuba', 'rechaud-cuba.jpg', 38.00, '15','Rechaud Redondo perfeito para a sua festa', 'Nao'),
(0,4, 'Rechaud', 'rechaud-redondo.jpg', 30.00, '8','Rechaud Redondo perfeito para a sua festa', 'Nao'),
(0,4, 'Rechaud bascu.', 'rechaud-basculante.jpeg', 50.00, '5','Rechaud perfeito para a sua festa', 'Nao'),
(0,4, 'Balde', 'balde-de-gelo.jpg', 5.50,'35','Balde de gelo perfieto para colocar suas bebidas', 'Nao'),
(0,4, 'Bandeja Lisa', 'bandeja-inox.jpg', 5.50, '35','Bandeja inox perfeita para a sua festa', 'Nao'),
(0,4, 'Bandeja Quadrada', 'bandeja-inox2.jpg', 5.50,'10','Bandeja inox perfeita para a sua festa', 'Nao'),
(0,5, 'Pranchão', 'pranchao.jpg', 25.00, '5','Um pranchão de madeira para colocar utensílios em cima', 'Nao'),
(0,5, 'Tampão', 'tampao.jpg', 10.00, '35','Um tampão de madeira de boa qualidade', 'Nao'),
(0,5, 'Mesa', 'mesa-plastica.jpg', 12.00, '40','Uma mesa de plastico para os seus convidados', 'Nao'),
(0,5, 'Cadeira Plastica', 'cadeira-plastica.jpg', 2.50, '90','Uma otima cadeira para os seus convidados', 'Nao'),
(0,6, 'Samovar Prata', 'Samovar.jpg', 30.00, '5','Um Samovar lindo para a sua festa', 'Nao'),
(0,7, 'Prato De Petala', 'prato-petala.jpg', 0.40, '300','Um prato lindo de porcelana para sua festa', 'Nao'),
(0,7, 'Prato Filetado', 'prato-filetado-porcelana.jpg', 0.60, '200','Um prato lindo de porcelana para sua festa', 'Nao'),
(0,7, 'Prato Germer', 'prato-germer.jpg', 0.40, '180','Um prato lindo de porcelana para sua festa', 'Nao'),
(0,7, 'Prato Pomerode', 'prato-pomerode.jpg', 0.50, '120','Um prato lindo de porcelana para sua festa', 'Nao'),
(0,7, 'Prato Wave', 'prato-wave.jpg', 0.70, '120','Um prato lindo de porcelana para sua festa', 'Nao'),
(0,8,'Sousplat aluminio', 'sousplat-aluminio.jpg', 4.00, '80','Sousplat de aluminio perfeita para sua festa', 'Nao'),
(0,8,'Sousplat MDF', 'sousplat-mdf.jpeg', 2.00, '90','Sousplat mdf perfeita para sua festa', 'Nao'),
(0,9, 'Suqueira Lisa', 'suqueira-lisa.jpg', 25.00, '5','Suqueira perfeita para sua festa', 'Nao'),
(0,9, 'Suqueira', 'suqueira.jpg', 25.00, '10','Suqueira perfeita para sua festa', 'Nao'),
(0,10, 'Kit Talheres De Inox', 'kit-talheres-inox.png', 0.40, '100','Um Kit de talheres inox para sua festa', 'Nao'),
(0,10, 'Garfo Dourado', 'garfo-dourado.png', 1.00,'50','Um Garfo lindo dourado para sua festa', 'Nao'),
(0,10, 'Colher Dourado Para Café', 'colher-cafe-dourado.png', 1.00,'50','Uma Colher dourado linda para sua festa', 'Nao'),
(0,10, 'Garfo Dourado Para Sobremesa', 'garfo-sobremesa-dourado.png', 1.00,'50','Um Garfo lindo dourado para sua festa', 'Nao'),
(0,10, 'Faca Dourada', 'faca-dourado.png', 1.00, '50','Uma Faca dourado linda para sua festa', 'Nao'),
(0,10, 'Colher Dourado Para Sobremesa', 'colher-sobremesa-dourado.png', 1.00,'50' ,'Uma Colher dourado linda para sua festa', 'Nao'),
(0,11, 'Bandeja', 'bandeja-garçom.jfif', 5.50, '50','Uma Bela bandeja para sua festa', 'Não'),
(0,11, 'Garrafa inox', 'garrafa-termica-inox.png', 15.00, '10','Garrafa termica de inox excelente para manter a sua bebida quente ou gelada', 'Nao'),
(0,11, 'Garrafa Termica', 'garrafa-termica-cafe.png', 15.00, '5','Garrafa termica de café excelente para manter o seu café quentinho', 'Nao'),
(0,11, 'Fritadeira', 'fritadeira.jpg', 50.00, '2','Fritadeira em otimo estado para sua festa', 'Nao'),
(0,12, 'Xicara Porcelana 60ml', 'xicara-60ml.jpg', 1.50, '80','Uma otima xicara para se tomar um café ou até mesmo um chá', 'Nao'),
(0,12, 'Xicara Porcelana 80ml ', 'xicara-porcelana-80ml.jpg', 1.50, '80','Uma otima xicara para se tomar um café ou até mesmo um chá', 'Nao');









