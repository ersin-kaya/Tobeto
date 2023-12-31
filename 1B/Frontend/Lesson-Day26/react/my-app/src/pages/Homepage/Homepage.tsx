import axios from 'axios';
import React, { ReactElement, useEffect, useState } from 'react'
import { GetAllProductsModel } from '../../models/responses/GetAllProductsModel';
import { ProductModel } from '../../models/responses/ProductModel';
import ProductCard from '../../components/ProductCard/ProductCard';
import ProductService from '../../services/ProductService';

type Props = {}

const Homepage = (props: Props): ReactElement => { //ReactElement diye...

    const [products, setProducts] = useState<ProductModel[]>([]);

    useEffect(() => {
        fetchProducts();
    }, []);

    // Bizi servis kullanımına götüren 3 neden..
    // 1- Birden fazla noktada kullanılabilir
    // 2- Sorumluluğun UI dosyası üzerinden kalkması için
    // 3- Ortak bir noktadan yönetebilmek için

    const fetchProducts = () => {
        let service: ProductService = new ProductService();
        // Promise return ettiğimiz için biz buna then bloğuda yazabiliriz, async await'te
        service.getAll()    // servis yoluyla istek atmış olacağız yani bu sorumluluğu(backend'e istek atma) servise yüklüyoruz
            .then(response => {
                setProducts(response.data.products)
            })
    }

    return (
        <div className="container">
            <div className="row">
                {products.map(product => (
                    <div key={product.id} className="col-3">
                        <ProductCard product={product} />
                    </div>
                ))}
            </div>
        </div>
    )
}

export default Homepage