window.onload = function()
{
	document.getElementById("pwIn").addEventListener("click", pwStartWork);
	document.getElementById("pwOut").addEventListener("click", pwEndWork);
	document.getElementById("drIn").addEventListener("click", drStartWork);
	document.getElementById("drOut").addEventListener("click", drEndWork);
	document.getElementById("tuIn").addEventListener("click", tuStartWork);
	document.getElementById("tuOut").addEventListener("click", tuEndWork);
	document.getElementById("nkIn").addEventListener("click", nkStartWork);
	document.getElementById("nkOut").addEventListener("click", nkEndWork);
}

function time() {
    var now = new Date();     
    document.getElementById('time').innerHTML = '<h1>' + timeOutputString(now) + '</h1>';
}

function pwStartWork() {
	startTime = new Date();		
	document.getElementById('pwIn').innerHTML =  timeOutputString(startTime);
	startTime = Date(timeOutputString(startTime));	
}

function pwEndWork() {
	var endTime = new Date();	
	document.getElementById('pwOut').innerHTML =  timeOutputString(timeDifference(startTime, endTime));
}

function drStartWork() {
	startTime = new Date();		
	document.getElementById('drIn').innerHTML =  timeOutputString(startTime);
	startTime = Date(timeOutputString(startTime));	
}

function drEndWork() {
	var endTime = new Date();	
	document.getElementById('drOut').innerHTML =  timeOutputString(timeDifference(startTime, endTime));
}

function tuStartWork() {
	startTime = new Date();		
	document.getElementById('tuIn').innerHTML =  timeOutputString(startTime);
	startTime = Date(timeOutputString(startTime));	
}

function tuEndWork() {
	var endTime = new Date();	
	document.getElementById('tuOut').innerHTML =  timeOutputString(timeDifference(startTime, endTime));
}

function nkStartWork() {
	startTime = new Date();		
	document.getElementById('nkIn').innerHTML =  timeOutputString(startTime);
	startTime = Date(timeOutputString(startTime));	
}

function nkEndWork() {
	var endTime = new Date();	
	document.getElementById('nkOut').innerHTML =  timeOutputString(timeDifference(startTime, endTime));
}

function timeOutputString(date) {
	var date = new Date(date);
	var hours = date.getHours() - 1;
	var minutes = date.getMinutes();
    var seconds = date.getSeconds();
	var time = "";

	time = (hours < 10) ? "0" + hours + ":" : hours + ":";
    time += (minutes < 10) ? "0" + minutes + ":" : minutes + ":";
    time += (seconds < 10) ? "0" + seconds : seconds;
	return time;
}

function timeDifference(startTime, endTime) {
    var endTime = new Date(endTime);
	var startTime = new Date(startTime);
	var difference = endTime - startTime;	
	
	return difference;
}

