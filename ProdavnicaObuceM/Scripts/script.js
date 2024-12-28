$(document).ready(function () {

    $(".patikeM, .patikeZ, .patikeD").click(function () {
        var naziv = $(this).data('naziv');
        var brend = $(this).data('brend');
        var cena = $(this).data('cena');
        var tip = ""; 

        if ($(this).hasClass("patikeM")) {
            tip = "Muška obuća"; 
        } else if ($(this).hasClass("patikeZ")) {
            tip = "Ženska obuća";  
        } else if ($(this).hasClass("patikeD")) {
            tip = "Dečija obuća"; 
        }

        alert('Uspešno ste dodali željeni proizvod u narudžbenicu');

        sessionStorage.setItem("naziv", naziv);
        sessionStorage.setItem("brend", brend);
        sessionStorage.setItem("cena", cena);
        sessionStorage.setItem("tip", tip);
    });

    function popuniFormu() {
        var tip = sessionStorage.getItem("tip");

        if (tip) {
            var prefix = "";
            if (tip === "Muška obuća") {
                prefix = "MuskaObuca";
            } else if (tip === "Ženska obuća") {
                prefix = "ZenskaObuca";
            } else if (tip === "Dečija obuća") {
                prefix = "DecijaObuca";
            }

            $('input[name="' + prefix + '.Naziv"]').val(sessionStorage.getItem("naziv"));
            $('input[name="' + prefix + '.Brend"]').val(sessionStorage.getItem("brend"));
            $('input[name="' + prefix + '.Cena"]').val(sessionStorage.getItem("cena"));
            $('select[name="' + prefix + '.Tip"]').val(sessionStorage.getItem("tip"));
        }
    }
    popuniFormu();
});
