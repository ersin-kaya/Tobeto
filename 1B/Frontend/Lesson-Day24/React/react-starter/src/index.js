import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App/*, { variable1 }*/ from './App'; // default ile export edileni öne yazarız
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);
