import React from 'react'
import { NavLink } from 'react-router-dom'
import { Dropdown } from 'semantic-ui-react'

export default function CartSummary() {
    return (
        <Dropdown item text='Sepet'>
            <Dropdown.Menu>
                <Dropdown.Item>Acer Laptop</Dropdown.Item>
                <Dropdown.Item>Dell Laptop</Dropdown.Item>
                <Dropdown.Item>Apple Laptop</Dropdown.Item>
                <Dropdown.Divider></Dropdown.Divider>
                <Dropdown.Item as={NavLink} to="/cart">Sepete git</Dropdown.Item>
            </Dropdown.Menu>
        </Dropdown>
    )
}
