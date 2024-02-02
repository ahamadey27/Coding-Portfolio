function my_Dictionary() {
    var Compressor = {
        1176: "FET",
        LA2A: "OPTICAL",
        DISTRESSOR: "Solid State"
    }; 
    delete Compressor.DISTRESSOR; 
    document.getElementById("Dictionary").innerHTML = Compressor.DISTRESSOR; 
}