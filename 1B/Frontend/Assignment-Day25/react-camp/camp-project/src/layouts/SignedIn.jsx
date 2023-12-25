import React from 'react'
import { Dropdown, Image, Menu } from 'semantic-ui-react'

// export default function SignedIn(props) { //bu şekilde kullanıp aşağıda {props.signOut} diyebiliriz
// !!!! ancak object destructuring'te yapabiliriz
export default function SignedIn({ anything, signOut }) {
    // !!! sıranın bir önemi yok gibi: Navi.jsx'te props olarak ikinci sırada anything geçip burada öne yazmamıza rağmen kendi değerini alıyor, sorulaca !!!
    // console.log(anything)
    // console.log("------")
    // console.log(signOut)

    return (
        <div>
            <Menu.Item>
                <Image avatar spaced="right" src="https://www.pngall.com/wp-content/uploads/12/Avatar-Profile-Vector.png"></Image>
                <Dropdown pointing="top right" text='Ersin'>
                    <Dropdown.Menu>
                        <Dropdown.Item text="Bilgilerim" icon="info"></Dropdown.Item>
                        <Dropdown.Item onClick={signOut} text="Çıkış Yap" icon="sign-out"></Dropdown.Item>
                    </Dropdown.Menu>
                </Dropdown>
            </Menu.Item>
        </div>
    )
}
