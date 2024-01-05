import { Form, Formik } from 'formik'
import React from 'react'
import { Button, } from 'semantic-ui-react'
import * as Yup from "yup"
import KodlamaIoTextInput from '../utilities/customFormControls/KodlamaIoTextInput'
import ProductService from '../services/productService'

function ProductAdd() {

    const addProduct = (product) => {
        let productService = new ProductService()

        productService.addProduct(product)
            .then(function (response) {
                console.log({ response });
            })
            .catch(function (error) {
                console.log(error);
            })
    }

    const initialValues = {
        categoryId: 1,
        productName: "",
        unitsInStock: 0,
        unitPrice: 0
    }

    const schema = Yup.object({
        categoryId: Yup.number().required("Kategori seçimi yapılmak zorundadır."),
        productName: Yup.string().required("Ürün adı zorunludur."),
        unitsInStock: Yup.number().required("Ürünün stok adedi girilmek zorundadır."),
        unitPrice: Yup.number().required("Ürün fiyatı zorunludur.")
    })

    return (
        <div>
            <Formik
                initialValues={initialValues}
                validationSchema={schema}
                onSubmit={(values) => {
                    // console.log(values);
                    addProduct(values)
                }}
            >
                <Form className='ui form'>
                    <KodlamaIoTextInput name="categoryId" placeholder="Category ID" />
                    <KodlamaIoTextInput name="productName" placeholder="Product Name" />
                    <KodlamaIoTextInput name="unitsInStock" placeholder="Units In Stock" />
                    <KodlamaIoTextInput name="unitPrice" placeholder="Unit Price" />
                    <Button color="green" type="submit">Add</Button>
                </Form>
            </Formik>
        </div>
    )
}

export default ProductAdd