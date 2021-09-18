// маска номера телефона
$('.phone-mask').inputmask("+9 (999) 999-9999");

// фильтр по таблице
$(document).ready(function () {
    $("#filter-input").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#filter-table tbody tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});