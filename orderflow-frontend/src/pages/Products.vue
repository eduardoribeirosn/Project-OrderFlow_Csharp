<script setup>
import { onMounted, ref } from "vue"
import api from "../services/api.js"

const products = ref([])

onMounted(async () => {
    const response = await api.get("/product")
    products.value = response.data
})
</script>

<template>
    <div>
        <h1>Produtos</h1>

        <table>

            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Preço</th>
                </tr>
            </thead>

            <tbody>
                <tr v-for="product in products" :key="product.id">
                    <td>{{ product.name }}</td>
                    <td>{{ product.price }}</td>
                </tr>
            </tbody>
        </table>

        <!-- <ul>
            <li v-for="product in products" :key="product.email">
                {{  product.name }} - {{ product.email }}
            </li>
        </ul> -->
    </div>
</template>