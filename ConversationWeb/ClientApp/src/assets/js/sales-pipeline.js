$(init);

function init() {
  $(".jdropwon").droppable({
    tolerance: 'pointer',
    accept: function (event, ui) {
      return true;
    },
    drop: function (event, ui) {
      var id;
      ui.draggable[0].id = id = uuidv4();
      sessionStorage.setItem("id", id);
      ui.draggable[0].style.display = "none";
      jQuery('.jdropwon').trigger('click');
    }
  })

  $(".jdroprecycle").droppable({
    tolerance: 'pointer',
    accept: function (event, ui) {
      return true;
    },
    drop: function (event, ui) {
      var id;
      ui.draggable[0].id = id = uuidv4();
      jQuery('#' + id).remove();
    }
  })

  $(".jdroplost").droppable({
    tolerance: 'pointer',
    accept: function (event, ui) {
      return true;
    },
    drop: function (event, ui) {
      var id;
      ui.draggable[0].id = id = uuidv4();
      sessionStorage.setItem("id", id);
      ui.draggable[0].style.display = "none";
      jQuery('.jdroplost').trigger('click');
    }
  })


  $(".droppable-area1, .droppable-area2, .droppable-area3, .droppable-area4, .droppable-area5").sortable({
    connectWith: ".connected-sortable",
    stack: '.connected-sortable div',
    start: function (e, ui) {
      document.getElementById("pipeline-status").style.display = "block";
    },
    stop: function (e, ui) {
      document.getElementById("pipeline-status").style.display = "none";
    }
  });
  $(".droppable-area6, .droppable-area7, .droppable-area8").sortable({
    connectWith: ".connected-sortable",
    stack: '.connected-sortable div',
  });

  $('#pipeline-status').hide();

  $('#savewon').click(function () {
    var id = sessionStorage.getItem("id");
    jQuery('#' + id).show().addClass("active");
    sessionStorage.removeItem("id");
  })
  $('#savelost').click(function () {
    var id = sessionStorage.getItem("id");
    jQuery('#' + id).show().addClass("active");
    sessionStorage.removeItem("id");
  })
}
function uuidv4() {
  return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
    var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
    return v.toString(16);
  });
}


$(".column").droppable({
  hoverClass: "ui-state-active"
  // outClass:'ui-state-active1'
});
$(".won").droppable({
  hoverClass: "won-hover"
});
$(".recycle").droppable({
  hoverClass: "recycle-hover"
});
$(".lost").droppable({
  hoverClass: "lost-hover"
});