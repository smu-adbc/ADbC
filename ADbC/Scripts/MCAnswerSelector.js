$(document).ready(function () {
    $('#questionButtons button').click(function () {
        var urlAction = $('#loader').data('url');
        var selectedQuestion = $(this).val();
        if (typeof selectedQuestion !== 'undefined') {
            $('#question').load(urlAction, { shortDescription: selectedQuestion });
        }
    })
})