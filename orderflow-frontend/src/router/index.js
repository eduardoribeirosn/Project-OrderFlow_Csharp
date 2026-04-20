import { createRouter, createWebHistory } from "vue-router"

import Dashboard from "../pages/Dashboard.vue"
import Users from "../pages/Users.vue"
import Products from "../pages/Products.vue"
import Orders from "../pages/Orders.vue"
import UsersPost from "../pages/UsersPost.vue"
import ProductsPost from "../pages/ProductsPost.vue"
import OrdersPost from "../pages/OrdersPost.vue"

const routes = [
    { path: "/", component: Dashboard },
    { path: "/users", component: Users },
    { path: "/products", component: Products },
    { path: "/orders", component: Orders },
    { path: "/usersPost", component: UsersPost },
    { path: "/productsPost", component: ProductsPost },
    { path: "/ordersPost", component: OrdersPost }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router