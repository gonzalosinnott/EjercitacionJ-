$("#Pais").change(function () {
    var PaisId = $(this).val();
    $.getJSON("/ABMDirecciones/LoadProvincias/", { PaisId },
        function (classesData) {
            var select = $("#Provincia");
            select.empty();
            select.append($('<option/>', {
                value: 0,
                text: "ELIJA UNA PROVINCIA"
            }));
            $.each(classesData, function (index, itemData) {
                select.append($('<option/>', {
                    value: itemData.Value,
                    text: itemData.Text
                }));
            });
        });
});

$("#Provincia").change(function () {
    var ProvinciaId = $(this).val();
    $.getJSON("/ABMDirecciones/LoadLocalidades/", { ProvinciaId },
        function (classesData) {
            var select = $("#Localidad");
            select.empty();
            select.append($('<option/>', {
                value: 0,
                text: "ELIJA UNA LOCALIDAD"
            }));
            $.each(classesData, function (index, itemData) {
                select.append($('<option/>', {
                    value: itemData.Value,
                    text: itemData.Text
                }));
            });
        });
});

$('#submitbtn').click(function (e) {
    e.preventDefault();
    if ($("#Pais").val() != "" && $("#Provincia").val() != "" && $("#Localidad").val() != "" && $("#CalleName").val() != "") {

        var selectedValue = "PAIS: " + $("#Pais option:selected").text() + '\r\n' +
            "PROVINCIA: " + $("#Provincia option:selected").text() + '\r\n' +
            "LOCALIDAD: " + $("#Localidad option:selected").text() + '\r\n' +
            "CALLE: " + $("#CalleName").val();
        $('#txtInfo').val(selectedValue);
    }
    else {
        alert("FALTAN COMPLETAR DATOS")
    }
});

$("#btnCreatePais").on("click", function () {

    $.ajax(
        {
            type: 'GET',
            url: '/ABMDirecciones/CreatePais',
            contentType: 'application/json; charset=utf=8',
            success: function (result) {
                $('#modal-add-content').html(result);
                $('#modal-add').modal('show');
            },
            error: function (er) {
                alert(er);
            }
        });
});

$("#btnCreateProvincia").on("click", function () {

    $.ajax(
        {
            type: 'GET',
            url: '/ABMDirecciones/CreateProvincia',
            contentType: 'application/json; charset=utf=8',
            success: function (result) {
                $('#modal-add-content').html(result);
                $('#modal-add').modal('show');
            },
            error: function (er) {
                alert(er);
            }
        });

});

$("#btnCreateLocalidad").on("click", function () {

    $.ajax(
        {
            type: 'GET',
            url: '/ABMDirecciones/CreateLocalidad',
            contentType: 'application/json; charset=utf=8',
            success: function (result) {
                $('#modal-add-content').html(result);
                $('#modal-add').modal('show');
            },
            error: function (er) {
                alert(er);
            }
        });

});

$("#btnDeletePais").on("click", function () {
    var data = $("#Pais").val()
    if (data == 0) {
        alert("SELECCIONE UN PAIS A ELIMINAR");
    }
    else {
        confirm('¿DESEA ELIMINAR ESTE PAIS?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeletePais?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        alert("REGISTRO ELIMINADO CON EXITO");
                        location.reload();
                    },
                    error: function (er) {
                        alert("LA TAREA FALLO CON EXITO");
                        location.reload();
                    }
                });
        }
    }

});

$("#btnDeleteProvincia").on("click", function () {
    var data = $("#Provincia").val()
    if (data == 0) {
        alert("SELECCIONE UNA PROVINCIA A ELIMINAR");
    }
    else {
        confirm('¿DESEA ELIMINAR ESTA PROVINCIA?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeleteProvincia?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        alert("REGISTRO ELIMINADO CON EXITO");
                        location.reload();
                    },
                    error: function (er) {
                        alert("LA TAREA FALLO CON EXITO");
                        location.reload();
                    }
                });
        }
    }
});

$("#btnDeleteLocalidad").on("click", function () {
    var data = $("#Localidad").val()
    if (data == 0) {
        alert("SELECCIONE UNA LOCALIDAD A ELIMINAR");
    }
    else {
        confirm('¿DESEA ELIMINAR ESTA PROVINCIA?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeleteLocalidad?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        alert("REGISTRO ELIMINADO CON EXITO");
                        location.reload();
                    },
                    error: function (er) {
                        alert("LA TAREA FALLO CON EXITO");
                        location.reload();
                    }
                });
        }
    }
});

$("#btnEditPais").on("click", function () {
    var data = $("#Pais").val();
    if (data == 0) {
        alert("SELECCIONE UN PAIS A MODIFICAR");
    }
    else {
        confirm('¿DESEA MODIFICAR ESTE PAIS?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/EditPais?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        $('#modal-edit-content').html(result);
                        $('#modal-edit').modal('show');
                    },
                    error: function (er) {
                        alert(er);
                    }
                });
        }
    }
});

$("#btnEditProvincia").on("click", function () {
    var data = $("#Provincia").val();
    if (data == 0) {
        alert("SELECCIONE UNA PROVINCIA A MODIFICAR");
    }
    else {
        confirm('¿DESEA MODIFICAR ESTA PROVINCIA?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/EditProvincia?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        $('#modal-edit-content').html(result);
                        $('#modal-edit').modal('show');
                    },
                    error: function (er) {
                        alert(er);
                    }
                });
        }
    }
});

$("#btnEditLocalidad").on("click", function () {
    var data = $("#Localidad").val();
    if (data == 0) {
        alert("SELECCIONE UNA LOCALIDAD A MODIFICAR");
    }
    else {
        confirm('¿DESEA MODIFICAR ESTA LOCALIDAD?')
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/EditLocalidad?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (result) {
                        $('#modal-edit-content').html(result);
                        $('#modal-edit').modal('show');
                    },
                    error: function (er) {
                        alert(er);
                    }
                });
        }
    }
});