var jQueryExample = {}; // holds our functions
var localCustomers;    // used for the ajax calls and part of the dataview
var customers;         // used for the data view
var selected = [];      // used to hold which rows were selected.
var grid;               // the datagrid


jQueryExample.jQueryWireUp = function () {
    jQueryExample.GetAllCustomer();
    jQueryExample.LoadDataView();
    jQueryExample.LoadDataGrid();
    jQueryExample.PageSizeOptions();
    jQueryExample.SelectedGridOptions();

    customers.refresh();

    jQueryExample.RemoveButton();
    jQueryExample.RefreshButton();
    jQueryExample.NewCustomer();
    jQueryExample.EditCustomer();
    jQueryExample.ClearButton();
};


jQueryExample.GetAllCustomer = function() {
    $.ajax({
        dataType: "json",
        url: "http://localhost:60025/api/customer",
        async: false,
        success: function (result) {
            localCustomers = result;
        }
    });
};

jQueryExample.LoadDataView = function() {
    customers = $.ui.dataviewlocal({
        input: localCustomers,
        paging: {
            limit: 10
        }
    });
};

jQueryExample.LoadDataGrid = function() {
    grid = $("#customers-local").grid({
        source: customers.result,
        refresh: function() {
            var paging = customers.options.paging,
                total = customers.totalCount;
            $(".paging-from").text(paging.offset + 1);
            var to = paging.offset + paging.limit + 1;
            if (to > total) {
                to = total;
            }
            $(".paging-to").text(to);
            $(".paging-total").text(total);
        }
    });

    grid.gridSelectable({
        selected: selected
    });
};

jQueryExample.PageSizeOptions = function() {
    $("#pager").pager({
        source: customers
    });

    $("#pagesize").change(function() {
        customers.option("paging.limit", +$(this).val()).refresh();
    });
};

jQueryExample.SelectedGridOptions = function() {
    // update status when selection changes
    $.observable(selected).bind("insert remove", function() {
        $(".selected-status").text(selected.length);
    });

    $("#customers-selected").grid({
        source: selected
    });

    $("#customers-local").grid({
        source: customers,
        heightStyle: "fill"
    }).gridFilter().gridSort();
};

jQueryExample.RemoveButton = function () {
    $("#removeCustomer").click(function () {
        if (!selected.length) {
            alert("None selected");
            return;
        }
        var customerId = selected[0].CustomerId;
        $.ajax({ type: "DELETE", url: "http://localhost:60025/api/customer/" + customerId });

        $.observable(localCustomers).remove(selected);
        $.observable(selected).remove(0, selected.length);
        customers.refresh();
    });
};


jQueryExample.ClearButton = function () {
    $("#clearSelection").click(function () {
        $.observable(selected).remove(0, selected.length);
        customers.refresh();
    });
};

jQueryExample.EditCustomer = function() {
    var customer;
    $("#editCustomer").click(function() {
        if (!selected.length) {
            alert("None selected");
            return;
        }
        customer = selected[0];
        $("#edit-tmpl").tmpl(meta(customer)).appendTo(editForm.find("fieldset").empty());
        editForm.dialog("open");
    });
    $("[type=submit]").button();
    var editForm = $("#editForm").dialog({
        autoOpen: false,
        width: 350,
        modal: true
    }).hide().submit(function(event) {
        event.preventDefault();

        var customerId = $("#CustomerId").val();
        var firstName = $("#FirstName").val();
        var lastName = $("#LastName").val();
        var address = $("#Address").val();
        var city = $("#City").val();
        var postalCode = $("#PostalCode").val();
        var state = $("#State").val();
        var country = $("#Country").val();
        var email = $("#Email").val();
        var phone = $("#Phone").val();
        var fax = $("#Fax").val();
        var company = $("#Company").val();

        var sentData = {
            CustomerId: customerId,
            FirstName: firstName,
            LastName: lastName,
            Address: address,
            City: city,
            PostalCode: postalCode,
            State: state,
            Country: country,
            Email: email,
            Phone: phone,
            Fax: fax,
            Company: company
        };

        $.ajax({ 
//                statusCode: {
//            404: function() {
//                alert("There was an error Posting");
//            }
            type: 'POST', 
            dataType: 'json', 
            url: 'http://localhost:60025/api/customer', 
            data: sentData }
        
    );
        $.observable(customer, localCustomers).property(serializeForm(this));
        customers.refresh();
        // TODO hide tooltip
        editForm.dialog("close");
    });
};

jQueryExample.NewCustomer = function() {
    $("#newCustomer").click(function() {
        var newCustomer = {
            FirstName: "",
            LastName: "",
            Address: "",
            City: "",
            PostalCode: "",
            State: "",
            Country: "",
            Email: "",
            Phone: "",
            Fax: "",
            Company: ""
        };

        $("#edit-tmpl").tmpl(meta(newCustomer)).appendTo(newForm.find("fieldset").empty());
        newForm.dialog("open");
    });

    $("[type=submit]").button();
    var newForm = $("#newForm").dialog({
        autoOpen: false,
        width: 350,
        modal: true
    }).hide().submit(function (event) {
        event.preventDefault();

        var firstName = $("#FirstName").val();
        var lastName = $("#LastName").val();
        var address = $("#Address").val();
        var city = $("#City").val();
        var postalCode = $("#PostalCode").val();
        var state = $("#State").val();
        var country = $("#Country").val();
        var email = $("#Email").val();
        var phone = $("#Phone").val();
        var fax = $("#Fax").val();
        var company = $("#Company").val();

        var sentData = {
            FirstName: firstName,
            LastName: lastName,
            Address: address,
            City: city,
            PostalCode: postalCode,
            State: state,
            Country: country,
            Email: email,
            Phone: phone,
            Fax: fax,
            Company: company
        };

        $.ajax({ type: 'POST', dataType: 'json', url: 'http://localhost:60025/api/customer', data: sentData,
            success: function (result) {
                $.observable(localCustomers).insert(result);
                customers.refresh();
            }
        });

        newForm.dialog("close");
    });
};

jQueryExample.RefreshButton = function () {
    $("#refresh").button({
        icons: {
            primary: "ui-icon-refresh"
        }
    }).click(function() {

        $.ajax({
            dataType: "json",
            url: "http://localhost:60025/api/customer",
            async: false,
            success: function(result) {
                $.observable(localCustomers).replaceAll(result);
            }
        });

        customers.refresh();

    });
};