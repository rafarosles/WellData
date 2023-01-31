/// <reference path="../global.js"/>

var wellDataContext =
{
    listTipoInfo: [],
    listApartado: [],
    listCampo: [],
    listClassPozo: [],
    listEstado : [],
    listmnemonico: [],
    listUwi: [],
    listStatusPozo: [],
    listNombrePozo : [],
    listDatosPozo: [],
    listDetalleMetadata: [],
    listCadido: [],
    listApartadoBloqueSur: [],
    listCadidoBloqueSur: [],
    listCampoBloqueSur: [],
    listEdoDoctoBloqueSur: [],
    listMneBloqueSur: [],
    listNombrePozoBloqueSur : [],
    listUwiBloqueSur: [],
    listEdoInfTecVer: [],
    listInfInfTecVer: [],
    listInformeInfTecVer: [],
    listPropsInfTecVer: [],
    listTipoExpInfTecVer: [],
    listRegistrosGeoVer: [],
    listIdInformeInfTec: [],
    listTipoInformeInfTec: [],
    listAreaInfoTec: [],
    listProspectoInfTec: [],
    listContenidoInfTec: [],
    listEdosAreaEstudioInfTec: [],
    listTipoExpInfoTec: [],
    listAniosInfoTec: [],
    listInformesTecnicos: [],

    obtenerCompoTipoInfo: function (callBackResult) {
        let self = this;
        self.listTipoInfo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",            
            url: urlServer + "accounts/ComboTipoInfo",
            data: {  },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listTipoInfo.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboApartado: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listApartado.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboApartado",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listApartado.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboCampo: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listCampo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboCampo",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listCampo.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboClassPozo: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listClassPozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboClassPozo",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listClassPozo.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboEstado: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listEstado.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboEstado",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listEstado.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboMnemonico: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listmnemonico.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboMnemonico",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listmnemonico.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboUwi: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listUwi.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboUwi",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listUwi.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboStatusPozo: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listStatusPozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboStatusPozo",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listStatusPozo.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboNombrePozo: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listNombrePozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboNombrePozo",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listNombrePozo.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboCadido: function (region_seleccionada, callBackResult) {
        let self = this;
        self.listCadido.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboCadido",
            data: { region_seleccionada },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listCadido.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerGridDatosPozo: function (region, inai, tipoInfo, uwi, class_pozo, status_pozo, campo, nombre_pozo, id_mnemonico, apartado, estado, callBackResult) {
        let self = this;
        self.listDatosPozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/GridCatTx",
            data: { region, p1: inai, p2: tipoInfo, p3: uwi, p4: class_pozo, p5: status_pozo, p6: campo, p7: nombre_pozo, p8: id_mnemonico, p9: apartado, p10: estado },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listDatosPozo.push({
                            id: resp.Resultado[i].id,
                            nombre_archivo_dig: resp.Resultado[i].nombre_archivo_dig,
                            inai: resp.Resultado[i].inai,
                            uwi: resp.Resultado[i].uwi,
                            codigo_mne: resp.Resultado[i].id_mnemonico,
                            nombre_pozo: resp.Resultado[i].nombre_pozo,
                            descripcion_mne: resp.Resultado[i].descripcion_mne
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerGridFiltrado: function (inai, tipoInfo, uwi, classpozo, statusPozo, campo, nombrepozo, mnemonico, apartado, estadoFisico, callBackResult) {
        let self = this;
        self.listDatosPozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/obtenerGridDatosPozo",
            data: { p1: inai, p2: tipoInfo, p3: uwi, p4: classpozo, p5:statusPozo, p6:campo, p7:nombrepozo, p8:mnemonico, p9:apartado, p10:estadoFisico },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listDatosPozo.push({
                            id: resp.Resultado[i].id, inai: resp.Resultado[i].inai, nombre_archivo_dig: resp.Resultado[i].nombre_archivo_dig, uwi: resp.Resultado[i].uwi, codigo_mne : resp.Resultado[i].codigo_mne, ubicacion : resp.Resultado[i].ubicacion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }                
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerDetalleMetadata: function (id, callBackResult) {
        let self = this;
        self.listDetalleMetadata.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ObtenerDetalleMetadata",
            data: { p1: id },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listDetalleMetadata.push({
                            inai: resp.Resultado[i].inai, uwi: resp.Resultado[i].uwi,
                            nombre_archivo_dig: resp.Resultado[i].nombre_archivo_dig, ubicacion: resp.Resultado[i].ubicacion,
                            no_caja: resp.Resultado[i].no_caja, tipo_info: resp.Resultado[i].tipo_info,
                            class_pozo: resp.Resultado[i].class_pozo, status_pozo: resp.Resultado[i].status_pozo,
                            campo: resp.Resultado[i].campo, nombre_pozo: resp.Resultado[i].nombre_pozo,
                            mnemonico: resp.Resultado[i].mnemonico, apartado: resp.Resultado[i].apartado,
                            total_hojas: resp.Resultado[i].total_hojas, no_total_paginas: resp.Resultado[i].no_total_paginas,
                            observaciones: resp.Resultado[i].observaciones, estado: resp.Resultado[i].estado
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    /*--------------------INFO BLOQUE SUR--------------------*/

    obtenerComboApartadoBloqueSur: function (callBackResult) {
        let self = this;
        self.listApartadoBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboApartadoBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listApartadoBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboCadidoBloqueSur: function (callBackResult) {
        let self = this;
        self.listCadidoBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboCadidoBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listCadidoBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboCampoBloqueSur: function (callBackResult) {
        let self = this;
        self.listCampoBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboCampoBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listCampoBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboEdoDoctoBloqueSur: function (callBackResult) {
        let self = this;
        self.listEdoDoctoBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboEstadoDoctoBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listEdoDoctoBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboMneBloqueSur: function (callBackResult) {
        let self = this;
        self.listMneBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboMneBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listMneBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboNombrePozoBloqueSur: function (callBackResult) {
        let self = this;
        self.listNombrePozoBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboNombrePozoBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listNombrePozoBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboUwiBloqueSur: function (callBackResult) {
        let self = this;
        self.listUwiBloqueSur.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboUwiBloqueSur",
            data: {},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listUwiBloqueSur.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerGridBloqueSur: function (inai, tipoInfo, uwi, class_pozo, status_pozo, campo, nombre_pozo, id_mnemonico, apartado, estado, callBackResult) {
        let self = this;
        self.listDatosPozo.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ObtenerGridBloqueSur",
            data: { p1: inai, p2: tipoInfo, p3: uwi, p4: class_pozo, p5: status_pozo, p6: campo, p7: nombre_pozo, p8: id_mnemonico, p9: apartado, p10: estado },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listDatosPozo.push({
                            id: resp.Resultado[i].id,
                            nombre_archivo_dig: resp.Resultado[i].nombre_archivo_dig,
                            inai: resp.Resultado[i].inai,
                            uwi: resp.Resultado[i].uwi,
                            codigo_mne: resp.Resultado[i].id_mnemonico,
                            nombre_pozo: resp.Resultado[i].nombre_pozo
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    /*------------------- REGISTROS GEOFISICOS -----------------------*/
    obtenerGridRegistrosGeoVer: function (region, nombre_pozo, callBackResult) {
        let self = this;
        self.listRegistrosGeoVer.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/GridCatRegistrosGeoVer",
            data: { region, p1: nombre_pozo },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listRegistrosGeoVer.push({
                            id: resp.Resultado[i].ID,
                            campo: resp.Resultado[i].Campo,
                            pozo: resp.Resultado[i].Pozo,
                            descripcion: resp.Resultado[i].Descripcion,
                            compania: resp.Resultado[i].Compania,
                            estado_fisico: resp.Resultado[i].Estado_Fisico,
                            escala: resp.Resultado[i].Escala,
                            cima: resp.Resultado[i].Cima,
                            base: resp.Resultado[i].Base,
                            fecha_registro: resp.Resultado[i].Fecha_Registro,
                            observaciones: resp.Resultado[i].Observaciones,
                            codigo_caja: resp.Resultado[i].Codigo_Caja,
                            ubicacion: resp.Resultado[i].Ubicacion

                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },


    /*-------------------INFORME TECNICO VERACRUZ-----------------------*/
    obtenerComboIdInformeInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listIdInformeInfTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboIdInformeInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listIdInformeInfTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboTipoInformeInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listTipoInformeInfTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboTipoInformeInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listTipoInformeInfTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboAreaInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listAreaInfoTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboAreaInfTec",
            data: { tipo_metadata},
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listAreaInfoTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboProspectoInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listProspectoInfTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboProspectoInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listProspectoInfTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboContenidoInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listContenidoInfTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboContenidoInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listContenidoInfTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboEdosAreaEstudioInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listEdosAreaEstudioInfTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboEdosAreaEstudioInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listEdosAreaEstudioInfTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboTipoExpedienteInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listTipoExpInfoTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboTipoExpedienteInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listTipoExpInfoTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerComboAniosInfTec: function (tipo_metadata, callBackResult) {
        let self = this;
        self.listAniosInfoTec.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/ComboAniosInfTec",
            data: { tipo_metadata },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listAniosInfoTec.push({
                            id: resp.Resultado[i].Id, descripcion: resp.Resultado[i].Descripcion
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    obtenerGridInformesTecnicos: function (tipo_metadata, id_informe, tipo_informe, area, prospecto, contenido, anio, estados_area_estudio, tipo_expediente, callBackResult) {
        let self = this;
        self.listInformesTecnicos.length = 0;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/GirdInformesTecnicos",
            data: { p1: tipo_metadata, p2: id_informe, p3: tipo_informe, p4: area, p5: prospecto, p6: contenido, p7: anio, p8: estados_area_estudio, p9: tipo_expediente },
            success: function (resp) {
                if (resp.Error === false) {
                    for (var i = 0; i < resp.Resultado.length; i++) {
                        self.listInformesTecnicos.push({
                            id: resp.Resultado[i].Id,
                            bloque: resp.Resultado[i].Bloque,
                            ubicacion: resp.Resultado[i].Ubicacion,
                            num_caja: resp.Resultado[i].Num_Caja,
                            tipo_informacion: resp.Resultado[i].Tipo_Info,
                            id_Informe: resp.Resultado[i].Id_Informe,
                            tipo_Informe: resp.Resultado[i].Tipo_Informe,
                            area: resp.Resultado[i].Area,
                            prospecto: resp.Resultado[i].Prospecto,
                            contenido: resp.Resultado[i].Contenido,
                            anio: resp.Resultado[i].Anio,
                            estados_areaestudio: resp.Resultado[i].Estados_AreaEstudio,
                            tipo_expediente: resp.Resultado[i].Tipo_Expediente,
                            tipo_pack: resp.Resultado[i].Tipo_Pack,
                            nombre_archivo_digital: resp.Resultado[i].Nombre_Archivo_Digital
                        });
                    }
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },


    crearTxt: function (region_documento, callBackResult) {
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/GenerarTxt",
            data: { region_documento },
            success: function (resp) {
                if (resp.Error === false)
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    iniciarSesion: function (usuario, contrasenia, callBackResult) {
        let self = this;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/IniciarSesion",
            data: { username: usuario, password: contrasenia },
            success: function (resp) {
                if (resp.Error === false)
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError });
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    abrirDocumento: function (nombreDocumento, region, nombre_pozo, tipo, callBackResult) {
        let self = this;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/AbrirDocumento",
            data: { docto: nombreDocumento, region: region, nombre_pozo: nombre_pozo, tipo: tipo},
            success: function (resp) {
                if (resp.Error === false) {                    
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError, source: resp.Ruta_Archivo });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    },

    abrirDocumentoInfoTec: function (nombreDocumento, nombre_pozo,  callBackResult) {
        let self = this;
        $.ajax({
            beforeSend: function () {
                /*$('#buscandoEmpresa').show()*/
            },
            type: "GET",
            url: urlServer + "accounts/AbrirDocumentoInfoTec",
            data: { docto: nombreDocumento,nombre_pozo: nombre_pozo },
            success: function (resp) {
                if (resp.Error === false) {
                    callBackResult({ ressult: 'tgp', message: resp.MensajeError, source: resp.Ruta_Archivo });
                }
                else
                    callBackResult({ ressult: 'notgp', message: resp.MensajeError });
            },
            error: function (ex) {
                callBackResult({ ressult: 'notgp', message: ex });
            },
            complete: function () {
                /*$('#buscandoEmpresa').hide()*/
            }
        });
    }
};