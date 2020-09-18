$(function () {

    $(document).on("click", "#rowDataDeleteBtn", function () {
        var dataId = $(this).attr("data-id");
    
        $("#modalDeleteBtn").attr("data-id", dataId);
    })


    $(document).on("click", "#modalDeleteBtn", function () {
        var dataId = $(this).attr("data-id");
        var data_ = {
            id: dataId
        }
        $.ajax({
            url: "/Admin/Products/DeleteProduct",
            type: "post",
            dataType: "json",
            data: data_,
            success: function (d) {
                $(`#rowDataDeleteBtn[data-id=${dataId}]`).parent().parent().remove();
                $("#exampleModal").removeClass("show");
                $(".modal-backdrop").removeClass("show");
                console.log("success")
               
            },
            error: function (d) {
                console.log("error")
            }
        })
    })
})