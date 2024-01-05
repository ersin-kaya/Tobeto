import React, { useEffect, useState } from 'react'
import { Button, Icon, Menu, Table } from 'semantic-ui-react'
import ProductService from '../services/productService'
import { Link } from 'react-router-dom'
import { useDispatch } from 'react-redux'
import { addToCart } from '../store/actions/cartActions'
import { toast } from 'react-toastify'

export default function ProductList() {

    const dispatch = useDispatch()

    const [products, setProducts] = useState([]) // react hook // lifecycle hook

    // şu an hook kullandığımız için ve şu an bir fonksiyon komponenti içerisinde olduğumuz için class component'lerdeki componentDidMount'u kullanamıyoruz, componentDidMount -> mantık şu, sayfa yerleşti şimdi state'i değiştir. yani products değiştiği anda, kullanıldığı component yeniden render ediliyor...

    useEffect(() => {
        let productService = new ProductService()
        productService.getProducts().then(result => setProducts(result.data.data))
    }, [])

    const handleAddToCart = (product, quantity) => {
        dispatch(addToCart(product, quantity))
        toast.success(`${product.productName} sepete eklendi!`)
    }

    return (
        <Table celled>
            <Table.Header>
                <Table.Row>
                    <Table.HeaderCell>Id</Table.HeaderCell>
                    <Table.HeaderCell>CategoryId</Table.HeaderCell>
                    <Table.HeaderCell>ProductName</Table.HeaderCell>
                    <Table.HeaderCell>UnitsInStock</Table.HeaderCell>
                    <Table.HeaderCell>UnitPrice</Table.HeaderCell>
                    <Table.HeaderCell></Table.HeaderCell>
                </Table.Row>
            </Table.Header>

            <Table.Body>
                {
                    products.map((product) => ( // jsx üretmek için
                        <Table.Row key={product.productId}>
                            <Table.Cell>{product.productId}</Table.Cell>
                            <Table.Cell>{product.categoryId}</Table.Cell>
                            <Table.Cell><Link to={`/products/${product.productId}`}>{product.productName}</Link></Table.Cell>
                            <Table.Cell>{product.unitsInStock}</Table.Cell>
                            <Table.Cell>{product.unitPrice}</Table.Cell>
                            <Table.Cell>
                                <Button className='bg-success' onClick={() => handleAddToCart(product)}>Sepete Ekle</Button>
                            </Table.Cell>
                        </Table.Row>
                    ))
                }
            </Table.Body>

            <Table.Footer>
                <Table.Row>
                    <Table.HeaderCell colSpan='3'>
                        <Menu floated='right' pagination>
                            <Menu.Item as='a' icon>
                                <Icon name='chevron left' />
                            </Menu.Item>
                            <Menu.Item as='a'>1</Menu.Item>
                            <Menu.Item as='a'>2</Menu.Item>
                            <Menu.Item as='a'>3</Menu.Item>
                            <Menu.Item as='a'>4</Menu.Item>
                            <Menu.Item as='a' icon>
                                <Icon name='chevron right' />
                            </Menu.Item>
                        </Menu>
                    </Table.HeaderCell>
                </Table.Row>
            </Table.Footer>
        </Table>
    )
}
