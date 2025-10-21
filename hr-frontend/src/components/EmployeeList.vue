<template>
  <div class="employee-list">
    <h3 class="text-xl font-semibold mb-2">Employee List</h3>
    <ul class="bg-white shadow-rounded-xl divide-y">
      <li v-for="employee in employees" :key="employee.id" class="p-3 hover:bg-gray-50">
      <span> {{ employee.name }} - {{ employee.position }}</span>
      <span class="text-gray-500 text-sm"> (ID: {{ employee.department?.name }})</span>
      </li>
    </ul>
  </div>
</template>

<script>
import { ref, onMounted } from 'vue'  
import axios from 'axios'

const employees = ref([])

onMounted(async () => {
    const response = await axios.get('http://localhost:5000/api/employees')
    employees.value = response.data
})
</script>