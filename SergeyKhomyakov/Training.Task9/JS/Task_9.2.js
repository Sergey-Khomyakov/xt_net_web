function GetResult() {

    var str = document.getElementById('inputTxT').value;
    var reg = new RegExp("([\+]|[\-]|[\*]|[\/]|[\=])");
    var words = str.split(reg);
    var result = 0;
    for (let i = 0; i < words.length; i++) {

        if(result != 0)
        {
            switch (words[i]) 
            {
                case "-":
                    result = result - parseFloat(words[i+1]);
                    break;
                case "+":
                    result = result + parseFloat(words[i+1]);
                    break;
                case "*":
                    result = result * parseFloat(words[i+1]);
                    break;
                case "/":
                    result = result / parseFloat(words[i+1]);
                    break;
            } 
        }else if(result == 0)
        {
            switch (words[i]) 
            {
                case "-":
                    result += parseFloat(words[i-1]) - parseFloat(words[i+1]);
                    break;
                case "+":
                    result += parseFloat(words[i-1]) + parseFloat(words[i+1]);
                    break;
                case "*":
                    result += parseFloat(words[i-1]) * parseFloat(words[i+1]);
                    break;
                case "/":
                    result += parseFloat(words[i-1]) / parseFloat(words[i+1]);
                    break;
            } 
        }   
    } 
    
    document.getElementById("result").innerHTML = result;
}