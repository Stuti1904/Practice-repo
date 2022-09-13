var exp = require('express');
var fs = require('fs');
var api = exp();
var port = 3000;
const router= exp.Router();
router.use((req,res,next)=>{
    console.log("Time", new Date());
    next()
})
router.get("/user/:id", (req, res, next)=>{
    console.log("Request URL", req.originalUrl);
    res.end()
})
api.use('/', router);
api.listen(port, ()=>{
    console.log('server running');
})