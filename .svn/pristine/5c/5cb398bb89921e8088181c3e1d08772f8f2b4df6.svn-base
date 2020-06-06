
/*
* 弹出DIV层
*/


function showDiv() {
    var Idiv = document.getElementById("Idiv");
    var mou_head = document.getElementById('mou_head');
    Idiv.style.display = "block";
    //以下部分要将弹出层居中显示
    Idiv.style.left = (document.documentElement.clientWidth - Idiv.clientWidth) / 2 + document.documentElement.scrollLeft + "px";
    Idiv.style.top = (document.documentElement.clientHeight - Idiv.clientHeight) / 6 + document.documentElement.scrollTop + "px";

    //以下部分使整个页面至灰不可点击
    var procbg = document.createElement("div"); //首先创建一个div
    procbg.setAttribute("id", "mybg"); //定义该div的id
    procbg.style.background = "#000000";
    procbg.style.width = "100%";
    procbg.style.height = "100%";
    procbg.style.position = "fixed";
    procbg.style.top = "0";
    procbg.style.left = "0";
    procbg.style.zIndex = "500";
    procbg.style.opacity = "0.6";
    procbg.style.filter = "Alpha(opacity=70)";
    //背景层加入页面
    document.body.appendChild(procbg);
    document.body.style.overflow = "hidden"; //取消滚动条

    //以下部分实现弹出层的拖拽效果
    var posX;
    var posY;
    dhead.onmousedown = function (e) {
        if (!e) e = window.event; //IE
        posX = e.clientX - parseInt(Idiv.style.left);
        posY = e.clientY - parseInt(Idiv.style.top);
        document.onmousemove = mousemove;
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
    function mousemove(ev) {
        if (ev == null) ev = window.event;//IE
        Idiv.style.left = (ev.clientX - posX) + "px";
        Idiv.style.top = (ev.clientY - posY) + "px";
    }
}


function showDivId(div_id) {
    var Idiv = document.getElementById(div_id);
    var mou_head = document.getElementById('mou_head');
    Idiv.style.display = "block";
    //以下部分要将弹出层居中显示
    Idiv.style.left = (document.documentElement.clientWidth - Idiv.clientWidth) / 2 + document.documentElement.scrollLeft + "px";
    Idiv.style.top = (document.documentElement.clientHeight - Idiv.clientHeight) / 6 + document.documentElement.scrollTop + "px";

    //以下部分使整个页面至灰不可点击
    var procbg = document.createElement("div"); //首先创建一个div
    procbg.setAttribute("id", "mybg"); //定义该div的id
    procbg.style.background = "#000000";
    procbg.style.width = "100%";
    procbg.style.height = "100%";
    procbg.style.position = "fixed";
    procbg.style.top = "0";
    procbg.style.left = "0";
    procbg.style.zIndex = "500";
    procbg.style.opacity = "0.6";
    procbg.style.filter = "Alpha(opacity=70)";
    //背景层加入页面
    document.body.appendChild(procbg);
    document.body.style.overflow = "hidden"; //取消滚动条

    //以下部分实现弹出层的拖拽效果
    var posX;
    var posY;
    dhead.onmousedown = function (e) {
        if (!e) e = window.event; //IE
        posX = e.clientX - parseInt(Idiv.style.left);
        posY = e.clientY - parseInt(Idiv.style.top);
        document.onmousemove = mousemove;
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
    function mousemove(ev) {
        if (ev == null) ev = window.event;//IE
        Idiv.style.left = (ev.clientX - posX) + "px";
        Idiv.style.top = (ev.clientY - posY) + "px";
    }
}

function closeDivId(div_id) //关闭弹出层
{
    var Idiv = document.getElementById(div_id);
    Idiv.style.display = "none";
    document.body.style.overflow = "auto"; //恢复页面滚动条
    var body = document.getElementsByTagName("body");
    var mybg = document.getElementById("mybg");
    body[0].removeChild(mybg);

}

function closeDiv() //关闭弹出层
{
    var Idiv = document.getElementById("Idiv");
    Idiv.style.display = "none";
    document.body.style.overflow = "auto"; //恢复页面滚动条
    var body = document.getElementsByTagName("body");
    var mybg = document.getElementById("mybg");
    body[0].removeChild(mybg);

}


function show() {
    var Idiv = document.getElementById("prodown");
    var mou_head = document.getElementById('mou_head');
    Idiv.style.display = "block";
    //以下部分要将弹出层居中显示
    Idiv.style.left = (document.documentElement.clientWidth - Idiv.clientWidth) / 2 + document.documentElement.scrollLeft + "px";
    Idiv.style.top = (document.documentElement.clientHeight - Idiv.clientHeight) / 3 + document.documentElement.scrollTop + "px";

    //以下部分使整个页面至灰不可点击
    var procbg = document.createElement("div"); //首先创建一个div
    procbg.setAttribute("id", "mybg"); //定义该div的id
    procbg.style.background = "#000000";
    procbg.style.width = "100%";
    procbg.style.height = "100%";
    procbg.style.position = "fixed";
    procbg.style.top = "0";
    procbg.style.left = "0";
    procbg.style.zIndex = "500";
    procbg.style.opacity = "0.6";
    procbg.style.filter = "Alpha(opacity=70)";
    //背景层加入页面
    document.body.appendChild(procbg);
    document.body.style.overflow = "hidden"; //取消滚动条

    //以下部分实现弹出层的拖拽效果
    var posX;
    var posY;
    dhead1.onmousedown = function (e) {
        if (!e) e = window.event; //IE
        posX = e.clientX - parseInt(Idiv.style.left);
        posY = e.clientY - parseInt(Idiv.style.top);
        document.onmousemove = mousemove;
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
    function mousemove(ev) {
        if (ev == null) ev = window.event;//IE
        Idiv.style.left = (ev.clientX - posX) + "px";
        Idiv.style.top = (ev.clientY - posY) + "px";
    }
}

function closeDivs() //关闭弹出层
{
    var Idiv = document.getElementById("prodown");
    Idiv.style.display = "none";
    document.body.style.overflow = "auto"; //恢复页面滚动条
    var body = document.getElementsByTagName("body");
    var mybg = document.getElementById("mybg");
    body[0].removeChild(mybg);

}


function showPort() {
    var Idiv = document.getElementById("outInport");
    var mou_head = document.getElementById('mou_head');
    Idiv.style.display = "block";
    //以下部分要将弹出层居中显示
    Idiv.style.left = (document.documentElement.clientWidth - Idiv.clientWidth) / 2 + document.documentElement.scrollLeft + "px";
    Idiv.style.top = (document.documentElement.clientHeight - Idiv.clientHeight) / 3 + document.documentElement.scrollTop + "px";

    //以下部分使整个页面至灰不可点击
    var procbg = document.createElement("div"); //首先创建一个div
    procbg.setAttribute("id", "mybg"); //定义该div的id
    procbg.style.background = "#000000";
    procbg.style.width = "100%";
    procbg.style.height = "100%";
    procbg.style.position = "fixed";
    procbg.style.top = "0";
    procbg.style.left = "0";
    procbg.style.zIndex = "500";
    procbg.style.opacity = "0.6";
    procbg.style.filter = "Alpha(opacity=70)";
    //背景层加入页面
    document.body.appendChild(procbg);
    document.body.style.overflow = "hidden"; //取消滚动条

    //以下部分实现弹出层的拖拽效果
    var posX;
    var posY;
    dhead3.onmousedown = function (e) {
        if (!e) e = window.event; //IE
        posX = e.clientX - parseInt(Idiv.style.left);
        posY = e.clientY - parseInt(Idiv.style.top);
        document.onmousemove = mousemove;
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
    function mousemove(ev) {
        if (ev == null) ev = window.event;//IE
        Idiv.style.left = (ev.clientX - posX) + "px";
        Idiv.style.top = (ev.clientY - posY) + "px";
    }
}

function closePort() //关闭弹出层
{
    var Idiv = document.getElementById("outInport");
    Idiv.style.display = "none";
    document.body.style.overflow = "auto"; //恢复页面滚动条
    var body = document.getElementsByTagName("body");
    var mybg = document.getElementById("mybg");
    body[0].removeChild(mybg);

}


function showProcess() {
    var Idiv = document.getElementById("process");
    var mou_head = document.getElementById('mou_head');
    Idiv.style.display = "block";
    //以下部分要将弹出层居中显示
    Idiv.style.left = (document.documentElement.clientWidth - Idiv.clientWidth) / 2 + document.documentElement.scrollLeft + "px";
    Idiv.style.top = (document.documentElement.clientHeight - Idiv.clientHeight) / 3 + document.documentElement.scrollTop + "px";

    //以下部分使整个页面至灰不可点击
    var procbg = document.createElement("div"); //首先创建一个div
    procbg.setAttribute("id", "mybg"); //定义该div的id
    procbg.style.background = "#000000";
    procbg.style.width = "100%";
    procbg.style.height = "100%";
    procbg.style.position = "fixed";
    procbg.style.top = "0";
    procbg.style.left = "0";
    procbg.style.zIndex = "500";
    procbg.style.opacity = "0.6";
    procbg.style.filter = "Alpha(opacity=70)";
    //背景层加入页面
    document.body.appendChild(procbg);
    document.body.style.overflow = "hidden"; //取消滚动条

    //以下部分实现弹出层的拖拽效果
    var posX;
    var posY;
    dhead2.onmousedown = function (e) {
        if (!e) e = window.event; //IE
        posX = e.clientX - parseInt(Idiv.style.left);
        posY = e.clientY - parseInt(Idiv.style.top);
        document.onmousemove = mousemove;
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
    function mousemove(ev) {
        if (ev == null) ev = window.event;//IE
        Idiv.style.left = (ev.clientX - posX) + "px";
        Idiv.style.top = (ev.clientY - posY) + "px";
    }
}


function closePro() //关闭弹出层
{
    var Idiv = document.getElementById("process");
    Idiv.style.display = "none";
    document.body.style.overflow = "auto"; //恢复页面滚动条
    var body = document.getElementsByTagName("body");
    var mybg = document.getElementById("mybg");
    body[0].removeChild(mybg);

}

$(document).ready(function () {
    $(".div_canmove").mousedown(function (e)//e鼠标事件
    {
        $(this).css("cursor", "move"); //改变鼠标指针的形状
        var offset = $(this).parent().parent().offset(); //DIV在页面的位置
        var x = e.pageX - offset.left; //获得鼠标指针离DIV元素左边界的距离
        var y = e.pageY - offset.top; //获得鼠标指针离DIV元素上边界的距离
        $(document).bind("mousemove", function (ev)//绑定鼠标的移动事件，因为光标在DIV元素外面也要有效果，所以要用doucment的事件，而不用DIV元素的事件
        {
            $(".div_canmove").parent().parent().stop(); //加上这个之后
            var _x = ev.pageX - x; //获得X轴方向移动的值
            //var _y = ev.pageY - pop_height_formove - y; //获得Y轴方向移动的值
            var _y = ev.pageY - y; //获得Y轴方向移动的值
            $(".div_canmove").parent().parent().animate({ left: _x + "px", top: _y + "px" }, 10);
            //$(".show").fadeTo(0.5); //点击后开始拖动并透明显示
        });
    });
    $(document).mouseup(function () {
        $(".div_canmove").css("cursor", "default");
        $(this).unbind("mousemove");
        //$(".show").fadeTo(1); //松开鼠标后停止移动并恢复成不透明
    })
})

