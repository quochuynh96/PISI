// Algorithm search json
init = function(){
    for (var i = 0; i < dictionary.length; i++) {
        document.getElementById('keywords').innerHTML += "<li onclick ='show(" + i + ")'>"+
        dictionary[i].word + "</li>";        
    }
}
// call the init function when page loads
init();

//display a word, its definition and realted words
show = function(i){
    document.getElementById('keywords').innerHTML = dictionary[i].word;
    document.getElementById('definition').innerHTML = dictionary[i].definition;
     var list = "";
     for ( var j = 0; i <dictionary[i].rel.length; j++){
     }
}