

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



/* ===================  Gestion Capacitacion ============================*/
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
CREATE PROCEDURE [spInsertGESTION_CAPACITACION]

@iIdCapacitacion int,
@iIdRepresentante int,
@dFechaRealizacionCapacitacion date,
@tHoraInicio time,
@tHoraFin time,
@iTiempoTest int,
@iUsuarioCrea int
AS
BEGIN
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
END
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
CREATE PROCEDURE [spInsertTEST]
@iIdGestorCapacitacion int,
@vDescricionTest varchar(max),
@dFechaTest date,
@iEstadoTest int,
@iUsuarioCrea int,
@dFechaCrea datetime
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
CREATE PROCEDURE [spUpdateTEST]
@iIdTest int,
@iIdGestorCapacitacion int,
@vDescricionTest varchar(max),
@dFechaTest date,
@iEstadoTest int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spGet_PREGUNTA]
@iIdPregunta int =0
AS
BEGIN
SELECT *
FROM
PREGUNTA
where (iIdPregunta = @iIdPregunta or @iIdPregunta=0)
END


GO
CREATE PROCEDURE [spInsertPREGUNTA]
@iIdTest int,
@vEnunciadoPregunta varchar(max),
@iPuntajePregunta int,
@iTipoRespuestaPregunta int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
AS
BEGIN
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
CREATE PROCEDURE [spUpdatePREGUNTA]
@iIdPregunta int,
@iIdTest int,
@vEnunciadoPregunta varchar(max),
@iPuntajePregunta int,
@iTipoRespuestaPregunta int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spInsertOPCION_PREGUNTA]
@iIdPregunta int,
@vEnunciadoOpcion varchar(150),
@iEstadoOpcion int,
@iUsuarioCrea int
AS
BEGIN
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
CREATE PROCEDURE [spUpdateOPCION_PREGUNTA]
@iIdOpcion int,
@iIdPregunta int,
@vEnunciadoOpcion varchar(150),
@iEstadoOpcion int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spInsertEVALUACION_PROVEEDOR]
@iIdProveedor int,
@iCalidadProducto int,
@iPrecio int,
@iCondiciones int,
@dFechaEvaluacion date,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spUpdateEVALUACION_PROVEEDOR]
@iIdEvaluacionProveedor int,
@iIdProveedor int,
@iCalidadProducto int,
@iPrecio int,
@iCondiciones int,
@dFechaEvaluacion date,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spInsertEVALUACIONPROVEEDORPREGUNTA]
@iIdEvaluacionProveedor int,
@iIdMateriaPrima int,
@vObservacion varchar(max),
@dFecha date,
@iPuntajeTotal int,
@iPorcentajeCumplimiento int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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
CREATE PROCEDURE [spUpdateEVALUACIONPROVEEDORPREGUNTA]
@iIdEvaluacionProveedorPregunta int,
@iIdEvaluacionProveedor int,
@iIdMateriaPrima int,
@vObservacion varchar(max),
@dFecha date,
@iPuntajeTotal int,
@iPorcentajeCumplimiento int,
@iUsuarioCrea int,
@dFechaCrea datetime,
@iUsuarioMod int,
@dFechaMod datetime
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


USE [BDICARO]
GO

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
