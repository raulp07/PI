new Vue({
    el: "#app",
    data: {
        Lista_Capacitacion: [],
        Lista_Personal: [],
        Lista_Preguntas: [],
        OpcionesRespuesta: [],
        vCodCapacitacion: "",
        vTemaCapacitacion: "",
        vCodPersonal: "",
        codPregunta: 1,
        EstadoActualizar: 0,
    },
    methods: {
        ListaCapacitacion: function () {

            axios.post("/Capacitacion/ListaCapacitacion/").then(function (response) {
                this.Lista_Capacitacion = response.data.ListaCAPACITACION;
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
        ListarPersonal: function () {

            axios.post("/Capacitacion/ListaPersonal/").then(function (response) {
                this.Lista_Personal = response.data.ListaPersonal;
            }.bind(this)).catch(function (error) {
            });
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
                var _Enunciadotest = $('#Enunciadotest').val();
                var _valortest = $('#valortest').val();
                var _optradio = $('input:radio[name=optradio]:checked').val();

                var _codPregunta = this.codPregunta;
                var datos = this.Lista_Preguntas;

                var lista = { "codpregunta": _codPregunta, "Enunciadotest": _Enunciadotest, "valortest": _valortest, "optradio": _optradio };
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
                this.EstadoActualizar = 0;

            }

        },
        QuitarPregunta: function (codpregunta) {

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
            this.EstadoActualizar = _ListaP.codpregunta;

        },
        CancelarPregunta: function () {
            $('#Enunciadotest').empty();
            $('#valortest').val(0);
            this.EstadoActualizar = 0;
        }
    },
    computed: {},
    created: function () {
        this.ListaCapacitacion();

    },
    mounted: function () {
    }
})

