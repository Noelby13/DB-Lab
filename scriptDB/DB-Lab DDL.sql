/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      Diagrama ER-Laboratorio.dm1
 *
 * Date Created : Tuesday, June 06, 2023 10:49:29
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: Tbl_ArqueoCaja 
 */

CREATE TABLE Tbl_ArqueoCaja(
    idArqueo         int         IDENTITY(1,1),
    diferencia       float       NULL,
    montoInicial     float       NOT NULL,
    montoFinal       float       NULL,
    fechaApertura    datetime    NULL,
    fechaCierre      datetime    NULL,
    estatus          bit         NOT NULL,
    idUsuario        int         NOT NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (idArqueo)
)
go



IF OBJECT_ID('Tbl_ArqueoCaja') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_ArqueoCaja >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_ArqueoCaja >>>'
go

/* 
 * TABLE: Tbl_Categoria 
 */

CREATE TABLE Tbl_Categoria(
    idCategoria    int              IDENTITY(1,1),
    nombre         nvarchar(150)    NOT NULL,
    descripcion    nvarchar(200)    NOT NULL,
    estado         bit              DEFAULT True NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (idCategoria)
)
go



IF OBJECT_ID('Tbl_Categoria') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Categoria >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Categoria >>>'
go

/* 
 * TABLE: Tbl_Cliente 
 */

CREATE TABLE Tbl_Cliente(
    idPaciente         int              IDENTITY(1,1),
    primerNombre       nvarchar(30)     NOT NULL,
    segundoNombre      nvarchar(50)     NULL,
    primerApellido     nvarchar(30)     NOT NULL,
    segundoApellido    nvarchar(50)     NULL,
    sexo               bit              NOT NULL,
    fechaNacimiento    date             NOT NULL,
    telefono           nvarchar(20)     NULL,
    correo             nvarchar(150)    NULL,
    direccion          nvarchar(400)    NULL,
    cedula             nvarchar(20)     NOT NULL,
    estado             bit              DEFAULT True NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idPaciente)
)
go



IF OBJECT_ID('Tbl_Cliente') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Cliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Cliente >>>'
go

/* 
 * TABLE: Tbl_DetalleFactura 
 */

CREATE TABLE Tbl_DetalleFactura(
    idDetalleFactura    int               IDENTITY(1,1),
    cantidad            int               NULL,
    precioUnitario      decimal(10, 2)    NOT NULL,
    idFactura           int               NOT NULL,
    idExamen            int               NOT NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (idDetalleFactura)
)
go



IF OBJECT_ID('Tbl_DetalleFactura') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_DetalleFactura >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_DetalleFactura >>>'
go

/* 
 * TABLE: Tbl_Doctor 
 */

CREATE TABLE Tbl_Doctor(
    idDoctor           int             IDENTITY(1,1),
    primerNombre       nvarchar(30)    NOT NULL,
    segundoNombre      nvarchar(50)    NULL,
    primerApellido     nvarchar(30)    NOT NULL,
    segundoApellido    nvarchar(50)    NULL,
    estado             bit             DEFAULT True NOT NULL,
    especialidad       nvarchar(50)    NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (idDoctor)
)
go



IF OBJECT_ID('Tbl_Doctor') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Doctor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Doctor >>>'
go

/* 
 * TABLE: Tbl_Empresa 
 */

CREATE TABLE Tbl_Empresa(
    id                  int              IDENTITY(1,1),
    telefono            nvarchar(15)     NULL,
    email               nvarchar(50)     NULL,
    ruc                 nvarchar(14)     NULL,
    logo                image            NULL,
    nombreEmpresa       nvarchar(100)    NULL,
    eslogan             nvarchar(150)    NULL,
    direccionEmpresa    nvarchar(200)    NULL,
    CONSTRAINT PK19 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Tbl_Empresa') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Empresa >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Empresa >>>'
go

/* 
 * TABLE: Tbl_EstadoFactura 
 */

CREATE TABLE Tbl_EstadoFactura(
    idEstadoFactura    int             IDENTITY(1,1),
    estado             nvarchar(20)    NULL,
    CONSTRAINT PK20 PRIMARY KEY NONCLUSTERED (idEstadoFactura)
)
go



IF OBJECT_ID('Tbl_EstadoFactura') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_EstadoFactura >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_EstadoFactura >>>'
go

/* 
 * TABLE: Tbl_Estudio 
 */

CREATE TABLE Tbl_Estudio(
    idEstudio         int              IDENTITY(1,1),
    nombreEstudio     nvarchar(100)    NOT NULL,
    valorInferiorH    float            NULL,
    valorSuperiorH    float            NULL,
    valorTextoH       nvarchar(50)     NULL,
    valorInferiorM    float            NULL,
    valorSuperiorM    float            NULL,
    valorTextoM       nvarchar(50)     NULL,
    estado            bit              NOT NULL,
    idUnidad          int              NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (idEstudio)
)
go



IF OBJECT_ID('Tbl_Estudio') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Estudio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Estudio >>>'
go

/* 
 * TABLE: Tbl_Examen 
 */

CREATE TABLE Tbl_Examen(
    idExamen       int              IDENTITY(1,1),
    Nombre         nvarchar(150)    NOT NULL,
    descripcion    nvarchar(200)    NULL,
    Precio         float            NOT NULL,
    estado         bit              NOT NULL,
    idCategoria    int              NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (idExamen)
)
go



IF OBJECT_ID('Tbl_Examen') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Examen >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Examen >>>'
go

/* 
 * TABLE: Tbl_ExamenEstudio 
 */

CREATE TABLE Tbl_ExamenEstudio(
    idExamenEstudio    int    IDENTITY(1,1),
    idExamen           int    NOT NULL,
    idEstudio          int    NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (idExamenEstudio)
)
go



IF OBJECT_ID('Tbl_ExamenEstudio') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_ExamenEstudio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_ExamenEstudio >>>'
go

/* 
 * TABLE: Tbl_Factura 
 */

CREATE TABLE Tbl_Factura(
    idFactura          int         IDENTITY(1,1),
    total              float       NOT NULL,
    fechaEmision       datetime    NOT NULL,
    idPaciente         int         NOT NULL,
    idUsuario          int         NOT NULL,
    idMetodoPago       int         NULL,
    idDoctor           int         NOT NULL,
    idEstadoFactura    int         NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (idFactura)
)
go



IF OBJECT_ID('Tbl_Factura') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Factura >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Factura >>>'
go

/* 
 * TABLE: Tbl_Funcion 
 */

CREATE TABLE Tbl_Funcion(
    idFuncion        int             IDENTITY(1,1),
    nombreFuncion    nvarchar(50)    NOT NULL,
    CONSTRAINT PK15 PRIMARY KEY NONCLUSTERED (idFuncion)
)
go



IF OBJECT_ID('Tbl_Funcion') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Funcion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Funcion >>>'
go

/* 
 * TABLE: Tbl_MetodoPago 
 */

CREATE TABLE Tbl_MetodoPago(
    idMetodoPago    int              IDENTITY(1,1),
    nombre          nvarchar(100)    NOT NULL,
    CONSTRAINT PK21 PRIMARY KEY NONCLUSTERED (idMetodoPago)
)
go



IF OBJECT_ID('Tbl_MetodoPago') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_MetodoPago >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_MetodoPago >>>'
go

/* 
 * TABLE: Tbl_Resultado 
 */

CREATE TABLE Tbl_Resultado(
    idResultado          int              IDENTITY(1,1),
    resultadoNumerico    float            NULL,
    resultadoTexto       nvarchar(100)    NULL,
    idFactura            int              NOT NULL,
    idEstudio            int              NOT NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (idResultado)
)
go



IF OBJECT_ID('Tbl_Resultado') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Resultado >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Resultado >>>'
go

/* 
 * TABLE: Tbl_Rol 
 */

CREATE TABLE Tbl_Rol(
    idRol          int              IDENTITY(1,1),
    nombre         nvarchar(60)     NOT NULL,
    descripcion    nvarchar(150)    NULL,
    estado         bit              DEFAULT True NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idRol)
)
go



IF OBJECT_ID('Tbl_Rol') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Rol >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Rol >>>'
go

/* 
 * TABLE: Tbl_RolFuncion 
 */

CREATE TABLE Tbl_RolFuncion(
    idRolFuncion    int    IDENTITY(1,1),
    idFuncion       int    NOT NULL,
    idRol           int    NOT NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (idRolFuncion)
)
go



IF OBJECT_ID('Tbl_RolFuncion') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_RolFuncion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_RolFuncion >>>'
go

/* 
 * TABLE: Tbl_Unidad 
 */

CREATE TABLE Tbl_Unidad(
    idUnidad       int              IDENTITY(1,1),
    nombre         nvarchar(20)     NOT NULL,
    descripcion    nvarchar(200)    NULL,
    estado         bit              NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (idUnidad)
)
go



IF OBJECT_ID('Tbl_Unidad') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Unidad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Unidad >>>'
go

/* 
 * TABLE: Tbl_Usuario 
 */

CREATE TABLE Tbl_Usuario(
    idUsuario          int              IDENTITY(1,1),
    primerNombre       nvarchar(30)     NOT NULL,
    segundoNombre      nvarchar(50)     NULL,
    primerApellido     nvarchar(30)     NOT NULL,
    segundoApellido    nvarchar(50)     NULL,
    username           nvarchar(150)    NOT NULL,
    telefono           nvarchar(20)     NOT NULL,
    correo             nvarchar(100)    NULL,
    fechaIngreso       date             NOT NULL,
    cedula             nvarchar(40)     NOT NULL,
    pwd                nvarchar(50)     NOT NULL,
    estado             bit              DEFAULT True NOT NULL,
    idRol              int              NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (idUsuario)
)
go



IF OBJECT_ID('Tbl_Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Tbl_Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tbl_Usuario >>>'
go

/* 
 * TABLE: Tbl_ArqueoCaja 
 */

ALTER TABLE Tbl_ArqueoCaja ADD CONSTRAINT RefTbl_Usuario27 
    FOREIGN KEY (idUsuario)
    REFERENCES Tbl_Usuario(idUsuario)
go


/* 
 * TABLE: Tbl_DetalleFactura 
 */

ALTER TABLE Tbl_DetalleFactura ADD CONSTRAINT RefTbl_Factura14 
    FOREIGN KEY (idFactura)
    REFERENCES Tbl_Factura(idFactura) ON DELETE CASCADE
go

ALTER TABLE Tbl_DetalleFactura ADD CONSTRAINT RefTbl_Examen15 
    FOREIGN KEY (idExamen)
    REFERENCES Tbl_Examen(idExamen)
go


/* 
 * TABLE: Tbl_Estudio 
 */

ALTER TABLE Tbl_Estudio ADD CONSTRAINT RefTbl_Unidad22 
    FOREIGN KEY (idUnidad)
    REFERENCES Tbl_Unidad(idUnidad)
go


/* 
 * TABLE: Tbl_Examen 
 */

ALTER TABLE Tbl_Examen ADD CONSTRAINT RefTbl_Categoria18 
    FOREIGN KEY (idCategoria)
    REFERENCES Tbl_Categoria(idCategoria)
go


/* 
 * TABLE: Tbl_ExamenEstudio 
 */

ALTER TABLE Tbl_ExamenEstudio ADD CONSTRAINT RefTbl_Examen16 
    FOREIGN KEY (idExamen)
    REFERENCES Tbl_Examen(idExamen)
go

ALTER TABLE Tbl_ExamenEstudio ADD CONSTRAINT RefTbl_Estudio17 
    FOREIGN KEY (idEstudio)
    REFERENCES Tbl_Estudio(idEstudio)
go


/* 
 * TABLE: Tbl_Factura 
 */

ALTER TABLE Tbl_Factura ADD CONSTRAINT RefTbl_Cliente10 
    FOREIGN KEY (idPaciente)
    REFERENCES Tbl_Cliente(idPaciente)
go

ALTER TABLE Tbl_Factura ADD CONSTRAINT RefTbl_Usuario11 
    FOREIGN KEY (idUsuario)
    REFERENCES Tbl_Usuario(idUsuario)
go

ALTER TABLE Tbl_Factura ADD CONSTRAINT RefTbl_Doctor13 
    FOREIGN KEY (idDoctor)
    REFERENCES Tbl_Doctor(idDoctor)
go

ALTER TABLE Tbl_Factura ADD CONSTRAINT RefTbl_EstadoFactura28 
    FOREIGN KEY (idEstadoFactura)
    REFERENCES Tbl_EstadoFactura(idEstadoFactura)
go

ALTER TABLE Tbl_Factura ADD CONSTRAINT RefTbl_MetodoPago29 
    FOREIGN KEY (idMetodoPago)
    REFERENCES Tbl_MetodoPago(idMetodoPago)
go


/* 
 * TABLE: Tbl_Resultado 
 */

ALTER TABLE Tbl_Resultado ADD CONSTRAINT RefTbl_Factura19 
    FOREIGN KEY (idFactura)
    REFERENCES Tbl_Factura(idFactura) ON DELETE CASCADE
go

ALTER TABLE Tbl_Resultado ADD CONSTRAINT RefTbl_Estudio23 
    FOREIGN KEY (idEstudio)
    REFERENCES Tbl_Estudio(idEstudio)
go


/* 
 * TABLE: Tbl_RolFuncion 
 */

ALTER TABLE Tbl_RolFuncion ADD CONSTRAINT RefTbl_Funcion25 
    FOREIGN KEY (idFuncion)
    REFERENCES Tbl_Funcion(idFuncion)
go

ALTER TABLE Tbl_RolFuncion ADD CONSTRAINT RefTbl_Rol26 
    FOREIGN KEY (idRol)
    REFERENCES Tbl_Rol(idRol)
go


/* 
 * TABLE: Tbl_Usuario 
 */

ALTER TABLE Tbl_Usuario ADD CONSTRAINT RefTbl_Rol21 
    FOREIGN KEY (idRol)
    REFERENCES Tbl_Rol(idRol)
go


