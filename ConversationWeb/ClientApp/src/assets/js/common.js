$(document).ready(function () {
  "use strict";

  var $ = jQuery.noConflict();
  $('.vm-profile-pic, .vm-profile').each(function(){ var r = Math.random() * 255; var g = Math.random() * 255; var b = Math.random() * 255; var a = 0.8; var new_color = 'rgba(' + r + ',' + g + ',' + b + ',' + a +')'; $(this).css('background-color',new_color); });

  var $ = jQuery.noConflict();
  $('#radioBtn a').on('click', function(){
    var sel = $(this).data('title');
    var tog = $(this).data('toggle');
    $('#'+tog).prop('value', sel);
    
    $('a[data-toggle="'+tog+'"]').not('[data-title="'+sel+'"]').removeClass('active').addClass('notActive');
    $('a[data-toggle="'+tog+'"][data-title="'+sel+'"]').removeClass('notActive').addClass('active');
})
$("#menu-toggle").click(function(e) {
  e.preventDefault();
  $("#main-wrapper").toggleClass("toggled");
  $("#menu-toggle span").toggleClass("rotate");
  $(".vm-logo").toggleClass("d-none");
  $(".vm-primary-header-logo").toggleClass("vm-primary-header-logo-expand");
  $(".vm-logo-expand").toggleClass("d-inline-block");
  
});
$(".modelone").click(function(e) {
 
  $(this).toggleClass("active");
  
  
});
$("#menu-toggle").click(function(e) {
  e.preventDefault();
  $(".vm-call-info").toggleClass("toggled1");
  
  
});
$('[data-toggle="tooltip"]').tooltip()
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

  $("#smart-view-check1").click(function() {
    if($(this).is(":checked")) {
        $(".smart-view-visible").slideDown();
    } else {
        $(".smart-view-visible").slideUp();
    }
  });


  $(".vm-replace").click(function(e) {
    $(".vm-introduction-replace").slideDown();
  });
  $(".vm-add-voicemail-upload").click(function(e) {
    $(".vm-add-voicemail-record").slideDown();
  });



  $('.vm-profile-show').click(function (e) {
    $('.vm-dropdown-profile').toggleClass("p-show");
    $(".dropdown-toggle").toggleClass("arrow-up");
  })
  
  $('.vm-multi-select-dropdown ').click(function(e){
    $(this).closest(".vm-column-gutter").parent().find('.vm-multi-select-dropdown').toggleClass('show');
    $(this).closest(".vm-column-gutter").parent().siblings().find('.vm-multi-select-dropdown').removeClass('show')
    $(this).closest(".vm-column-gutter").parent().find('.dropdown-menu').toggleClass('show');
    $(this).closest(".vm-column-gutter").parent().siblings().find('.dropdown-menu').removeClass('show');
})
  // $('.vm-profile-show1').click(function (e) {
  //   $('.dropdown-menu1').toggleClass("show");
   
  // })
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
  $('.vm-manage-opportunity-click').click(function () {
    $('.vm-manage-opportunity-flyout').toggleClass('active');
    $('.vm-manage-opportunity-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-add-contact-click').click(function () {
    $('.vm-add-contact-flyout').toggleClass('active');
    $('.vm-add-contact-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-manage-contact-click').click(function () {
    $('.vm-manage-contact-flyout').toggleClass('active');
    $('.vm-manage-contact-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-income-call-click').click(function () {
    $('.vm-income-call-flyout').toggleClass('active');
    $('.vm-income-call-flyout .vm-flyout-close').toggleClass('d-block');
    //$('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-add-company-click').click(function () {
    $('.vm-add-company-flyout').toggleClass('active');
    $('.vm-add-company-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-manage-company-click').click(function () {
    $('.vm-manage-company-flyout').toggleClass('active');
    $('.vm-manage-company-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-add-opportunity-click').click(function () {
    $('.vm-add-opportunity-flyout').toggleClass('active');
    $('.vm-add-opportunity-flyout .vm-flyout-close').toggleClass('d-block');
    $('.vm-add-opportunity-quote').toggleClass('d-none'); 
    $('.vm-add-opportunity-flyout').removeClass('vm-dual-activity');
    $('.vm-add-opportunity').removeClass('vm-single-column');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  


 


  $('.vm-add-opportunity-quote-close').click(function () {
    $('.vm-add-opportunity-quote').toggleClass('d-none'); 
   // $('.vm-add-opportunity-flyout').toggleClass('vm-single-column');
   // $('.vm-add-opportunity').toggleClass('vm-single-column'); 
   // $('.vm-add-opportunity-flyout').removeClass('vm-dual-activity');   
    
  });
  $('.vm-opportunity-quote-expand').click(function () {
    $('.vm-add-opportunity-flyout').toggleClass('vm-dual-activity');
    $('.vm-add-opportunity').toggleClass('vm-single-column');
    $('.vm-add-opportunity-quote').addClass('d-block');
  });


  $('.vm-add-opportunity-flyout .vm-flyout-close').click(function () {
   $('.vm-add-opportunity-flyout').toggleClass('vm-dual-activity');
  $('.vm-add-opportunity').toggleClass('vm-single-column');
    $('.vm-add-opportunity-quote').toggleClass('d-block');
  });
  
  $('.vm-contact-view-click').click(function () {
    $('.vm-profile-detail-view-flyout').toggleClass('active');
    $('.vm-profile-detail-view-flyout .vm-flyout-close').toggleClass('d-block');
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
    $('.vm-add-activity-flyout .vm-flyout-close').addClass('d-block');
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
  $('.vm-add-service-request-click').click(function () {
    $('.vm-add-service-request-flyout').toggleClass('active');
    $('.vm-add-service-request-flyout .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-won-opportunity-click').click(function () {
    $('.vm-won-opportunity-quote').toggleClass('active');
    $('.vm-won-opportunity-quote .vm-flyout-close').toggleClass('d-block');
    $('#vm-wrapper').toggleClass('vm-mask');
  });
  $('.vm-lost-opportunity-click').click(function () {
    $('.vm-lost-opportunity-quote').toggleClass('active');
    $('.vm-lost-opportunity-quote .vm-flyout-close').toggleClass('d-block');
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
 $('.vmfilter-fl-yout-click').click(function () {
  $('.vm-filter-flyout').toggleClass('active');
  $('.vm-filter-flyout .vm-flyout-close').toggleClass('d-block');
  $('#vm-wrapper').toggleClass('vm-mask');
});
$(".dropdown-menu ul li:only-of-type").addClass("rounded-radius");
$('.vm-flyout-close.vm-call-receive-click').on('click', function () {
  $('.vm-call-receive-contact-flyout').toggleClass('active');
  $('.vm-call-receive-contact-flyout .vm-flyout-close').toggleClass('d-block');
})
// Participants Flyout Js //
$('.vm-all-participants-icon').click(function () {
  $('.vm-all-participants').toggleClass('active');
  $('.vm-all-participants .vm-flyout-close').toggleClass('d-block');
  $('#vm-wrapper').toggleClass('vm-mask');
});

// Call Receive Flyout End//

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
 

//  $("#smart-view-check").click(function() {
//   if($(this).is(":checked")) {
//       $(".smart-view-visible").slideDown();
//   } else {
//       $(".smart-view-visible").slideUp();
//   }
// });




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
  $('.close-activity-modal').on('click', function () {
    $('.vm-activity-strikeout').addClass('strikeout-line');  //new
  })
  $('.vm-activity-strikeout .vm-activities-check').on('click', function () {
    $('.vm-activity-strikeout').addClass('d-none');  //new
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
    var position = $('#vm-header-search-icon').offset();
    $(".vm-search-close").css("left", position.left - 80);

  });

  $('.vm-search-close').on('click', function () {
    $('.vm-header-search-block').slideUp();
    $('.vm-search-close').removeClass('d-block');
    $('body').removeClass('overflow-hidden');
  });
  $('.vm-header #vm-notification-icon').on('click', function () {
    $('.vm-notification-close').addClass('d-block');
    $('.vm-notification-block').slideDown();
    $('body').addClass('overflow-hidden');
    var position = $('#vm-header-search-icon').offset();
    $(".vm-notification-close").css("left", position.left + 10);
  });
  $('.vm-notification-close').on('click', function () {
    $('.vm-notification-block').slideUp();
    $('.vm-notification-close').removeClass('d-block');
    $('body').removeClass('overflow-hidden');
  });


  $('.vm-call-icon').on('click', function () {
    $('.vm-take-calls').slideToggle();
  
   
  });

  $('.vm-call-close').on('click', function () {
    $('.vm-take-calls').slideUp();
    
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
    var con = $(".activity-board-scroll");
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
      scrollTo: '0px'
    });

  });
  $('.today-tab').on('click', function () {
    $('.activity-board-scroll').slimScroll({
      scrollTo: $('#past-due')[0].offsetHeight + 'px'
    });

  });


    



  $('.upcoming-tab').on('click', function () {
    var upcoming = $('#upcoming'); //set elements
    var upcomingPosition = 0;    
    var acti = upcoming.siblings();
    for(var i=0;i<acti.length;i++) {
      upcomingPosition+=acti[i].offsetHeight;;
    }
    $('.activity-board-scroll').slimScroll({
      scrollTo: upcomingPosition + 'px'
    });

  });

  // Dashboard Activity Board JS End//
 
  
// call interaction
 
$('.vm-call').click( function(e) {
  e.preventDefault(); // stops link from making page jump to the top
  e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-call-option').toggleClass('active');  
});

$('.vm-call-option').click( function(e) {  
  e.stopPropagation(); // when you click within the content area, it stops the page from seeing it as clicking the body too
});

$('body').click( function() {
  //  $('.vm-call-option').removeClass('active');
});
$('.vm-call-cancel').click( function(e) {
  // e.preventDefault(); // stops link from making page jump to the top
  // e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-call-option').toggleClass('active');  
});

$('.vm-call-now').click( function(e) {
  // e.preventDefault(); // stops link from making page jump to the top
  // e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-call-notes, .vm-call-info').toggleClass('active');  
  $('.vm-call-option').removeClass('active');
});
$('.vm-video-call').click( function(e) {
  // e.preventDefault(); // stops link from making page jump to the top
  // e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-video-call-info').toggleClass('active');  
  // $('.vm-call-option').removeClass('active');
});
$('.vm-call-notes-info').click( function(e) {
  $(this).toggleClass('active');
  // e.preventDefault(); // stops link from making page jump to the top
  // e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-call-notes').toggleClass('active');  
});

$('.vm-call-notes-cancel, .vm-save-notes').click( function(e) {
  $('.vm-call-notes-info').toggleClass('active'); 
  // e.preventDefault(); // stops link from making page jump to the top
  // e.stopPropagation(); // when you click the button, it stops the page from seeing it as clicking the body too
  $('.vm-call-notes').toggleClass('active');  
});
$('body').click( function() {
  // $('.vm-call-notes, .vm-call-info').removeClass('active');

});

// header dialpad

var count = 0;

$(".vm-digit").on('click', function() {
  var num = ($(this).clone().children().remove().end().text());
  if (count < 11) {
    $("#output").append('<span>' + num.trim() + '</span>');

    count++
  }
});

$('.fa-long-arrow-left').on('click', function() {
  $('#output span:last-child').remove();
  count--;
});




  // Contact onmousehover //
 
    $(".vm-contact-more-info").hover(function(){
      $(".vm-contact-more-details").fadeIn();
    });
    $(".vm-contact-more-details").mouseleave(function(){
     $(this).fadeOut();
   });


  //  Dashboard Upcoming Reminder Block //
  $(".vm-reschedule-view-more").click(function(){
    $(this).text($(this).text() == 'Less' ? '+3 More' : 'Less');
    $(".vm-reschedule-block").slideToggle();
    $(".vm-reschedule-view-more").toggleClass("rotate");
    
  })
  // Header Search Block  End//

  

  // Slimscroll JS //
  var screenHeight = $(window).height();
  var searchHeight = screenHeight - 160;
  $('.vm-call-history').slimscroll({
    height: 240,
  });
  $('.vm-manage-column-scroll').slimscroll({
    height: 240,
  });
  $('.vm-dropdown-scroll').slimscroll({
    height:150,
  });
  $('.vm-flyout-content, .vm-flyout-content1').slimscroll({
    height: searchHeight + 85,
  });

  $('.vm-call-receive-contact-flyout .vm-flyout-content').slimscroll({
    height: searchHeight - 62,
  });
 $('#search-block-scroll, #notification-block-scroll').slimscroll({
   height: searchHeight,
 });
 $('.vm-flyout-scroll1').slimscroll({
   height: screenHeight - 80,
 });
 $('.vm-flyout-scrol2').slimscroll({
   height: screenHeight - 150,
 });
  $('.activity-board-scroll').slimscroll({
    height: '675px'
  });
  $('.vm-autocomplete-box-scroll-js').slimscroll({
    height: '169px'
  });
  
  $('.vm-contactlist-scroll').slimscroll({
    height: '100%',
  });
  $('.vm-video-large-window').slimscroll({
    height: '100vh',
  });
  
  $('.today-tab').trigger('click');

  // Slimscroll JS  End//
  $(".show-toast-danger").click(function(){
    $(".vm-toast-danger").toast('show');
  });
  $(".show-toast-success").click(function(){
    $(".vm-toast-success").toast('show');
  });
  $(".show-toast-warning").click(function(){
    $(".vm-toast-warning").toast('show');
  });
  $(".show-toast-poor").click(function(){
    $(".vm-toast-poor-network").toast({ autohide: false }); 
    $(".vm-toast-poor-network").toast('show');
   
  });
  // Reports Div Hide & Show //
  $(".vm-customize-report").click(function(){
    $(".vm-customize-report-block").slideDown();
    $(".vm-customized-report-bottom-block").slideDown();
    $(".vm-title-card ").addClass("vm-bb-x-r0");
  });
  $(".add-sales-overview").click(function(){
    $(".add-sales-overview-card").slideDown();
  });
  $(".vm-add-sales-overview-card-list").click(function(){
    $(".add-sales-overview-card").hide();
    $(".vm-view-sales-overview-card").slideDown();
  });
  $(".vm-view-sales-overview-card .vm-edit-icon a").click(function(){
    $(".add-sales-overview-card").show();
    $(".vm-view-sales-overview-card").slideUp();
  });
    

    $(".vm-action__cancel").click(function(){
      if($(".vm-customized-report-top-block").is(":visible")){
        $(this).parents(".vm-customized-report-bottom-block").slideUp();
      }else{
        $(this).parents(".vm-customized-report-bottom-block").slideUp();
        $('.vm-customize-report-block').slideUp()
      }
    });

    $(".vm-action__submit, .vm-action__cancel").click(function(){
      if($(".vm-customized-report-bottom-block").is(":visible")){
        $(this).parents().siblings().children(".vm-customized-report-top-arrow").removeClass('vm-customized-report-top-arrow-rotate');
      }else{
        $(this).parents().siblings().children(".vm-customized-report-top-arrow").addClass('vm-customized-report-top-arrow-rotate');
        // $('.vm-customize-report-block').slideUp()
      }
    });

    $(".vm-action__submit").click(function(){
      $(this).parents(".vm-customized-report-bottom-block").slideToggle();
      // $(".vm-customize-report-block").slideToggle();
      $(this).parents().siblings(".vm-customized-report-top-block").slideDown();
      // $(this).parents().siblings().children(".vm-customized-report-top-arrow").toggleClass('vm-customized-report-top-arrow-rotate');
    });

    $(".vm-customized-report-top-arrow").click(function(){
      $(".vm-customized-report-bottom-block").slideToggle();
      $(this).toggleClass('vm-customized-report-top-arrow-rotate');
    });
    $(".customized-close").click(function(){
      $(".vm-customize-report-block").slideUp();
      $(this).parents(".vm-customized-report-top-block").slideUp();
      $(".vm-title-card ").removeClass("vm-bb-x-r0");
    });
    // Activity Dropdown Select //
    // $('.vm-activity-day-dropdown').click(function () {
    //   $('.vm-activity-day-data').slideDown();
    //   $('.vm-activity-week-data').slideUp();
    //   $('.vm-activity-month-data').slideUp();
    // });
    // $('.vm-activity-week-dropdown').click(function () {
    //   $('.vm-activity-week-data').slideDown();
    //   $('.vm-activity-day-data').slideUp();
    //   $('.vm-activity-month-data').slideUp();
    // });
    // $('.vm-activity-month-dropdown').click(function () {
    //   $('.vm-activity-month-data').slideDown();
    //   $('.vm-activity-day-data').addClass('vm-d-none');
    //   $('.vm-activity-week-data').slideUp('vm-d-none');
    // });
    // $('.dropdown-menu li').on('click', function() {
    //   var getValue = $(this).text();
    //   $('.dropdown-select').text(getValue);
    // });

});

