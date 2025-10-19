<template>
  <div class="card, bg-white shadow-md rounded-lg p-6 flex items-center space-x-4 hover:shadow-lg transition-shadow duration-300"">
  <div>
  <h3 class="text-lg font-semibold text-gray-800">{{ name }}</h3>
  <p class="text-sm text-gray-500">{{ position }}</p>
  <p class="text-xs text-gray-400">Department: {{ department }}</p> 
  </div>
  </div>
</template>

<script setup>
defineProps(['name', 'position'])
</script>