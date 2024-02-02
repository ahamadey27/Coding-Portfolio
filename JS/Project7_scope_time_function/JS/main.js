function Time_Function() {
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It's morning";
    }
    else if (Time >= 12 == Time < 18) {
        Reply = "It's the afternoon"; 
    }
    else {
        Reply = "It's evening";
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}