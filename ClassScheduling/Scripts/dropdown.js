var menu = document.getElementsByClassName("dropdown");

if (window.location.pathname == "/home/index" || window.location.pathname == "/home/info"){
    menu.style.visibility = "hidden";
} else {
    menu.style.visibility = "visible";
}
