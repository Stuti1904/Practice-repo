import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import Invoices from './InVoices';
import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
 <BrowserRouter>
 <Routes>
  <Route path="/" element={<App />}>
    <Route path="invoices" element={<Invoices />}>
      <Route
        index
        element={
          <main>
            <p>Select an invoice</p>
          </main>
        }
      >
        </Route>
      <Route path=":invoiceId" element={<Invoices />} />
    </Route>
    <Route
      path="*"
      element={
        <main>
          <p>There's nothing here!</p>
        </main>
      }
    />
  </Route>
</Routes>
</BrowserRouter>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
