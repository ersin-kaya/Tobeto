import axios from 'axios';
import React, { useEffect } from 'react'
import { useLocation, useParams } from 'react-router-dom';
import { ProductModel } from '../../models/responses/ProductModel';
import ProductService from '../../services/ProductService';

type Props = {}


const ProductDetail = (props: Props) => {
    // 1. yol
    // query string 
    // // getbyid?id=1 
    // const location = useLocation(); // useLocation'ın bize döndürdüğü yapıdan search'e bakarsak url'deki ? ve sonrasını göreceğiz
    // useEffect(() => {
    //     console.log(location)

    //     let query = new URLSearchParams(location.search); // 
    //     console.log(query);
    //     console.log(query.get("id"));                    // query'deki id'yi alalım
    // }, [])


    // 2. yol
    // path variable 
    // // getbyid/1   // bununla veri almak için root'ta değişiklik yapmak gerekcek
    const params = useParams<{ id: string }>(); // burada id'nin nullable old. görüyoruz çünkü gönderilmeyebilir 
    useEffect(() => {
        // console.log(params);
        if (params.id) { //eğer bu değişken/in bir değeri var ise
            // detay sayfasına istek at
            let service: ProductService = new ProductService();
            // service.getById(parseInt(params.id)).then(response => {
            //..
            // }) // veya then kısmını kullanmayıp await edelim..
            // bunun için bir fonk. yazıp async olarak işaretliyoruz

            fetchDetails(params.id);

        }
    }, [])

    const fetchDetails = async (id: string) => {
        let service: ProductService = new ProductService();
        let response = await service.getById(parseInt(id));   // Promise return ettiğimiz için biz buna then bloğuda yazabiliriz, async await'te
        console.log(response);
    }

    return (
        <div>ProductDetail</div>
    )
}

export default ProductDetail
// getbyid?id=1 // query string // 1. yol
// getbyid/1    // path variable