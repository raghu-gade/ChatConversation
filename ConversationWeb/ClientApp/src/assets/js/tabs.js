$(document).ready(function () {
    "use strict";
    var $ = jQuery.noConflict();
    // BOOTSTRAP TABBAR ANIMATION CODE
    $(document).on('click', '.slider-tabs .nav-link', function () {
      handleTabChange($(this));
    });
    handleTabChange($('.slider-tabs .active'));
    function handleTabChange(tab) {
      var nav = tab.closest('.nav');
      $('.indicator', nav).css({
        width: tab.outerWidth(),
        left: tab.position().left
      });
      tab.siblings().removeClass('active');
      tab.addClass('active');
    }
    // END BOOTSTRAP TABBAR ANIMATION CODE
  });