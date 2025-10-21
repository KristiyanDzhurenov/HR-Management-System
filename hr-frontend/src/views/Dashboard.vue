<template>
  <div>
    <h2 class="text-2xl font-semibold mb-4">Dashboard</h2>
    <p>Welcome to your HR Management System dashboard!</p>

    <div class="grid grid-cols-3 gap-6 mt-6">
      <div class="bg-white shadow rounded-x1l p-4 text-center">
        <h3 class="text-lg font-semibold">Departments</h3>
        <p>View and manage company departments.</p>
      </div>
      <div class="bg-white shadow rounded-x1l p-4 text-center">
        <h3 class="text-lg font-semibold">Employees</h3>
        <p>Manage employee records and information.</p>
    </div>
    <div class="bg-white shadow rounded-x1l p-4 text-center">
        <h3 class="text-lg font-semibold">Leave Requests</h3>
        <p>Review and approve employee leave requests.</p>
      </div>
    </div>
    <EmployeeList />
     <router-link to="/departments">Go to Departments</router-link>
     <router-link to="/employees">Go to Employees</router-link>
     
  </div>
</template>

<script setup>
import EmployeeList from '@/components/EmployeeList.vue'
import { RouterLink } from 'vue-router'
</script>