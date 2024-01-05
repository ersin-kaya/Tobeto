import { combineReducers } from "redux";
import cartReducer from "./reducers/cartReducer";

// tüm state'leri topladığımız yer

const rootReducer = combineReducers({
    cart: cartReducer,
})

export default rootReducer;