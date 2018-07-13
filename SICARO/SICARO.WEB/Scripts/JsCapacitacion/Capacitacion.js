new Vue({
    el: "#app",
    data: {
        Lista_Capacitacion: [],
        Lista_Personal: [],
        Lista_Operarios: [],
        Lista_Preguntas: [],
        OpcionesRespuesta: [],
        vCodCapacitacion: "",
        vTemaCapacitacion: "",
        vCodPersonal: "",
        codPregunta: 1,
        EstadoActualizar: 0,
        NotaMaxima: 20,
        Estado_Almacenamiento_Preguntas: 0,
        Estado_Almacenamiento_Operarios: 0,
    },
    methods: {
        ListaCapacitacion: function () {

            axios.post("/Capacitacion/ListaCapacitacion/").then(function (response) {
                this.Lista_Capacitacion = response.data.ListaCAPACITACION;
            }.bind(this)).catch(function (error) {
            });
        },
        ListarPersonal: function () {
            axios.post("/Capacitacion/ListaPersonal/").then(function (response) {
                this.Lista_Personal = response.data.ListaPersonal;
            }.bind(this)).catch(function (error) {
            });
        },
        GestionarCapacitacion: function (iIdCapacitacion, vCodCapacitacion, vTemaCapacitacion) {
            this.iIdCapacitacion = iIdCapacitacion;
            this.vCodCapacitacion = vCodCapacitacion;
            this.vTemaCapacitacion = vTemaCapacitacion;
            $("#CAPACITACION").hide();
            $("#GESTIONCAPACITACION").show();
            this.ListarPersonal();
        },
        MostrarPersonal: function () {
            $("#ModalPersonal").modal('show');
        },

        ExpositorSeleccionado: function (vCodPersonal) {
            this.vCodPersonal = vCodPersonal;
        },
        AceptarExpositor: function () {
            var _Lista_Personal = this.Lista_Personal;
            var _vCodPersonal = this.vCodPersonal;
            var _lista = _Lista_Personal.find(function (val) {
                return (val.vCodPersonal == _vCodPersonal);
            });
            $('#ExpNombre').val(_lista.vNombrePersonal);
            $('#ExpoApePat').val(_lista.vApellidoPaternoPersonal);
            $('#ExpoApeMat').val(_lista.vApellidoMaternoPersonal);
            $("#ModalPersonal").modal('hide');
        },
        PrepararTest: function () {
            $("#ModalTest").modal('show');
        },
        VerTest: function () {
        },
        AgregarOperarios: function () {
            debugger;
            var _vCodPersonal = this.vCodPersonal;
            if (this.vCodPersonal.length != 0) {
                var _Lista_Personal = this.Lista_Personal;
                _Lista_Personal = _Lista_Personal.filter(function (eval) {
                    return eval.vCodPersonal != _vCodPersonal;
                });
                this.Lista_Operarios = _Lista_Personal;
                debugger;
            } else {
                debugger;
                this.Lista_Operarios = this.Lista_Personal;
            }
            debugger;
            $("#ModalOperario").modal('show');
            
        },
        VerOperarios: function () {
        },
        GrabarOpcionVF: function () {
            var datos = this.OpcionesRespuesta;
            var _ResTextOpcion = "";
            var _chkEstadoCorrecto = "";
            var _estadovalor = $('input:radio[name=opRespuesta]:checked').val();
            var _codPregunta = this.codPregunta;
            if (this.EstadoActualizar == 0) {
                var list = { "codpregunta": _codPregunta, "Respuesta": _ResTextOpcion, "estado": _chkEstadoCorrecto, "estadovalor": _estadovalor };
                datos.push(list);
                this.OpcionesRespuesta = datos;
            } else {
                _codpregunta = this.EstadoActualizar;
                $.each(datos, function (key, val) {
                    if (val.codpregunta == _codpregunta) {
                        val.Respuesta = _Respuesta;
                        val.Respuesta = _ResTextOpcion;
                        val.estado = _chkEstadoCorrecto;
                        val.estadovalor = _estadovalor;
                    }
                });
            }
            this.OpcionesRespuesta = datos;
        },
        AgregarRespuesta: function () {
            var datos = this.OpcionesRespuesta;
            var _ResTextOpcion = $('#ResTextOpcion').val().trim();
            var _chkEstadoCorrecto = $('#chkEstadoCorrecto').is(':checked') ? 'Correcto' : 'Incorrecto';
            var _estadovalor = $('#chkEstadoCorrecto').is(':checked') ? 1 : 0;
            var _codPregunta = this.codPregunta;

            var _Validar = datos.find(function (val) {
                return val.Respuesta == _ResTextOpcion;
            });
            if (_Validar != undefined) {
                alert('Ya existe una respuesta igual');
                return;
            }

            var list = { "codpregunta": _codPregunta, "Respuesta": _ResTextOpcion, "estado": _chkEstadoCorrecto, "estadovalor": _estadovalor };
            datos.push(list);
            this.OpcionesRespuesta = datos;
        },
        QuitarOpcion: function (Respuesta) {
            var datos = this.OpcionesRespuesta;
            var result = datos.filter(function (elem) {
                return elem.Respuesta != Respuesta;
            });
            this.OpcionesRespuesta = result;
        },
        AgregarPregunta: function () {
            if (this.EstadoActualizar == 0) {
                var _Enunciadotest = $('#Enunciadotest').val().trim();
                var _valortest_porcentaje = $('#valortest').val();
                var _valortest = (this.NotaMaxima * _valortest_porcentaje) / 100;

                if (_Enunciadotest.length == 0) {
                    alert('El enunciado esta vacio, ingrese uno');
                    return;
                }
                if (_valortest_porcentaje <= 0) {
                    alert('El valor de esta pregunta no puede ser 0');
                    return;
                }

                var _optradio = $('input:radio[name=optradio]:checked').val();
                var _TipoRespuesta = $('input:radio[name=optradio]:checked').val() == 1 ? "V/F" : "Opción";
                var _codPregunta = this.codPregunta;
                var datos = this.Lista_Preguntas;




                var _Validar = datos.find(function (val) {
                    return val.Enunciadotest == _Enunciadotest;
                });
                if (_Validar != undefined) {
                    alert('Ya existe una respuesta igual');
                    return;
                };
                var sumatoria_puntos = 0;
                $.each(datos, function (key, val) {
                    sumatoria_puntos = sumatoria_puntos + parseInt(val.valortestPorcentaje);
                });
                if (sumatoria_puntos == 100) {
                    alert('La suma del valor de las preguntas ya alcanzaron el puntaje maximo');
                    return;
                };
                if ((sumatoria_puntos + parseInt(_valortest_porcentaje)) > 100) {
                    alert('La suma del valor de las preguntas sobrevasa el puntaje maximo se recomienda un valor de ' + (100 - sumatoria_puntos));
                    return;
                };

                var lista = { "codpregunta": _codPregunta, "Enunciadotest": _Enunciadotest, "TipoRespuesta": _TipoRespuesta, "optradio": _optradio, "valortestPorcentaje": _valortest_porcentaje, "valortest": _valortest };
                datos.push(lista);

                this.GrabarOpcionVF();
                this.codPregunta = this.codPregunta + 1;
                this.Lista_Preguntas = datos;
            } else {

                var _codpregunta = this.EstadoActualizar;
                var _Enunciadotest = $('#Enunciadotest').val();
                var _valortest = $('#valortest').val();
                var _optradio = $('input:radio[name=optradio]:checked').val();

                var datos = this.Lista_Preguntas;
                $.each(datos, function (key, val) {
                    if (val.codpregunta == _codpregunta) {
                        val.Enunciadotest = _Enunciadotest;
                        val.valortest = _valortest;
                        val.optradio = _optradio;
                    }
                });
            }
            this.LimpiarFormulario();

        },
        QuitarPregunta: function (codpregunta) {
            var _Lista_Preguntas = this.Lista_Preguntas;
            var _OpcionesRespuesta = this.OpcionesRespuesta;

            _Lista_Preguntas = _Lista_Preguntas.filter(function (val) {
                return val.codpregunta != codpregunta;
            });
            _OpcionesRespuesta = _OpcionesRespuesta.filter(function (val) {
                return val.codpregunta != codpregunta;
            });
            this.Lista_Preguntas = _Lista_Preguntas;
            this.OpcionesRespuesta = _OpcionesRespuesta;



        },
        EditarPeqgunta: function (codpregunta) {

            var _Lista_Preguntas = this.Lista_Preguntas;
            var _OpcionesRespuesta = this.OpcionesRespuesta;

            var _ListaP = _Lista_Preguntas.find(function (val) {
                return val.codpregunta == codpregunta;
            });
            var _ListaO = _OpcionesRespuesta.find(function (val) {
                return val.codpregunta == codpregunta;
            });
            $('#Enunciadotest').val(_ListaP.Enunciadotest);
            $('#valortest').val(_ListaP.valortest);

            $('input:radio[name=optradio][value=' + _ListaP.optradio + ']').prop('checked', true);
            $('input:radio[name=opRespuesta][value=' + _ListaO.estadovalor + ']').prop('checked', true);

            $('#btnAgregarPregunta').text('Actualizar Pregunta');
            $('#btnCancelarPregunta').removeClass('hide');
            this.EstadoActualizar = _ListaP.codpregunta;

        },
        CancelarPregunta: function () {
            this.LimpiarFormulario();
        },
        LimpiarFormulario: function () {
            $('#Enunciadotest').val('');
            $('#valortest').val(0);
            this.EstadoActualizar = 0;
            $('#btnCancelarPregunta').addClass('hide');
            $('#btnAgregarPregunta').text('Agregar Pregunta');
        },
        GrabarPreguntas: function () {
            this.Estado_Almacenamiento_Preguntas = 1;
        },
        CancelarPreguntas: function () {
            $("#ModalTest").modal('hide');
            this.Estado_Almacenamiento_Preguntas = 0;
        },
        GrabarOperarios: function () {
            this.Estado_Almacenamiento_Operarios = 1;
        },
        CancelarOperarios: function () {
            this.Estado_Almacenamiento_Operarios = 0;
            $("#ModalOperario").modal('hide');
        },
        GrabarCapacitacion: function () {

        },
        CancelarCapacitacion: function () {

        },
    },
    computed: {},
    created: function () {
        this.ListaCapacitacion();
    },
    mounted: function () {
    }
})

