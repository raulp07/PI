
new Vue({
    el: "#app",
    data: {
    },
    methods: {
        EmpezarEvaluacion: function () {
            google.charts.load('current', { 'packages': ['gauge'] });
            google.charts.setOnLoadCallback(drawChart);

            function drawChart() {

                //var data = google.visualization.arrayToDataTable([
                //  ['Label', 'Value'],
                //  ['Indicador', 80]
                //]);

                //var options = {
                //    width: 100, height: 120,
                //    redFrom: 90, redTo: 100,
                //    yellowFrom: 75, yellowTo: 90,
                //    minorTicks: 5
                //};

                var data = google.visualization.arrayToDataTable([
                ['Label', 'Value'],
                ['Rank', 70]
                ]);

                var options = {
                    width: 250, height: 250,
                    redFrom: 0, redTo: 35,
                    yellowFrom: 35, yellowTo: 70,
                    greenFrom: 70, greenTo: 100,
                    //minorTicks: 20,
                    max: 100,
                    min: 0,
                    //majorTicks: ['100', '1']
                };

                //var options = {
                //    width: 250, height: 250,
                //    redFrom: 0, redTo: 10,
                //    yellowFrom: 10, yellowTo: 15,
                //    greenFrom: 15, greenTo: 20,
                //    minorTicks: 20,
                //    max: 20,
                //    min: 0,
                //    majorTicks: ['20', '1']
                //};

                var chart = new google.visualization.Gauge(document.getElementById('chart_div'));
                chart.draw(data, options);

            }

            //axios.post("/TestEvaluacion/GenerarCamposCapacitacion/").then(function (response) {

            //}.bind(this)).catch(function (error) {
            //});
        },
        MostrarConfiguracionIntervalo: function () {
            $('#ConfiguracionIntervalos').attr('style', 'display:block');
        },
        OcultarConfiguracionIntervalo: function () {
            $('#ConfiguracionIntervalos').attr('style', 'display:none');
        },
    },
    computed: {},
    created: function () {
        this.EmpezarEvaluacion();

    },
    mounted: function () {
    }
})