import api from "./api.js"

export async function getUsers() {
    const response = await api.get("/users")
    console.log(response)
    return response.data
}

export async function createUser(data) {
    const response = await api.post("/users", data)
    return response.data
}