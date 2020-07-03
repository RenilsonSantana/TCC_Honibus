create database dbHONIBUS
go

use dbHONIBUS
go

CREATE TABLE tbONIBUS (
numeracao int PRIMARY KEY,
fabricacao date,
placa char(7),
modelOnibus char(50),
situacao char(20),
motoristaUm char (50),
motoristaDois char (50),
periodoMotUm char (10),
periodoMotDois char (10),
)
go

CREATE TABLE tbMOTORISTA (
nomeMotorista char(100),
registroMot int PRIMARY KEY,
habilitacao decimal(11),
cpf decimal(11),
dataAdm date,
turno char(20),
situacao char(10),
numeracao int
)
go

CREATE TABLE tbFLUXO (
chegada time,
saida time,
data date,
campo int primary key identity,
registroMot int,
numeracao int,
confirmacao char(20),
FOREIGN KEY(numeracao) REFERENCES tbONIBUS (numeracao),
FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot),
)


go


CREATE TABLE tbADM (
usuario char(50) PRIMARY KEY,
senha char(50)
)

go
 insert into tbADM(usuario,senha)
                  values('admHonibus@control.com', '1234adm');
go


CREATE TABLE viagem (
registroMot int,
numeracao int,
FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot),
FOREIGN KEY(numeracao) REFERENCES tbONIBUS (numeracao)
)

go

CREATE TABLE tbOCORENCIA (
nOcorencia int PRIMARY KEY,
motivoOcorencia char(100),
descricaoMotivo char (200),
motorista char (50),
data datetime,
numeracao int,
registroMot int,
FOREIGN KEY(numeracao) REFERENCES tbONIBUS (numeracao),
FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot)
)
go



 insert into tbONIBUS(numeracao, fabricacao, placa, modelOnibus, situacao, motoristaUm, motoristaDois, periodoMotUm, periodoMotDois)
                  values(1234, '02/05/2015', 'maj8894','mercedes benz' ,'ativo', 'José da Silva', 'Alexandre Pereira', 'tarde', 'manha'),
				        (5678, '22/10/2013', 'ujh8745','volkswagen/man' ,'ativo','Ronaldo Rodrigues', 'André da Silva','tarde', 'noite'),
						(1011, '06/03/2010', 'olk4723','marcopolo','ativo', 'Maria Antonieta de Souza (I)', 'Breno Rodrigues','tarde', 'manha'),
						(1112, '02/08/2014', 'agf5632', 'iveco', 'ativo', 'Amauri de Souza Jr', 'Andreia Souza', 'tarde', 'noite'),
						(1213, '03/07/2017', 'plv9472', 'volvo', 'ativo', 'Renilson Santana  (I)', 'Josefa Resotti', 'tarde', 'noite'),
						(1314, '05/09/2011', 'ufr4147', 'scania', 'ativo', 'Jonathan Francisco', 'Bernardo Silva Santos', 'manha', 'tarde'),
						(5687, '06/01/2001', 'iar8987', 'jimbei', 'inativo', 'Nicolas Aguiar de Souza (A)', 'Yara dos Santos (A)', 'manha', 'noite'),
						(8954, '06/01/2018', 'iar8974', 'mercedes', 'ativo', 'Nicolas Aguiar de Souza', 'Yara dos Santos', 'manha', 'noite');
go

 insert into tbMOTORISTA(nomeMotorista, registroMot, cpf, turno, habilitacao, dataAdm, situacao, numeracao)
                  values('José da Silva', 12 , 123456, 'tarde', 8974, '22/05/2008', 'ATIVO', 1234),
				        ('Alexandre Pereira', 16 , 895475, 'manha', 7412, '22/05/2010', 'ATIVO', 1234),
				        ('Ronaldo Rodrigues', 11 , 678945, 'tarde', 6578, '05/10/2005', 'ATIVO', 5678),
						('André da Silva', 17 , 647145, 'noite', 5206, '05/10/2011', 'ATIVO', 5678),
						('Maria Antonieta de Souza', 13 , 589463, 'tarde', 8745, '10/12/2016', 'INATIVO',1011 ),
						('Breno Rodrigues', 18 , 542142, 'manha/tarde', 8741, '10/11/2017', 'ATIVO', 1011 ),
						('Amauri de Souza Jr', 9 , 151889, 'tarde', 1014, '06/08/2002', 'ATIVO', 1112),
						('Andreia Souza', 19 , 745632, 'noite', 1416, '06/08/2015', 'ATIVO', 1112),
						('Renilson Santana', 15 , 121516, 'tarde', 6974, '03/01/2018', 'INATIVO', 1213),
						('Josefa Resotti', 20 , 141718, 'tarde/noite', 7415, '03/04/2017', 'ATIVO', 1213),
						('Jonathan Francisco', 10 , 581463, 'tarde/noite', 7895, '05/11/2009','ATIVO', 1314),
						('Bernardo Silva Santos', 22 , 151619, 'manha', 8495, '05/11/2010','ATIVO', 1314),
						('Nicolas Aguiar de Souza', 14 , 697410, 'manhã', 0147, '05/11/2010','ATIVO', 8954),
						('Yara dos Santos', 21 , 484714, 'manhã', 1474, '05/11/2011','ATIVO', 8954);
go

 insert into tbFLUXO(chegada, saida, data, registroMot, numeracao, confirmacao)
                  values('14:20', '14:50', '04/07/2018', 12, 1234, 'null'),
				        ('15:15', '15:45', '04/07/2018', 17, 5678, 'null'),
                        ('16:00', '16:30', '04/07/2018', 10, 1314, 'null'),
                        ('20:00', '20:30', '04/07/2018', 21, 8954, 'null');
				select * from tbOCORENCIA