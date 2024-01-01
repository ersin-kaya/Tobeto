import { ReactElement } from 'react';
import logo from './logo.svg';
import { Route, Routes } from 'react-router-dom';
import Homepage from './pages/Homepage/Homepage';
import ProductDetail from './pages/ProductDetail/ProductDetail';
import Navbar from './components/Navbar/Navbar';
import AddProduct from './pages/AddProduct/AddProduct';


function App(): ReactElement {
  return (
    <>
      <Navbar />
      <Routes>
        <Route path='/' element={<Homepage />}></Route>
        {/* <Route path='/product-detail' element={<ProductDetail />}></Route> */} {/* query string ile alırken */}
        <Route path='/product-detail/:id' element={<ProductDetail />}></Route> {/* path variable ile alırken route değişiyor, hangi isimle almak istiyorsak öyle adlandırıyoruz. Ayrıca url'den verilen değeri sayfa içerisinde bu isimle(id) okuyabiliriz. Bunu useParams ile yapabiliriz. */}
        <Route path='/add-product' element={<AddProduct />}></Route>
      </Routes>
    </>
  );
}

export default App;
