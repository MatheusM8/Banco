CREATE TABLE [dbo].[Conta]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Numero] VARCHAR(50) NULL, 
    [Agencia] VARCHAR(50) NULL, 
    [Saldo] DECIMAL(18, 2) NULL, 
    [Tipo] VARCHAR(50) NULL
)
