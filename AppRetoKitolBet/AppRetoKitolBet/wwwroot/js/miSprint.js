document.getElementById("buscar_btn").addEventListener("click", obtenerPersonas);//ponemos el "boton" en el js

function obtenerPersonas() {

    //let nombre = document.getElementById("nombre").value;
    let url = "http://192.168.99.100:32769/api/v3/projects/4/work_packages";
    //let url = "https://swapi.co/api/people/"+ /planets +"?search=" + nombre;//esto con los planetas y especies

    let xhr = new XMLHttpRequest();
    xhr.open("GET", url);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            mostrarDatos(JSON.parse(xhr.response));
        }
    };
    xhr.send();
}

function mostrarDatos(responseObj) { 
    let nombre = document.getElementById("nombre").value;
    let listaDeWP = responseObj.results;//results es un objeto con una lista dentro
    let mensajeEnHtml = "";
    for (let i = 0; i < listaDeWP.length; i++) {
        let nombre = listaDeWP[i];
        let mensaje = "<p>" + nombre + "</p>";
        mensajeEnHtml += mensaje;
    }
    document.getElementById("lista").innerHTML = mensajeEnHtml;
}