const express = require('express');
const app = express();
const port = 3000;

app.use((req,res,next) =>{

    console.log(`Request Method: ${req.method},Request URL : ${req.url}`);
    next();
})

//static middleware : serve files from public directory
app.use(express.static("public"));

app.get("/",(req,res)=>{

    res.sendFile(__dirname+"/index.html")
})
 //To start the server
 app.listen(port,()=>{

    console.log(`server running on Port http://localhost:3000`);
 });