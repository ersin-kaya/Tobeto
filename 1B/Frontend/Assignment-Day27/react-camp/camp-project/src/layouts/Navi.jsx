import React, { useState } from 'react'
import { Container, Menu } from 'semantic-ui-react'
import CartSummary from './CartSummary'
import SignedOut from './SignedOut'
import SignedIn from './SignedIn'
import { useNavigate } from 'react-router-dom'
import { useSelector } from 'react-redux'

export default function Navi() {
    const { cartItems } = useSelector(state => state.cart)

    const [isAuthenticated, setIsAuthenticated] = useState(false)

    const navigate = useNavigate() // useHistory yerine kullanıldı... galiba değişmiş..

    // !!! bu işlemi fonksiyon yazmadanda ele alabiliriz ancak ileride işlem için bir logic eklenecek olursa patlarız, bu yüzden her zaman bir metotla ele almak daha iyi diyebiliriz...
    function handleSignOut() {
        setIsAuthenticated(false)
        navigate("/")
    }

    function handleSignIn() {
        setIsAuthenticated(true)
    }

    return (
        <div>
            <Menu fixed="top">
                <Container>
                    <Menu.Item
                        name='home'
                    />
                    <Menu.Item
                        name='messages'
                    />

                    <Menu.Menu position='right'>
                        {cartItems.length > 0 && <CartSummary />}
                        {isAuthenticated ? <SignedIn signOut={handleSignOut} anything={1} /> : <SignedOut signIn={handleSignIn} />}
                        {/* signOut -> props */}
                    </Menu.Menu>
                </Container>
            </Menu>
        </div>
    )
}
