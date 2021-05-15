"use strict";


(function () {
    document.getElementById("txtcreatepost").addEventListener("keyup", function () {
        var target = $('#txtcreatepost').val();
        var key = "afc58add519db4e32a130b9c533d5871";
        var field = "icon_type";

        $.ajax({
            url: "https://api.linkpreview.net",
            dataType: "jsonp",
            data: { q: target, fields: field, key: key },
            success: function (response) {
                if (response.error) {
                    console.log(response.description);
                    return;
                }
                console.log(response);
                debugger; 
                $('.sectionpreviewlink').css('display', 'block');
                document.getElementById("mytitle").innerHTML = response.title
                document.getElementById("amyimage").href = response.url
                document.getElementById("mytitle").href = response.url
              /*  document.getElementById("mydescription").innerHTML = response.description*/
                document.getElementById("myimage").src = response.image
                document.getElementById("myurl").href = response.url
                document.getElementById("myurl").innerHTML = response.url
            }
        });

    });
    $('.bi-x-circle-fill ').click(function () {

        $('.sectionpreviewlink').css('display', 'none');

    });
    $('.divtxtcreatepost').click(function () {
        debugger;
        $('#modalcreatepost').modal('show');
    });
    $('.lilike').toolbar({
        content: '#toolbar--like-options',
        position: 'top',
        style: 'white',
        hideOnClick: true,
    });
})();

window.onload = function () {
    //$('.fa-eye').toolbar({
    //    content: '#toolbar-options',
    //});
};

function preview() {
    frame.src = URL.createObjectURL(event.target.files[0]);
}


