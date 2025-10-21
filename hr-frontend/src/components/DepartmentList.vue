<template>
    <div>
        <h3 class="text-xl font-semibold mb-2">Departments</h3>
        <ul class="bg-white shadow rounded-x1l divide-y">
            <li v-for="department in departments" :key="department.id" class="p-3 hover:bg-gray-50">
                {{ department.name }} - {{ department.manager }}
            </li>
        </ul>
    </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import axios from 'axios'
const departments = ref([])

onMounted(async () => {
    const response = await axios.get('http://localhost:5000/api/departments')
    departments.value = response.data
})
</script>