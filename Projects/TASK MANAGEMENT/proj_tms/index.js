var mysql = require("mysql");

var con = mysql.createConnection({
    host:"localhost",
    user:"root",
    password:"Sakhare@123",
    database:"taskmanagement"
});

con.connect(function(error){
    if(error)throw error;
    console.log("connect");
});







