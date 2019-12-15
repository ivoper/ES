CREATE TABLE Promotor(
	designacao TEXT NOT NULL,
	nacionalidade TEXT NOT NULL,
	nib INT NOT NULL,
	nif INT PRIMARY KEY
);

CREATE TABLE Responsavel(
	designacao TEXT NOT NULL,
	email TEXT NOT NULL,
	telefone VARCHAR(15) PRIMARY KEY
);

CREATE TABLE Utilizador(
	id INT IDENTITY(1,1) PRIMARY KEY,
	tipo VARCHAR NOT NULL,
	username VARCHAR NOT NULL,
	passw VARCHAR NOT NULL,
	CONSTRAINT tipo_constraint CHECK (tipo in ('tecnico', 'gestor de financiamento', 'comissao de financiamento'))
);

CREATE TABLE Projeto(
	id INT PRIMARY KEY,
	tipo TEXT NOT NULL,
	montante_financiamento FLOAT NOT NULL,
	descricao TEXT NOT NULL,
	estado TEXT NOT NULL,
	data_criacao DATETIME NOT NULL,
	id_tecnico INT REFERENCES Utilizador(id) NOT NULL, -- Garantir que é um utilizador do tipo tecnico.
	telefone VARCHAR(15) REFERENCES Responsavel(telefone) NOT NULL,
	nif INT REFERENCES Promotor(nif) NOT NULL,
);

CREATE TABLE ParecerTecnico(
	id INT IDENTITY(1,1) PRIMARY KEY,
	texto_livre VARCHAR NOT NULL,
	decisao VARCHAR NOT NULL,
	data_parecer DATETIME NOT NULL, 
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	CONSTRAINT decisao_constraint CHECK (decisao IN ('aprovado', 'rejeitado'))
);

CREATE TABLE Despacho(
	id INT IDENTITY(1,1) PRIMARY KEY,
	resultado VARCHAR NOT NULL,
	montante FLOAT NOT NULL,
	custo_elegivel FLOAT NOT NULL,
	data_despacho DATETIME NOT NULL,
	prazo_execucao DATE NOT NULL, -- AAAA/MM/DD
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	CONSTRAINT resultado_constraint CHECK (resultado IN ('aprovado', 'rejeitado', 'transformado em bonificacao'))
);

CREATE TABLE Pagamento(
	montante FLOAT NOT NULL,
	data_pagamento DATETIME NOT NULL,
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	PRIMARY KEY(montante, data_pagamento, id_projeto)
);