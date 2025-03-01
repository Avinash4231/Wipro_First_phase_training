const express = require('express');
const app = express();
const port = 3000;

// application-level middleware(which will run on every request)
app.use((req,res,next) => {

console.log("Application - Level Middleware")
next(); // pass the control to next middleware or route
});

//route-level middleware for '/Logger' route
const specialMiddleware = (req,res,next) => {

    console.log("Time:", new Date().toISOString());
    next(); // pass the control to the next handler for /logger
};

app.get("/logger",specialMiddleware, (req,res) => {

    console.log("Route handler for /logger");
    res.send("Logger Page");
});

app.get("/display",(req,res) => {

console.log("route handler for display ");
res.send("Normal Page");


});
 //To start the server
 app.listen(port,()=>{

    console.log(`server running on Port http://localhost:3000`);
 });