

IF OBJECT_ID ( 'spGet_CAPACITACION', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_CAPACITACION;  
Go
CREATE PROCEDURE [spGet_CAPACITACION]
@iIdCapacitacion int = 0
AS
BEGIN
SELECT *
FROM
CAPACITACION
where (iIdCapacitacion = @iIdCapacitacion OR 0 = @iIdCapacitacion)
END

GO

/* ===================  Gestion Capacitacion ============================*/
IF OBJECT_ID ( 'spGet_GESTION_CAPACITACION', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_GESTION_CAPACITACION  
Go
CREATE PROCEDURE [spGet_GESTION_CAPACITACION]
@iIdGestionCapacitacion int =0
AS
BEGIN
SELECT *
FROM
GESTION_CAPACITACION
where (iIdGestionCapacitacion = @iIdGestionCapacitacion OR 0 = @iIdGestionCapacitacion)
END
GO
IF OBJECT_ID ( 'spInsertGESTION_CAPACITACION', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertGESTION_CAPACITACION  
GO  
CREATE PROCEDURE [spInsertGESTION_CAPACITACION]

@iIdCapacitacion int,
@iIdRepresentante int,
@dFechaRealizacionCapacitacion date,
@tHoraInicio time,
@tHoraFin time,
@iTiempoTest int,
@iUsuarioCrea int,
@nLatitud numeric(25,23),
@nLongitud numeric(25,23)
AS
BEGIN

update capacitacion set Latitud = @nLatitud,
						Longitud = @nLongitud
		where iIdCapacitacion = @iIdCapacitacion

INSERT INTO 
GESTION_CAPACITACION(
iIdCapacitacion,
iIdRepresentante,
dFechaRealizacionCapacitacion,
tHoraInicio,
tHoraFin,
iTiempoTest,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdCapacitacion,
@iIdRepresentante,
@dFechaRealizacionCapacitacion,
@tHoraInicio,
@tHoraFin,
@iTiempoTest,
@iUsuarioCrea,
GETDATE()
)


declare @iIdGestionCapacitacion int = @@IDENTITY

EXECUTE [dbo].[spInsertTEST] @iIdGestionCapacitacion,'',@dFechaRealizacionCapacitacion,1,1

END
GO

IF OBJECT_ID ( 'spUpdateGESTION_CAPACITACION', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateGESTION_CAPACITACION  
GO  
CREATE PROCEDURE [spUpdateGESTION_CAPACITACION]
@iIdGestionCapacitacion int,
@iIdCapacitacion int,
@iIdRepresentante int,
@dFechaRealizacionCapacitacion date,
@tHoraInicio time,
@tHoraFin time,
@iTiempoTest int,
@iUsuarioMod int
AS
BEGIN
UPDATE
GESTION_CAPACITACION
SET
iIdCapacitacion = @iIdCapacitacion,
iIdRepresentante = @iIdRepresentante,
dFechaRealizacionCapacitacion = @dFechaRealizacionCapacitacion,
tHoraInicio = @tHoraInicio,
tHoraFin = @tHoraFin,
iTiempoTest = @iTiempoTest,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdGestionCapacitacion = @iIdGestionCapacitacion
END



/*  ================================================================= */


/* ===================  Proveedor ============================*/
Go
IF OBJECT_ID ( 'spGet_PROVEEDOR', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_PROVEEDOR  
GO  

CREATE PROCEDURE [spGet_PROVEEDOR]
@iIdProveedor int =0
AS
BEGIN
SELECT *
FROM
PROVEEDOR
where (iIdProveedor = @iIdProveedor or @iIdProveedor=0) 
END


/*  ================================================================= */

/* ===================  Representante ============================*/


Go
IF OBJECT_ID ( 'spGet_REPRESENTANTE', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_REPRESENTANTE  
GO  
CREATE PROCEDURE [spGet_REPRESENTANTE]
@iIdRepresentante int =0
AS
BEGIN
SELECT *
FROM
REPRESENTANTE
where (iIdRepresentante = @iIdRepresentante or @iIdRepresentante=0)
END

GO
IF OBJECT_ID ( 'spInsertREPRESENTANTE', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertREPRESENTANTE  
GO 
CREATE PROCEDURE [spInsertREPRESENTANTE]
@iIdProveedor int,
@vNombreRepresentante varchar(200),
@vApellidoPaternoRepresentante varchar(200),
@vApellidoMaternoRepresentante varchar(200),
@cDNI char(8),
@vCelular varchar(20),
@iTipoRepresentante int,
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
REPRESENTANTE(
iIdProveedor,
vNombreRepresentante,
vApellidoPaternoRepresentante,
vApellidoMaternoRepresentante,
cDNI,
vCelular,
iTipoRepresentante,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdProveedor,
@vNombreRepresentante,
@vApellidoPaternoRepresentante,
@vApellidoMaternoRepresentante,
@cDNI,
@vCelular,
@iTipoRepresentante,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateREPRESENTANTE', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateREPRESENTANTE  
GO 
CREATE PROCEDURE [spUpdateREPRESENTANTE]

@iIdRepresentante int,
@iIdProveedor int,
@vNombreRepresentante varchar(200),
@vApellidoPaternoRepresentante varchar(200),
@vApellidoMaternoRepresentante varchar(200),
@cDNI char(8),
@vCelular varchar(20),
@iTipoRepresentante int,
@iUsuarioMod int
AS
BEGIN
UPDATE
REPRESENTANTE
SET
iIdProveedor = @iIdProveedor,
vNombreRepresentante = @vNombreRepresentante,
vApellidoPaternoRepresentante = @vApellidoPaternoRepresentante,
vApellidoMaternoRepresentante = @vApellidoMaternoRepresentante,
cDNI = @cDNI,
vCelular = @vCelular,
iTipoRepresentante = @iTipoRepresentante,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdRepresentante = @iIdRepresentante
END

/*  ================================================================= */




/* ===================  test ============================*/

Go
IF OBJECT_ID ( 'spGet_TEST', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_TEST  
GO 
CREATE PROCEDURE [spGet_TEST]
@iIdTest int =0 
AS
BEGIN
SELECT *
FROM
TEST
where (iIdTest = @iIdTest or @iIdTest=0)
END


GO
IF OBJECT_ID ( 'spInsertTEST', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertTEST  
GO 
CREATE PROCEDURE [spInsertTEST]
@iIdGestorCapacitacion int,
@vDescricionTest varchar(max),
@dFechaTest date,
@iEstadoTest int,
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
TEST(
iIdGestorCapacitacion,
vDescricionTest,
dFechaTest,
iEstadoTest,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdGestorCapacitacion,
@vDescricionTest,
@dFechaTest,
@iEstadoTest,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateTEST', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateTEST  
GO 
CREATE PROCEDURE [spUpdateTEST]
@iIdTest int,
@iIdGestorCapacitacion int,
@vDescricionTest varchar(max),
@dFechaTest date,
@iEstadoTest int,
@iUsuarioMod int
AS
BEGIN
UPDATE
TEST
SET
iIdGestorCapacitacion = @iIdGestorCapacitacion,
vDescricionTest = @vDescricionTest,
dFechaTest = @dFechaTest,
iEstadoTest = @iEstadoTest,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdTest = @iIdTest
END

/*  ================================================================= */

/* ===================  Gestion Pregunta ============================*/
Go
IF OBJECT_ID ( 'spGet_PREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_PREGUNTA  
GO 
CREATE PROCEDURE [spGet_PREGUNTA]
@iIdPregunta int =0
AS
BEGIN

declare @hora_Actual time
declare @idGestionCapatacion int
declare @idtest int
declare @tiempoTest int

set @hora_Actual = (select convert(char(8), getdate(), 108) )


select @idGestionCapatacion = gp.iIdGestionCapacitacion, @tiempoTest = gp.iTiempoTest from GESTION_CAPACITACION gp
where (@hora_Actual between gp.tHoraInicio and gp.tHoraFin ) and CONVERT(date, gp.dFechaRealizacionCapacitacion, 112) = CONVERT(date, GETDATE(), 112)

set @idtest = (select t.iIdTest from TEST t where t.iIdGestorCapacitacion = @idGestionCapatacion)

SELECT p.iIdPregunta,p.iIdTest,p.vEnunciadoPregunta,p.iPuntajePregunta,p.iTipoRespuestaPregunta, @tiempoTest as 'iUsuarioCrea',p.dFechaCrea,p.iUsuarioMod,p.dFechaMod
FROM
PREGUNTA p
where (iIdPregunta = @iIdPregunta or @iIdPregunta=0)
and iIdTest = @idtest
END


GO
IF OBJECT_ID ( 'spInsertPREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertPREGUNTA  
GO
CREATE PROCEDURE [spInsertPREGUNTA]
@iIdTest int,
@vEnunciadoPregunta varchar(max),
@iPuntajePregunta int,
@iTipoRespuestaPregunta int,
@iUsuarioCrea int
AS
BEGIN

set @iIdTest = (select max(iIdTest) from TEST)

INSERT INTO 
PREGUNTA(
iIdTest,
vEnunciadoPregunta,
iPuntajePregunta,
iTipoRespuestaPregunta,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdTest,
@vEnunciadoPregunta,
@iPuntajePregunta,
@iTipoRespuestaPregunta,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdatePREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdatePREGUNTA  
GO
CREATE PROCEDURE [spUpdatePREGUNTA]
@iIdPregunta int,
@iIdTest int,
@vEnunciadoPregunta varchar(max),
@iPuntajePregunta int,
@iTipoRespuestaPregunta int,
@iUsuarioMod int
AS
BEGIN
UPDATE
PREGUNTA
SET
iIdTest = @iIdTest,
vEnunciadoPregunta = @vEnunciadoPregunta,
iPuntajePregunta = @iPuntajePregunta,
iTipoRespuestaPregunta = @iTipoRespuestaPregunta,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdPregunta = @iIdPregunta
END
/*  ================================================================= */



/* ===================  Gestion Opcion Pregunta ============================*/

Go
IF OBJECT_ID ( 'spGet_OPCION_PREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_OPCION_PREGUNTA  
GO
CREATE PROCEDURE [spGet_OPCION_PREGUNTA]
@iIdOpcion int =0
AS
BEGIN
SELECT *
FROM
OPCION_PREGUNTA
where (iIdOpcion = @iIdOpcion or @iIdOpcion=0)
END

GO
IF OBJECT_ID ( 'spInsertOPCION_PREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertOPCION_PREGUNTA  
GO
CREATE PROCEDURE [spInsertOPCION_PREGUNTA]
@iIdPregunta int,
@vEnunciadoOpcion varchar(150),
@iEstadoOpcion int,
@iUsuarioCrea int
AS
BEGIN

set @iIdPregunta = (select max(iIdPregunta) from PREGUNTA)

INSERT INTO 
OPCION_PREGUNTA(
iIdPregunta,
vEnunciadoOpcion,
iEstadoOpcion,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdPregunta,
@vEnunciadoOpcion,
@iEstadoOpcion,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateOPCION_PREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateOPCION_PREGUNTA  
GO
CREATE PROCEDURE [spUpdateOPCION_PREGUNTA]
@iIdOpcion int,
@iIdPregunta int,
@vEnunciadoOpcion varchar(150),
@iEstadoOpcion int,
@iUsuarioMod int
AS
BEGIN
UPDATE
OPCION_PREGUNTA
SET
iIdPregunta = @iIdPregunta,
vEnunciadoOpcion = @vEnunciadoOpcion,
iEstadoOpcion = @iEstadoOpcion,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdOpcion = @iIdOpcion
END
/*  ================================================================= */


/* ===================  Gestion Personal ============================*/

Go
IF OBJECT_ID ( 'spGet_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_PERSONAL  
GO
CREATE PROCEDURE [spGet_PERSONAL]
@iIdPersonal int =0
AS
BEGIN
SELECT *
FROM
PERSONAL
where (iIdPersonal = @iIdPersonal or @iIdPersonal=0)
END

GO
IF OBJECT_ID ( 'spInsertPERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertPERSONAL  
GO
CREATE PROCEDURE [spInsertPERSONAL]
@vCodPersonal varchar(15),
@vNombrePersonal varchar(200),
@vApellidoPaternoPersonal varchar(200),
@vApellidoMaternoPersonal varchar(200),
@cDNI char(8),
@dFechaNacimiento date,
@vDomicilio varchar(max),
@iIdArea int,
@iUbigeo int,
@iTipoPersonal int,
@iEstadoPersonal int,
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
PERSONAL(
vNombrePersonal,
vApellidoPaternoPersonal,
vApellidoMaternoPersonal,
cDNI,
dFechaNacimiento,
vDomicilio,
iIdArea,
iUbigeo,
iTipoPersonal,
iEstadoPersonal,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@vNombrePersonal,
@vApellidoPaternoPersonal,
@vApellidoMaternoPersonal,
@cDNI,
@dFechaNacimiento,
@vDomicilio,
@iIdArea,
@iUbigeo,
@iTipoPersonal,
@iEstadoPersonal,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdatePERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdatePERSONAL  
GO
CREATE PROCEDURE [spUpdatePERSONAL]
@iIdPersonal int,
@vCodPersonal varchar(15),
@vNombrePersonal varchar(200),
@vApellidoPaternoPersonal varchar(200),
@vApellidoMaternoPersonal varchar(200),
@cDNI char(8),
@dFechaNacimiento date,
@vDomicilio varchar(max),
@iIdArea int,
@iUbigeo int,
@iTipoPersonal int,
@iEstadoPersonal int,
@iUsuarioMod int
AS
BEGIN
UPDATE
PERSONAL
SET
vNombrePersonal = @vNombrePersonal,
vApellidoPaternoPersonal = @vApellidoPaternoPersonal,
vApellidoMaternoPersonal = @vApellidoMaternoPersonal,
cDNI = @cDNI,
dFechaNacimiento = @dFechaNacimiento,
vDomicilio = @vDomicilio,
iIdArea = @iIdArea,
iUbigeo = @iUbigeo,
iTipoPersonal = @iTipoPersonal,
iEstadoPersonal = @iEstadoPersonal,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdPersonal = @iIdPersonal
END
/*  ================================================================= */


/* ===================  Gestion Personal ============================*/

Go
IF OBJECT_ID ( 'spGet_EVALUACION_PROVEEDOR', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_EVALUACION_PROVEEDOR  
GO
CREATE PROCEDURE [spGet_EVALUACION_PROVEEDOR]
@iIdEvaluacionProveedor int =0
AS
BEGIN
SELECT *
FROM
EVALUACION_PROVEEDOR
where (iIdEvaluacionProveedor = @iIdEvaluacionProveedor or @iIdEvaluacionProveedor=0)
END


GO
IF OBJECT_ID ( 'spInsertEVALUACION_PROVEEDOR', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertEVALUACION_PROVEEDOR  
GO
CREATE PROCEDURE [spInsertEVALUACION_PROVEEDOR]
@iIdProveedor int,
@iCalidadProducto int,
@iPrecio int,
@iCondiciones int,
@dFechaEvaluacion date,
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
EVALUACION_PROVEEDOR(
iIdProveedor,
iCalidadProducto,
iPrecio,
iCondiciones,
dFechaEvaluacion,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdProveedor,
@iCalidadProducto,
@iPrecio,
@iCondiciones,
@dFechaEvaluacion,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateEVALUACION_PROVEEDOR', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateEVALUACION_PROVEEDOR  
GO
CREATE PROCEDURE [spUpdateEVALUACION_PROVEEDOR]
@iIdEvaluacionProveedor int,
@iIdProveedor int,
@iCalidadProducto int,
@iPrecio int,
@iCondiciones int,
@dFechaEvaluacion date,
@iUsuarioMod int
AS
BEGIN
UPDATE
EVALUACION_PROVEEDOR
SET
iIdProveedor = @iIdProveedor,
iCalidadProducto = @iCalidadProducto,
iPrecio = @iPrecio,
iCondiciones = @iCondiciones,
dFechaEvaluacion = @dFechaEvaluacion,
iUsuarioMod = @iUsuarioMod,
dFechaMod = GETDATE()
WHERE
iIdEvaluacionProveedor = @iIdEvaluacionProveedor
END
/*  ================================================================= */




/* ===================  Gestion Materia Prima ============================*/

Go
IF OBJECT_ID ( 'spGet_MATERIA_PRIMA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_MATERIA_PRIMA  
GO
CREATE PROCEDURE [spGet_MATERIA_PRIMA]
@iIdMateriaPrima int =0
AS
BEGIN
SELECT *
FROM
MATERIA_PRIMA
where (iIdMateriaPrima = @iIdMateriaPrima or @iIdMateriaPrima=0)
END

GO
IF OBJECT_ID ( 'spInsertMATERIA_PRIMA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertMATERIA_PRIMA  
GO
CREATE PROCEDURE [spInsertMATERIA_PRIMA]
@vCodMateriaPrima varchar(15),
@vNombreMateriaPrima varchar(200),
@vDescripcionMateriaPrima varchar(max),
@iOlorCS int,
@iColorCS int,
@iSaborCS int,
@iTexturaCS int,
@iBrixRF int,
@iPHRF int,
@iAcidesRF int,
@vRequisitosMicrobiolicos varchar(300),
@vRequisitoRotulado varchar(300),
@vRequisitosEmpaquetado varchar(300),
@vRequisitosPresentacion varchar(300),
@vCondicionFisicaEntrega varchar(300),
@vCondicionFisicaAlmacenamiento varchar(300),
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
MATERIA_PRIMA(
vNombreMateriaPrima,
vDescripcionMateriaPrima,
iOlorCS,
iColorCS,
iSaborCS,
iTexturaCS,
iBrixRF,
iPHRF,
iAcidesRF,
vRequisitosMicrobiolicos,
vRequisitoRotulado,
vRequisitosEmpaquetado,
vRequisitosPresentacion,
vCondicionFisicaEntrega,
vCondicionFisicaAlmacenamiento,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@vNombreMateriaPrima,
@vDescripcionMateriaPrima,
@iOlorCS,
@iColorCS,
@iSaborCS,
@iTexturaCS,
@iBrixRF,
@iPHRF,
@iAcidesRF,
@vRequisitosMicrobiolicos,
@vRequisitoRotulado,
@vRequisitosEmpaquetado,
@vRequisitosPresentacion,
@vCondicionFisicaEntrega,
@vCondicionFisicaAlmacenamiento,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateMATERIA_PRIMA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateMATERIA_PRIMA  
GO
CREATE PROCEDURE [spUpdateMATERIA_PRIMA]
@iIdMateriaPrima int,
@vCodMateriaPrima varchar(15),
@vNombreMateriaPrima varchar(200),
@vDescripcionMateriaPrima varchar(max),
@iOlorCS int,
@iColorCS int,
@iSaborCS int,
@iTexturaCS int,
@iBrixRF int,
@iPHRF int,
@iAcidesRF int,
@vRequisitosMicrobiolicos varchar(300),
@vRequisitoRotulado varchar(300),
@vRequisitosEmpaquetado varchar(300),
@vRequisitosPresentacion varchar(300),
@vCondicionFisicaEntrega varchar(300),
@vCondicionFisicaAlmacenamiento varchar(300),
@iUsuarioMod int
AS
BEGIN
UPDATE
MATERIA_PRIMA
SET
vNombreMateriaPrima = @vNombreMateriaPrima,
vDescripcionMateriaPrima = @vDescripcionMateriaPrima,
iOlorCS = @iOlorCS,
iColorCS = @iColorCS,
iSaborCS = @iSaborCS,
iTexturaCS = @iTexturaCS,
iBrixRF = @iBrixRF,
iPHRF = @iPHRF,
iAcidesRF = @iAcidesRF,
vRequisitosMicrobiolicos = @vRequisitosMicrobiolicos,
vRequisitoRotulado = @vRequisitoRotulado,
vRequisitosEmpaquetado = @vRequisitosEmpaquetado,
vRequisitosPresentacion = @vRequisitosPresentacion,
vCondicionFisicaEntrega = @vCondicionFisicaEntrega,
vCondicionFisicaAlmacenamiento = @vCondicionFisicaAlmacenamiento,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdMateriaPrima = @iIdMateriaPrima
END
/*  ================================================================= */


/* ===================  Gestion Materia Prima ============================*/

Go
IF OBJECT_ID ( 'spGet_EVALUACIONPROVEEDORPREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_EVALUACIONPROVEEDORPREGUNTA  
GO
CREATE PROCEDURE [spGet_EVALUACIONPROVEEDORPREGUNTA]
@iIdEvaluacionProveedorPregunta int =0
AS
BEGIN
SELECT *
FROM
EVALUACIONPROVEEDORPREGUNTA
where (iIdEvaluacionProveedorPregunta = @iIdEvaluacionProveedorPregunta or @iIdEvaluacionProveedorPregunta=0)
END

GO
IF OBJECT_ID ( 'spInsertEVALUACIONPROVEEDORPREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertEVALUACIONPROVEEDORPREGUNTA  
GO
CREATE PROCEDURE [spInsertEVALUACIONPROVEEDORPREGUNTA]
@iIdEvaluacionProveedor int,
@iIdMateriaPrima int,
@vObservacion varchar(max),
@dFecha date,
@iPuntajeTotal int,
@iPorcentajeCumplimiento int,
@iUsuarioCrea int
AS
BEGIN
INSERT INTO 
EVALUACIONPROVEEDORPREGUNTA(
iIdEvaluacionProveedor,
iIdMateriaPrima,
vObservacion,
dFecha,
iPuntajeTotal,
iPorcentajeCumplimiento,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdEvaluacionProveedor,
@iIdMateriaPrima,
@vObservacion,
@dFecha,
@iPuntajeTotal,
@iPorcentajeCumplimiento,
@iUsuarioCrea,
GETDATE()
)
END

GO
IF OBJECT_ID ( 'spUpdateEVALUACIONPROVEEDORPREGUNTA', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateEVALUACIONPROVEEDORPREGUNTA  
GO
CREATE PROCEDURE [spUpdateEVALUACIONPROVEEDORPREGUNTA]
@iIdEvaluacionProveedorPregunta int,
@iIdEvaluacionProveedor int,
@iIdMateriaPrima int,
@vObservacion varchar(max),
@dFecha date,
@iPuntajeTotal int,
@iPorcentajeCumplimiento int,
@iUsuarioMod int
AS
BEGIN
UPDATE
EVALUACIONPROVEEDORPREGUNTA
SET
iIdEvaluacionProveedor = @iIdEvaluacionProveedor,
iIdMateriaPrima = @iIdMateriaPrima,
vObservacion = @vObservacion,
dFecha = @dFecha,
iPuntajeTotal = @iPuntajeTotal,
iPorcentajeCumplimiento = @iPorcentajeCumplimiento,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdEvaluacionProveedorPregunta = @iIdEvaluacionProveedorPregunta
END
/*  ================================================================= */


/* ===================  UBIGEO ============================*/

Go
IF OBJECT_ID ( 'spGetUBIGEOAll', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGetUBIGEOAll  
GO
CREATE PROCEDURE [spGetUBIGEOAll]
@vCodDpto INT=0,
@vCodProv INT =0,
@vCodDist INT =0
AS
BEGIN
SELECT *
FROM
UBIGEO
END

/*  ================================================================= */

/* ===================  CAPACITACION PERSONAL ============================*/


Go
IF OBJECT_ID ( 'spGet_CAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGet_CAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spGet_CAPACITACION_PERSONAL]
@iIdCapacitacionPersonal INT =0 
AS
BEGIN
SELECT *
FROM
CAPACITACION_PERSONAL
where (iIdCapacitacionPersonal = @iIdCapacitacionPersonal or @iIdCapacitacionPersonal = 0)
END

GO
IF OBJECT_ID ( 'spInsertCAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertCAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spInsertCAPACITACION_PERSONAL]
@iIdPersonal int,
@iIdCapacitacion int,
@iPuntajePersonal int,
@vObservacionPersonal varchar(max),
@iAsistenciaPersonal int,
@iUsuarioCrea int
AS
BEGIN



declare @hora_Actual time
declare @idtest int
declare @tiempoTest int

set @hora_Actual = (select convert(char(8), getdate(), 108) )
set @iIdCapacitacion = (select  gp.iIdCapacitacion from GESTION_CAPACITACION gp
where (@hora_Actual between gp.tHoraInicio and gp.tHoraFin ) and 
CONVERT(date, gp.dFechaRealizacionCapacitacion, 112) = CONVERT(date, GETDATE(), 112))

if not exists (select  gp.iIdCapacitacion from GESTION_CAPACITACION gp
where (@hora_Actual between gp.tHoraInicio and gp.tHoraFin ) and 
CONVERT(date, gp.dFechaRealizacionCapacitacion, 112) = CONVERT(date, GETDATE(), 112))
begin
	set @iIdCapacitacion = (select max(iIdCapacitacion) from CAPACITACION)
end


INSERT INTO 
CAPACITACION_PERSONAL(
iIdPersonal,
iIdCapacitacion,
iPuntajePersonal,
vObservacionPersonal,
iAsistenciaPersonal,
iUsuarioCrea,
dFechaCrea
)
VALUES (
1,--@iIdPersonal,
@iIdCapacitacion,
@iPuntajePersonal,
@vObservacionPersonal,
@iAsistenciaPersonal,
@iUsuarioCrea,
GETDATE()
)
END

GO
IF OBJECT_ID ( 'spUpdateCAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateCAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spUpdateCAPACITACION_PERSONAL]
@iIdCapacitacionPersonal int,
@iIdPersonal int,
@iIdCapacitacion int,
@iPuntajePersonal int,
@vObservacionPersonal varchar(max),
@iAsistenciaPersonal int,
@iUsuarioMod int
AS
BEGIN
UPDATE
CAPACITACION_PERSONAL
SET
iIdPersonal = @iIdPersonal,
iIdCapacitacion = @iIdCapacitacion,
iPuntajePersonal = @iPuntajePersonal,
vObservacionPersonal = @vObservacionPersonal,
iAsistenciaPersonal = @iAsistenciaPersonal,
iUsuarioMod = @iUsuarioMod,
dFechaMod = GETDATE()
WHERE
iIdCapacitacionPersonal = @iIdCapacitacionPersonal
END

/*  ================================================================= */

/* =================== DETALLE CAPACITACION PERSONAL =================*/

GO
IF OBJECT_ID ( 'spGetDETALLE_CAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spGetDETALLE_CAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spGetDETALLE_CAPACITACION_PERSONAL]
(
@iIdDetalleCapacitacionPersonal int = 0
)
AS
BEGIN
SELECT *
FROM
DETALLE_CAPACITACION_PERSONAL
where (iIdDetalleCapacitacionPersonal = @iIdDetalleCapacitacionPersonal or @iIdDetalleCapacitacionPersonal = 0)
END

GO
IF OBJECT_ID ( 'spInsertDETALLE_CAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spInsertDETALLE_CAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spInsertDETALLE_CAPACITACION_PERSONAL]
@iIdCapacitacionPersonal int,
@iIdPregunta int,
@iIdOpcion int,
@iEstadoRespuesta int,
@iUsuarioCrea int
AS
BEGIN

set @iIdCapacitacionPersonal = (select max(iIdCapacitacionPersonal) from CAPACITACION_PERSONAL)

INSERT INTO 
DETALLE_CAPACITACION_PERSONAL(
iIdCapacitacionPersonal,
iIdPregunta,
iIdOpcion,
iEstadoRespuesta,
iUsuarioCrea,
dFechaCrea
)
VALUES (
@iIdCapacitacionPersonal,
@iIdPregunta,
@iIdOpcion,
@iEstadoRespuesta,
@iUsuarioCrea,
getdate()
)
END

GO
IF OBJECT_ID ( 'spUpdateDETALLE_CAPACITACION_PERSONAL', 'P' ) IS NOT NULL   
    DROP PROCEDURE spUpdateDETALLE_CAPACITACION_PERSONAL  
GO
CREATE PROCEDURE [spUpdateDETALLE_CAPACITACION_PERSONAL]
@iIdDetalleCapacitacionPersonal int,
@iIdCapacitacionPersonal int,
@iIdPregunta int,
@iIdOpcion int,
@iEstadoRespuesta int,
@iUsuarioMod int
AS
BEGIN
UPDATE
DETALLE_CAPACITACION_PERSONAL
SET
iIdCapacitacionPersonal = @iIdCapacitacionPersonal,
iIdPregunta = @iIdPregunta,
iIdOpcion = @iIdOpcion,
iEstadoRespuesta = @iEstadoRespuesta,
iUsuarioMod = @iUsuarioMod,
dFechaMod = getdate()
WHERE
iIdDetalleCapacitacionPersonal = @iIdDetalleCapacitacionPersonal
END

GO
/*  ================================================================= */

--Servicios


IF OBJECT_ID ( 'ListaServicioCircular', 'P' ) IS NOT NULL   
    DROP PROCEDURE ListaServicioCircular  
GO
create proc ListaServicioCircular
as

begin
select 'Aprovados' as 'titulo',count(*) 'Aciertos' from CAPACITACION_PERSONAL
where ipuntajepersonal >=12
union
select 'Desaprovados' as 'titulo',count(*) 'Aciertos' from CAPACITACION_PERSONAL
where ipuntajepersonal <12
union
select t1.titulo, t1.Aciertos from
(select top 1 p.vEnunciadoPregunta as 'titulo', sum(iestadoRespuesta) 'Aciertos' from DETALLE_CAPACITACION_PERSONAL dcp
inner join pregunta p on dcp.iidpregunta= p.iidpregunta
group by p.vEnunciadoPregunta
order by sum(iestadoRespuesta) desc) t1
union
select t2.titulo, t2.Aciertos from
(select top 1 p.vEnunciadoPregunta as 'titulo', sum(iestadoRespuesta) 'Aciertos' from DETALLE_CAPACITACION_PERSONAL dcp
inner join pregunta p on dcp.iidpregunta= p.iidpregunta
group by p.vEnunciadoPregunta
order by sum(iestadoRespuesta) asc) t2
end




/*
INSERT INTO [dbo].[CAPACITACION]
           ([vTemaCapacitacion]
           ,[dFechaPropuestaCapacitacion]
           ,[iEstadoCapactiacion]
           ,[iEstadoComunicacionCapacitacion]
           ,[iUsuarioCrea]
           ,[dFechaCrea])
     VALUES
           ('Limpieza colectiva'
           ,GETDATE()
           ,2
           ,0
           ,1
           ,GETDATE())
GO


INSERT INTO [dbo].[PERSONAL]
           ([vNombrePersonal]
           ,[vApellidoPaternoPersonal]
           ,[vApellidoMaternoPersonal]
           ,[cDNI]
           ,[dFechaNacimiento]
           ,[vDomicilio]
           ,[iIdArea]
           ,[iUbigeo]
           ,[iTipoPersonal]
           ,[iEstadoPersonal])
     VALUES
           ('Raul'
           ,'Paucar'
           ,'Huillca'
           ,'46668967'
           ,'12/31/1990'
           ,'5 de mayo'
           ,2
           ,123456
           ,2
           ,2)
GO

INSERT INTO [dbo].[PERSONAL]
           ([vNombrePersonal]
           ,[vApellidoPaternoPersonal]
           ,[vApellidoMaternoPersonal]
           ,[cDNI]
           ,[dFechaNacimiento]
           ,[vDomicilio]
           ,[iIdArea]
           ,[iUbigeo]
           ,[iTipoPersonal]
           ,[iEstadoPersonal])
     VALUES
           ('Johnny'
           ,'Rivera'
           ,'Varzola'
           ,'45254857'
           ,'7/15/1993'
           ,'rinconada'
           ,2
           ,123456
           ,2
           ,2)
GO

*/