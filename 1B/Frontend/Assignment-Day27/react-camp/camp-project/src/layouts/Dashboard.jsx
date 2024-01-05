import React from 'react'
import Categories from './Categories'
import ProductList from '../pages/ProductList'
import { Grid } from 'semantic-ui-react'
import { Route, Routes } from 'react-router-dom'
import ProductDetail from '../pages/ProductDetail'
import CartDetail from '../pages/CartDetail'
import { ToastContainer } from 'react-toastify'
import "react-toastify/dist/ReactToastify.css";
import ProductAdd from '../pages/ProductAdd'

export default function Dashboard() {
    return (
        <div>
            <ToastContainer position="bottom-right" />
            <Grid>
                <Grid.Row>
                    <Grid.Column width={4}>
                        <Categories></Categories>
                    </Grid.Column>

                    <Grid.Column width={12}>
                        <Routes>
                            <Route exact path='/' Component={ProductList}></Route>
                            <Route path='/products' Component={ProductList}></Route>
                            {/* <Route exact path='/products' Component={ProductList}></Route> */}   {/* galiba yeni sürümde buna gerek kalmıyor yani alttakiyle benzerliği sorun olmuyor... */}

                            {/* /1 yerine :id !! */}
                            <Route path='/products/:id' Component={ProductDetail}></Route>
                            <Route path='/cart' Component={CartDetail}></Route>
                            <Route path='/product/add' Component={ProductAdd}></Route>

                            {/* <Route path='*'></Route> */}
                        </Routes>
                    </Grid.Column>
                </Grid.Row>
            </Grid>
        </div>
    )
}
