window.onload = function()
{
	document.getElementById("startButton").addEventListener("click", startWork);
	document.getElementById("endButton").addEventListener("click", endWork);
    window.setInterval("time()", 1000);
	
}

function time() {
    var now = new Date();     
    document.getElementById('time').innerHTML = '<h1>' + timeOutputString(now) + '</h1>';
}

function startWork() {
	var now = new Date();		
	document.getElementById('modalStartBody').innerHTML =  timeOutputString(now);	
}

function endWork() {
	var now = new Date();	
	document.getElementById('modalEndBody').innerHTML =  timeOutputString(now);
}

function timeOutputString(date) {	
	var hours = date.getHours();
	var minutes = date.getMinutes();
    var seconds = date.getSeconds();
	var time = "";
	time = (hours < 10) ? "0" + hours + ":" : hours + ":";
    time += (minutes < 10) ? "0" + minutes + ":" : minutes + ":";
    time += (seconds < 10) ? "0" + seconds : seconds;
	return time;
}

function elapsedTime(){
	//values set to millisecond
	var msecPerMinute = 1000 * 60;
	var msecPerHour = msecPerMinute * 60;
	var msecPerDay = msecPerHour * 24;
	
	//Set the Date
	var date = new Date();
	var dateMsec = date.getTime();
	
	date.getMonth();
	date.getDate();
	date.getHours();
	
	//get the diffrence in milliseconds.
	var interval = dateMsec - date.getTime();
	
	//calculate how many days
	var days = Math.floor(interval / msecPerDay);
	interval = interval - (days * msecPerDay);
	
	//calculate hours, minutes and seconds
	var hours = Math.floor(interval / msecPerHour);
	interval = interval - (hours * msecPerHour);
	
	var minutes = Math.floor(interval/msecPerMinute);
	interval = interval - (minutes * msecPerMinute);
	
	var seconds = Math.floor(interval/1000);
}