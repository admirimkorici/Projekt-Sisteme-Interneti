$(document).ready(function () {
    $("#g1").hide();
    $("#g2").hide();
    $("#g3").hide();
    $("#g4").hide();
    $("#Viti").change(function () {
        if ($("#Dega").val() == "Teknologji Informacioni dhe Komunikimi") {
            $("#g1").show();
            $("#g2").show();
            $("#g3").hide();
            $("#g4").hide();
        }
        else
            if ($("#Dega").val() == "Informatike" && $(this).val() == 1) {
                $("#g1").show();
                $("#g2").show();
                $("#g3").hide();
                $("#g4").hide();
            }
            else {
                $("#g1").hide();
                $("#g2").hide();
                $("#g3").show();
                $("#g4").show();
            }
        $("#Grupi").prop("selectedIndex", "Grupi");
    });
});