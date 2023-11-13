require('dotenv').config();
const express = require("express");
var app = express();
const chat = require('./chat');

app.use(function(req, res, next) {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE');
    res.setHeader('Access-Control-Allow-Headers', 'Content-Type');
    res.setHeader('Access-Control-Allow-Credentials', true);
    next();
});

app.get("/", function (request, response) {
    response.send("Hello World!");
})

app.get("/getToken", function (request, response) {
    let token = chat.getToken(request.query.userName);
   response.send(JSON.stringify(token));
})

app.listen(3000, function () {
    console.log("Started application on port %d", 3000);
});
