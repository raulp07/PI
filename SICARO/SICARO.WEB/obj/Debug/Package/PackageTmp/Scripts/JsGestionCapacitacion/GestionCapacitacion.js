new Vue({
    el: "#app",
    data: {
        Lista_Capacitacion: [],
        vCodCapacitacion: "",
        vTemaCapacitacion:"",
    },
    methods: {
        ListaDatosCapacitacion: function () {
            axios.post("/GestionCapacitacion/GenerarCamposCapacitacion/").then(function (response) {
                this.vCodCapacitacion = response.data.vCodCapacitacion;
                this.vTemaCapacitacion = response.data.vTemaCapacitacion;
            }.bind(this)).catch(function (error) {
            });
        },
        GestionarCapacitacion: function (vCodCapacitacion, vTemaCapacitacion) {
            var param = {
                iIdCapacitacion: iIdCapacitacion,
                vCodCapacitacion: vCodCapacitacion,
                vTemaCapacitacion: vTemaCapacitacion
            };
            var Json = { C: param };
            axios.post("/GestionCapacitacion/Index/", Json).then(function (response) {

            }.bind(this)).catch(function (error) {
            });
        }
    },
    computed: {},
    created: function () {
        this.ListaDatosCapacitacion();

    },
    mounted: function () {
    }
})