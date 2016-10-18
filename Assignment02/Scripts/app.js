/* custom JavaScript goes here */

/* Name: Names: 
    Anmol Sharma Student ID: 300878140
    Waynell Lovell Student ID: 300833478
/* app.js file */
$(document).ready(function () {
    console.log("jquery trigerring!");
    $("#name").click(function () {
        return confirm("Are you Sure you want to logout?");
    })
    $("a.btn.btn-danger.btn-sm").click(function(){
    return confirm("Are you Sure you want to permnamently delete this?");
    })
})