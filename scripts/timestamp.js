window.onload = function()
{
    start();
}

 function start() {
    time();
    window.setInterval("time()", 1000);
}

function time() {
    var now = new Date();
    var hours = now.getHours();
    var minutes = now.getMinutes();
    var seconds = now.getSeconds();
 	var time = "";
	
    time = (hours < 10) ? "0" + hours + ":" : hours + ":";
    time += (minutes < 10) ? "0" + minutes + ":" : minutes + ":";
    time += (seconds < 10) ? "0" + seconds : seconds;
 
    document.getElementById('time').innerHTML = '<h1>' + time + '</h1>';
}

