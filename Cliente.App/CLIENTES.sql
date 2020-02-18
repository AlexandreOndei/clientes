CREATE TABLE CLIENTE
(
	ID INT PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(50) NOT NULL,
    CPF VARCHAR(11) NOT NULL,
    TELEFONE VARCHAR(10),
    CELULAR VARCHAR(11) NOT NULL,
    DATA_NASCIMENTO DATE NOT NULL,
    SEXO CHAR(1) NOT NULL,
    CEP VARCHAR(8),
    LOGRADOURO VARCHAR(50) NOT NULL,
    NUMERO INT NOT NULL,
    COMPLEMENTO VARCHAR(25),
    BAIRRO VARCHAR(50),
    ID_CIDADE INT NOT NULL,
    FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE (ID)
);

CREATE TABLE ESTADO
(
	SIGLA CHAR(2) PRIMARY KEY,
    NOME VARCHAR(100) NOT NULL
);

INSERT INTO ESTADO (NOME, SIGLA) VALUES
('Acre', 'AC'), 
('Alagoas', 'AL'), 
('Amapá', 'AP'), 
('Amazonas', 'AM'), 
('Bahia', 'BA'), 
('Ceará', 'CE'), 
('Distrito Federal', 'DF'), 
('Espírito Santo', 'ES'), 
('Goiás', 'GO'), 
('Maranhão', 'MA'), 
('Mato Grosso', 'MT'), 
('Mato Grosso do Sul', 'MS'), 
('Minas Gerais', 'MG'), 
('Pará', 'PA'), 
('Paraíba', 'PB'), 
('Paraná', 'PR'), 
('Pernambuco', 'PE'), 
('Piauí', 'PI'), 
('Rio de Janeiro', 'RJ'), 
('Rio Grande do Norte', 'RN'), 
('Rio Grande do Sul', 'RS'), 
('Rondônia', 'RO'), 
('Roraima', 'RR'), 
('Santa Catarina', 'SC'), 
('São Paulo', 'SP'), 
('Sergipe', 'SE'), 
('Tocantins', 'TO');

CREATE TABLE CIDADE
(
	ID INT PRIMARY KEY AUTO_INCREMENT,
    NOME VARCHAR(100) NOT NULL,
    SIGLA_ESTADO CHAR(2) NOT NULL,
    FOREIGN KEY (SIGLA_ESTADO) REFERENCES ESTADO (SIGLA)
);