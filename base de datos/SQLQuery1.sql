IF DB_ID('SurDigitalDB') IS NULL
    CREATE DATABASE SurDigitalDB;
GO

USE SurDigitalDB;
GO

IF OBJECT_ID('dbo.OrdenServicio', 'U') IS NOT NULL DROP TABLE dbo.OrdenServicio;
IF OBJECT_ID('dbo.Equipo',        'U') IS NOT NULL DROP TABLE dbo.Equipo;
IF OBJECT_ID('dbo.Tecnico',       'U') IS NOT NULL DROP TABLE dbo.Tecnico;
IF OBJECT_ID('dbo.Cliente',       'U') IS NOT NULL DROP TABLE dbo.Cliente;
GO

CREATE TABLE dbo.Cliente (
    IdCliente  INT IDENTITY(1,1) NOT NULL,
    Cedula     VARCHAR(9)   NOT NULL,
    Nombre     VARCHAR(50)  NOT NULL,
    Apellidos  VARCHAR(80)  NOT NULL,
    Telefono   VARCHAR(8)   NOT NULL,
    Correo     VARCHAR(100) NULL,
    CONSTRAINT PK_Cliente PRIMARY KEY (IdCliente),
    CONSTRAINT UQ_Cliente_Cedula UNIQUE (Cedula),
    CONSTRAINT CK_Cliente_Cedula CHECK (LEN(Cedula) = 9 AND Cedula NOT LIKE '%[^0-9]%'),
    CONSTRAINT CK_Cliente_Telefono CHECK (LEN(Telefono) = 8 AND Telefono NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE dbo.Tecnico (
    IdTecnico    INT IDENTITY(1,1) NOT NULL,
    Cedula       VARCHAR(9)   NOT NULL,
    Nombre       VARCHAR(50)  NOT NULL,
    Apellidos    VARCHAR(80)  NOT NULL,
    Telefono     VARCHAR(8)   NOT NULL,
    Especialidad VARCHAR(60)  NOT NULL,
    CONSTRAINT PK_Tecnico PRIMARY KEY (IdTecnico),
    CONSTRAINT UQ_Tecnico_Cedula UNIQUE (Cedula),
    CONSTRAINT CK_Tecnico_Cedula CHECK (LEN(Cedula) = 9 AND Cedula NOT LIKE '%[^0-9]%'),
    CONSTRAINT CK_Tecnico_Telefono CHECK (LEN(Telefono) = 8 AND Telefono NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE dbo.Equipo (
    IdEquipo   INT IDENTITY(1,1) NOT NULL,
    IdCliente  INT         NOT NULL,
    TipoEquipo VARCHAR(30) NOT NULL,
    Marca      VARCHAR(40) NOT NULL,
    Modelo     VARCHAR(60) NOT NULL,
    CONSTRAINT PK_Equipo PRIMARY KEY (IdEquipo),
    CONSTRAINT FK_Equipo_Cliente FOREIGN KEY (IdCliente) REFERENCES dbo.Cliente (IdCliente),
    CONSTRAINT CK_Equipo_Tipo CHECK (TipoEquipo IN
        ('Laptop','PC de escritorio','Impresora','Celular','Tablet','Red','Otro'))
);
GO

CREATE TABLE dbo.OrdenServicio (
    IdOrden           INT IDENTITY(1,1) NOT NULL,
    IdEquipo          INT           NOT NULL,
    IdTecnico         INT           NOT NULL,
    FechaIngreso      DATETIME      NOT NULL CONSTRAINT DF_Orden_Ingreso DEFAULT GETDATE(),
    FechaEntrega      DATETIME      NULL,
    ProblemaReportado VARCHAR(300)  NOT NULL,
    Estado            VARCHAR(20)   NOT NULL CONSTRAINT DF_Orden_Estado DEFAULT 'Recibido',
    CostoManoObra     DECIMAL(10,2) NOT NULL CONSTRAINT DF_Orden_Costo DEFAULT 0,
    CONSTRAINT PK_OrdenServicio PRIMARY KEY (IdOrden),
    CONSTRAINT FK_Orden_Equipo  FOREIGN KEY (IdEquipo)  REFERENCES dbo.Equipo (IdEquipo),
    CONSTRAINT FK_Orden_Tecnico FOREIGN KEY (IdTecnico) REFERENCES dbo.Tecnico (IdTecnico),
    CONSTRAINT CK_Orden_Estado CHECK (Estado IN ('Recibido','En reparación','Entregado')),
    CONSTRAINT CK_Orden_Costo CHECK (CostoManoObra >= 0),
    CONSTRAINT CK_Orden_Fechas CHECK (FechaEntrega IS NULL OR FechaEntrega >= FechaIngreso)
);
GO

INSERT INTO dbo.Cliente (Cedula, Nombre, Apellidos, Telefono, Correo) VALUES
('108540123', 'María',   'Vargas Mora',    '88451236', 'maria.vargas@example.com'),
('204560789', 'José',    'Araya Quesada',  '87123456', 'jose.araya@example.com'),
('113450987', 'Karla',   'Jiménez Brenes', '83659874', NULL),
('305670234', 'Esteban', 'Rojas Pérez',    '86547123', 'esteban.rojas@example.com'),
('107890456', 'Laura',   'Mora Fallas',    '84561237', 'laura.mora@example.com');

INSERT INTO dbo.Tecnico (Cedula, Nombre, Apellidos, Telefono, Especialidad) VALUES
('112340567', 'Carlos', 'Rojas Núñez', '88001122', 'Hardware y mantenimiento'),
('209870345', 'Andrea', 'Solano Cruz', '87003344', 'Redes y software');

INSERT INTO dbo.Equipo (IdCliente, TipoEquipo, Marca, Modelo) VALUES
(1, 'Laptop',           'HP',       'Pavilion 15'),
(1, 'Impresora',        'Epson',    'L3250'),
(2, 'PC de escritorio', 'Genérica', 'Torre ATX'),
(3, 'Laptop',           'Lenovo',   'IdeaPad 3'),
(4, 'Celular',          'Samsung',  'Galaxy A32'),
(4, 'Red',              'TP-Link',  'Archer C6'),
(5, 'Laptop',           'Dell',     'Inspiron 14');

INSERT INTO dbo.OrdenServicio
    (IdEquipo, IdTecnico, FechaIngreso, FechaEntrega, ProblemaReportado, Estado, CostoManoObra) VALUES
(1, 1, '2026-10-01', '2026-10-03', 'Se apaga por sobrecalentamiento', 'Entregado',     12000.00),
(2, 2, '2026-10-02', NULL,         'No imprime en color',             'En reparación',  8000.00),
(3, 1, '2026-10-05', NULL,         'La PC no enciende',               'En reparación', 10000.00),
(4, 1, '2026-10-06', NULL,         'Pantalla con rayas verticales',   'Recibido',          0.00),
(6, 2, '2026-10-08', '2026-10-09', 'Sin señal Wi-Fi',                 'Entregado',      6000.00),
(7, 1, '2026-10-12', NULL,         'Equipo muy lento',                'En reparación', 15000.00);
GO

SELECT o.IdOrden, c.Nombre + ' ' + c.Apellidos AS Cliente, e.TipoEquipo, e.Marca,
       t.Nombre AS Tecnico, o.Estado, o.CostoManoObra
FROM dbo.OrdenServicio o
JOIN dbo.Equipo  e ON e.IdEquipo  = o.IdEquipo
JOIN dbo.Cliente c ON c.IdCliente = e.IdCliente
JOIN dbo.Tecnico t ON t.IdTecnico = o.IdTecnico;
GO