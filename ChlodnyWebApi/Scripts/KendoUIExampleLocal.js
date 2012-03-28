var KendoExample = {};

KendoExample.KendoWireUp = function () {
    var grid = $("#grid").data("kendoGrid");
    // Inital load the grid with all customer Id's
    $.getJSON("http://localhost:60025/api/customer",
                function (data) {
                    KendoExample.processResult(data);
                });


    //Wire Up the button to search
    $("#makeRequest").click(function () {
        var customerId = $("#customerId").val();
        $.getJSON("http://localhost:60025/api/customer/" + customerId,
                function (data) {
                    KendoExample.processResult(data);
                });
    });

            $("#allRequest").click(function () {
        $.getJSON("http://localhost:60025/api/customer/",
                function (data) {
                    KendoExample.processResult(data);
                });
    });
};

        KendoExample.processResult = function (resultJson) {

            // Just for Demo Purpose at this time.  Typically you would pull this data from Knockout or Backbone and refresh and filter
            $("#grid").empty();

            $("#grid").kendoGrid({
                dataSource: {
                    data: resultJson,
                    pageSize: 10
                },
                height: 400,
                groupable: true,
                filterable: true,
                scrollable: true,
                sortable: true,
                selectable: true,
                pageable: true,
                // editable: true,
                columns: [
                    {
                        field: "CustomerId",
                        title: "ID"
                    },
                    {
                        field: "FirstName",
                        title: "First Name"
                    },
                    {
                        field: "LastName",
                        title: "Last Name"
                    },
                    {
                        field: "Address"
                    },
                    {
                        field: "City"
                    },
                    {
                        field: "PostalCode",
                        title: "Postal Code"
                    },
                    {
                        field: "State"
                    },
                    {
                        field: "Country"
                    },
                    {
                        field: "Email"
                    },
                    {
                        field: "Fax"
                    },
                    {
                        field: "Company"
                    }
                ]
            });
            // }


            var crudServiceBaseUrl = "http://localhost:60025/api",
                dataSource = new kendo.data.DataSource({
                    transport: {
                        read: {
                            url: crudServiceBaseUrl + "/customer",
                            dataType: "json"
                        },
                        update: {
                            url: crudServiceBaseUrl + "/customer",
                            dataType: "jsonp"
                        },
                        destroy: {
                            url: crudServiceBaseUrl + "/customer",
                            dataType: "json"
                        },
                        create: {
                            url: crudServiceBaseUrl + "/customer",
                            dataType: "json"
                        },
                        parameterMap: function(options, operation) {
                            if (operation !== "read" && options.models) {
                                return { models: kendo.stringify(options.models) };
                            }
                        }
                    },
                    batch: true,
                    pageSize: 30,
                            schema: {
                                model: {
                                    id: "CustomerId",
                                    fields: {
                                        CustomerId: { editable: false, nullable: false },
                                        FirstName: { editable: true, nullable: false },
                                        LastName: { editable: true, nullable: false },
                                        Company: { editable: true, nullable: true },
                                        Address: { editable: true, nullable: true },
                                        City: { editable: true, nullable: true },
                                        State: { editable: true, nullable: true },
                                        Country: { editable: true, nullable: true },
                                        PostalCode: { editable: true, nullable: true },
                                        Phone: { editable: true, nullable: true },
                                        Fax: { editable: true, nullable: true },
                                        Email: { editable: true, nullable: false },
                                        SupportRepId: { editable: true, nullable: true },
                                        Deleted: { editable: false, nullable: true }
                                    }
                                }
                            }
                });

            $("#grid2").kendoGrid({
                dataSource: dataSource,
                navigatable: true,
                groupable: true,
                filterable: true,
                scrollable: true,
                sortable: true,
                selectable: true,
                editable: true,
                pageable: true,
                height: 400,
                toolbar: ["create", "save", "cancel"],
                columns: [
                    {
                        field: "CustomerId",
                        title: "ID"
                    },
                    {
                        field: "FirstName",
                        title: "First Name"
                    },
                    {
                        field: "LastName",
                        title: "Last Name"
                    },
                    {
                        field: "Address"
                    },
                    {
                        field: "City"
                    },
                    {
                        field: "PostalCode",
                        title: "Postal Code"
                    },
                    {
                        field: "State"
                    },
                    {
                        field: "Country"
                    },
                    {
                        field: "Email"
                    },
                    {
                        field: "Fax"
                    },
                    {
                        field: "Company"
                    }
                ]
                
            });
};

KendoExample.processError = function (resultJson) {
    var error = "there was an error";
    alert(error);
};