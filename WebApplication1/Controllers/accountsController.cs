using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class accountsController : Controller
    {
        public JsonResult ComboTipoInfo()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboTipoInfo(); //SELECT A TABLA TIPO INFO
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboApartado(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboApartado(region_seleccionada); //SELECT A TABLA APARTADO
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboCampo(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboCampo(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboClassPozo(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboClassPozo(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboEstado(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboEstado(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboMnemonico(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboMnemonico(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboStatusPozo(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboStatusPozo(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboNombrePozo(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboNombrePozo(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboCadido(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboCadido(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboUwi(string region_seleccionada)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboUwi(region_seleccionada);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GridCatTx(string region, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            Resultado_Bloques objResultado = new Resultado_Bloques();
            Cat_Bloques objVeracruz = new Cat_Bloques();
            p1  = p1 == "0" ? string.Empty : p1;       //cadido
            p2  = p2 == "0" ? string.Empty : p2;       //tipoInfo
            p3  = p3 == "0" ? string.Empty : p3;       //uwi
            p4  = p4 == "0" ? string.Empty : p4;       //class_pozo
            p5  = p5 == "0" ? string.Empty : p5;       //status_pozo
            p6  = p6 == "0" ? string.Empty : p6;       //campo
            p7  = p7 == "0" ? string.Empty : p7;       //nombre_pozo
            p8  = p8 == "0" ? string.Empty : p8;       //id_mnemonico
            p9  = p9 == "0" ? string.Empty : p9;       //apartado
            p10 = p10 == "0" ? string.Empty : p10;     //estado


            objVeracruz.inai            = p1;
            objVeracruz.tipo_info       = p2;
            objVeracruz.uwi             = p3;
            objVeracruz.class_pozo      = p4;
            objVeracruz.status_pozo     = p5;
            objVeracruz.campo           = p6;
            objVeracruz.nombre_pozo     = p7;
            objVeracruz.id_mnemonico    = p8;
            objVeracruz.apartado        = p9;
            objVeracruz.estado          = p10;
            objVeracruz.Region          = region;

            try
            {
                List<Cat_Bloques> listPrincipal = new List<Cat_Bloques>();
                List<Cat_Bloques> list = new List<Cat_Bloques>();
                //objResultado.Resultado  = CursorDataContext.GridCatTx(objVeracruz);
                listPrincipal = CursorDataContext.GridCatTx(objVeracruz);
                System.Web.HttpContext.Current.Session["SessionListCatTx_Filtrada"] = listPrincipal;
                list = listPrincipal;

                if (p1 != "")
                {
                    var result = from c in list
                                 where c.id_cadido.Equals(p1)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    System.Web.HttpContext.Current.Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p2 != "") //tipoInfo
                {
                    var list2 = Session["SessionListCatTx_Filtrada"];
                    list = (List<Cat_Bloques>)list2;

                    var result = from c in list
                                 where c.id_info.Equals(p2)
                                 where c.id_info.Equals(p2)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p3 != "") //uwi
                {
                    var list3 = Session["SessionListCatTx_Filtrada"];
                    list = (List<Cat_Bloques>)list3;

                    var result = from c in list
                                 where c.id_uwi.Equals(p3)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p4 != "") //classpozo
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_class_pozo.Equals(p4)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p5 != "") //statusPozo
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_status_pozo.Equals(p5)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p6 != "") //campo
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_campo.Equals(p6)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p7 != "") //nombrepozo
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_nombre_pozo.Equals(p7)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p8 != "") //mnemonico
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_mnemonico.Equals(p8)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p9 != "") //apartado
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_apartado.Equals(p9)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p10 != "") //estadoFisico
                {
                    list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_estado.Equals(p10)
                                 select c;
                    result = result.ToList<Cat_Bloques>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }

                list = (List<Cat_Bloques>)Session["SessionListCatTx_Filtrada"];
                objResultado.Error = false;
                objResultado.Resultado = list;

                System.Web.HttpContext.Current.Session["SessionListaTxt"] = list;
                var jsonResult = Json(objResultado, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult obtenerGridDatosPozo(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            ResultadoTx objResultado = new ResultadoTx();
            try
            {
                List<WellData_Tx> list = new List<WellData_Tx>();
                List<WellData_Tx> listPrincipal = new List<WellData_Tx>();
                listPrincipal = (List<WellData_Tx>)Session["SessionListCatTx"];
                System.Web.HttpContext.Current.Session["SessionListCatTx_Filtrada"] = listPrincipal;
                list = listPrincipal;
                if (p1 != null)
                {
                    var result = from c in list
                                 where c.inai.Equals(p1)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    System.Web.HttpContext.Current.Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p2 != "0" && p2 != null) //tipoInfo
                {
                    var list2 = Session["SessionListCatTx_Filtrada"];
                    list = (List<WellData_Tx>)list2;

                    var result = from c in list
                                 where c.id_info.Equals(p2)
                                 //where c.id_info.Equals(p2)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p3 != "0" && p3 != null) //uwi
                {
                    var list3 = Session["SessionListCatTx_Filtrada"];
                    list = (List<WellData_Tx>)list3;

                    var result = from c in list
                                 where c.id_uwi.Equals(p3)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p4 != "0" && p4 != null) //classpozo
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_class_pozo.Equals(p4)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p5 != "0" && p5 != null) //statusPozo
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_status_pozo.Equals(p5)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p6 != "0" && p6 != null) //campo
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_campo.Equals(p6)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p7 != "0" && p7 != null) //nombrepozo
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_nombre_pozo.Equals(p7)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p8 != "0" && p8 != null) //mnemonico
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_mnemonico.Equals(p8)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p9 != "11" && p9 != null) //apartado
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_apartado.Equals(p9)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                if (p10 != "0" && p10     != null) //estadoFisico
                {
                    list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                    var result = from c in list
                                 where c.id_estado.Equals(p10)
                                 select c;
                    result = result.ToList<WellData_Tx>();
                    Session["SessionListCatTx_Filtrada"] = result;
                }
                list = (List<WellData_Tx>)Session["SessionListCatTx_Filtrada"];
                //var content = result.ToList<WellData_Tx>();
                objResultado.Error = false;
                objResultado.Resultado = list;

                var jsonResult = Json(objResultado, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;

                //return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                return Json(objResultado, JsonRequestBehavior.AllowGet);

            }
        }
        public JsonResult ObtenerDetalleMetadata(int p1)
        {
            try
            {
                WellData_Tx objData = new WellData_Tx();
                objData.id = p1;
                ResultadoTx objResultado = new ResultadoTx();
                objResultado.Resultado = CursorDataContext.ObtenerDetalleMetadata(objData);
                return Json(objResultado, JsonRequestBehavior.AllowGet);

            }
            catch(Exception ex)
            {
                ResultadoTx objResultado = new ResultadoTx();
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GenerarTxt(string region_documento)
        {
            ResultadoComun objRespuesta = new ResultadoComun();
            try
            {                
                List<Cat_Bloques> list = new List<Cat_Bloques>();
                //Cat_Bloques objBloques = new Cat_Bloques();

                list = (List<Cat_Bloques>)Session["SessionListaTxt"];

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Archivos_Welldata\Información_Pozos.txt"))
                {
                    int position = 0;
                    string Region = string.Empty;
                    if (region_documento == "1")
                        Region = "Veracruz";
                    else if (region_documento == "2")
                        Region = "Bloque Sur";
                    file.WriteLine(Region);
                    string encabezado = "ID       Expedientes de pozo     Descripcion";
                    file.WriteLine(encabezado);
                    foreach (Cat_Bloques objBloques in list)
                    {
                        position = position + 1;
                        string text = position +" -    " + objBloques.nombre_archivo_dig + "        " + objBloques.descripcion_mne;
                        file.WriteLine(text);

                    }
                }
                objRespuesta.Error = false;
                objRespuesta.MensajeError = "Archivo Generado Correctamente";

                return Json(objRespuesta, JsonRequestBehavior.AllowGet);
                
            }
            catch(Exception ex)
            {
                objRespuesta.Error = true;
                objRespuesta.MensajeError = ex.Message;
                return Json(objRespuesta, JsonRequestBehavior.AllowGet);
                
            }
        }

        /*--------------------INFO BLOQUE SUR--------------------*/

        public JsonResult ComboApartadoBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboApartadoBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboCadidoBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboCadidoBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboCampoBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboCampoBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboEstadoDoctoBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboEstadoDoctoBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboMneBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboMneBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboNombrePozoBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboNombrePozoBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboUwiBloqueSur()
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboUwiBloqueSur();
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ObtenerGridBloqueSur(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            Resultado_Bloques objResultado = new Resultado_Bloques();
            Cat_Bloques objVeracruz = new Cat_Bloques();
            p1 = p1 == "0" ? string.Empty : p1;       //cadido
            p2 = p2 == null ? string.Empty : p2;       //tipoInfo
            p3 = p3 == "0" ? string.Empty : p3;       //uwi
            p4 = p4 == null ? string.Empty : p4;       //class_pozo
            p5 = p5 == null ? string.Empty : p5;       //status_pozo
            p6 = p6 == null ? string.Empty : p6;       //campo
            p7 = p7 == "0" ? string.Empty : p7;       //nombre_pozo
            p8 = p8 == "0" ? string.Empty : p8;       //id_mnemonico
            p9 = p9 == "0" ? string.Empty : p9;       //apartado
            p10 = p10 == "0" ? string.Empty : p10;     //estado


            objVeracruz.inai = p1;
            objVeracruz.tipo_info = p2;
            objVeracruz.uwi = p3;
            objVeracruz.class_pozo = p4;
            objVeracruz.status_pozo = p5;
            objVeracruz.campo = p6;
            objVeracruz.nombre_pozo = p7;
            objVeracruz.id_mnemonico = p8;
            objVeracruz.apartado = p9;
            objVeracruz.estado = p10;

            try
            {
                List<Cat_Bloques> listPrincipal = new List<Cat_Bloques>();
                List<Cat_Bloques> list = new List<Cat_Bloques>();
                objResultado.Resultado = CursorDataContext.ObtenerGridBloqueSur(objVeracruz);
                objResultado.Error = false;

                var jsonResult = Json(objResultado, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }

        /*--------------------REGISTROS GEOFISICOS--------------------*/
        public JsonResult GridCatRegistrosGeoVer(string region, string p1, string p2)
        {
            Resultado_Registros_Geo_Veracruz objResultado = new Resultado_Registros_Geo_Veracruz();
            Cat_Registros_Geo_Veracruz objRegistrosGeo = new Cat_Registros_Geo_Veracruz();
            
            p1 = p1 == "0" ? string.Empty : p1;       //pozo

            objRegistrosGeo.Pozo = p1;
            objRegistrosGeo.Region = region;
            objRegistrosGeo.Campo = string.Empty;
            try
            {
                List<Cat_Registros_Geo_Veracruz> listPrincipal = new List<Cat_Registros_Geo_Veracruz>();
                List<Cat_Registros_Geo_Veracruz> list = new List<Cat_Registros_Geo_Veracruz>();
                //objResultado.Resultado  = CursorDataContext.GridCatTx(objVeracruz);
                listPrincipal = CursorDataContext.GridCatRegistrosGeoVer(objRegistrosGeo);
                objResultado.Error = false;
                objResultado.Resultado = listPrincipal;
                System.Web.HttpContext.Current.Session["SessionListaTxt"] = listPrincipal;
                list = listPrincipal;


                if (p1 != "")
                {
                    var result = from c in list
                                 where c.Id_Pozo.Equals(p1)
                                 select c;
                    result = result.ToList<Cat_Registros_Geo_Veracruz>();
                    System.Web.HttpContext.Current.Session["SessionListCatTx_Filtrada"] = result;
                }
                //if (p2 != "") //tipoInfo
                //{
                //    var list2 = Session["SessionListCatTx_Filtrada"];
                //    list = (List<Cat_Bloques>)list2;

                //    var result = from c in list
                //                 where c.id_info.Equals(p2)
                //                 where c.id_info.Equals(p2)
                //                 select c;
                //    result = result.ToList<Cat_Bloques>();
                //    Session["SessionListCatTx_Filtrada"] = result;
                //}

                list = (List<Cat_Registros_Geo_Veracruz>)Session["SessionListCatTx_Filtrada"];
                objResultado.Error = false;
                objResultado.Resultado = list;

                System.Web.HttpContext.Current.Session["SessionListaTxt"] = list;

                var jsonResult = Json(objResultado, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }

        /*--------------------INFORME TECNICO VERACRUZ--------------------*/
        public JsonResult ComboIdInformeInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboIdInformeInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboTipoInformeInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboTipoInformeInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboAreaInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboAreaInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboProspectoInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboProspectoInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboContenidoInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboContenidoInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboEdosAreaEstudioInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboEdosAreaEstudioInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboTipoExpedienteInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboTipoExpedienteInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult ComboAniosInfTec(string tipo_metadata)
        {
            Comun objComun = new Comun();
            ResultadoComun objResultado = new ResultadoComun();
            try
            {
                objResultado.Resultado = CursorDataContext.ComboAniosInfTec(tipo_metadata);
                objResultado.Error = false;
                objResultado.MensajeError = "";
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GirdInformesTecnicos(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            ResultadoInformeTecnico objResultado = new ResultadoInformeTecnico();
            WellData_Informe_Tecnico objInfoTec = new WellData_Informe_Tecnico();
            try
            {                
                p1 = p1 == "0" ? string.Empty : p1;       //tipo_metadata
                p2 = p2 == "0" ? string.Empty : p2;       //id_informe
                p3 = p3 == "0" ? string.Empty : p3;       //tipo_informe
                p4 = p4 == "0" ? string.Empty : p4;       //area
                p5 = p5 == "0" ? string.Empty : p5;       //prospecto
                p6 = p6 == "0" ? string.Empty : p6;       //contenido
                p7 = p7 == "0" ? string.Empty : p7;       //anio
                p8 = p8 == "0" ? string.Empty : p8;       //estados_area_estudio
                p9 = p9 == "0" ? string.Empty : p9;       //tipo_expediente


                objInfoTec.Tipo_Metadata = p1;
                objInfoTec.Id_Informe = p2;
                objInfoTec.Tipo_Informe = p3;
                objInfoTec.Area = p4;
                objInfoTec.Prospecto = p5;
                objInfoTec.Contenido = p6;
                objInfoTec.Anio = p7;
                objInfoTec.Estados_AreaEstudio = p8;
                objInfoTec.Tipo_Expediente = p9;

                List<WellData_Informe_Tecnico> list_informes_tec = new List<WellData_Informe_Tecnico>();
                List<WellData_Informe_Tecnico> list = new List<WellData_Informe_Tecnico>();
                list_informes_tec = CursorDataContext.GridInfomresTecnicos(objInfoTec);
                System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = list_informes_tec;




                /*FILTROS*/
                list = list_informes_tec;

                if (p2 != "")
                {
                    var result = from c in list
                                 where c.Id_Informe.Equals(p2)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p3 != "")
                {
                    var result = from c in list
                                 where c.Id_Tipo_Informe.Equals(p3)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p4 != "")
                {
                    var result = from c in list
                                 where c.Id_Area.Equals(p4)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p5 != "")
                {
                    var result = from c in list
                                 where c.Id_Prospecto.Equals(p5)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p6 != "")
                {
                    var result = from c in list
                                 where c.Id_Contenido.Equals(p6)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p7 != "")
                {
                    var result = from c in list
                                 where c.Id_Anio.Equals(p7)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p8 != "")
                {
                    var result = from c in list
                                 where c.Id_Estados_AreaEstudios.Equals(p8)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }
                else if (p9 != "")
                {
                    var result = from c in list
                                 where c.Id_Tipo_Expediente.Equals(p9)
                                 select c;
                    result = result.ToList<WellData_Informe_Tecnico>();
                    System.Web.HttpContext.Current.Session["SessionListInfTec_Filtrada"] = result;
                }

                /*TERMINA*/


                list = (List<WellData_Informe_Tecnico>)Session["SessionListInfTec_Filtrada"];
                objResultado.Error = false;
                objResultado.Resultado = list;

                System.Web.HttpContext.Current.Session["SessionListaInformesTecnicos"] = list;
                var jsonResult = Json(objResultado, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;

            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }




        public JsonResult IniciarSesion(string username, string password)
        {
            WellData_Usuario objUsuario = new WellData_Usuario();
            ResultadoUsuario objResultado = new ResultadoUsuario();
            try
            {
                objUsuario.Usuario = username;
                objUsuario.Password = password;
                objUsuario = CursorDataContext.IniciarSesion(objUsuario);
                if (objUsuario.Nombre != null)
                {
                    objResultado.Error = false;
                    objResultado.MensajeError = "";
                    System.Web.HttpContext.Current.Session["SessionLogin"] = objResultado;
                }
                else {
                    objResultado.Error = true;
                    objResultado.MensajeError = "Error en los datos de sesión";
                    System.Web.HttpContext.Current.Session["SessionLogin"] = objResultado;
                }
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                objResultado.Error = true;
                objResultado.MensajeError = ex.Message;
                objResultado.Resultado = null;
                return Json(objResultado, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult AbrirDocumento(string docto, string region, string nombre_pozo, string tipo)
        {
            ResultadoComun objResultado = new ResultadoComun();
            Comun objArchivo = new Comun();

            string file_name = docto + ".pdf";
            //string file_name = "prueba1.txt";

            //var files = System.IO.Directory.GetFiles("D:/Neuralog_PDFS", file_name, System.IO.SearchOption.AllDirectories);
            var files = System.IO.Directory.GetFiles("C:/inetpub/wwwroot/neuralog/Archivos_Welldata/", file_name, System.IO.SearchOption.AllDirectories);

            //System.Diagnostics.Process.Start(files[0]);

            if (files.Length > 0)
            {
                objResultado.Error = false;
                objResultado.MensajeError = string.Empty;
                objResultado.Ruta_Archivo = files[0];
            }
            else
            {
                objResultado.Error = true;
                objResultado.MensajeError = "No existe el archivo";
            }
            return Json(objResultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AbrirDocumentoInfoTec(string docto, string nombre_pozo)
        {
            ResultadoComun objResultado = new ResultadoComun();
            Comun objArchivo = new Comun();

            string file_name = docto + ".pdf";
            //string file_name = "prueba1.txt";

            //var files = System.IO.Directory.GetFiles("D:/Neuralog_PDFS", file_name, System.IO.SearchOption.AllDirectories);
            var files = System.IO.Directory.GetFiles("C:/inetpub/wwwroot/neuralog/Archivos_Welldata/", file_name, System.IO.SearchOption.AllDirectories);

            //System.Diagnostics.Process.Start(files[0]);

            if (files.Length > 0)
            {
                objResultado.Error = false;
                objResultado.MensajeError = string.Empty;
                objResultado.Ruta_Archivo = files[0];
            }
            else
            {
                objResultado.Error = true;
                objResultado.MensajeError = "No existe el archivo";
            }
            return Json(objResultado, JsonRequestBehavior.AllowGet);
        }

        

        // GET: accounts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult menu()
        {
            ResultadoUsuario objResultado = new ResultadoUsuario();
            objResultado = (ResultadoUsuario)System.Web.HttpContext.Current.Session["SessionLogin"];
            if (System.Web.HttpContext.Current.Session["SessionLogin"] != null && objResultado.Error == false)
            {
                return View();
            }
            else
                return RedirectToAction("login", "accounts");
        }
        public ActionResult documento()
        {
            ResultadoUsuario objResultado = new ResultadoUsuario();
            objResultado = (ResultadoUsuario)System.Web.HttpContext.Current.Session["SessionLogin"];
            if (System.Web.HttpContext.Current.Session["SessionLogin"] != null && objResultado.Error == false)
            {
                return View();
            }
            else
                return RedirectToAction("login", "accounts");
        }
        public ActionResult informe()
        {
            ResultadoUsuario objResultado = new ResultadoUsuario();
            objResultado = (ResultadoUsuario)System.Web.HttpContext.Current.Session["SessionLogin"];
            if (System.Web.HttpContext.Current.Session["SessionLogin"] != null && objResultado.Error == false)
            {
                return View();
            }
            else
                return RedirectToAction("login", "accounts");
        }
    }
}