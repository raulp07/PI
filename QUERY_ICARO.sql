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
iIdPersonal int FOREIGN KEY references PERSONAL(iIdPersonal),
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