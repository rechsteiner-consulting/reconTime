$(document).ready(function(){
		    $(window).resize(function(){
				if ($(window).width() < 600) {
					$("pw").text("pw") && $("dr").text("dr") && $("tu").text("tu") && $("nk").text("nk");
				}  
				
				else {
					$("pw").text("Patrick Weber") && $("dr").text("David Rechsteiner") && $("tu").text("Tobias Urech") && $("nk").text("Nils Keller");
				}  
			});	
		});
		
function check(form) { /*function to check userid & password*/
						/*the following code checkes whether the entered userid and password are matching*/
						
						if(form.userid.value == ("") && form.pswrd.value == "") {
							window.location = "adminpanel.html";/*opens the target page while Id & password matches*/
						}
						else {
							alert("Error Password or Username incorrect")/*displays error message*/
						}
}