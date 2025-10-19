<template>
  <div>
    <h1>Dashboard</h1>
    <p>Welcome to the HR Management System Dashboard!</p>
    <EmployeeList />
     <router-link to="/departments">Go to Departments</router-link>
     <router-link to="/employees">Go to Employees</router-link>
     
  </div>
</template>

<script setup>
import EmployeeList from '@/components/EmployeeList.vue'
import { RouterLink } from 'vue-router'
</script>