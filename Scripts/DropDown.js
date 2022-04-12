$(document).ready(function () {
    $("#v1").hide();
    $("#v2").hide();
    $("#Dega").change(function () {
        if ($(this).val() != null) {
            $("#v1").show();
            $("#v2").show();
            $("#g1").hide();
            $("#g2").hide();
            $("#g3").hide();
            $("#g4").hide();
            $("#Grupi").prop("selectedIndex", "Grupi");
            $("#Viti").prop("selectedIndex", "Viti");
        }
    });
});