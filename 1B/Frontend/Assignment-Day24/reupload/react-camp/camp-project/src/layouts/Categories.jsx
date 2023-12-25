import React from 'react'
import { Menu } from 'semantic-ui-react'

export default function Categories() {
    return (
        <Menu pointing vertical>
            <Menu.Item
                name='home'
            />
            <Menu.Item
                name='messages'
            />
            <Menu.Item
                name='friends'
            />
        </Menu>
    )
}
