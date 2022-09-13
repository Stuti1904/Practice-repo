var exp = require('express');
var fs = require('fs');
var api = exp();
var port = 3000;
api.use(exp.json());
api.get('/students', (req, res) => {
    fs.readFile('./students.json', 'utf-8', (err, data) => {
        const student = JSON.parse(data);
        res.send(`${JSON.stringify(student)}`);
    })
})
api.get('/students/:ID', (req, res) => {
    fs.readFile('./students.json', 'utf-8', (err, data) => {
        const data1 = JSON.parse(data)
        const result = data1.find((data) => {
            return data.ID == parseInt(req.params.ID);
        })
        res.send(`${JSON.stringify(result)}`);
    })
})
api.get('/student/:Name/fees/', (req, res) => {
    fs.readFile('./students.json', "utf-8", (err, data) => {
        var studentData = JSON.parse(data);
        console.log(studentData);
        var result = studentData.find((data) => {
            return data.Name == req.params.Name;

        })
        result = result.Fees;
        res.send(`${JSON.stringify(result)}`);
        console.log(result);
    })
})


api.get('/student/:id/result', (req, res)=>{
    fs.readFile('./students.json', "utf-8", (err, data)=>{
        var studentArray= JSON.parse(data);
        console.log(studentArray);
        var result= studentArray.find((data)=>{
            return data.ID== parseInt(rq.params.id);
        })
        result= result.Result;
        res.send(`${JSON.stringify(result)}`);
        console.log(result);
    })
})
api.listen(port, () => {
    console.log("SERVER STARTED");
})