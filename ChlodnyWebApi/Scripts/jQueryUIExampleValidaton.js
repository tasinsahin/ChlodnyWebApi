/// <reference path="jquery-1.7.2-vsdoc.js" />
var jQueryExampleValidation = {}; // holds our functions

jQueryExampleValidation.LoadStylesNewForm = function () {

    $.validator.setDefaults({
        submitHandler: function() {
            $("#newForm").dialog("close");
        }
    });
   
    $("#newForm").validate({
        rules: {
            FirstName: {
                required: true,
                minlength: 2
            },
            LastName: {
                required: true,
                minlength: 2
            },


            Email: {
                required: true,
                email: true
            }

        },
        messages: {
            FirstName: "Please enter your firstname",
            LastName: "Please enter your lastname",

            Email: "Please enter a valid email address"

        }
    });
};

jQueryExampleValidation.LoadStylesEditForm = function () {

    $.validator.setDefaults({
        submitHandler: function () {
            $("#editForm").dialog("close");
        }
    });

    $("#editForm").validate({
        rules: {
            FirstName: {
                required: true,
                minlength: 2
            },
            LastName: {
                required: true,
                minlength: 2
            },


            Email: {
                required: true,
                email: true
            }

        },
        messages: {
            FirstName: "Please enter your firstname",
            LastName: "Please enter your lastname",

            Email: "Please enter a valid email address"

        }
    });
};








