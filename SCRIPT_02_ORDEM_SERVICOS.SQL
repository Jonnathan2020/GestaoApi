-- Criando a tabela TB_ORDEMSERVICOS
CREATE TABLE TB_ORDEMSERVICOS (
    Id INT PRIMARY KEY,
    Status INT,  -- Status Enum pode ser mapeado como int
    Atividade VARCHAR(255),
    DataCriacao DATE,
    DataAvaliacao DATE,
    DataFinalizacao DATE,
    DataEntrega DATE,
    ValorServico DECIMAL(10, 2)
);

-- Inserindo dados na tabela TB_ORDEMSERVICOS
INSERT INTO TB_ORDEMSERVICOS (Id, Status, Atividade, DataCriacao, DataAvaliacao, DataFinalizacao, DataEntrega, ValorServico) 
VALUES
(1, 3, 'Substituido HD', '2024-11-10', '2024-11-10', '2024-11-12', '2024-11-13', 350.00),
(2, 5, 'Revisado e testado', '2024-11-10', '2024-11-10', '2024-11-13', '2024-11-13', 950.00);
