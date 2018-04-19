$(document).ready(function () {
    $('#diagrams img').click(function () {
        var diagram = $(this).attr('src');
        if (typeof diagram !== 'undefined') {
            $('#diagramImage').attr('src', diagram)
            $('#imageView').modal('show');
        }
    })
})