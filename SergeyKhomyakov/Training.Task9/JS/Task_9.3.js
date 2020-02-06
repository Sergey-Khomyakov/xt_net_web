function OneElementAdd() {
    var selectSelected = document.getElementById("select-Selected");
    var selectAwailable = document.getElementById("select-Awailable");
    var seline = selectAwailable.options.selectedIndex;
    selectSelected.options[selectSelected.options.length] = new Option(selectAwailable.options[seline].text, selectAwailable.options[seline].value);
    selectAwailable.remove(seline);   
}
function OneElementDelete() {
    var selectSelected = document.getElementById("select-Selected");
    var selectAwailable = document.getElementById("select-Awailable");
    var seline = selectSelected.options.selectedIndex;
    selectAwailable.options[selectAwailable.options.length] = new Option(selectSelected.options[seline].text, selectSelected.options[seline].value);
    selectSelected.remove(seline);
}
function AllElementAdd() {
    var selectSelected = document.getElementById("select-Selected");
    var selectAwailable = document.getElementById("select-Awailable");
    for(var i = 0; i < selectAwailable.options.length; i++)
    {
        selectSelected[i] = new Option(selectAwailable.options[i].text, selectAwailable.options[i].value)
    }
    for(var i = selectAwailable.length - 1; i != -1; i--)
    {
        selectAwailable.remove(i);
    }
}
function AllElementDelete() {
    var selectSelected = document.getElementById("select-Selected");
    var selectAwailable = document.getElementById("select-Awailable");
    for(var i = 0; i < selectSelected.options.length; i++)
    {
        selectAwailable[i] = new Option(selectSelected.options[i].text, selectSelected.options[i].value)
    }
    for(var i = selectSelected.length - 1; i != -1; i--)
    {
        selectSelected.remove(i);
    }
}