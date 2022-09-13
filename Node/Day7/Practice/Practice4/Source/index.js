let express= require('express');
let fs= require('fs');
let port=3000;
const router= express.Router();
let app= express();
app.use(express.json());
router.use((req, res, next)=>{
    console.log(`Request type= ${req.method}`);
    next();
});
router.get('/', (req, res)=>{
    var emp=[];
    fs.readFile('./employees.json', (err, data)=>{
        if(err){
            console.log(err);
        }
        else{
            emp= JSON.parse(data);
            res.send(emp);
        }
    })
})
router.get('/employee/:id', (req,res)=>{
    fs.readFile('./employees.json', (err,data)=>{
        const emp= JSON.parse(data);
        const result= emp.find((data)=>{
            return data.id==parseInt(req.params.id);
        })
        res.send(result);
        console.log(result);
    })
})
router.post('/employee', (req, res)=>{
    data1=[];
    fs.readFile('./employees.json', "utf-8", (err, data)=>{
        data1= JSON.parse(data);
        data1.push(req.body);
        fs.writeFile('./employees.json', JSON.stringify(data1), (err)=>{
            console.log("File written");
        })
        res.send(data1);
        res.end();
    })
})
router.put('employees/:id',(req,res)=>{
    data1=[];
    fs.readFile('./employees.json', "utf-8", (err, data)=>{
        data1= JSON.parse(data);
        const result= data1.find((data)=>{
            return data.id= parseInt(req.params.id);
        })
        result.id= req.body.id;
    })
})
app.listen(port, ()=>{
console.log("server started");
})
app.use('/', router);