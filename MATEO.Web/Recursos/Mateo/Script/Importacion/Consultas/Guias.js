var GetConsultGuiaResult;
GetConsultGuiaResult = {
    "GetConsultGuiaResult": {
        "Result": {
            "Codigo": 1,
            "Mensaje": "OK",
            "ResultEje": true
        },
        "lstCabVolante": null,
        "lstDetVolante": null,
        "lstUbicVolante": null,
        "lstVolanteReport": [
          {
              "CO_CIUD_DEST": "MXMEX ",
              "CO_CIUD_ORIG": "USIAH ",
              "CO_EMPR": "06",
              "CO_ENTI_AGEM": "9999        ",
              "CO_ENTI_AGRE": "9999        ",
              "CO_ENTI_CONS": "99999999999 ",
              "CO_ENTI_LINE": "UA          ",
              "CO_TERM": "0001",
              "DE_CARG_0001": "UAL CATERING  SUPPLIES SLAC  151",
              "DE_DEST_CARG": "",
              "DE_ENTI_AGEM": "",
              "DE_ENTI_AGRE": "",
              "DE_ORIG_CARG": "",
              "DE_TIPO_INGR": "",
              "KG_RECI": "797,15",
              "KG_RECI_VOLA": "797,15",
              "NO_CONS": "UNITED AIRLINES C/O LSG/SKY CHAFS-MEXHI-0193123",
              "NU_BULT_RECI": "151",
              "NU_BULT_VOLA": "151",
              "NU_GUIA": "190240260CHI",
              "NU_GUIA_MADR": "001615492956",
              "NU_MANI": "201600000000070",
              "NU_VOLA": "00415599",
              "NU_VOLA_MADR": "00415599",
              "NU_VUEL": "1092",
              "Result": null,
              "ST_INVE": "S",
              "ST_TRAN": "",
              "ST_VOLA": "NOR",
              "TI_INGR": "NR"
          }
        ]
    }
};
function GuiasGetData() {

    if (GetConsultGuiaResult.GetConsultGuiaResult.Result.Codigo == 1) {
        var lstDatosGrilla = GetConsultGuiaResult.GetConsultGuiaResult.lstVolanteReport;
        SetDataGuiaGrid(lstDatosGrilla);
    }
    else {
        //Mensaje de Error

    }

};
function SetDataGuiaGrid(DataGrid) {    
    if (DataGrid.lstVolanteReport.length >= 1) {
        if (DataGrid.lstVolanteReport.length = 1) {
            SelectGridVola(DataGrid);
        }
        else {

        }
    }

};
function FillGridTable(DataGrid)
{
    
}
function SelectGridVola(RegVolante)
{
    /*[data-mani='...']*/
    
    
    var NU_MANI = $("[data-mani='NU_MANI']");
    var NU_VUEL = $("[data-mani='NU_VUEL']");
    var DE_ENTI_LINE = $("[data-mani='DE_ENTI_LINE']");
    var DE_ORIG_VUEL = $("[data-mani='DE_ORIG_VUEL']");
    var DE_DEST_VUEL = $("[data-mani='DE_DEST_VUEL']");

    var NU_VOLA = $("[data-vola='NU_VOLA']");
    var NU_GUIA_MADR = $("[data-vola='NU_GUIA_MADR']");
    var NU_GUIA = $("[data-vola='NU_GUIA']");
    var DE_ORIG_CARG = $("[data-vola='DE_ORIG_CARG']");
    var DE_DEST_CARG = $("[data-vola='DE_DEST_CARG']");
    var DE_AGEN_RECE = $("[data-vola='DE_AGEN_RECE']");
    var DE_AGEN_EMBA = $("[data-vola='DE_AGEN_EMBA']");
    var NU_BULT = $("[data-vola='NU_BULT']");
    var KG_RECI = $("[data-vola='KG_RECI']");
    var TP_INGR = $("[data-vola='TP_INGR']");
    var DE_CARG = $("[data-vola='DE_CARG']");
    var DE_CONS = $("[data-vola='DE_CONS']");
    
    NU_MANI.text(RegVolante.NU_MANI);
    NU_VUEL.text(RegVolante.NU_VUEL);
    DE_ENTI_LINE.text(RegVolante.DE_ENTI_LINE);
    DE_ORIG_VUEL.text(RegVolante.DE_ORIG_VUEL);
    DE_DEST_VUEL.text(RegVolante.DE_DEST_VUEL);

    NU_VOLA.text(RegVolante.NU_VOLA);
    NU_GUIA_MADR.text(RegVolante.NU_GUIA_MADR);
    NU_GUIA.text(RegVolante.NU_GUIA);
    DE_ORIG_CARG.text(RegVolante.DE_ORIG_CARG);
    DE_DEST_CARG.text(RegVolante.DE_DEST_CARG);
    DE_AGEN_RECE.text(RegVolante.DE_AGEN_RECE);
    DE_AGEN_EMBA.text(RegVolante.DE_AGEN_EMBA);
    NU_BULT.text(RegVolante.NU_BULT);
    KG_RECI.text(RegVolante.KG_RECI);
    TP_INGR.text(RegVolante.TP_INGR);
    DE_CARG.text(RegVolante.DE_CARG);
    DE_CONS.text(RegVolante.DE_CONS);

}



