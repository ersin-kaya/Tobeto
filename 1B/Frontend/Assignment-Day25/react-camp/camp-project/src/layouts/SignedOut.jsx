import React from 'react'
import { Button, Menu } from 'semantic-ui-react'

// export default function SignedOut(props) { //bu şekilde kullanıp aşağıda {props.signIn} diyebiliriz
// !!!! ancak object destructuring'te yapabiliriz
export default function SignedOut({ signIn }) {
    return (
        <div>
            <Menu.Item>
                <Button onClick={signIn} secondary>Giriş Yap</Button>
                <Button secondary style={{ marginLeft: '0.5em' }}>Kayıt Ol</Button>
            </Menu.Item>
        </div >
    )
}
