import api from "./api.js"

export async function getProducts() {
    const response = await api.get("/product")
    console.log(response)
    return response.data
}

export async function createProduct(data) {
    const response = await api.post("/product", data)
    return response.data
}