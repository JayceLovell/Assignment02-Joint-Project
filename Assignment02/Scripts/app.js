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
})