var http = require('http');
var fs = require('fs');
var url = 'http://localhost:3001';

var server = http.createServer((req, res) => {
  var Url1 = new URL(url + req.url);

  if (Url1.pathname === '/upload') {
    fs.readFile('demo.txt', 'utf-8', (err, data) => {
      let content = data;
      fs.writeFile('./uploaded.txt', content, { flag: 'w+' }, (err) => {
        if (err) {
          console.log(err);
          res.end();
        } else {
          res.write('File Uploded successfulluy.');
          res.end();
        }
      });
    });
  }
});

server.listen(3001);
console.log('Server running on port : 3001');
