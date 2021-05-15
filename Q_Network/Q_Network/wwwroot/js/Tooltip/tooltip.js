"use strict";


(function () {
    $('.lilike').toolbar({
        content: '#toolbar--like-options',
        position: 'top',
        hideOnClick: true,
    });
})();

window.onload = function () {
 
};

function preview() {
    frame.src = URL.createObjectURL(event.target.files[0]);
}


