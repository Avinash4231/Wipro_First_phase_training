const express = require('express');
const app = express();
const port = 3000

//Middleware to parse JSON body -- Built-in 
//app.use(express.json());

//get request - http://localhost:3000
app.get("/",(req,res) => {


    res.send("Welcome to Express JS Middleware");
});

//post request -  http://localhost:3000/data
app.post('/data', (req,res) =>{

   const{id,name} = req.body;
   res.json({message :"Post request received :", data: {name} , id : {id}})
});

//update request -  http://localhost:3000/update
app.put('/update', (req,res) =>{

    const{id,name} = req.body;
    res.json({message :"PUT request received :", data: {name} , id : {id}})
 });
 
 //delete request -  http://localhost:3000/delete
 app.delete('/delete', (req,res) =>{

  //  const{id,name} = req.body;
    res.json({message :"Data deleted :"})
 });

 //To start the server
 app.listen(port,()=>{

    console.log(`server running`);
 });