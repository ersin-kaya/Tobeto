import React from 'react'
import { ProductModel } from '../../models/responses/ProductModel';
import { Link } from 'react-router-dom';

type Props = {  // Props artık bir type, anonim bir tip değil, 
    // props'a bir veri geçecek veya okuyacaksak bunu da modelliyoruz
    // modellemeyi direkt komponentin içerisinde yapıyoruz ayrı bir interface'e gerek yok
    // çünkü o komponente özel bir yapı zaten
    product: ProductModel;

    // product?: ProductModel; 
    // ? => bir alanı nullable yapar
    // ! => nullable olan içerisinden veri okurken null değilse kontrolü yapar
}

const ProductCard = (props: Props) => {
    return (
        <div className="card">
            <img
                src={props.product.thumbnail}
                className="card-img-top img-fluid"
                alt="..."
            />
            <div className="card-body">
                <h5 className="card-title">{props.product.title}</h5>
                <p className="card-text">{props.product.description}</p>
                {/* query string */}
                {/* <Link
                    to={"/product-detail?id=" + props.product.id}
                    className="btn btn-primary"
                >
                    Detail
                </Link> */}
                {/* path variable */}
                <Link
                    to={"/product-detail/" + props.product.id}
                    className="btn btn-primary"
                >
                    Detail
                </Link>
                <button className="btn btn-danger">Sil</button>
            </div>
        </div>
    )
}

export default ProductCard