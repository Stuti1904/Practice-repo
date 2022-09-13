import React from 'react';
export class HeaDer extends React.Component{
        render(){
            return(
                <div id="header">
                <nav>
                    <ul>
                        <li><a href="#home" className='links'>Home</a></li>
                        <li><a href="#about" className='links'>About</a></li>
                    </ul>
                </nav>
            </div>
            )

        }
   
}
export default HeaDer;
