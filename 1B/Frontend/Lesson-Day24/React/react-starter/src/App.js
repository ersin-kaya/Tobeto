import logo from './logo.svg';
import './App.css';
import React, { useEffect, useState } from 'react';
import { clear } from '@testing-library/user-event/dist/clear';
import { act } from 'react-dom/test-utils';
import Navbar from './components/Navbar/Navbar';
import ProductCard from './components/ProductCard/ProductCard';
import "bootstrap/dist/css/bootstrap.css"
import { BrowserRouter, Route, Routes } from 'react-router-dom';
// app.js en kapsayıcı component old. için bootstrap.css'i burada import ediyoruz

import Homepage from './pages/Homepage/Homepage';
import Products from './pages/Products/Products';

export default function App() {

  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Homepage />}></Route>
        <Route path='/products' element={<Products />}></Route>
        <Route path='*' element={<div>Not found</div>}></Route>
      </Routes>
    </BrowserRouter>
  );


  // return (
  //   <div>
  //     <nav class="navbar navbar-expand-lg bg-light">
  //       <div class="container-fluid">
  //         <a class="navbar-brand" href="#">Navbar</a>
  //         <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
  //           <span class="navbar-toggler-icon"></span>
  //         </button>
  //         <div class="collapse navbar-collapse" id="navbarNav">
  //           <ul class="navbar-nav">
  //             <li class="nav-item">
  //               <a class="nav-link active" aria-current="page" href="#">Home</a>
  //             </li>
  //             <li class="nav-item">
  //               <a class="nav-link" href="#">Features</a>
  //             </li>
  //             <li class="nav-item">
  //               <a class="nav-link" href="#">Pricing</a>
  //             </li>
  //             <li class="nav-item">
  //               <a class="nav-link disabled">Disabled</a>
  //             </li>
  //           </ul>
  //         </div>
  //       </div>
  //     </nav>


  //     <button className='btn btn-success'>Click Me!</button>
  //   </div>
  // );



  // const [total, setTotal] = useState(0);

  // useEffect(
  //   () => {
  //     if (total > 10) {
  //       alert("Toplam 10'dan büyük olamaz");
  //       setTotal(10);
  //     }
  //     console.log(`useEffect çalıştı: ${total}`)
  //   }, [total]);

  // useEffect(
  //   () => {
  //     console.log("useEffect2");
  //   }, []
  // );

  // const increase = () => {
  //   setTotal(total + 1);
  // }

  // const decrease = () => {
  //   setTotal(total - 1);
  // }

  // const [activity, setActivity] = useState("");
  // const [activityList, setActivityList] = useState(["Aktivite 1", "Aktivite 2", "Aktivite 3"])

  // const clearActivity = () => {
  //   setActivity("");
  // }

  // const removeActivity = (activity) => {
  //   setActivityList(activityList.filter(i => i !== activity));
  // }

  // const addActivity = () => {
  //   setActivityList([...activityList, activity]);
  //   clearActivity();
  // }

  // // let id = 1;

  // return (
  //   <React.Fragment>

  //     <Navbar name="halit" /> {/* self-closing */}

  //     {/* <Navbar>
  //       <div>Merhaba</div>
  //     </Navbar> */}


  //     <div>
  //       <p>{total}</p>
  //     </div>
  //     <div>
  //       <button onClick={increase}>Artır</button>
  //       <button onClick={() => { decrease(); }}>Azalt</button>

  //     </div>

  //     <br />
  //     <hr />
  //     <br />

  //     <ProductCard name="Mouse" price="200"></ProductCard>
  //     <ProductCard name="Laptop" classes="yellow-border" price="5000"></ProductCard>

  //     <br />
  //     <hr />
  //     <br />

  //     <div>

  //       <input value={activity} onChange={(event) => { setActivity(event.target.value) }} type="text" placeholder='Aktivite giriniz...' />

  //       <br />

  //       <button onClick={() => { addActivity() }}>Ekle</button>
  //       <ul>
  //         {activityList.map((element) => <li key={element}>{element} <button onClick={() => { removeActivity(element) }}>X</button></li>)}
  //       </ul>
  //     </div>
  //   </React.Fragment >
  // );
}
