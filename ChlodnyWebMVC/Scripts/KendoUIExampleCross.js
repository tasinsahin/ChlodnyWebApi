var KendoExampleCross = {};
// var data;

// KendoExample.KendoWireUp = function () {
 //   $.ajax({ type: "GET", url: "http://localhost:60025/api/customer/5", success: KendoExample.processResult, error: KendoExample.processError });


//    var dataSource = new kendo.data.DataSource({
//        transport: {
//            read: {
//                // the remote service url
//                url: "http://localhost:60025/api/customer/5",

//                // JSONP is required for cross-domain AJAX
//                dataType: "jsonp",
//                // additional parameters sent to the remote service
//                data: {
//                    q: "html5"
//                }
//            }
//        },
//        // describe the result format
//        schema: {
//            // the data which the data source will be bound to is in the "results" field
//            data: "results"
//        }
//    });

//    var d = dataSource;

//    $("#grid").kendoGrid({
//        //        dataSource: dataSource,
//        dataSource: {
//                            type: "jsonp",
//                            transport: {
//                                read: "http://localhost:60025/api/customer/2?callback=myCallBack"
//                            },
//        schema: {
//            model: {
//                fields: {
//                    FirstName: {type: "string"},
//                    LastName: {type: "string"}
//                }
//            }
//        }
//        
//        },
//        height: 280,
//        scrollable: {
//            virtual: true
//        },
//        sortable: true,
//        columns: ["FirstName", "LastName", "Address", "City", "PostCode", "State", "Country", "Email", "Fax", "Company"]
    //    });
    



//};

//KendoExample.processResult = function (resultJson) {
//    data = resultJson;
//    var data2 = data;

//};

//KendoExample.processError = function (resultJson) {
//    var error = "there was an error";
//    alert(error);
//};

//    


/* ******************************************************************************************************** */
KendoExampleCross.DoAjaxCall = function (parameter, datatype, data) {
    jQuery.ajax({
        type: 'POST',
        url: "http://localhost:60025/api/customer" + parameter,
        data: data,
        dataType: datatype,
        success: function (data, textStatus) {
            try {
                var jsonData = eval(data);
                if (jsonData.IsSucess) {
                    eval(jsonData.CallBack + '(jsonData.ResponseData, jsonData.Message)');
                } else {
                    alert(jsonData.Message + jsonData.IsSucess);
                }
            } catch (err) {
                alert(err);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Error:" + errorThrown + " and " + jqXHR + " and " + textStatus);
        }
    });
};





















/* ******************************************************************************************************** */


KendoExampleCross.KendoWireUp = function () {
    var grid = $("#grid").data("kendoGrid");
    // Inital load the grid with all customer Id's
    
     $.ajax({
        dataType: "jsonp",
        url: "http://localhost:60025/api/customer",
        async: false,
        success: function (result) {
            KendoExampleCross.processResult(result);
        }
    });

//    $.ajax("http://localhost:60025/api/customer?callback=myCallBack,
//    datatype:"jsonp",
//                function (data) {
//                    KendoExampleCross.processResult(data);
//                });


    //Wire Up the button to search
    $("#makeRequest").click(function () {
        var customerId = $("#customerId").val();
        $.getJSON("http://localhost:60025/api/customer/?callback=myCallBack" + customerId,
                function (data) {
                    KendoExampleCross.processResult(data);
                });
    });

    $("#allRequest").click(function () {
        $.getJSON("http://localhost:60025/api/customer/?callback=myCallBack",
                function (data) {
                    KendoExampleCross.processResult(data);
                });
    });
};

KendoExampleCross.processResult = function (resultJson) {

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


                var crudServiceBaseUrl = "http://localhost:60025/api/?callback=myCallBack",
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
                        parameterMap: function (options, operation) {
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

KendoExampleCross.processError = function(resultJson) {
    var error = "there was an error";
    alert(error);
};