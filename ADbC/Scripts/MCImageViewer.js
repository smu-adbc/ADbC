$(document).ready(function () {
    $('#answers img').click(function () {
        var answerDiagram = $(this).attr('src');
        if (typeof answerDiagram !== 'undefined') {
            $('#answerImage').attr('src', answerDiagram)
            $('#imageView').modal('show');
        }
    })
})