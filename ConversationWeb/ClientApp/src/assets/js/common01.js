$(document).ready(function () {
  "use strict";


  var $ = jQuery.noConflict();
  $('#radioBtn a').on('click', function(){
    var sel = $(this).data('title');
    var tog = $(this).data('toggle');
    $('#'+tog).prop('value', sel);
    
    $('a[data-toggle="'+tog+'"]').not('[data-title="'+sel+'"]').removeClass('active').addClass('notActive');
    $('a[data-toggle="'+tog+'"][data-title="'+sel+'"]').removeClass('notActive').addClass('active');
})
// FLYOUT DROPDOWN SELECT SCRIPT
$('.vm-ca-dropdown ul li').on('click', function() {
  var selectedOption = $(this).attr('name');
   $('.ca-sliding-details').slideUp();
  $('.' + selectedOption).slideDown();
  $('.vm-ca-dropdown button span').text($(this).attr('value'))

});
// FLYOUT DROPDOWN SELECT SCRIPT
  $(".vm-associate-autocomplete input").focus(function(){
    $('.vm-autocomplete-box').fadeIn(600);
    
  });
  $('.vm-select-associate').on('click', function() {
    $('.vm-autocomplete-form').fadeOut(600, function() {
      $('.vm-autocomplete-added').fadeIn(600);
    });

  })

  // Inline Edit JS //
  $('.vm-inline-edit').on('click', function () {
    $(this).children('.vm-view-mode').fadeOut('slow', function () {
      $(this).parents('.vm-inline-edit').children('.vm-edit-mode').fadeIn('slow');
    });
    $(this).addClass('vm-open-inline');
  });
  $('.vm-edit-actions span').on('click', function (e) {
    $(this).parents('.vm-inline-edit').children('.vm-edit-mode').fadeOut('slow', function () {
      $(this).parents('.vm-inline-edit').children('.vm-view-mode').fadeIn('slow');

      $(this).parents('.vm-inline-edit').removeClass('vm-open-inline');
    });
    e.stopPropagation();
  })
  // Inline Edit JS End //
  $('.vm-profile-show').click(function (e) {
    $('.vm-dropdown-profile').toggleClass("p-show");
    $(".dropdown-toggle").toggleClass("arrow-up");
  })
  var del = 200;
  $('.icontent').hide().prev('.mark').hover(function () {
    $(this).next('.icontent').stop('fx', true).slideToggle(del);
  });
  $('.vm-tabbar').each(function () {
    var self = $(this);
    $('<em />').appendTo(self).css('--offset', self.find('.active').position().left + self.find('.active').width() / 2);
  });

  // Profile Detail View Flyout Js //
  $(document).on("click", ".link-Updown a", function (event) {
    event.preventDefault();
    $('.vm-profile-detail-view-flyout').toggleClass('active');
    $('.vm-profile-detail-view-flyout .vm-flyout-close').toggleClass('d-inline-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  })

  // Contact Popover //
  $(".vm-profile-detail-pop").popover({ trigger: "manual", html: true, animation: false })
    .on("mouseenter", function () {
      var _this = this;
      $(this).popover("show");
      $(".popover").on("mouseleave", function () {
        $(_this).popover('hide');
      });
    }).on("mouseleave", function () {
      var _this = this;
      setTimeout(function () {
        if (!$(".popover:hover").length) {
          $(_this).popover("hide");
        }
      }, 300);
    });

  $('.vm-profile-detail-view-click').click(function () {
    $('.vm-profile-detail-view-flyout').removeClass('active');
    $('.vm-manage-activity-flyout .vm-flyout-close').toggleClass('d-none');
    $('#vm-wrapper').removeClass('vm-mask');
  });


  // Profile Detail View Flyout Js End//

  $('.vm-manage-activity-click').click(function () {
    $('.vm-manage-activity-flyout').toggleClass('active');
    $('.vm-manage-activity-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
    $('.vm-add-contact-flyout').removeClass('active');
  });
  $('.vm-add-contact-click').click(function () {
    $('.vm-add-contact-flyout').toggleClass('active');
    $('.vm-add-contact-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });

  $('.vm-add-company-click').click(function () {
    $('.vm-add-company-flyout').toggleClass('active');
    $('.vm-add-company-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-add-opportunity-click').click(function () {
    $('.vm-add-opportunity-flyout').toggleClass('active');
    $('.vm-add-opportunity-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });

  //  Add Activity Flyout JS //

  //  Add Activity Flyout JS //
  $('.company-add').on('click', function () {
    $('.vm-add-activity').hide();
    $('.vm-add-activity').removeClass('d-block');
    $('.vm-ad-view .vm-flyout-close').addClass('vm-ad-view-close');
    $('.vm-company-view').removeClass('d-none');
    $('.vm-add-activity-flyout').addClass('vm-dual-activity');  //new

    $('.vm-company-view').addClass('vm-company-view-show');  //new
    $('.vm-ad-view').removeClass('w-100');  //new
  })
  $('.vm-flyout-close-company-detail').on('click', function () {
    $('.vm-company-view').hide();
    $('.vm-ad-view').addClass('d-block w-100');

    $('.vm-company-view').removeClass('d-block');  //new
    $('.vm-add-activity').addClass('d-block'); //new
    $('.vm-add-activity-flyout').addClass('vm-dual-activity');

  });
  $(document).on('click', ".vm-ad-view-close", function () {
    //$('.vm-add-activity-flyout').removeClass('active');
    $('#vm-wrapper').addClass('vm-mask');
    $('.vm-add-activity').addClass('d-block');
    $('.vm-ad-view').removeClass('w-100');
    $('.vm-company-view').addClass('d-block');
    $('vm-add-activity-flyout .vm-flyout-close').addClass('d-block')
    $('.vm-company-view').removeClass('d-block');  //new
    $('.vm-ad-view').removeClass('d-block');  //new
  })
  $('.vm-add-activity-click').click(function () {
    $('.vm-add-activity-flyout').toggleClass('active');
    // $('.vm-add-activity-flyout .vm-flyout-close').toggleClass('d-block');
    $('.vm-add-activity-flyout .vm-flyout-close').addClass('d-block');
    //$('.vm-manage-activity-flyout').toggleClass('d-none');
    $('#vm-wrapper').toggleClass('vm-mask');
    $('.vm-add-activity').removeClass('vm-single-column'); //new
  });

  $('.vm-flyout-close.vm-add-activity-click').on('click', function () {
    $('.vm-add-activity-flyout').removeClass('vm-dual-activity');
    $('.vm-add-activity').removeClass('')
  })

  $('.vm-add-activity-detail-view .vm-lead-close ').on('click', function () {
    $('.vm-add-activity-flyout').removeClass('vm-dual-activity');
        $('.vm-add-activity-flyout').addClass('active');
  });
  $('.vm-add-activity-detail-view .vm-flyout-close').on('click', function () {
    $('.vm-flyouts .vm-add-activity').removeClass('vm-single-column');
  });
  $('.add-activity-name-select').on('click', function () {
    $('.vm-add-activity').toggleClass('vm-single-column');
    $('.vm-add-activity-detail-view').addClass('vm-dual-column');
  });

  $('.add-activity-name-select').on('click', function () {
    $('.vm-add-activity-flyout').toggleClass('vm-dual-activity');
  });


  $('.vm-flyout-close-company-detail').on('click', function () {

    $('.vm-add-activity-flyout').removeClass('.vm-dual-activity');
  })

  $('.vm-select-createnew').on('click', function() {
    $('.vm-contact-view').addClass('vm-dual-column');
    $('.vm-contact-view').removeClass('d-none');
    $('.vm-add-activity-flyout').addClass('vm-dual-activity');
    $('.vm-ad-view').addClass('d-none');
    $('.vm-add-activity').addClass('w-50').removeClass('w-100');

  });

  $('.vm-contact-view-close').on('click', function() {
    $('.vm-contact-view').removeClass('vm-dual-column');
    $('.vm-contact-view').addClass('d-none');
    $('.vm-add-activity-flyout').removeClass('vm-dual-activity');
    $('.vm-ad-view').removeClass('d-none');
    $('.vm-add-activity').removeClass('w-50').addClass('w-100');

  })
  //  Add Activity Flyout JS  End//

  //  Add Activity Flyout JS  End//
  $('.vm-add-company-activity-click').click(function () {

    $('.vm-add-company-activity-flyout').toggleClass('active');
    $('.vm-add-company-activity-flyout .vm-flyout-close').toggleClass('d-block');
    $('body').toggleClass('mask');
    $('.vm-manage-activity-flyout').removeClass('active');
    $('.vm-add-an-opportunity-activity-flyout').removeClass('active');
    $('.vm-add-request-flyout').removeClass('active');

  });
  $('.vm-add-an-opportunity-activity-click').click(function () {
    $('.vm-add-an-opportunity-activity-flyout').toggleClass('active');
    $('.vm-add-an-opportunity-activity-flyout .vm-flyout-close').toggleClass('d-block');
    $('body').toggleClass('mask');

  });
  $('.vm-add-request-activity-click').click(function () {
    $('.vm-add-request-flyout').toggleClass('active');
    $('.vm-add-request-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });

  // flyout plus icon open sidebar
  $('.vm-more-icon').click(function () {
    $(this).parent().toggleClass('open');
    
  });
  $('.vm-more .vm-flyout li a').click(function () {
    $('.vm-more').toggleClass('open');
    document.documentElement.scrollTop = 0;
    
  });

 // Filter Flyout Js //
 $('.vm-filter-flyout-click').click(function () {
  $('.vm-filter-flyout').toggleClass('active');
  $('.vm-filter-flyout .vm-flyout-close').toggleClass('d-block');
  $('#vm-wrapper').toggleClass('vm-mask');
});
$(".dropdown-menu ul li:only-of-type").addClass("rounded-radius");

// Smart View Sections //

$('.vm-smart-view-add').click(function () {
  $(this).hide();
  $('.vm-tick-icon').show();
  $('.vm-smart-view-edit').slideDown();
});
$('.vm-tick-icon').click(function () {
  $('.vm-smart-view-close-text').show();
  $('.vm-smart-view-close').show();
   $(this).hide();
   $('.vm-smart-view-add-text').hide();
   $('.vm-smart-view-edit').slideUp();
 });
 $('.vm-smart-view-close').click(function () {
  $('.vm-smart-view-close-text').hide();
  $('.vm-smart-view-close').hide();
   $('.vm-smart-view-add-text').show();
   $('.vm-smart-view-add').show();
 });
 

 $("#smart-view-check").click(function() {
  if($(this).is(":checked")) {
      $(".smart-view-visible").slideDown();
  } else {
      $(".smart-view-visible").slideUp();
  }
});



  /*START BULK ACTION PANEL SCRIPT*/

  $('.vm-bulk-action-check').change(function () {

    if ($('.vm-bulk-action-check').is(":checked")) {
      $(".vm-bulk-action-panel").slideDown('slow')
      // alert('test')
    }

    else {
      $(".vm-bulk-action-panel").slideUp('slow')
    }

  })

  $('.vm-close-bulk-action-panel').click(function () {
    $('.vm-bulk-action-check').prop("checked", false);
    $(".vm-bulk-action-panel").slideUp('slow')
  })

  $(".vm-pull-down").click(function () {
    $(".vm-deals-pipeline").slideToggle(500);
    $(".vm-pull-down svg").toggleClass('rotate');
    $(".vm-strip").toggleClass('vm-stripe-hide');
  });
  /*END BULK ACTION PANEL SCRIPT*/
  
  // Contact Popover //
  $(".vm-profile-detail-pop").popover({ trigger: "manual", html: true, animation: false })
    .on("mouseenter", function () {
      var _this = this;
      $(this).popover("show");
      $(".popover").on("mouseleave", function () {
        $(_this).popover('hide');
      });
    }).on("mouseleave", function () {
      var _this = this;
      setTimeout(function () {
        if (!$(".popover:hover").length) {
          $(_this).popover("hide");
        }
      }, 300);
    });

  // Activity Board List active & inactive //
  $('.vm-list-tab li a').click(function () {
    $(".vm-list-tab .active").removeClass("active");
    $(this).addClass("active");
  });
  // Activity Board List active & inactivevEnd //
  // Header Search Block //

  $('.vm-header .vm-search-icon').on('click', function () {
    $('.vm-search-close').addClass('d-block');
    $('.vm-header-search-block').slideDown();
    $('body').addClass('overflow-hidden');
    var position = $('#vm-header-search-icon').position();
    $(".vm-search-close").css("left", position.right - 80);

  });
  $('.vm-search-close').on('click', function () {
    $('.vm-header-search-block').slideUp();
    $('.vm-search-close').removeClass('d-block');
    $('body').removeClass('overflow-hidden');

  });
  // Header Search Block End//

  // Contact Page Label Edit //
  $(".vm-edit-cnt").click(function (e) {
    $(this).parent().hide();
    $(this).parent().next().show();
    e.stopPropagation();
  });

  // Add Contact JS START //
  $(".vm-add-contact-icon").click(function () {
    $(".vm-add-contact").slideToggle();
    $(".vm-add-contact-icon").hide();
    $('.vm-blank-screen').slideUp();
    

  });

  $(".vm-add-contact-link").click(function () {
     $(".vm-add-contact").slideToggle();
    $('.vm-blank-screen').slideUp();
  });
  // Add Contact JS END //


  $(".vm-contact-cancel").click(function () {
    $(".vm-add-contact").slideToggle();
    $(".vm-add-contact-icon").show();
    $('.vm-blank-screen').slideDown();

  });


  // Tab JS //
  // $(".vm-tabs .nav-tabs a").click(function () {
  //   var position = $(this).parent().position();
  //   var width = $(this).parent().width();
  //   $(".vm-tabs .slider").css({ "left": + position.left, "width": width });
  // });
  // var actWidth = $(".vm-tabs .nav-tabs").find(".active").parent("li").width();
  // var actPosition = $(".vm-tabs .nav-tabs .active").position();
  // $(".vm-tabs .slider").css({ "left": + actPosition.left, "width": actWidth });


  function checkcontainerscroll(elem) {
    var con = $(".slimScrollDiv");
    var contHeight = con.height();
    var contTop = con.scrollTop();
    var contBottom = contTop + contHeight;

    var elemTop = $(elem).offset().top - con.offset().top -1;
    var elemBottom = elemTop + $(elem).height();

    return ((elemTop < 0 && elemBottom > 0) || (elemTop > 0 && elemTop <= con.height()));
  }

  $('.activity-board-scroll').scroll(function () {
    $('.vm-list-tab a').removeClass('active');
    $.each($(".activity-board-scroll section"), function (i, e) {
      if (checkcontainerscroll($(e))) {
        $('.' + e.id).children()[0].classList.add('active');
        return false;
      }
    });
  })



  // Dashboard Activity Board JS //

  var pastdue = $('#past-due'); //set elements
  var pastduePosition = pastdue.position();

  var today = $('#today'); //set elements
  var todayPosition = today.position();

  var upcoming = $('#upcoming'); //set elements
  var upcomingPosition = upcoming.position();

  $('.past-tab').on('click', function () {
    $('.activity-board-scroll').slimScroll({
      scrollTo: pastduePosition.top + 'px'
    });

  });
  $('.today-tab').on('click', function () {
    $('.activity-board-scroll').slimScroll({
      scrollTo: todayPosition.top + 'px'
    });

  });

  $('.upcoming-tab').on('click', function () {
    $('.activity-board-scroll').slimScroll({
      scrollTo: upcomingPosition.top + 'px'

    });

  });

  // Dashboard Activity Board JS End//

  // Contact onmousehover //
 
    $(".vm-contact-more-info").hover(function(){
      $(".vm-contact-more-details").fadeIn();
    });
    $(".vm-contact-more-details").mouseleave(function(){
     $(this).fadeOut();
   });


  // Header Search Block  End//
  // Slimscroll JS //
  var screenHeight = $(window).height();
  var searchHeight = screenHeight - 160;
  
  // $('.vm-flyout-content').slimscroll({
  //   height: searchHeight + 85,
  // });
  $('.vm-flyout-content, .vm-flyout-content1').slimscroll({
    height: searchHeight + 85,
  });
 $('#search-block-scroll').slimscroll({
   height: searchHeight,
 });
 $('.vm-flyout-scroll1').slimscroll({
   height: screenHeight - 80,
 });
 $('.vm-flyout-scrol2').slimscroll({
   height: screenHeight - 150,
 });
  $('.activity-board-scroll').slimscroll({
    height: '1216px'
  });
  $('.today-tab').trigger('click');

  // Slimscroll JS  End//

});

