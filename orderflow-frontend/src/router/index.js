import { createRouter, createWebHistory } from "vue-router"

import Dashboard from "../pages/Dashboard.vue"
import Users from "../pages/Users.vue"
import Products from "../pages/Products.vue"
import Orders from "../pages/Orders.vue"

const routes = [
    { path: "/", component: Dashboard },
    { path: "/users", component: Users },
    { path: "/products", component: Products },
    { path: "/orders", component: Orders }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router