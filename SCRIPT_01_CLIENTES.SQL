-- Criando a tabela TB_CLIENTE
CREATE TABLE TB_CLIENTE (
    Id INT PRIMARY KEY,
    Nome VARCHAR(200),
    Sobrenome VARCHAR(200),
    Cpf VARCHAR(14),
    Celular BIGINT,
    Endereco VARCHAR(255),
    EndNum INT,
    Bairro VARCHAR(100),
    Cidade VARCHAR(100),
    UF VARCHAR(2)
);

-- Inserindo dados na tabela TB_CLIENTE
INSERT INTO TB_CLIENTE (Id, Nome, Sobrenome, Cpf, Celular, Endereco, EndNum, Bairro, Cidade, UF) 
VALUES
(1, 'Jonnathan', 'Santos', '46881735070', 11999988877, 'Rua Napoleao', 1543, 'Vila Guilherme', 'São Paulo', 'SP'),
(2, 'Amadeu', 'Romusvaldo', '5717425885', 11991492477, 'Rua Seilandia', 23, 'Seilandia', 'São Paulo', 'SP'),
(3, 'Abel', 'Santo', '12345678901', 1199988776655, 'Rua da irmandadde', 50, 'Vila Armadada', 'São Paulo', 'SP'),
(4, 'Magno', 'Magnanimo', '52875298410', 11923492477, 'Rua quarteto', 153, 'X-men', 'São Paulo', 'SP');