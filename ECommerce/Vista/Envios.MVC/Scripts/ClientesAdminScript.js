function CreateCliente() {
    $.ajax(
        {
            type: 'GET',
            url: '/ClientesAdmin/CreateCliente',
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


function EditCliente(id) {
    console.log(id);
    $.ajax(
        {
            type: 'GET',
            url: '/ClientesAdmin/EditCliente?id=' + id,
            contentType: 'application/json; charset=utf=8',
            success: function (result) {
                $('#modal-edit-content').html(result);
                $('#modal-edit').modal('show');
            },
            error: function (er) {
                alert(er);
            }
        });
};

function DeleteCliente(id) {
    console.log(id);
    if (confirm('¿DESEA ELIMINAR ESTE CLIENTE?') == true) {
        $.ajax(
            {
                type: 'GET',
                url: '/ClientesAdmin/DeleteCliente?id=' + id,
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
};


