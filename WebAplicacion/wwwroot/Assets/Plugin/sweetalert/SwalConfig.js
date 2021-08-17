"use strict";
var Loading = Swal.mixin({
    toast: true,
    didOpen: function (toast) {
        Swal.showLoading();
        $(".swal2-backdrop-show").css({ 'width': '100%', 'height': '100%' });
        $(".swal2-loading ").css({ 'width': 'auto' });
    },
    backdrop: 'rgba(0, 0, 0, 0.03)',
    customClass: {
        confirmButton: "hdbtn"
    }
});
var Toast = Swal.mixin({
    toast: true,
    position: 'bottom-start',
    showConfirmButton: false,
    timer: 3000,
    timerProgressBar: true,
    didOpen: function (toast) {
        toast.addEventListener('mouseenter', Swal.stopTimer);
        toast.addEventListener('mouseleave', Swal.resumeTimer);
    }
});
var ComfirmAlert = function (Mensaje, confirmButtonText, Icon, confirmButtonColor, cancelButtonColor) {
    return Swal.fire({
        title: Mensaje,
        icon: Icon,
        showCancelButton: true,
        confirmButtonColor: confirmButtonColor,
        cancelButtonColor: cancelButtonColor,
        confirmButtonText: confirmButtonText
    });
};
//# sourceMappingURL=SwalConfig.js.map