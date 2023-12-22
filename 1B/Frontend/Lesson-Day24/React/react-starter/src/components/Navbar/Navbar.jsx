function Navbar(props) {
    console.log(props);
    return <div>{`id: ${props.id} - name: ${props.name}`}</div>
}

export default Navbar;