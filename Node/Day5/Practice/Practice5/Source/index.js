const EventEmitter= require('events');
const { mainModule } = require('process');
const emitter= new EventEmitter();
function main(){
    console.log("this is the main function");
}
function side(){
    console.log("this is another function");
}
emitter.on('eventOne', main);
emitter.on('eventOne', side)
console.log(emitter.rawListeners('eventOne'));

