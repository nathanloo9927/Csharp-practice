// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("degenerate male");
    $(document).on("click", ".edit-product-button", function () {
        console.log("nyeh " + $(this).val());

        // store the product ID
        var productID = $(this).val();

        $.ajax({
            type: 'json',
            data: {
                "id": productID
            },
            url: '/Product/ShowDetailsJSON',
            success: function (data) {
                console.log(data);

                // fill in the input fields in the modal

                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }
        })
    });

    $("#save-button").click(function () {
        // get the values from the input fields and create a json object to submit the controller
        var product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()
        };

        console.log("joy");
        console.log(product);

        //save the updated product record into the database
        $.ajax({
            type: 'json',
            data: product,
            url: '/Product/ProcessEditReturnPartial',
            success: function (data) {
                console.log(data);
                $("#card-number-" + product.Id).html(data).hide().fadeIn(2000);
            }
        })
    })
});