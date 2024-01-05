import React from 'react'
import { useSelector } from 'react-redux'
import { NavLink } from 'react-router-dom'
import { Dropdown, Label } from 'semantic-ui-react'

export default function CartSummary() {

    const { cartItems } = useSelector(state => state.cart)

    return (
        <Dropdown item text='Sepet'>
            <Dropdown.Menu>
                {
                    cartItems.map((cartItem) => (
                        <Dropdown.Item key={cartItem.product.productId}>
                            {cartItem.product.productName}
                            <span>&nbsp;&nbsp;&nbsp;</span>
                            <Label>
                                {cartItem.quantity}
                            </Label>
                        </Dropdown.Item>
                    ))
                }
                <Dropdown.Divider></Dropdown.Divider>
                <Dropdown.Item as={NavLink} to="/cart">Sepete git</Dropdown.Item>
            </Dropdown.Menu>
        </Dropdown >
    )
}
