﻿var table = "";
$(document).ready(function () {
    table = $("#myTable").DataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "orderMulti": false,
        "paging": true,
        "responsive": true,
        "ajax": "http://localhost/DemoAppWithRepositoryAutofac.API/GetCountryList",
        "columns": [
            { "data": "countryName", "name": "CountryName" },
            { "data": "countryId", "name": "CountryId" },
            {
                data: null,
                orderable: false,
                width: 100,
                render: function (data, type, row) {
                    //console.log(data);
                    return "<a href='Country/Edit/" + data.countryId + "'  class='btn btn-primary btn-small-x fa fa-pencil'></a>"
                        + "&nbsp;&nbsp;<a id=" + data.countryId + " Onclick='fnConfirm(this);' class='btn btn-primary btn-small-x fa fa-trash-o'></a>"
                }
            }
        ]
    });
});


function fnConfirm(model) {
    $('#myModalDelete').modal('show');
    $("#DeleteDiv").html("Are you sure you want to delete this record?");
    $("#ConfirmDeleting").click(function () {
        $.ajax({
            url: "Country/DeleteData/" + model.id,
            type: 'post',
            contentType: 'application/x-www-form-urlencoded',
            data: $(this).serialize(),
            success: function (data, textStatus, jQxhr) {
                $('#myModalDelete').modal('hide');
                table.ajax.reload(null, false);
            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });
    });
}

