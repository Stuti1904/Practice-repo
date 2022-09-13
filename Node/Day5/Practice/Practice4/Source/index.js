const EventEmitter= require('events');
const myEmitter= new EventEmitter();
function c1(){
    console.log("an event occured");
}
function c2(){
    console.log("yet another occured");
}
myEmitter.on('eventOne', c1);
myEmitter.on('eventOne', c2);
myEmitter.emit('eventOne');