// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("Degenerate Male");

    $(".customerRadio").change(function () {
        console.log("diabolical");
        updateCustomer();
    });

    function updateCustomer() {
        $.ajax({
            type: "POST",
            url: 'Customer/ShowOnePerson',
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                $("#customerInformationArea").html(data);
            }
        });
    }

    $("#selectCustomer").click(function () {
        event.preventDefault();
        console.log("nyehhhhh");
        updateCustomer();
    });
});