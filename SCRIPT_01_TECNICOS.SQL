CREATE TABLE TB_TECNICO (
    Id INT PRIMARY KEY,
    Nome VARCHAR(200),
    Sobrenome VARCHAR(200),
    Cpf VARCHAR(14),
    Especialidade VARCHAR(100)
);

-- Inserindo os dados dos técnicos na tabela TB_TECNICO
INSERT INTO TB_TECNICO (Id, Nome, Sobrenome, Cpf, Especialidade) 
VALUES
(100, 'Chico', 'Tavares', '98765432115', 'Eletricista'),
(101, 'Castiel', 'Silva', '44265432115', 'Informática'),
(102, 'Baltazar', 'Santo', '85265432115', 'Pedreiro');