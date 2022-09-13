const EventEmitter = require('events');
const evenEmitter = new EventEmitter();
evenEmitter.on('start', () =>{
console.log("started");
});
evenEmitter.emit('start');
