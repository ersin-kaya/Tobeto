function ProductCard(props) {
    return (
        <div className={"product-card " + props.classes}>
            <img src='https://static.ticimax.cloud/cdn-cgi/image/width=-,quality=85/14862/uploads/urunresimleri/buyuk/dell-inspiron-2-in-1-16-oled-touch-lap-8a8b3-.jpg' />
            <p>{props.name}</p>
            <span>{props.price} TL</span>
        </div>);

}

export default ProductCard;