$(document).ready(function () {

    $("#Pais").change(function () {
        var PaisId = $(this).val();
        var select = $("#Localidad");
        select.empty();
        select.append($('<option/>', {
            value: 0,
            text: "ELIJA UNA LOCALIDAD"
        }));
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

});


function LimpiarFormulario() {

    $("#Pais").val('')

    var select = $("#Provincia");
    select.empty();
    select.append($('<option/>', {
        value: 0,
        text: "ELIJA UNA PROVINCIA"
    }));

    var select = $("#Localidad");
    select.empty();
    select.append($('<option/>', {
        value: 0,
        text: "ELIJA UNA LOCALIDAD"
    }));

    $("#CalleName").val('')
    $('#txtInfo').val('')
};



function CargarDireccion() {
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
};



function CreatePais(){
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
};

function CreateProvincia(){
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
};

$('#ProvinciaCreateSelectedPais').change(function () {
    $('#PaisId').val($('#Pais:selected').val());
});

function CreateLocalidad() {
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

};

$('#LocalidadCreateSelectedProvincia').change(function () {
    $('#ProvinciaId').val($('#Provincia:selected').val());
});

function DeletePais()  {
    var data = $("#Pais").val()
    if (data == 0) {
        alert("SELECCIONE UN PAIS A ELIMINAR");
    }
    else {
        if(confirm('¿DESEA ELIMINAR ESTE PAIS?')==true)
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeletePais?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (response) {
                        if (response.result == "SUCCESS") {
                            alert("REGISTRO BORRADO");
                            location.reload();
                        }
                    },
                    error: function (er) {
                        alert("ERROR AL QUERER BORRAR EL REGISTRO");
                    }
                });
        }
    }
};

function DeleteProvincia()  {
    var data = $("#Provincia").val()
    if (data == 0) {
        alert("SELECCIONE UNA PROVINCIA A ELIMINAR");
    }
    else {
        if (confirm('¿DESEA ELIMINAR ESTA PROVINCIA?') == true)
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeleteProvincia?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (response) {
                        if (response.result == "SUCCESS") {
                            alert("REGISTRO BORRADO");
                            LimpiarFormulario();
                        }
                    },
                    error: function (er) {
                        alert("ERROR AL QUERER BORRAR EL REGISTRO");
                    }
                });
        }
    }
};

function DeleteLocalidad() {
    var data = $("#Localidad").val()
    if (data == 0) {
        alert("SELECCIONE UNA LOCALIDAD A ELIMINAR");
    }
    else {
        if (confirm('¿DESEA ELIMINAR ESTA LOCALIDAD?') == true)
        {
            $.ajax(
                {
                    type: 'GET',
                    url: '/ABMDirecciones/DeleteLocalidad?id=' + data,
                    contentType: 'application/json; charset=utf=8',
                    success: function (response) {
                        if (response.result == "SUCCESS") {
                            alert("REGISTRO BORRADO");
                            LimpiarFormulario();
                        }
                    },
                    error: function (er) {
                        alert("ERROR AL QUERER BORRAR EL REGISTRO");
                    }
                });
        }
    }
};

function EditPais() {
    var data = $("#Pais").val()
    if (data == '') {
        alert("SELECCIONE UN PAIS A MODIFICAR");
    }
    else {        
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
};

function EditProvincia(){
    var data = $("#Provincia").val();
    if (data == 0) {
        alert("SELECCIONE UNA PROVINCIA A MODIFICAR");
    }
    else {        
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
};

function EditLocalidad() {
    var data = $("#Localidad").val();
    if (data == 0) {
        alert("SELECCIONE UNA LOCALIDAD A MODIFICAR");
    }
    else {        
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
};