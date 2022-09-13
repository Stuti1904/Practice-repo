const EventEmitter= require('events');
const evenEmitter = new EventEmitter();
evenEmitter.on('start', demo =>{
console.log(`this is the number you wanted ${demo}`);
})
evenEmitter.emit('start', 25);