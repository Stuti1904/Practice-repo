import logo from './logo.svg';
import './App.css';
import { Link } from "react-router-dom";
function App() {
  return (
    <div className="App">
     <div>
      <h1>Bookkeeper!</h1>
      <nav>
        <Link to="/invoices">Invoices</Link>
      </nav>
    </div>
    </div>
  );
}

export default App;
