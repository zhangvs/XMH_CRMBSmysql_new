$(document).ready(function () {
    /* This code is executed after the DOM has been completely loaded */

    var tmp;

    $('.note').each(function () {
        /* Finding the biggest z-index value of the notes */
        tmp = $(this).css('z-index');
        if (tmp > zIndex) zIndex = tmp;
    })


    /* A helper function for converting a set of elements to draggables: */
    make_draggable($('.note'));

    /* Configuring the fancybox plugin for the "Add a note" button: */
    $("#addButton").fancybox({
        'zoomSpeedIn': 600,
        'zoomSpeedOut': 500,
        'easingIn': 'easeOutBack',
        'easingOut': 'easeInBack',
        'hideOnContentClick': false,
        'padding': 15
    });



    $('#editNote').fancybox();

    /* Listening for keyup events on fields of the "Add a note" form: */
    $('.pr-body,.pr-author').live('keyup', function (e) {
        if (!this.preview)
            this.preview = $('#fancy_ajax .note');

        /* Setting the text of the preview to the contents of the input field, and stripping all the HTML tags: */
        this.preview.find($(this).attr('class').replace('pr-', '.')).html($(this).val().replace(/<[^>]+>/ig, ''));
    });

    /* Changing the color of the preview note: */
    $('.color').live('click', function () {
        $('#fancy_ajax .note').removeClass('yellow green blue').addClass($(this).attr('class').replace('color', ''));
    });

    /* The submit button: */
    $('#note-submit').live('click', function (e) {

        if ($('.pr-body').val().length < 1) {
            alert("不能少于1个字符！")
            return false;
        }

        //if ($('.pr-author').val().length < 1) {
        //    alert("You haven't entered your name!")
        //    return false;
        //}

        $(this).replaceWith('<img src="img/ajax_load.gif" style="margin:30px auto;display:block" />');

        var top = parseInt(Math.random() * 300);
        var left = parseInt(Math.random() * 800);

        var data = {
            'Action': 'save',
            'top': top,
            'left': left,
            'zindex': ++zIndex,
            'body': $('.pr-body').val(),
            'author': $('.pr-author').val(),
            'color': $.trim($('#fancy_ajax .note').attr('class').replace('note', ''))
        };

        /* Sending an AJAX POST request: */
        $.post('../../data/Personal_notes.ashx', data, function (msg) {
         
            if (parseInt(msg)) {
                /* msg contains the ID of the note, assigned by MySQL's auto increment: */
                var tmp = $('#fancy_ajax .note').clone();
                tmp.find('div.delbtn').attr('noteid', msg);
                tmp.find('span.data').text(msg).end().css({ 'z-index': zIndex, top: top, left: left });
                tmp.appendTo($('#main'));
                make_draggable(tmp)
                $("#main .note").remove();
                initdate();
                initHeight();
                $(window).resize(function () {
                    initHeight();
                });
            }
       
            $("#addButton").fancybox.close();
            //  initDel();
         
         
        });
        e.preventDefault();
    })
    $('.note-form').live('submit', function (e) { e.preventDefault(); });
});


function initdate() {
 
    $.ajax({
        type: "get",
        url: "../../data/Personal_notes.ashx", /* 注意后面的名字对应CS的方法名称 */
        data: { Action: 'Get', rnd: Math.random() }, /* 注意参数的格式和名称 */
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            var obj = eval(result);
            //alert(obj.constructor); //String 构造函数
            for (var i = 0; i < obj.length ; i++) {
                CreateItem(obj[i].id, obj[i].note_content, obj[i].note_color, obj[i].xyz);
            }
            initDel();
        }
    });
}


var zIndex = 0;
function make_draggable(elements) {
    /* Elements is a jquery object: */
    elements.draggable({
        containment: 'parent',
        start: function (e, ui) { ui.helper.css('z-index', ++zIndex); },
        stop: function (e, ui) {

            /* Sending the z-index and positon of the note to update_position.php via AJAX GET: */

            $.get('../../data/Personal_notes.ashx', {
                Action: 'update',
                x: ui.position.left,
                y: ui.position.top,
                z: zIndex,
                id: parseInt(ui.helper.find('span.data').html())
            });
        }
    });
}
