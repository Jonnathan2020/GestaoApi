-- Criando a tabela Usuario
CREATE TABLE Usuario (
    Id INT PRIMARY KEY,
    Username VARCHAR(100),
    PasswordHash VARBINARY(MAX),
    PasswordSalt VARBINARY(MAX),
    Perfil VARCHAR(50) DEFAULT 'Jogador',
    Email VARCHAR(100),
    Latitude DECIMAL(10, 7),
    Longitude DECIMAL(10, 7)
);

-- Inserindo o usuário padrão na tabela Usuario
-- O hash e salt são fictícios aqui, você precisa gerar esses valores usando o algoritmo de criptografia no código C#
INSERT INTO Usuario (Id, Username, PasswordHash, PasswordSalt, Perfil, Email, Latitude, Longitude)
VALUES
(1, 'UsuarioAdmin', 0x123456, 0xabcdef, 'Admin', 'seuEmail@gmail.com', -23.5200241, -46.596498);