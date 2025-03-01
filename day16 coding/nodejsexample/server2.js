const express = require('express');
const app = express();
const port = 3000;
app.get('/',(req,res)=> {
    res.send("Hello Everyone !");
});
app.get('/about',(req,res)=> {
    res.send("About us !");
});
app.get('/contact',(req,res)=> {
    res.send("Contact Us !");
});
app.listen(port , () => 
{
    console.log(`server is running: ${port}`)
});