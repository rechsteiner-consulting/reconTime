window.onload = function()
{
	document.getElementById("startButton").addEventListener("click", startWork);
	document.getElementById("endButton").addEventListener("click", endWork);
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






function startWork() {
	var now = new Date();
	var startWorkHours = now.getHours();
	var startWorkMinutes = now.getMinutes();
    var startWorkSeconds = now.getSeconds();
	var startTime = "";
	
	startTime = (startWorkHours < 10) ? "0" + startWorkHours + ":" : startWorkHours + ":";
    startTime += (startWorkMinutes < 10) ? "0" + startWorkMinutes + ":" : startWorkMinutes + ":";
    startTime += (startWorkSeconds < 10) ? "0" + startWorkSeconds : startWorkSeconds;
	
	document.getElementById('modalStartBody').innerHTML =  startTime ;
	
}

function endWork() {
	var now = new Date();
	var endWorkHours = now.getHours();
	var endWorkMinutes = now.getMinutes();
    var endWorkSeconds = now.getSeconds();
	var endTime = "";
	
	endTime = (endWorkHours < 10) ? "0" + endWorkHours + ":" : endWorkHours + ":";
    endTime += (endWorkMinutes < 10) ? "0" + endWorkMinutes + ":" : endWorkMinutes + ":";
    endTime += (endWorkSeconds < 10) ? "0" + endWorkSeconds : endWorkSeconds;
	
	document.getElementById('modalEndBody').innerHTML =  endTime ;
	
}