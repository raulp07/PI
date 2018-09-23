
new Vue({
    el: "#app",
    data: {
        Lista_Preguntas: [],
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


            axios.post("/TestEvaluacion/GenerarCamposCapacitacion/").then(function (response) {

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