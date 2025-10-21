<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <div class="min-h-screen bg-gray-100 text-gray-900">
    <nav class="bg-white shadow mb-6">
      <div class="max-w-7x1 mx-auto px-4 py-4 flex justify-between items-center">
      <h1 class="text-2xl font-bold">HR Management System</h1>
      <ul class="flex gap-6">
        <li><RouterLink to="/" class="hover:text-blue-600">Dashboard</RouterLink></li>
        <li><RouterLink to="/departments" class="hover:text-blue-600">Departments</RouterLink></li>
        <li><RouterLink to="/employees" class="hover:text-blue-600">Employees</RouterLink></li> 
        <li><RouterLink to="/leaverequests" class="hover:text-blue-600">Leave Requests</RouterLink></li>
      </ul>
    </div>
  </nav>


    <main class="max-w-7x1 mx-auto px-4">
      <RouterView />
    </main> 
  </div>      
</template>

<style scoped>
</style>
