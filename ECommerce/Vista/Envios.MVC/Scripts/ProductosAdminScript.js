function CreateProducto() {
    $.ajax(
        {
            type: 'GET',
            url: '/ProductosAdmin/CreateProducto',
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


function EditProducto(id) {
    console.log(id);
    $.ajax(
        {
            type: 'GET',
            url: '/ProductosAdmin/EditProducto?id=' + id,
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

function DeleteProducto(id) {
    console.log(id);
    if (confirm('¿DESEA ELIMINAR ESTE PRODUCTO?') == true) {
        $.ajax(
            {
                type: 'GET',
                url: '/ProductosAdmin/DeleteProducto?id=' + id,
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


