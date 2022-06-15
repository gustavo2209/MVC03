function amigosIns() {
    $("#tbl_amigos_accion").val("INS");
    $("#tbl_amigos_titulo").val("");
    $("#tbl_amigos_precio").val("");

    $("#dlg_amigos_title").text("Nuevo Amigo");
    $("#dlg_amigos_errores").html("");

    $("#dlg_amigos").modal("show");
}

function amigosUpd(idamigo) {
    $("#tbl_amigos_accion").val("UPD");
    $("#tbl_amigos_idamigo").val(idamigo);
    $("#tbl_amigos_nombre").val($("#nombre_" + idamigo).text().trim());
    $("#tbl_amigos_correo").val($("#correo_" + idamigo).text().trim());
    $("#tbl_amigos_telefono").val($("#telefono_" + idamigo).text().trim());
    $("#tbl_amigos_direccion").val($("#direccion_" + idamigo).text().trim());

    $("#dlg_amigos_title").text("Actualizar Amigo");
    $("#dlg_amigos_errores").html("");
    $("#dlg_amigos").modal("show");
}

function amigosInsUpd() {
    var accion = $("#tbl_amigos_accion").val();
    var idamigo = $("#tbl_amigos_idamigo").val();
    var nombre = $("#tbl_amigos_nombre").val();
    var correo = $("#tbl_amigos_correo").val();
    var telefono = $("#tbl_amigos_telefono").val();
    var direccion = $("#tbl_amigos_direccion").val();

    // VALIDANDO
    var msg = "<ul>";
    if ($.trim(nombre) === "") {
        msg += "<li>Ingrese nombre de amigo</li>";
    }
    if ($.trim(correo) === "") {
        msg += "<li>Debe ingresar correo electronico</li>";
    }
    if ($.trim(telefono) === "") {
        msg += "<li>Debe ingresar telefono</li>";
    }
    if ($.trim(direccion) === "") {
        msg += "<li>Debe ingresar direccion</li>";
    }
    msg += "</ul>";

    if (msg.length > 9) {
        $("#dlg_amigos_errores").html(msg);
    } else {
        window.location = "../Home/Index?accion=" + accion + "&idamigo=" + idamigo + "&nombre=" + nombre + "&correo=" + correo + "&telefono=" + telefono + "&direccion=" + direccion;
    }
}

function amigosDel(idamigo) {
    var titulo = $("#nombre_" + idamigo).text();
    $("#dlg_confirm_title").text("Retiro de Amigo");
    $("#dlg_confirm_msg").html("¿Eliminar " + titulo + "?");
    $("#dlg_confirm_dato1").val("DEL");
    $("#dlg_confirm_dato2").val(idamigo);
    $("#dlg_confirm_error").hide();
    $("#dlg_confirm").modal("show");
}

function dlg_confirm_confirm() {
    var accion = $("#dlg_confirm_dato1").val();

    if (accion === "DEL") {
        var idamigo = $("#dlg_confirm_dato2").val();

        window.location = "../Home/Index?accion=" + accion + "&idamigo=" + idamigo;
    } else if(accion === "OTRA_ACCION") {
        // para el futuro
    }
}