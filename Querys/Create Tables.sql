CREATE TABLE Promotor(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nib NUMERIC(9) NOT NULL UNIQUE,
	nif NUMERIC(9) NOT NULL UNIQUE,
	nome VARCHAR(100) NOT NULL,
	nacionalidade VARCHAR(15) NOT NULL
);

CREATE TABLE Responsavel(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(30) NOT NULL,
	telefone VARCHAR(15) NOT NULL
);

CREATE TABLE Utilizador(
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(30) NOT NULL,
	passw VARCHAR(30) NOT NULL
);

CREATE TABLE Tecnico(
	id_utilizador INT PRIMARY KEY,
	FOREIGN KEY (id_utilizador) REFERENCES Utilizador(id)
);

CREATE TABLE GestorDeFinanciamento(
	id_utilizador INT PRIMARY KEY,
	FOREIGN KEY (id_utilizador) REFERENCES Utilizador(id)
);

CREATE TABLE ComissaoDeFinanciamento(
	id_utilizador INT PRIMARY KEY,
	FOREIGN KEY (id_utilizador) REFERENCES Utilizador(id)
);

CREATE TABLE Estado(
	id INT PRIMARY KEY,
	estado VARCHAR(15)
);

CREATE TABLE EstadosTecnico(
	id_estado INT REFERENCES Estado(id) PRIMARY KEY
);

CREATE TABLE EstadosComissao(
	id_estado INT REFERENCES Estado(id) PRIMARY KEY
);

CREATE TABLE EstadosGestor(
	id_estado INT REFERENCES Estado(id) PRIMARY KEY
);

CREATE TABLE Projeto(
	id INT PRIMARY KEY,
	descricao VARCHAR(100) NOT NULL,
	data_criacao DATETIME NOT NULL,
	montante_solicitado FLOAT NOT NULL,
	estado INT REFERENCES Estado(id) NOT NULL,
	id_tecnico INT REFERENCES Tecnico(id_utilizador) NOT NULL,
	id_responsavel int REFERENCES Responsavel(id) NOT NULL,
	id_promotor INT REFERENCES Promotor(id) NOT NULL,
);

CREATE TABLE Incentivo(
	id_projeto INT PRIMARY KEY,
	FOREIGN KEY (id_projeto) REFERENCES Projeto(id)
);

CREATE TABLE Bonificacao(
	id_projeto INT PRIMARY KEY,
	FOREIGN KEY (id_projeto) REFERENCES Projeto(id)
);

CREATE TABLE Historico(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	estado INT REFERENCES Estado(id) NOT NULL
);

CREATE TABLE ParecerTecnico(
	id INT IDENTITY(1,1) PRIMARY KEY,
	texto VARCHAR(100) NOT NULL,
	decisao VARCHAR(9) NOT NULL,
	data_parecer DATETIME NOT NULL, 
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	CONSTRAINT decisao_constraint CHECK (decisao IN ('aprovado', 'rejeitado'))
);

CREATE TABLE Despacho(
	id INT IDENTITY(1,1) PRIMARY KEY,
	resultado VARCHAR(30) NOT NULL,
	data_despacho DATETIME NOT NULL,
	id_projeto INT REFERENCES Projeto(id) NOT NULL,
	CONSTRAINT resultado_constraint CHECK (resultado IN ('aprovado', 'rejeitado', 'transformado'))
);

CREATE TABLE DespachoIncentivo(
	id_despacho INT PRIMARY KEY,
	montante FLOAT,
	custo_elegivel FLOAT,
	prazo_execucao DATE,
	FOREIGN KEY (id_despacho) REFERENCES Despacho(id)
);

CREATE TABLE DespachoBonificacao(
	id_despacho INT PRIMARY KEY,
	taxa FLOAT,
	montante_maximo FLOAT,
	periodo DATE,
	FOREIGN KEY (id_despacho) REFERENCES Despacho(id)
);

CREATE TABLE Pagamento(
	id INT IDENTITY(1,1) PRIMARY KEY,
	valor FLOAT NOT NULL,
	data DATETIME NOT NULL,
	id_projeto INT REFERENCES Incentivo(id_projeto) NOT NULL,
	id_despacho INT REFERENCES Despacho(id) NOT NULL
);
