
new Vue({
    el: "#app",
    data: {
        Lista_Materia_Prima: [],
        Lista_Proveedor: [],
        Lista_Control_Produccion: [],
        RedInicio: 0,
        RedFin: 35,
        YellowInicio: 35,
        YellowFin: 70,
        GreenInicio: 70,
        GreenFin: 100,
    },
    methods: {
        EmpezarEvaluacion: function () {
            //
            google.charts.load('current', { 'packages': ['gauge'] });
            google.charts.setOnLoadCallback(drawChart);
            var _RedInicio = this.RedInicio;
            var _RedFin = this.RedFin;
            var _YellowInicio = this.YellowInicio;
            var _YellowFin = this.YellowFin;
            var _GreenInicio = this.GreenInicio;
            var _GreenFin = this.GreenFin;
            function drawChart() {          
                var data = google.visualization.arrayToDataTable([
                ['Label', 'Value'],
                ['Rank', 70]
                ]);
                var options = {
                    width: 250, height: 250,
                    redFrom: _RedInicio, redTo: _RedFin,
                    yellowFrom: _YellowInicio, yellowTo: _YellowFin,
                    greenFrom: _GreenInicio, greenTo: _GreenFin,
                    //minorTicks: 20,
                    max: 100,
                    min: 0,
                    //majorTicks: ['100', '1']
                };
                var chart = new google.visualization.Gauge(document.getElementById('chart_div'));
                chart.draw(data, options);

            }
            var jsonData = { iIdMateriaPrima: 0 };
            axios.post("/Predicciones/ListaMateriaPrima/", jsonData).then(function (response) {
                this.Lista_Materia_Prima = response.data.ListaMATERIA_PRIMA;
                this.ListaControlPoduccion();
            }.bind(this)).catch(function (error) {
            });
            //axios.post("/TestEvaluacion/GenerarCamposCapacitacion/").then(function (response) {

            //}.bind(this)).catch(function (error) {
            //});
        },
        ModificarConulta: function () {

            var opcion = $('#Consulta').val();

            if (opcion == 3) {
                $('.divproveedor').hide();
                $('.divActividad').show();

            } else {
                $('.divproveedor').show();
                $('.divActividad').hide();
            }
        },
        ConsultarProveedor: function () {

            var MP = $('#slProducto').val();
            if (MP == 0) {
                return;
            }
            var jsonData = { iUbigeo: MP };
            axios.post("/Predicciones/ListaMateriaPrimaProveedor/", jsonData).then(function (response) {
                this.Lista_Proveedor = response.data.ListaMATERIA_PRIMAProveedor;
            }.bind(this)).catch(function (error) {
            });
        },
        MostrarConfiguracionIntervalo: function () {
            $('#ConfiguracionIntervalos').attr('style', 'display:block');
        },
        OcultarConfiguracionIntervalo: function () {
            $('#ConfiguracionIntervalos').attr('style', 'display:none');
            this.EmpezarEvaluacion();
        },
        ListaControlPoduccion: function () {

            var MP = $('#slProducto').val();
            if (MP == 0) {
                return;
            }
            var jsonData = {};
            axios.post("/Pronostico/ListaControlProduccion/", jsonData).then(function (response) {
                this.Lista_Control_Produccion = response.data.CONTROLPRODUCCION;
            }.bind(this)).catch(function (error) {
            });
        },
        GuardarControlProduccion: function () {
            
            var param = {
                idProducto: $('#slProducto').val(),
                tipoPronostico: $('#Consulta').text(),
                cantidadProducida: 0,// $('#').val(),
                idActividadControlProduccion: $('#slProducto').val(),
                indicador: 'Rojo',
            };

            var MP = $('#slProducto').val();
            if (MP == 0) {
                return;
            }
            axios.post("/Pronostico/GuardarControlProduccion/", param).then(function (response) {
                if (response.data.resultado > 0) {
                    alert('Registro Completo');
                }
            }.bind(this)).catch(function (error) {
            });
        },

    },
    computed: {},
    created: function () {
        this.EmpezarEvaluacion();
        

    },
    mounted: function () {
    }
})