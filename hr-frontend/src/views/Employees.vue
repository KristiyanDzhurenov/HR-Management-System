<script setup lang="ts">
import { ref, onMounted } from 'vue'  
import axios from 'axios'

interface Employee {
  id: number
  name: string
  email: string
  position: string
}

const employees = ref<Employee[]>([])

onMounted(async () => {
    const res = await axios.get('http://localhost:5000/api/employees')
    employees.value = res.data
})
</script>

<template>
  <div class="employees">
    <h2 class="text-2xl font-semibold mb-4">Employees</h2>
    <table class="min-w-full border">
      <thead>
        <tr class="bg-gray-100">
          <th class="p-2 border">Name</th>
          <th class="p-2 border">Email</th>
          <th class="p-2 border">Position</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="employee in employees" :key="employee.id" class="hover:bg-gray-100">
          <td class="p-2 border">{{ employee.name }}</td>
          <td class="p-2 border-">{{ employee.email }}</td>
          <td class="p-2 border-">{{ employee.position }}</td>
        </tr>
      </tbody>
    </table>
    </div>
  </template>
