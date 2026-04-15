<script setup>
import { onMounted, ref } from "vue"
import { getUsers } from "../services/userService.js"

const users = ref([])

onMounted(async () => {
    users.value = await getUsers()
})
</script>

<template>
    <div>
        <h1>Usuários</h1>

        <ul>
            <li v-for="user in users" :key="user.email">
                {{  user.name }} - {{ user.email }}
            </li>
        </ul>
    </div>
</template>