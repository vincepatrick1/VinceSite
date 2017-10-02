$(document).ready(function () {
    $("#b4").click(function () {
        $("#b1").css("display", "block")
    });


    $("#b5").click(function () {
        $("#b2").css("display", "block")
    });

    $("#b6").click(function () {
        $("#b3").css("display", "block")
    });

    $("#b5").click(function () {
        $("#b1").css("display", "none")
    });
    $("#b6").click(function () {
        $("#b1").css("display", "none")
    });
});