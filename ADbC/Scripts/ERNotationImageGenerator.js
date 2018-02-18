var url;
$(document).ready(function () {
    $('#radioBox input:radio').click(function () {
        var selNotation = $('input[name=notation]:checked').val();
        var selRelation = $('input[name=relation]:checked').val();
        if (typeof selNotation !== 'undefined' && typeof selRelation !== 'undefined') {
            var url = '/Content/Images/ERNotation/' + selNotation + '/' + selRelation + '.png';
            $('#diagram').attr('src', url)
            if ($('#diagram').css('visibility') == 'hidden') {
                $('#diagram').css('visibility', 'visible')
            }
            //$('#output').load(url, { not: selNotation, rel: selRelation });
        }
    })
})