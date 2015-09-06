var chatHub = $.connection.chatHub;

chatHub.client.writeMessage = function (fromUser, message) {
    var template = "<div class=\"panel panel-default\">" +
                            "<div class=\"panel-heading\">" +
                                "<h3 class=\"panel-title\">" + fromUser + " says:</h3>" +
                            "</div>" +
                            "<div class=\"panel-body\">" + message + "</div></div>";

    $("#messageList").prepend(template);
};

$("#sendMessage").on("click", function () {
    var fromUser = $("#personName").val();
    var message = $("#personMessage").val();

    chatHub.server.broadcastMessage(fromUser, message);
});

$.connection.hub.start();
