import React from 'react';

export class Alphabet extends React.Component{

    printAlphabet(){
        var result = '';
        for(let i=65;i<=90;i++)
            result += String.fromCharCode(i) +' ';
            return result;
        }
        render(){
            return(
                <div><h1>Alphabets</h1><hr/> <hr/> <h3>{this.printAlphabet()}</h3></div>
            )

        }
   
}
export default Alphabet;
