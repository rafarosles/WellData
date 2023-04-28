/// <reference path="../Models/WellDataModel.js"/>
/// <reference path="../global.js"/>

(function () {
    var app = angular.module('WellData', ['ngPagination']);
    //var app = angular.module('WellData', []);

    app.controller('WellDataController', ['$scope', '$compile', function ($scope, $compile) {

        var self = this;
        let listTipoInfo = "";
        let listApartados = "";
        let listCampo = "";
        let listClassPozo = "";
        let listUwi = "";
        let listStatusPozo = "";
        let listNombrePozo = "";
        let listDatosPozo = "";
        let listDetalleMetadata = "";
        let listCadido = "";
        let listApartadoBloqueSur = ''
        let listCadidoBloqueSur = ''
        let listCampoBloqueSur = ''
        let listEdoDoctoBloqueSur = ''
        let listMneBloqueSur = ''
        let listNombrePozoBloqueSur = ''
        let listUwiBloqueSur = ''
        let listEdoInfTecVer = ''
        let listTipoExpInfTecVer = ''
        let listRegistrosGeoVer = ''
        let listIdInformeInfTecVer = ''
        let listTipoInformeInfTecVer = ''
        let listAreaInfoTecVer = ''
        let listProspectoInfTecVer = ''
        let listContenidoInfTecVer = ''
        let listEdosAreaEstudioInfTecVer = ''
        let listTipoExpInfoTecVer = ''
        let listAniosInfoTec = ''
        let listInformesTecnicos = ''
        let tipo_metadata = 0
        let region_seleccionada = 0
        let listCompaniasAfectaciones = '';
        let listEstadosAfectaciones = '';
        let listMunicipiosAfectaciones = '';
        let listProyectosAfectaciones = '';
        let listRegimenAfectaciones = '';
        let listAfectaciones = '';
        let listAfectaciones_pep = '';
        let listDetalleAfectacionCia = '';
        let listAfectadoAfectaciones = '';

        this.iniciar_sesion = () => {
            wellDataContext.iniciarSesion(self.username, self.password, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        location.replace(urlServer + 'accounts/menu')
                        break;
                    case "notgp":
                        Swal.fire({
                            title: 'Error!',
                            text: 'Error en los datos de iniicio de sesión',
                            icon: 'error',
                            confirmButtonText: 'Ok'
                        })
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        // Obtenemos el tipo de informacion a buscar
        self.tipo_info_seleccionada = () => {
            self.listNombrePozo = ""
            self.listCampo = ""
            self.listApartados = ""
            self.listClassPozo = ""
            self.listmnemonico = ""
            self.listUwi = ""
            self.listCadido = ""
            document.getElementById("region").value = "0";
            let e = document.getElementById("tipo_info");
            let value = e.value;
            self.tipo_info_selected = ""

            if (value === "1") {
                self.tipo_info_selected = "E" // E= Expediente
                document.getElementById('cadido').disabled = false
                //document.getElementById('tipo_informacion').disabled    = false
                document.getElementById('uwi').disabled = false
                document.getElementById('class_pozo').disabled = false
                document.getElementById('mnemonico').disabled = false
                document.getElementById('apartado').disabled = false
            }
            else if (value === "2") {
                self.tipo_info_selected = "R" // R = Registro Geofisicos
                document.getElementById('cadido').disabled = true
                //document.getElementById('tipo_informacion').disabled    = true
                document.getElementById('uwi').disabled = true
                document.getElementById('class_pozo').disabled = true
                document.getElementById('mnemonico').disabled = true
                document.getElementById('apartado').disabled = true
            }
            document.getElementById('region').disabled = false;
        }

        // Obtenemos la región de donde queremos hacer la busqueda (Veracruz / Bloque Sur)
        self.region_seleccionada = () => {
            let e = document.getElementById("region");
            let value = e.value;
            region_seleccionada = value
            if (value === "1")
                cargarDatos()
            else if (value === "2")
                cargarDatosBloqueSur()
        }

        //Cargamos los combos para obteber la información de la región veracruz
        let cargarDatos = () => {
            document.getElementById('div_tabla_registros_geo').style.display = 'none'
            //$('#btn-buscar').prop('disabled', true);
            //obtenerGridDatosPozo()
            if (self.tipo_info_selected == 'E') {
                CompoTipoInfo()
                obtenerComboApartado(region_seleccionada)
                obtenerComboCampo(region_seleccionada)
                obtenerComboClassPozo(region_seleccionada)
                obtenerComboEstado(region_seleccionada)
                obtenerComboMnemonico(region_seleccionada)
                obtenerComboStatusPozo(region_seleccionada)
                obtenerComboNombrePozo(region_seleccionada)
                obtenerComboUwi(region_seleccionada)
                obtenerComboCadido(region_seleccionada)

            }
            else if (self.tipo_info_selected == 'R') {
                obtenerComboNombrePozo(region_seleccionada)
                obtenerComboCampo(region_seleccionada)
            }
        }

        //Cargamos los combos para obtener la información del bloque sur
        let cargarDatosBloqueSur = () => {
            document.getElementById('div_tabla').style.display = 'none'
            if (self.tipo_info_selected == 'E') {
                CompoTipoInfo()
                obtenerComboApartado(region_seleccionada)
                obtenerComboCampo(region_seleccionada)
                obtenerComboClassPozo(region_seleccionada)
                obtenerComboEstado(region_seleccionada)
                obtenerComboMnemonico(region_seleccionada)
                obtenerComboStatusPozo(region_seleccionada)
                obtenerComboNombrePozo(region_seleccionada)
                obtenerComboUwi(region_seleccionada)
                obtenerComboCadido(region_seleccionada)
            }
            else if (self.tipo_info_selected == 'R') {
                obtenerComboNombrePozo(region_seleccionada)
                obtenerComboCampo(region_seleccionada)
            }
        }

        // Carga de combos de la región Veracruz
        let CompoTipoInfo = () => {
            wellDataContext.obtenerCompoTipoInfo(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listTipoInfo = wellDataContext.listTipoInfo
                        self.tipoInfo = self.listTipoInfo[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboApartado = (region_seleccionada) => {
            wellDataContext.obtenerComboApartado(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listApartados = wellDataContext.listApartado
                        self.apartado = self.listApartados[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboCampo = (region_seleccionada) => {
            wellDataContext.obtenerComboCampo(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listCampo = wellDataContext.listCampo
                        self.campo = self.listCampo[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboClassPozo = (region_seleccionada) => {
            wellDataContext.obtenerComboClassPozo(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listClassPozo = wellDataContext.listClassPozo
                        self.classpozo = self.listClassPozo[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboEstado = (region_seleccionada) => {
            wellDataContext.obtenerComboEstado(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listEstado = wellDataContext.listEstado
                        self.estadoFisico = self.listEstado[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboMnemonico = (region_seleccionada) => {
            wellDataContext.obtenerComboMnemonico(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listmnemonico = wellDataContext.listmnemonico
                        self.mnemonico = self.listmnemonico[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboStatusPozo = (region_seleccionada) => {
            wellDataContext.obtenerComboStatusPozo(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listStatusPozo = wellDataContext.listStatusPozo
                        self.statusPozo = self.listStatusPozo[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboNombrePozo = (region_seleccionada) => {
            wellDataContext.obtenerComboNombrePozo(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listNombrePozo = wellDataContext.listNombrePozo
                        self.nombrepozo = self.listNombrePozo[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboUwi = (region_seleccionada) => {
            wellDataContext.obtenerComboUwi(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listUwi = wellDataContext.listUwi
                        self.uwi = self.listUwi[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboCadido = (region_seleccionada) => {
            wellDataContext.obtenerComboCadido(region_seleccionada, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listCadido = wellDataContext.listCadido
                        self.cadido = self.listCadido[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        //Obtenemos el tipo de busqueda que se desea realizar (Tipo de información a buscar y la región a buscar)
        this.obtenerGridDatosPozo = () => {
            let i = document.getElementById("tipo_info");
            let value_i = i.value;
            let e = document.getElementById("region");
            let region_documento = e.value;
            if (value_i == "1")
                obtenerGridPozoVeracruz(region_documento)
            else if (value_i == "2")
                obtenerGridRegistrosGeoVer(region_documento)
        }

        // Obtiene la Información de expedientes por region
        let obtenerGridPozoVeracruz = (region) => {
            $('#btn-buscar').prop('disabled', true);
            /*let tipoInfo = $("#tipo_informacion option:selected").text()
            let uwi = $("#uwi option:selected").text()
            let classpozo = $("#class_pozo option:selected").text()
            let statusPozo = $("#statu_pozo option:selected").text()
            let campo = $("#campo option:selected").text()
            let nombrepozo = $("#nombre_pozo option:selected").text()
            let mnemonico = $("#mnemonico option:selected").text()
            let apartado = $("#apartado option:selected").text()
            let estadoFisico = $("#estado option:selected").text()*/

            /*let position = mnemonico.indexOf("-")
            if(position > 0)
                mnemonico = mnemonico.substr(position+2, mnemonico.length-1)
                */

            //wellDataContext.obtenerGridDatosPozo(this.inai, tipoInfo, uwi, classpozo, statusPozo, campo, nombrepozo, mnemonico, apartado, estadoFisico, function (resp) {
            wellDataContext.obtenerGridDatosPozo(region, this.cadido, this.tipoInfo, this.uwi, this.classpozo, this.statusPozo, this.campo, this.nombrepozo, this.mnemonico, this.apartado, this.estadoFisico, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listDatosPozo = wellDataContext.listDatosPozo
                        document.getElementById('div_tabla').style.display = 'block'
                        $('#btn-buscar').prop('disabled', false);
                        //$(document).ready(function () {
                        //    $('#data_table_imp').DataTable();
                        //});
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        //Obtiene el checklist de cada registro mostrado en el grid de pozos
        this.obtenerDetalleMetadata = (id) => {
            wellDataContext.obtenerDetalleMetadata(id, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listDetalleMetadata = wellDataContext.listDetalleMetadata
                        self.inai_detalle = self.listDetalleMetadata[0].inai
                        self.uwi_detalle = self.listDetalleMetadata[0].uwi
                        self.nombre_doc_detalle = self.listDetalleMetadata[0].nombre_archivo_dig
                        self.ubicacion_detalle = self.listDetalleMetadata[0].ubicacion
                        self.caja_detalle = self.listDetalleMetadata[0].no_caja
                        self.tipo_info_detalle = self.listDetalleMetadata[0].tipo_info
                        self.class_pozo_detalle = self.listDetalleMetadata[0].class_pozo
                        self.status_pozo_detalle = self.listDetalleMetadata[0].status_pozo
                        self.campo_detalle = self.listDetalleMetadata[0].campo
                        self.nombre_pozo_detalle = self.listDetalleMetadata[0].nombre_pozo
                        self.mnemonico_detalle = self.listDetalleMetadata[0].mnemonico
                        self.apartado_detalle = self.listDetalleMetadata[0].apartado
                        self.total_hojas_detalle = self.listDetalleMetadata[0].total_hojas
                        self.total_pag_detalle = self.listDetalleMetadata[0].no_total_paginas
                        self.observaciones_detalle = self.listDetalleMetadata[0].observaciones
                        self.estado_detalle = self.listDetalleMetadata[0].estado
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        // Obtiene información de los registros geofisicos por su region
        let obtenerGridRegistrosGeoVer = (region_documento) => {
            $('#btn-buscar').prop('disabled', true);
            wellDataContext.obtenerGridRegistrosGeoVer(region_documento, this.nombrepozo, this.campo, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listRegistrosGeoVer = wellDataContext.listRegistrosGeoVer
                        document.getElementById('div_tabla_registros_geo').style.display = 'block'
                        $('#btn-buscar').prop('disabled', false);
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        //Reestablece los filtros 
        this.reiniciarFiltros = () => {
            let e = document.getElementById("region");
            let value = e.value;
            region_seleccionada = value
            if (value === "1")
                cargarDatos()
            else if (value === "2")
                cargarDatosBloqueSur()
        }

        this.reiniciarFiltros_InfoTec = () => {
            let e = document.getElementById("region");
            let value = e.value;
            combos_info_tec(value)
        }

        //Abre los documentos PDF (Mejorar el mensaje de error al no encontrar un archivo)
        this.abrirDocumento = (nombreDocumento, nombre_pozo) => {
            let e = document.getElementById("region");
            let region = e.value;
            let i = document.getElementById('tipo_info')
            let tipo = i.value;
            wellDataContext.abrirDocumento(nombreDocumento, region, nombre_pozo, tipo, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        let source = resp.source //---> \ > /
                        console.log(source)
                        source = (resp.source).substr(27, resp.source.length)
                        window.open(source, '_blank');
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        //Crea un TXT con la información de la busqueda realizada (Pozos / Registros ) //Mejorar como se muestra la información
        this.crearTxt = () => {
            let e = document.getElementById("region");
            let region_documento = e.value;
            wellDataContext.crearTxt(region_documento, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        alert('Lista Generada')
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }



        /*--------------------INFORME TÉCNICO VERACRUZ--------------------*/

        //Guardamos la región seleccionada
        self.region_seleccionada_inf_tec = () => {
            let e = document.getElementById("region");
            let value = e.value;
            self.apartado = ""
            combos_info_tec(value)
            tipo_metadata = value
        }

        //Cargamos los combos dependiendo la región seleccionada
        let combos_info_tec = (value) => {
            obtenerComboIdInformeInfTec(value)
            obtenerComboTipoInformeInfTec(value)
            obtenerComboAreaInfTec(value)
            obtenerComboProspectoInfTec(value)
            obtenerComboContenidoInfTec(value)
            obtenerComboEdosAreaEstudioInfTec(value)
            obtenerComboTipoExpedienteInfTec(value)
            obtenerComboAniosInfTec(value)
        }

        let obtenerComboIdInformeInfTec = (value) => {
            wellDataContext.obtenerComboIdInformeInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listIdInformeInfTec = wellDataContext.listIdInformeInfTec
                        self.informe = self.listIdInformeInfTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboTipoInformeInfTec = (value) => {
            wellDataContext.obtenerComboTipoInformeInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listTipoInformeInfTec = wellDataContext.listTipoInformeInfTec
                        self.tipoInforme = self.listTipoInformeInfTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboAreaInfTec = (value) => {
            wellDataContext.obtenerComboAreaInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAreaInfoTec = wellDataContext.listAreaInfoTec
                        self.area = self.listAreaInfoTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboProspectoInfTec = (value) => {
            wellDataContext.obtenerComboProspectoInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listProspectoInfTec = wellDataContext.listProspectoInfTec
                        self.prospecto = self.listProspectoInfTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboContenidoInfTec = (value) => {
            wellDataContext.obtenerComboContenidoInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listContenidoInfTec = wellDataContext.listContenidoInfTec
                        self.contenido = self.listContenidoInfTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboEdosAreaEstudioInfTec = (value) => {
            wellDataContext.obtenerComboEdosAreaEstudioInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listEdosAreaEstudioInfTec = wellDataContext.listEdosAreaEstudioInfTec
                        self.edoAreaEstudio = self.listEdosAreaEstudioInfTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboTipoExpedienteInfTec = (value) => {
            wellDataContext.obtenerComboTipoExpedienteInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listTipoExpInfoTec = wellDataContext.listTipoExpInfoTec
                        self.tipoExpediente = self.listTipoExpInfoTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboAniosInfTec = (value) => {
            wellDataContext.obtenerComboAniosInfTec(value, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAniosInfoTec = wellDataContext.listAniosInfoTec
                        self.anio = self.listAniosInfoTec[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        this.abrirDocumentoInfoTec = (nombreDocumento, nombre_pozo) => {
            wellDataContext.abrirDocumentoInfoTec(nombreDocumento, nombre_pozo, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        let source = resp.source //---> \ > /
                        console.log(source)
                        source = (resp.source).substr(27, resp.source.length)
                        window.open(source, '_blank');
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        //Obtenemos los informes tecnicos de la región seleccionada (falta aplicar filtros de LINQ)
        this.obtenerGridInformesTecnicos = () => {

            $('#btn-buscar').prop('disabled', true);

            wellDataContext.obtenerGridInformesTecnicos(tipo_metadata, this.informe, this.tipoInforme, this.area, this.prospecto, this.contenido, this.anio, this.edoAreaEstudio, this.tipoExpediente, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listInformesTecnicos = wellDataContext.listInformesTecnicos
                        document.getElementById('div_tabla').classList.remove("hidden");
                        $('#btn-buscar').prop('disabled', false);
                        //$(document).ready(function () {
                        //    $('#data_table_imp').DataTable();
                        //});
                        break;
                    case "notgp":
                        alert(resp.message);
                        $('#btn-buscar').prop('disabled', false);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        // Funciones sin usar         
        this.obtenerGridFiltrado = () => {
            document.getElementById('div_tabla').classList.add("hidden");
            //let tipoInfo        = $("#tipo_informacion option:selected").text()
            let uwi = $("#uwi option:selected").text()
            let classpozo = $("#class_pozo option:selected").text()
            let statusPozo = $("#statu_pozo option:selected").text()
            let campo = $("#campo option:selected").text()
            let nombrepozo = $("#nombre_pozo option:selected").text()
            let mnemonico = $("#mnemonico option:selected").text()
            let apartado = $("#apartado option:selected").text()
            let estadoFisico = $("#estado option:selected").text()
            wellDataContext.obtenerGridFiltrado(this.inai, this.tipoInfo, this.uwi, this.classpozo, this.statusPozo, this.campo, this.nombrepozo, this.mnemonico, this.apartado, this.estadoFisico, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listDatosPozo = wellDataContext.listDatosPozo
                        document.getElementById('div_tabla').classList.remove("hidden");
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        // Afectaciones

        self.region_seleccionada_afectaciones = () => {
            if (self.region == "1")
                cargarCombosCia();
            else if (self.region == "2")
                cargarCombosPep();
        }

        this.reiniciarFiltrosAfectaciones = () => {
            //let e = document.getElementById("region");
            //let value = e.value;
            //region_seleccionada = value
            if (self.region === "1")
                cargarCombosCia();
            else if (self.region === "2")
                cargarCombosPep
        }

        let cargarCombosCia = () => {
            obtenerComboCompaniasCia();
            obtenerComboEstadoCia();
            obtenerComboProyectoCia();
            obtenerComboRegimenCia();
            //obtenerComboAfectadoCia();
        };
        let cargarCombosPep = () => {
            obtenerComboCompaniaPep();
            obtenerComboEstadoPep();
            obtenerComboProyectoPep();
            obtenerComboRegimenPep();
            //obtenerComboAfectadoPep();
        };

        let obtenerComboCompaniasCia = () => {
            wellDataContext.obtenerComboCompaniasCia( function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listCompaniasAfectaciones = wellDataContext.listCompaniasAfectaciones
                        self.compania = self.listCompaniasAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboEstadoCia = () => {
            wellDataContext.obtenerComboEstadoCia(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listEstadosAfectaciones = wellDataContext.listEstadosAfectaciones
                        self.estado = self.listEstadosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboMunicipioCia = (estado) => {
            wellDataContext.obtenerComboMunicipioCia(estado, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listMunicipiosAfectaciones = wellDataContext.listMunicipiosAfectaciones
                        self.municipio = self.listMunicipiosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboProyectoCia = () => {
            wellDataContext.obtenerComboProyectoCia(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listProyectosAfectaciones = wellDataContext.listProyectosAfectaciones;
                        self.proyecto = self.listProyectosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboRegimenCia = () => {
            wellDataContext.obtenerComboRegimenCia(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listRegimenAfectaciones = wellDataContext.listRegimenAfectaciones
                        self.regimen = self.listRegimenAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboAfectadoCia = () => {
            wellDataContext.obtenerComboAfectadoCia(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAfectadoAfectaciones = wellDataContext.listAfectadoAfectaciones
                        self.nombre_afectado = self.listAfectadoAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };


        let obtenerComboCompaniaPep = () => {
            wellDataContext.obtenerComboCompaniaPep(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listCompaniasAfectaciones = wellDataContext.listCompaniasAfectaciones
                        self.compania = self.listCompaniasAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboEstadoPep = () => {
            wellDataContext.obtenerComboEstadoPep(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listEstadosAfectaciones = wellDataContext.listEstadosAfectaciones
                        self.estado = self.listEstadosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboMunicipioPep = (estado) => {
            wellDataContext.obtenerComboMunicipioPep(estado, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listMunicipiosAfectaciones = wellDataContext.listMunicipiosAfectaciones
                        self.municipio = self.listMunicipiosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboProyectoPep = () => {
            wellDataContext.obtenerComboProyectoPep(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listProyectosAfectaciones = wellDataContext.listProyectosAfectaciones;
                        self.proyecto = self.listProyectosAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboRegimenPep = () => {
            wellDataContext.obtenerComboRegimenPep(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listRegimenAfectaciones = wellDataContext.listRegimenAfectaciones
                        self.regimen = self.listRegimenAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };

        let obtenerComboAfectadoPep = () => {
            wellDataContext.obtenerComboAfectadoPep(function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAfectadoAfectaciones = wellDataContext.listAfectadoAfectaciones
                        self.nombre_afectado = self.listAfectadoAfectaciones[0].id
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        };



        this.obtener_descripcion_cia = (id) => {
            wellDataContext.obtenerAfectacionCia(id, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listDetalleAfectacionCia = wellDataContext.listDetalleAfectacionCia;
                        self.nombre_compania_cia        = self.listDetalleAfectacionCia[0].Compania;
                        self.proyecto_cia               = self.listDetalleAfectacionCia[0].Proyecto;
                        self.no_caja_provicional        = self.listDetalleAfectacionCia[0].Num_Caja_Provicional;
                        self.no_estimacion              = self.listDetalleAfectacionCia[0].Num_Estimacion;
                        /*self.no_estacion              = self.listDetalleAfectacionCia[0].Num_Tomo;*/
                        self.no_tomo                    = self.listDetalleAfectacionCia[0].Num_Tomo;
                        self.no_dictamen                = self.listDetalleAfectacionCia[0].Num_Dictamen;
                        self.anio                       = self.listDetalleAfectacionCia[0].Anio;
                        self.afectado                   = self.listDetalleAfectacionCia[0].Nombre_Afectado;
                        self.finiquito                  = self.listDetalleAfectacionCia[0].Finiquito;
                        self.permiso                    = self.listDetalleAfectacionCia[0].No_Permiso;
                        self.fecha_solicitud_ficha_pago = self.listDetalleAfectacionCia[0].Fecha_Solicitud_Ficha_Pago;
                        self.fecha_pago                 = self.listDetalleAfectacionCia[0].Fecha_Pago;
                        self.predio_parecela_rancho     = self.listDetalleAfectacionCia[0].Predio_Parcela_Rancho;
                        self.municipiocia                  = self.listDetalleAfectacionCia[0].Municipio;
                        self.estadocia                     = self.listDetalleAfectacionCia[0].Estado;
                        self.regimen                    = self.listDetalleAfectacionCia[0].Regimen;
                        self.importe                    = self.listDetalleAfectacionCia[0].Importe;
                        self.afectaciones               = self.listDetalleAfectacionCia[0].Afectacion;
                        self.finiquito_afectaciones     = self.listDetalleAfectacionCia[0].Finiquito_x_Afectacion;
                        self.reporte_danios             = self.listDetalleAfectacionCia[0].Reporte_Danios;
                        self.croquis_plano              = self.listDetalleAfectacionCia[0].Croquis_Plano_Estudio;
                        self.evidencia_fotografica      = self.listDetalleAfectacionCia[0].Evidencia_Fotografica_Afectacion;
                        self.oficio_deslinde            = self.listDetalleAfectacionCia[0].Oficio_Deslinde;
                        self.acuerdo_permiso            = self.listDetalleAfectacionCia[0].Acuerdo_Permiso;
                        self.ine                        = self.listDetalleAfectacionCia[0].Ine;
                        self.copia_ficha_pago           = self.listDetalleAfectacionCia[0].Copia_Ficha_Pago;
                        self.observaciones              = self.listDetalleAfectacionCia[0].Observaciones;

                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        this.obtener_descripcion_pep = (id) => {
            wellDataContext.ObtenerAfectacionPep(id, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listDetalleAfectacionCia = wellDataContext.listAfectacionesPep;
                        self.nombre_compania_pep = self.listDetalleAfectacionCia[0].Compania;
                        self.proyecto_pep = self.listDetalleAfectacionCia[0].Proyecto;
                        self.clv_lev_sismologico = self.listDetalleAfectacionCia[0].Clave_Levantamiento_Sismologico;
                        self.no_caja_pep = self.listDetalleAfectacionCia[0].Num_Caja;
                        self.no_siarp_pep = self.listDetalleAfectacionCia[0].Num_Siarp; 
                        self.anio_pep = self.listDetalleAfectacionCia[0].Anio;
                        self.afectado_pep = self.listDetalleAfectacionCia[0].Nombre_Afectado;
                        self.folio_pep = self.listDetalleAfectacionCia[0].Folio;
                        self.fecha_solicitud_ficha_pago_pep = self.listDetalleAfectacionCia[0].Fecha_Solicitud_Ficha_Pago;
                        self.fecha_pago_pep = self.listDetalleAfectacionCia[0].Fecha_Pago;
                        self.nombre_comunidad_pep = self.listDetalleAfectacionCia[0].Comunidad;
                        self.municipio_pep = self.listDetalleAfectacionCia[0].Municipio;
                        self.estado_pep = self.listDetalleAfectacionCia[0].Estado;
                        self.regimen_pep = self.listDetalleAfectacionCia[0].Regimen;
                        self.importe_pep = self.listDetalleAfectacionCia[0].Importe;
                        self.afectaciones_pep = self.listDetalleAfectacionCia[0].Afectacion;
                        self.recibo_siarp_pep = self.listDetalleAfectacionCia[0].Recibo_Siarp_Firmas;
                        self.copia_finiquito_pep = self.listDetalleAfectacionCia[0].Copia_Finiquito_Afectaciones;
                        self.copia_ficha_pago_pep = self.listDetalleAfectacionCia[0].Copia_Ficha_Pago;
                        self.ine_pep = self.listDetalleAfectacionCia[0].Ine;
                        self.reporte_danios_pep = self.listDetalleAfectacionCia[0].Reporte_Danios;
                        self.formato_servidumbre_pep = self.listDetalleAfectacionCia[0].Formato_Permiso_Servidumbre;
                        self.documento_acredita_prop_pep = self.listDetalleAfectacionCia[0].Documento_Acredita_Propiedad;
                        self.copia_croquis_pep = self.listDetalleAfectacionCia[0].Croquis_Afectaciones;
                        self.copia_ubicacion_pep = self.listDetalleAfectacionCia[0].Copia_Ubicacion_Plano_Estudio;
                        self.copia_oficio_direccionamiento_pep = self.listDetalleAfectacionCia[0].Copia_Oficio_Direccionamiento_Presupuestal;
                        self.observaciones_pep = self.listDetalleAfectacionCia[0].Observaciones;

                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        self.estado_afeccion = () => {
            if (self.estado !== null) {
                if (self.region === "1")
                    obtenerComboMunicipioCia(self.estado);
                else if (self.region === "2")
                    obtenerComboMunicipioPep(self.estado);
            }
        }

        self.obtenerAfectaciones = () => {
            if (self.region == 1)
                obtenerAfectacionesCia();
            else
                obtenerAfectacionesPep()
        }

        let obtenerAfectacionesCia = () => {
            wellDataContext.ObtenerGridAfectaciones(self.compania, self.estado, self.municipio, self.proyecto, self.regimen, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAfectaciones = wellDataContext.listAfectaciones
                        document.getElementById('div_tabla').style.display = 'block';
                        document.getElementById('div_tabla_pep').style.display = 'none';
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        let obtenerAfectacionesPep = () => {
            wellDataContext.ObtenerGridAfectacionesPep(self.compania, self.estado, self.municipio, self.proyecto, self.regimen, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        self.listAfectaciones_pep = wellDataContext.listAfectaciones
                        document.getElementById('div_tabla').style.display = 'none';
                        document.getElementById('div_tabla_pep').style.display = 'block';
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }

        this.abrirDocumentoAfectacion = (afectado, folio, clave, proyecto, compania) => {
            let nombreDocto = `${afectado}_${folio}`;
            let carpeta = `${proyecto}_${clave}`;
            wellDataContext.abrirDocumentoAfectacion(nombreDocto, compania, function (resp) {
                switch (resp.ressult) {
                    case "tgp":
                        let source = resp.source //---> \ > /
                        console.log(source)
                        source = (resp.source).substr(27, resp.source.length)
                        window.open(source, '_blank');
                        break;
                    case "notgp":
                        alert(resp.message);
                        break;
                    default:
                        break;
                }
                $scope.$apply();
            });
        }
    }]);
})();


jQuery(document).ready(function ($) {
    $(document).ready(function () {
        $('.select').select2();
    });

    //if (location.href && location.href.indexOf('login') == -1) {
    //    $(document).ready(function () {
    //        $('#data_table_imp').DataTable();
    //        $('#data_table_registros_geo').DataTable();
    //    });
    //}
});