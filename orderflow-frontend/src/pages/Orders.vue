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

        <table>

            <thead>
                <tr>
                    <th>Número da Compra</th>
                    <th>Id da Compra</th>
                    <th>Nome do Comprador</th>
                    <th>Nome do Produto</th>
                    <th>Preço</th>
                    <th>Quantidade Comprada</th>
                    <th>Quantidade no Estoque</th>
                    <th>Status</th>
                </tr>
            </thead>

            <tbody>
                <tr v-for="order in orders" :key="order.id">
                    <td>{{ order.numeroDaCompra }}</td>
                    <td>{{ order.id }}</td>
                    <td>{{ order.nomeUser }}</td>
                    <td>{{ order.nomeProduct }}</td>
                    <td>{{ order.price }}</td>
                    <td>{{ order.quantity }}</td>
                    <td>{{ order.stock }}</td>
                    <td>{{ order.status }}</td>
                </tr>
            </tbody>
        </table>

        <!-- <ul>
            <li v-for="order in orders" :key="order.id">
                Pedido - {{ order.status }}
            </li>
        </ul> -->
    </div>
</template>

<style>
th {
    padding: 50px 0;
    font-size: .8rem;
    width: 100px;
}
</style>