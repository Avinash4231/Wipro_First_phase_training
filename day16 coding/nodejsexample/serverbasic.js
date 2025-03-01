var express = require ("express");//it will load express framework which will allow with the server 
var app = express();//it represent the express application
app.set("viewEngine","jade");//viewEngine allow us to rerender dynamic html page 
app.get("/myapp/",function(req,res){
res.send("hello express"); //rootur1 http://localhost:3000/myapp/
});
var server = app.listen(3000,function(){
console.log("http listen on the port :3000")
});