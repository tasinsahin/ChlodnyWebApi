var Event = {}; // holds our functions
Event.EventValue = {}; // holds the json data for events

Event.WireUp = function () {
    Event.GetAllEvents();
    Event.LoadCalendarData();
    Event.LoadAllEvents();
    Event.AddNewButton();
    Event.BindSlider();

    $('button').button();
    $('#startDate').datepicker();
    $('#endDate').datepicker();

};


Event.LoadCalendarData = function () {
    $('#calendar').fullCalendar({
        editable: true,
        theme: true,
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        }
    });

};

Event.GetAllEvents = function() {
    $.ajax({
        dataType: "json",
        url: "http://localhost:60025/api/event",
        async: false,
        success: function(result) {
            Event.EventValue = result;
        }
    });
};

Event.LoadAllEvents = function () {
    $.each(Event.EventValue, function () {
        
        // convert the datetime returned from Web Api to something JavaScript can use.
        var eStart = this.StartDate.replace('/Date(', '');
        eStart = eStart.replace(')/', '');
        eStart = new Date(parseInt(eStart));

        var eEnd = this.EndDate.replace('/Date(', '');
        eEnd = eEnd.replace(')/', '');
        eEnd = new Date(parseInt(eEnd));

        var eventObject = {
            id: this.EventId,
            title: this.EventDescription,
            start: eStart,
            end: eEnd,
            allDay: this.AllDay
        };

        $('#calendar').fullCalendar('renderEvent', eventObject, true);

    });
};

Event.AddNewButton = function () {

    $('#dialogEvent').dialog({
        autoOpen: false,
        modal: true,
        position: "center",
        resizable: true,
        closeOnEscape: true,
        dialogClass: "ui-state-error",
        show: "blind",
        hide: "explode",
        buttons: {
            "Add": function () {
                var eventObject = {
                    title: $("#title").val(),
                    start: $("#startDate").val(),
                    end: $("#endDate").val()
                };

                Event.AddEvent(eventObject);
                $('#dialogEvent').dialog("close");
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });


    $("#newEvent").click(function () {
        Event.ClearForm();
        $('#dialogEvent').dialog("option", "title", "Add a New Event?").dialog("open");
    });
};

Event.AddEvent = function (eventObject) {
    $('#calendar').fullCalendar('renderEvent', eventObject, true);
};

Event.ClearForm = function () {
    $("#title").val("");
    $("#startDate").val("");
    $("#endDate").val("");
};

Event.BindSlider = function () {
    $("#slider").slider({
        value: 100,
        min: 10,
        max: 200,
        step: 10,
        slide: function (event, ui) {
            $('#calcontainer').css('zoom', ui.value + '%');
        }
    });
};