import { Outlet, Link } from "react-router-dom";

export default function App() {
  return (
    <div>
      <h1>Bookkeeper</h1>
      <nav>
        <Link to="/invoices">Invoices</Link>
      </nav>
      <Outlet />
    </div>
  );
}