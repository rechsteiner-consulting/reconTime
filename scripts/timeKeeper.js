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
	startTime = new Date();		
	document.getElementById('modalStartBody').innerHTML =  timeOutputString(startTime);
	startTime = Date(timeOutputString(startTime));	
}

function endWork() {
	var now = new Date();	
	var endTime = new Date(timeOutputString(now));// HIER LIEGT DER FEHLER, FINDE IHN! LG JOEL
	timeOutputString(timeDifference(startTime, endTime)) ;
	//document.getElementById('modalEndBody').innerHTML =  timeOutputString(timeDifference(startTime, endTime));
}

function timeOutputString(date) {
	var date = new Date(date);
	var hours = date.getHours();
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
	var difference = new Date();
	difference.setDate(startTime.getDate()-endTime.getDate());
	difference.setDate(startTime.getSeconds()-endTime.getSeconds());
  console.log(endTime.getDate());
  console.log(difference.getDate(), difference.getTime());
	document.getElementById('modalEndBody').innerHTML =  (endTime.getTime() - startTime.getTime());
	return difference;
}


