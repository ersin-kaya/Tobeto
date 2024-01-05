import axios from "axios"

export default class ProductService {
    getProducts() {
        return axios.get("https://localhost:7295/api/Products/getall")
    }

    getByProductId(id) {
        return axios.get(`https://localhost:7295/api/Products/getbyid?id=${id}`);
    }

    addProduct(product) {
        return axios.post('https://localhost:7295/api/Products/add', {
            categoryId: product.categoryId,
            productName: product.productName,
            unitsInStock: product.unitsInStock,
            unitPrice: product.unitPrice
        })
    }
}