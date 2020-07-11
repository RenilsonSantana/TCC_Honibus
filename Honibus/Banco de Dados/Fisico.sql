create database dbHONIBUS
go

use dbHONIBUS
go

CREATE TABLE tbONIBUS (
numeracao int,
linha char(8),
fabricacao char(100),
placa char(7),
modelOnibus char(10),
situacao char(100),
id_Onibus int PRIMARY KEY identity
)
go

CREATE TABLE tbFLUXO (
chegada time,
saida time,
data date,
id_Fluxo int PRIMARY KEY identity,
id_Onibus int,
registroMot int,
FOREIGN KEY(id_Onibus) REFERENCES tbONIBUS (id_Onibus)
)
go

CREATE TABLE tbMOTORISTA (
nomeMotorista char(100),
registroMot int PRIMARY KEY,
habilitacao decimal(11,0),
cpf decimal(11,0),
dataAdm date,
turno char(10)
)
go

CREATE TABLE tbADM (
login char(50) PRIMARY KEY,
senha char(50)
)
go

CREATE TABLE viagem (
registroMot int,
id_Onibus int,
FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot),
FOREIGN KEY(id_Onibus) REFERENCES tbONIBUS (id_Onibus)
)
go

CREATE TABLE tbOCORENCIA (
nOcorencia int PRIMARY KEY identity,
motivoOcorencia char(100),
id_Onibus int,
registroMot int,
FOREIGN KEY(id_Onibus) REFERENCES tbONIBUS (id_Onibus),
FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot)
)
go

ALTER TABLE tbFLUXO ADD FOREIGN KEY(registroMot) REFERENCES tbMOTORISTA (registroMot)
