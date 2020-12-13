
function Login() {

	var username=document.getElementById("UserName").value;
	var password=document.getElementById("Password").value;
	let xhr=new XMLHttpRequest();
	var url="https://localhost:44369/categories?username="+username+"&password="+password;

	
	xhr.open('GET', url);
	xhr.send();
	xhr.onreadystatechange = () => {
		if(xhr.status===200){
			if (xhr.readyState === 4) {
        	window.alert(xhr.response);
    		}
		}
		else{
			if (xhr.readyState === 4){
				window.alert("Internal Server Error!");
			}
			
		}
    	
}

}