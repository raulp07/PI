create  database BDICARO
GO
use BDICARO
go


CREATE TABLE ESTADO
(
iIDEstado int primary key identity,
vNombre varchar(100),
vGrupo varchar(100)
)
go

CREATE TABLE UBIGEO (
vCodDpto varchar(2)  ,
vCodProv varchar(2) ,
vCodDist varchar(2) ,
vNombre varchar(36) 
) 

go

CREATE TABLE CAPACITACION 
(
iIdCapacitacion int identity primary key,
vCodCapacitacion AS 'C' + RIGHT('000000' + CAST(iIdCapacitacion AS VARCHAR(10)), 6) PERSISTED,
vTemaCapacitacion varchar(250),
dFechaPropuestaCapacitacion date,
iEstadoCapactiacion int,
iEstadoComunicacionCapacitacion int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go
ALTER TABLE CAPACITACION ADD Longitud numeric(25,23) , Latitud numeric(25,23)  
go

CREATE TABLE PROVEEDOR
(
iIdProveedor int primary key identity,
vNombreProveedor varchar(200),
vRUC varchar(20),
vTelefono varchar(20),
vNroLicenciaMunicipal varchar(50),
vNroInspeccionSanitaria varchar(50),
iEstadoEmpresa int,
iTipoEmpresa int,
iUbigeo int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

go
CREATE TABLE REPRESENTANTE
(
iIdRepresentante int primary key identity,
iIdProveedor int FOREIGN KEY references PROVEEDOR(iIdProveedor),
vNombreRepresentante varchar(200),
vApellidoPaternoRepresentante varchar(200),
vApellidoMaternoRepresentante varchar(200),
cDNI char(8),
vCelular varchar(20),
iTipoRepresentante int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go

CREATE TABLE GESTION_CAPACITACION
(
iIdGestionCapacitacion int primary key identity,
iIdCapacitacion int FOREIGN KEY references CAPACITACION(iIdCapacitacion),
iIdRepresentante int,
dFechaRealizacionCapacitacion date,
tHoraInicio time,
tHoraFin time,
iTiempoTest int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go
CREATE TABLE TEST
(
iIdTest int primary key identity,
iIdGestorCapacitacion int FOREIGN KEY references GESTION_CAPACITACION(iIdGestionCapacitacion),
vDescricionTest varchar(MAX),
dFechaTest date,
iEstadoTest int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

go

CREATE TABLE PREGUNTA
(
iIdPregunta int primary key identity,
iIdTest int FOREIGN KEY references TEST(iIdTest),
vEnunciadoPregunta varchar(MAX),
iPuntajePregunta int,
iTipoRespuestaPregunta int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go

CREATE TABLE OPCION_PREGUNTA
(
iIdOpcion int primary key identity,
iIdPregunta int FOREIGN KEY references PREGUNTA(iIdPregunta),
vEnunciadoOpcion varchar(150),
iEstadoOpcion int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go

CREATE TABLE PERSONAL
(
iIdPersonal int primary key identity,
vCodPersonal AS 'P' + RIGHT('000000' + CAST(iIdPersonal AS VARCHAR(10)), 6) PERSISTED,
vNombrePersonal varchar(200),
vApellidoPaternoPersonal varchar(200),
vApellidoMaternoPersonal varchar(200),
cDNI char(8),
dFechaNacimiento date,
vDomicilio varchar(MAX),
iIdArea int,
iUbigeo int,
iTipoPersonal int,
iEstadoPersonal int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
GO

CREATE TABLE CAPACITACION_PERSONAL
(
iIdCapacitacionPersonal int primary key identity,
iIdPersonal int,-- FOREIGN KEY references PERSONAL(iIdPersonal),
iIdCapacitacion int FOREIGN KEY references CAPACITACION(iIdCapacitacion),
iPuntajePersonal int,
vObservacionPersonal varchar(MAX),
iAsistenciaPersonal int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go

CREATE TABLE DETALLE_CAPACITACION_PERSONAL
(
iIdDetalleCapacitacionPersonal int identity primary key ,
iIdCapacitacionPersonal int FOREIGN KEY references CAPACITACION_PERSONAL(iIdCapacitacionPersonal),
iIdPregunta int FOREIGN KEY references PREGUNTA(iIdPregunta),
iIdOpcion int FOREIGN KEY references OPCION_PREGUNTA(iIdOpcion),
iEstadoRespuesta int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go



CREATE TABLE EVALUACION_PROVEEDOR
(
iIdEvaluacionProveedor int primary key identity,
iIdProveedor int FOREIGN KEY references PROVEEDOR(iIdProveedor),
iCalidadProducto int,
iPrecio int,
iCondiciones int,
dFechaEvaluacion date,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

go

CREATE TABLE MATERIA_PRIMA
(
iIdMateriaPrima int primary key identity,
vCodMateriaPrima AS 'MP' + RIGHT('000000' + CAST(iIdMateriaPrima AS VARCHAR(10)), 6) PERSISTED,
vNombreMateriaPrima varchar(200),
vDescripcionMateriaPrima varchar(MAX),
iOlorCS int,
iColorCS int,
iSaborCS int,
iTexturaCS int,
iBrixRF int,
iPHRF int,
iAcidesRF int,
vRequisitosMicrobiolicos varchar(300),
vRequisitoRotulado varchar(300),
vRequisitosEmpaquetado varchar(300),
vRequisitosPresentacion varchar(300),
vCondicionFisicaEntrega varchar(300),
vCondicionFisicaAlmacenamiento varchar(300),
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

go

CREATE TABLE EVALUACIONPROVEEDORPREGUNTA
(
iIdEvaluacionProveedorPregunta int primary key identity,
iIdEvaluacionProveedor int FOREIGN KEY references EVALUACION_PROVEEDOR(iIdEvaluacionProveedor),
iIdMateriaPrima int FOREIGN KEY references MATERIA_PRIMA(iIdMateriaPrima),
vObservacion varchar(MAX),
dFecha date,
iPuntajeTotal int,
iPorcentajeCumplimiento int,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
go

--tablas nuevas



CREATE TABLE RECEPCIONMATERIAPRIMA
(
idRecepcionMateriaPrima int primary key identity,
idMateriaPrima int FOREIGN KEY references MATERIA_PRIMA(iIdMateriaPrima),
idProveedor int Foreign key references PROVEEDOR(iIdProveedor) ,
guiaRemision varchar(MAX),
fechaSolicitada datetime,
fechaRecepcionSolicitada datetime,
loteMateriaPrima varchar(MAX),
unidadDeMedida varchar(MAX),
pesoPermitido int,
fechaVencimiento datetime,
mermaMateriaPrima int,
pesoRealMateriaPrima int
)
go


CREATE TABLE ENTRADASALIDAMATERIAPRIMA
(
idEntradaSalidaMateriaPrima int primary key identity,
idMateriaPrima int FOREIGN KEY references MATERIA_PRIMA(iIdMateriaPrima),
idProveedor int Foreign key references PROVEEDOR(iIdProveedor),
fecha datetime,
loteMateriaPrima varchar(MAX),
fechaVencimiento datetime,
unidadDeMedida varchar(MAX),
stockInicial int,
ingreso int,
despacho int,
stockFinal int
)
go

CREATE TABLE CONTROLPRODUCCION
(
idProducto int primary key identity,
fechaProduccion datetime,
cantidadProducida int,
idActividadControlProduccion int,
)
go

CREATE TABLE ACTIVIDADCONTROLPRODUCCION
(
idactividadControlProduccion int primary key identity,
tiempoInicialPesado datetime,
tiempoFinalPesado datetime,
tiempoInicialMezclado1 datetime,
tiempoFinalMezclado1 datetime,
tiempoInicialMezclado2 datetime,
tiempoFinalMezclado2 datetime,
tiempoInicialMezclado3 datetime,
tiempoFinalMezclado3 datetime,
tiempoInicialReposo datetime,
tiempoFinalReposo datetime,
tiempoInicialFiltrado datetime,
tiempoFinalFiltrado datetime,
tiempoInicialLlenado datetime,
tiempoFinalLlenado datetime,
tiempoInicialEncajonado datetime,
tiempoFinalEncajonado datetime
)
go

--------------------------------------------------------------
------- TABLAS PARA REGISTRO DEL HISTORICO DE PRONOSTICO -----
--------------------------------------------------------------


CREATE TABLE PRONOSTICO
(
idPronostico int primary key identity,
tipoPronostico varchar(MAX),
idProveedor int Foreign key references PROVEEDOR(iIdProveedor),
idProducto int,
idInsumo int,
idActividadProduccion int,
cantidad int,
unidadDeMedida varchar(MAX) 
)

-- Tablas Producto Detalle

go

CREATE TABLE PROVEEDOR_MATERIAPRIMA
(
iIdProveedor int Foreign key references PROVEEDOR(iIdProveedor),
iIdMateriaPrima int FOREIGN KEY references MATERIA_PRIMA(iIdMateriaPrima),
dFechaEvaluacion datetime,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

GO

CREATE TABLE PRODUCTO
(
iIdproducto int primary key identity,
vCodproducto AS 'PR' + RIGHT('000000' + CAST(iIdproducto AS VARCHAR(10)), 6) PERSISTED,
vNombreProducto varchar(MAX),
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)

GO

CREATE TABLE PRODUCTO_MATERIAPRIMA
(
iIdproducto int Foreign key references PRODUCTO(iIdproducto),
iIdMateriaPrima int FOREIGN KEY references MATERIA_PRIMA(iIdMateriaPrima),
dFechaEvaluacion datetime,
iUsuarioCrea int,
dFechaCrea datetime,
iUsuarioMod int,
dFechaMod datetime
)
