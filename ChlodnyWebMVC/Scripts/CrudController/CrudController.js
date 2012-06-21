$(document).ready(function() {
    GetArtistList();
});



function DoAjaxCall(parameter, datatype, data) {
    jQuery.ajax({
        type: 'GET',
        url: "http://localhost:60025/WebServices/ArtistHandler.ashx" + parameter,
        data: data,
        dataType: datatype,
        success: function (data, textStatus) {
            try {
                var jsonData = eval(data);
                if (jsonData.IsSucess) {
                    eval(jsonData.CallBack + '(jsonData.ResponseData, jsonData.Message)');
                }
                else {
                    alert(jsonData.Message + jsonData.IsSucess);
                }
            }
            catch (err) {
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Error:" + errorThrown + " and " + jqXHR + " and " + textStatus);
        }
    });
}

function GetArtistList () {
    DoAjaxCall("?method=getartist&callbackmethod=GetArtistListSuccess", 'script', '');
};

function GetArtistListSuccess(data, message) {

    var results = $.map(data, function(item) {
        return $.extend({ }, item, { label: item.Name, value: item.Name, option: this });
    });
};