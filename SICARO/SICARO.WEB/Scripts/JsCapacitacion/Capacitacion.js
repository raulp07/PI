new Vue({
    el: "#app",
    data: {
        Lista_Capacitacion: [],
        Lista_Personal:[],
        vCodCapacitacion: "",
        vTemaCapacitacion: "",
        vCodPersonal: "",
    },
    methods: {
        ListaCapacitacion: function () {

            axios.post("/Capacitacion/ListaCapacitacion/").then(function (response) {                
                this.Lista_Capacitacion = response.data.ListaCAPACITACION;                
            }.bind(this)).catch(function (error) {
            });
        },
        GestionarCapacitacion: function (iIdCapacitacion,vCodCapacitacion, vTemaCapacitacion) {            
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
            var _lista = Lista_Personal.find(function (val) {
                return (val.vCodPersonal == this.vCodPersonal);
            });
            $('#ExpNombre').val(_lista.vNombrePersonal);
            $('#ExpoApePat').val(_lista.vApellidoPaternoPersonal);
            $('#ExpoApeMat').val(_lista.vApellidoMaternoPersonal);

        }
    },
    computed: {},
    created: function () {
        this.ListaCapacitacion();

    },
    mounted: function () {
    }
})

