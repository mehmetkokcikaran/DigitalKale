$(document).ready(function () {

    $('#software').click(function () {
        $('#softwareDiv').show();
        $('#marketingDiv').hide();
        $('#mediaDiv').hide();
        $('#seoDiv').hide();
        $('#photoDiv').hide();
        $('#droneDiv').hide();
    });

    $('#marketing').click(function () {
        $('#marketingDiv').show();
        $('#softwareDiv').hide();
        $('#mediaDiv').hide();
        $('#seoDiv').hide();
        $('#photoDiv').hide();
        $('#droneDiv').hide();
    });

    $('#media').click(function () {

        $('#mediaDiv').show();
        $('#marketingDiv').hide();
        $('#softwareDiv').hide();
        $('#seoDiv').hide();
        $('#photoDiv').hide();
        $('#droneDiv').hide();
    });

    $('#seo').click(function () {

        $('#seoDiv').show();
        $('#mediaDiv').hide();
        $('#marketingDiv').hide();
        $('#softwareDiv').hide();
        $('#photoDiv').hide();
        $('#droneDiv').hide();
    });

    $('#photo').click(function () {

        $('#photoDiv').show();
        $('#seoDiv').hide();
        $('#mediaDiv').hide();
        $('#marketingDiv').hide();
        $('#softwareDiv').hide();
        $('#droneDiv').hide();
    });

    $('#drone').click(function () {

        $('#droneDiv').show();
        $('#photoDiv').hide();
        $('#seoDiv').hide();
        $('#mediaDiv').hide();
        $('#marketingDiv').hide();
        $('#softwareDiv').hide();
    });

});


$('.service-catergory li').on('click', function () {
    $('li').removeClass('active');
    $(this).addClass('active');
});