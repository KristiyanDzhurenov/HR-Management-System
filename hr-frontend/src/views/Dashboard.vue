<template>
  <div class="flex min-h-screen">
    <aside class="w-64 bg-gray-800 text-white p-6">
      <h2 class="text-2xl font-bold mb-6">HR Management</h2>
      <nav class="space-y-4">
        <RouterLink to="/employees" class="block hover:bg-gray-700 p-2 rounded">Employees</RouterLink>
        <RouterLink to="/departments" class="block hover:bg-gray-700 p-2 rounded">Departments</RouterLink>
        <RouterLink to="/leave-requests" class="block hover:bg-gray-700 p-2 rounded">Leave Requests</RouterLink>
      </nav>
    </aside>
      </div>
</template>

<script setup>
import { RouterLink } from 'vue-router'
</script>