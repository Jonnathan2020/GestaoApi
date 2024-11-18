-- Criando a tabela TB_EQUIPAMENTOS
CREATE TABLE TB_EQUIPAMENTOS (
    NumSerie BIGINT PRIMARY KEY,
    Nome VARCHAR(255),
    Marca VARCHAR(100),
    Modelo VARCHAR(100),
    Acessorios VARCHAR(255),
    Defeito VARCHAR(255)
);

-- Inserindo dados na tabela TB_EQUIPAMENTOS
INSERT INTO TB_EQUIPAMENTOS (NumSerie, Nome, Marca, Modelo, Acessorios, Defeito) 
VALUES
(5432414, 'Computador', 'Dell', 'D100I9', 'Cabo AC', 'Não reconhece HD'),
(5432156, 'Notebook', 'Apple', 'Macbook01', 'Fonte externa', 'Realizar revisão'),
(8975234, 'Impressora', 'Samsung', 'S1000', 'Cabo AC, Cabo usb', 'Não imprime colorido'),
(8456466, 'Impressora', 'Epson', 'EP1000', 'Sem Acessorios', 'Não imprime colorido');