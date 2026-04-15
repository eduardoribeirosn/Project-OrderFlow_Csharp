<script setup>
import { ref, onMounted } from "vue"
import api from "../services/api"

const orders = ref([])

onMounted(async () => {
    const response = await api.get("/orders")
    orders.value = response.data
})
</script>

<template>
    <div>
        <h1>Orders</h1>

        <ul>
            <li v-for="order in orders" :key="order.id">
                Pedido - {{ order.status }}
            </li>
        </ul>
    </div>
</template>