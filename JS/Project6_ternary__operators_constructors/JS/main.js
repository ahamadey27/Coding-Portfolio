function count_function() {
    document.getElementById("Nested_Function").innerHTML = Count();
    function Count() {
        var Starting_Point = 9;
        function Plus_One() { Starting_Point += 1 }; 
        Plus_One(); 
        return Starting_Point; 
    }
}