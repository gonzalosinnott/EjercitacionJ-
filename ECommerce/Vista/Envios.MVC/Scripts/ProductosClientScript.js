$(document).ready(function () {
    // Get a reference to the element that you want to work with
    var listaProductos = document.querySelector('.opener');

    // Set up an event handler. Notice that we don't use "on" in front
    // of the event name when doing it this way.
    listaProductos.addEventListener('mouseover', changeDefOver);
    listaProductos.addEventListener('mouseout', changeDefOut);

    function changeDefOver(e) {
        console.log("IN");
        $.ajax(
            {
                type: 'GET',
                url: '/ProductosClient/ListarProductos',
                contentType: 'application/json; charset=utf=8',
                success: function (result) {
                    $('#modal-list-content').html(result);
                    $('#modal-list').modal('show');
                },
                error: function (er) {
                    alert(er);
                }
            });
    }

    function changeDefOut(e) {
        console.log("OUT");
    }
})

function ComprarProducto(id, cantidad) {

    console.log(id);
    console.log(cantidad);
    
    
};

