
new Vue({
    el: "#app",
    data: {
        Lista_Materia_Prima: [],
        Lista_Proveedor: [],
        Lista_Opciones: [],
        vCodCapacitacion: "",
        vTemaCapacitacion: "",
        centesimas: 0,
        segundos: 60,
        minutos: 30,
        horas: 0,
    },
    methods: {
        EmpezarEvaluacion: function () {



            google.charts.load("current", { packages: ['corechart'] });
            google.charts.setOnLoadCallback(drawChart);
            function drawChart() {
                var data = google.visualization.arrayToDataTable([
                  ["Element", "Density", { role: "style" }],
                  ["Copper", 8.94, "#b87333"],
                  ["Silver", 10.49, "silver"],
                  ["Gold", 19.30, "gold"],
                  ["Platinum", 21.45, "color: #e5e4e2"]
                ]);

                var view = new google.visualization.DataView(data);
                view.setColumns([0, 1,
                                 {
                                     calc: "stringify",
                                     sourceColumn: 1,
                                     type: "string",
                                     role: "annotation"
                                 },
                                 2]);

                var options = {
                    title: "Density of Precious Metals, in g/cm^3",
                    width: 300,
                    height: 400,
                    bar: { groupWidth: "95%" },
                    legend: { position: "none" },
                };
                var chart = new google.visualization.ColumnChart(document.getElementById("columnchart_values"));
                chart.draw(view, options);
            }

            var jsonData = { iIdMateriaPrima: 0 };
            axios.post("/Predicciones/ListaMateriaPrima/", jsonData).then(function (response) {
                this.Lista_Materia_Prima = response.data.ListaMATERIA_PRIMA;
            }.bind(this)).catch(function (error) {
            });
        },
        ModificarConulta: function () {

            var opcion = $('#Consulta').val();

            if (opcion == 3) {
                $('.divPrincipal').hide();
                $('.divActividad').show();
                
            } else {
                $('.divPrincipal').show();
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
        GuardarPrediccion: function () {


            //@tipoPronostico varchar(max),
            //@idProveedor int,
            //@idProducto int,
            //@idInsumo int,
            //@idActividadProduccion int,
            //@cantidad int,
            //@unidadDeMedida varchar(max)

            var param = {
                tipoPronostico: $('#ddlPronostico').val(),
                idProveedor: $('#slProveedor').val(),
                idProducto: 0,// $('#').val(),
                idInsumo: $('#slProducto').val(),
                idActividadProduccion: $('#slActividad').val(),
                cantidad: $('#cantidadproducida').val(),
                unidadDeMedida: $('#slUnidadMedida').val(),
            };

            var MP = $('#slProducto').val();
            if (MP == 0) {
                return;
            }
            axios.post("/Predicciones/GuardarPronosticos/", param).then(function (response) {
                debugger;
                if (response.data.resultado > 0)
                {
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