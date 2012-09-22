$(function () {

    $.connection.hub.logging = true;

    var status = $.connection.status;

    status.joined = function (id, email, when) {

        if ($.connection.hub.id === id) {
            addMessage(email + ' : ' + id, 'blue');
        }

        addMessage(email + ' : ' + id + ' joined at ' + when, 'green');
    };

    status.rejoined = function (id, when) {
        addMessage(id + ' reconnected at ' + when, 'purple');
    };

    status.leave = function (id, when) {
        addMessage(id + ' left at ' + when, 'red');
    };

    function addMessage(value, color) {
        $('#messages').append('<li style="background-color:' + color + ';color:white">' + value + '</li>');
    }

    $.connection.hub.start();

});