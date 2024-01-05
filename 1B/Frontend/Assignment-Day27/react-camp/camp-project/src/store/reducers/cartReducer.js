import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

const initialState = {
    cartItems: cartItems
}

export default function cartReducer(state = initialState, { type, payload }) {
    switch (type) {
        case ADD_TO_CART:
            let product = state.cartItems.find(c => c.product.productId === payload.productId)
            // state.cartItems.push() // !!! push() ile referans değişmediği için redux bunu anlamayacaktır

            if (product) {
                product.quantity++; // adet güncellendi fakat..
                // ekranda verinin güncellenmesi için referansı değiştirelim.. ->
                return {
                    ...state
                }
            }
            else {
                return {
                    ...state, // Java & React - 13. Gün - 2:01:45 // bu satır şu an defensive ilerlediğimiz için var, yazmasakta olur
                    cartItems: [...state.cartItems, { quantity: 1, product: payload }]
                }
            }

        case REMOVE_FROM_CART:
            return {
                ...state, // Java & React - 13. Gün - 2:01:45 // bu satır şu an defensive ilerlediğimiz için var, yazmasakta olur
                cartItems: state.cartItems.filter(c => c.product.productId !== payload.productId)
            }

        default:
            return state;
            break;
    }
}