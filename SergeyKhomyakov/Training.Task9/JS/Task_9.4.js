var counter = 11;
function Timer() {
    counter--;
    document.getElementById("output").innerHTML = counter;
    setTim = setTimeout("Timer()", 1000);   
    if(counter == 0)
    {
        document.getElementById("output").innerHTML = counter;
        clearTimeout(setTim);
        document.location.href = document.getElementById("Next").href;
    }
    
}
function StopTimer() {
    clearTimeout(setTim);
}

function ResetTimer(){
    counter = 11;
    Timer();
}