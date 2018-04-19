var url;
$(document).ready(function () {
    var selNotation1 = document.getElementById("combo1").value;;
    var selNotation2 = document.getElementById("combo2").value;;
    var selRelation;
    $('#radioBox input:radio').click(function () {
        selRelation = $('input[name=relation]:checked').val();
        generateImage();
    })

    document.getElementById("combo1").onchange = function () {
        selNotation1 = document.getElementById("combo1").value;
        generateImage();
    };

    document.getElementById("combo2").onchange = function () {
        selNotation2 = document.getElementById("combo2").value;
        generateImage();
    };

    function generateImage() {
        if (typeof selNotation1 !== 'undefined' && typeof selRelation !== 'undefined') {
            var url = '/Content/Images/ERNotation/' + selNotation1 + '/' + selRelation + '.png';
            $('#diagram1').attr('src', url)
            if ($('#diagram1').css('visibility') == 'hidden') {
                $('#diagram1').css('visibility', 'visible')
            }
        }
        if (typeof selNotation2 !== 'undefined' && typeof selRelation !== 'undefined') {
            var url = '/Content/Images/ERNotation/' + selNotation2 + '/' + selRelation + '.png';
            $('#diagram2').attr('src', url)
            if ($('#diagram2').css('visibility') == 'hidden') {
                $('#diagram2').css('visibility', 'visible')
            }
        }
    }
})