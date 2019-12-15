CREATE TABLE Promotor(
	designacao VARCHAR(100) NOT NULL,
	nacionalidade VARCHAR(15) NOT NULL,
	nib NUMERIC(9) NOT NULL,
	nif NUMERIC(9) PRIMARY KEY
);

CREATE TABLE Responsavel(
	designacao VARCHAR(100) NOT NULL,
	email VARCHAR(30) NOT NULL,
	telefone VARCHAR(15) PRIMARY KEY
);

CREATE TABLE Utilizador(
	id INT IDENTITY(1,1) PRIMARY KEY,
	tipo VARCHAR(30) NOT NULL,
	username VARCHAR(30) NOT NULL,
	passw VARCHAR(30) NOT NULL,
	CONSTRAINT tipo_constraint_utilizador CHECK (tipo in ('tecnico', 'gestor de financiamento', 'comissao de financiamento'))
);

CREATE TABLE Projeto(
	id INT PRIMARY KEY,
	tipo VARCHAR(11) NOT NULL,
	montante_financiamento FLOAT NOT NULL,
	descricao VARCHAR(100) NOT NULL,
	estado VARCHAR(30) NOT NULL,
	data_criacao DATETIME NOT NULL,
	id_tecnico INT REFERENCES Utilizador(id) NOT NULL, -- Garantir que é um utilizador do tipo tecnico.
	telefone VARCHAR(15) REFERENCES Responsavel(telefone) NOT NULL,
	nif NUMERIC(9) REFERENCES Promotor(nif) NOT NULL,
	CONSTRAINT tipo_constraint_projeto CHECK (tipo in ('incentivo', 'bonificacao'))
);

CREATE TABLE ParecerTecnico(
	id INT IDENTITY(1,1) PRIMARY KEY,
	texto_livre VARCHAR(100) NOT NULL,
	decisao VARCHAR(9) NOT NULL,
	data_parecer DATETIME NOT NULL, 
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	CONSTRAINT decisao_constraint CHECK (decisao IN ('aprovado', 'rejeitado'))
);

CREATE TABLE Despacho(
	id INT IDENTITY(1,1) PRIMARY KEY,
	resultado VARCHAR(30) NOT NULL,
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
