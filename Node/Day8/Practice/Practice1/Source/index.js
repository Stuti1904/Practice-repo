const express= require('express');
let router= express.Router();
let fs= require('fs');
let app= express();
let port=3001;
app.use(express.json());
app.use('/', router);
router.get('/', (req,res,next)=>{
    var user=[];
    fs.readFile('./users.json', (err,data)=>{
      user=JSON.parse(data);
      res.send(user);
      console.log(user);
    })
})
router.post('/login', (req,res,next)=>{
    let userdata={
        username: req.body.username,
        password:req.body.password
    };
    if(userdata.username=="admin"&& userdata.password=="admin"){
        res.status(200).json({
            message:"Login successful"
        });
    }
    else{
        res.status(401).json({
            message: 'Login Failed'
        })
    }
})
app.listen(port, ()=>{
    console.log("server started");
})
app.use('/', router);