import logo from './logo.svg';
import './App.css';
import { HeaDer } from './Components/HeaDer';
import './Components/HeaDer.css'
import SectionHome from './Components/SectionHome';
import './Components/SectionHome.css'
import SectionAbout from './Components/SectionAbout';
import './Components/SectionAbout.css'
import FooTer from './Components/FooTer';
import './Components/FooTer.css'
function App() {
  return (
    <div className="App">
      <HeaDer></HeaDer>
      <SectionHome></SectionHome>
      <SectionAbout></SectionAbout>
      <FooTer></FooTer>
    </div>
  );
}

export default App;
