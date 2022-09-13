const EventEmitter= require('events');
const myemitter = new EventEmitter();
    function start(){
        console.log("exam start");
        setTimeout(()=>{
                console.log("exam over")
        }, 108000);
    }
myemitter.on('eventOne', start);
myemitter.emit('eventOne');

