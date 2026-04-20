<template>
    <div class="container">

        <aside class="sidebar">
            <h2>OrderFlow</h2>

            <nav>
                <router-link to="/">Dashboard</router-link>
                <router-link to="/users">Usuários</router-link>
                <router-link to="/products">Produtos</router-link>
                <router-link to="/orders">Pedidos</router-link>
            </nav>

            <h3>Cadastrar</h3>
            <nav>
                <router-link to="/usersPost">Usuários</router-link>
                <router-link to="/productsPost">Produtos</router-link>
                <router-link to="/ordersPost">Pedidos</router-link>
            </nav>
        </aside>

        <main class="content">
            <router-view />
        </main>
    </div>
</template>

<style>

.container {
    display: flex;
    height: 100vh;
}

.sidebar {
    width: 220px;
    background-color: #1e293b;
    color: white;
    padding: 20px;
}

.sidebar h2 {
    margin-bottom: 20px;
}

.sidebar a {
    display: block;
    color: white;
    margin-bottom: 10px;
    text-decoration: none;
}

.sidebar a:hover {
    opacity: 0.7;
}

.content {
    flex: 1;
    padding: 20px;
}

/* Tabela */
table {
    width: 100%;
    border-collapse: collapse;
}

th, td {
    border: 1px solid #ddd;
    padding: 100px;
}

th {
    background-color: #f1f5f9;
}

</style>
