$(".check input").change(function () {
    console.log("test");
    if ($(".check input").is(":checked")) {
        $(".teacher").css("visibility", "visible");
    }
    else {
        $(".teacher").css("visibility", "hidden");
    }
});



