<script setup>
import { createUser, getUsers } from "../services/userService.js"

async function criarUser() {
    let response = await createUser(
        {
            "Name": document.getElementById('idNomeUsuario'),
            "Email": document.getElementById('idEmailUsuario')
        }
    )
    console.log(response)
}
</script>

<template>
    <div>
        <h1>Cadastrar Usuários</h1>

        <div class="containerInput">
            <span>Nome do Usuário:</span>
            <input type="text" id="idNomeUsuario">
        </div>
        <div class="containerInput">
            <span>Email do Usuário</span>
            <input type="email" id="idEmailUsuario">
        </div>
        <div class="buttonCadastrar">
            <button id="idCadastrarUsuario" v-on:click="criarUser()">Cadastrar Usuário</button>
        </div>
    </div>
</template>

<style>
h1 {
    margin-bottom: 5rem;
}

.containerInput {
    width: 100%;
    display: flex;
    justify-content: space-around;
    margin: 1rem;
}

span {
   font-size: 1.5rem; 
   width: 30%;
}

input {
    width: 50%;
    font-size: 1.8rem;
    padding: .4rem;
}

.buttonCadastrar {
    width: 100%;
    display: flex;
    justify-content: center;
}

.buttonCadastrar button {
    font-size: 2rem;
    padding: 1rem;
    border-radius: 1rem;
    border: transparent;
    margin-top: 3rem;
}
</style>